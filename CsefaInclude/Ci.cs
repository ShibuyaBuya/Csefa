namespace Ci
{
    using System;
    using System.IO.Compression;
    using System.Runtime;
    using ICsefa;
    using Iso;
    using ISOCODE;

    using DiscUtils;
    using DiscUtils.Iso9660;
    using System.Xml;

    namespace Csefa
    {
        public class Csefa
        {

        }
    }
    public class CsefaIso : ICsefaISO
    {
        IsoCode ICsefaISO.RIso(string iso, bool force)
        {
            string isoCsefa = iso;
            string isoFolder = "csefa/iso";
            if (!File.Exists(isoCsefa))
            {
                return IsoCode.ISO_NOT_FOUND;
            }
            if (File.Exists(isoFolder + "/csefa.iso"))
            {
                if (!force)
                {
                    return IsoCode.ISO_REG_FAIL_ISO_EXISTS;
                }
            }
            Console.WriteLine("Force mode is enabled. Overwriting the ISO file... Reinstalling the ISO...");
            Console.WriteLine(" * IMPORTANT * This will remove all of your data. This may take a while...");
            File.Delete(isoFolder + "/csefa.iso");
            if (File.Exists(isoFolder + "/csefa.iso"))
            {
                Console.WriteLine("Deleting the ISO file failed.");
                return IsoCode.ISO_FORCE_REG_FAIL;
            }
            else
            {
                Console.WriteLine("Deleting the ISO file succeeded.");
                Directory.Delete("csefa", true);
                if (Directory.Exists("csefa"))
                {
                    Console.WriteLine("Deleting the csefa folder failed.");
                    return IsoCode.ISO_FORCE_REG_FAIL;
                }
                else
                {
                    Console.WriteLine("Deleting the csefa folder succeeded.");
                }
                Directory.CreateDirectory("csefa");
                Directory.CreateDirectory("csefa/iso");
                File.Move(isoCsefa, isoFolder + "/csefa.iso");
                if (!File.Exists(isoFolder + "/csefa.iso"))
                {
                    Console.WriteLine("Moving the ISO file failed.");
                    return IsoCode.ISO_FORCE_REG_FAIL;
                }
                else
                {
                    Console.WriteLine("Moving the ISO file succeeded.");
                }
                Console.WriteLine("Reinstalling the ISO...");
                Console.WriteLine("This may take a while...");
                // extract ISO file
                ISO.ExtractISO("csefa/iso/csefa.iso", "csefa");
                if (!File.Exists("csefa/iso.xml"))
                {
                    Console.WriteLine("Failed cause services.cs doesn't exists.");
                    return IsoCode.ISO_NOT_FOUND;
                }
                XmlDocument doc = new XmlDocument();
                doc.Load("csefa/iso.xml");
                XmlNodeList ServicesName = doc.GetElementsByTagName("services");
                if (ServicesName.Count == 0)
                {
                    return IsoCode.ISO_INVALID;
                }
                XmlNodeList ServicesVersion = doc.GetElementsByTagName("version");
                if (ServicesVersion.Count == 0)
                {
                    return IsoCode.ISO_INVALID;
                }

                XmlNodeList ServicesVersionCode = doc.GetElementsByTagName("versioncode");
                if (ServicesVersionCode.Count == 0)
                {
                    return IsoCode.ISO_INVALID;
                }
                XmlNodeList ServicesAuthor = doc.GetElementsByTagName("author");
                if (ServicesAuthor.Count == 0)
                {
                    return IsoCode.ISO_INVALID;
                }
                Console.WriteLine("Services name: " + ServicesName[0].InnerText);
                Console.WriteLine("Services version: " + ServicesVersion[0].InnerText);
                Console.WriteLine("Services version code: " + ServicesVersionCode[0].InnerText);
                Console.WriteLine("Services author: " + ServicesAuthor[0].InnerText);
                XmlNodeList Program = doc.GetElementsByTagName("Program");
                if (Program.Count == 0)
                {
                    return IsoCode.ISO_PROGRAM_NOT_FOUND_IN_SERVICE_XML;
                }
                if (!Directory.Exists($"csefa/{Program[0].InnerText}"))
                {
                    return IsoCode.ISO_PROGRAM_NOT_FOUND;
                }
                List<string> required = new List<string>();
                required.Add("User");
                required.Add("Library");
                required.Add("System");
                required.Add("Service");
                required.Add("Runner");
                required.Add("Installer");
                required.Add("Recovery");
                required.Add("Boot");
                required.Add("INIXC");
                required.Add("ICS");
                required.Add("Csefa");
                foreach (string req in required)
                {
                    if (!Directory.Exists($"csefa/{Program[0].InnerText}/{req}"))
                    {
                        return IsoCode.ISO_PROGRAM_NOT_FOUND;
                    }
                }
                //string[] required = new string(["User", "Library", "System", "Service", "Runner", "Installer", "Recovery", "Boot", "INIXC", "ICS", "Csefa"]);
                foreach (string req in required)
                {
                    if (!Directory.Exists($"csefa/{Program[0].InnerText}/{req}"))
                    {
                        return IsoCode.ISO_PROGRAM_NOT_FOUND;
                    }
                }

                Console.WriteLine("Reinstalling the ISO succeeded.");
                Console.WriteLine("Setting up the ISO...");
                Directory.CreateDirectory($"csefa/{Program[0].InnerText}/User/Programs/Csefa");

                Console.WriteLine("Setting up the ISO succeeded.");
                return IsoCode.ISO_FORCE_REG_DONE;
            }
            // extract ISO file


        }
        IsoCode ICsefaISO.Loader()
        {
            // Extract the ISO file
            return IsoCode.ISO_LOAD_DONE;



        }
    }
}
