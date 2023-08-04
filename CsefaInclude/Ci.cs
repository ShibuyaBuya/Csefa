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
            if (File.Exists(isoFolder + "/csefa.iso"))
            {
                if (!force)
                {
                    return IsoCode.ISO_REG_FAIL_ISO_EXISTS;
                }
                else if (force)
                {
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
                        if (!File.Exists("csefa/iso.xml")){
                            Console.WriteLine("Failed cause services.cs doesn't exists.");
                            return IsoCode.ISO_NOT_FOUND;
                        }
                        XmlDocument doc = new XmlDocument();
                        doc.Load("csefa/iso.xml");
                        XmlNodeList ServicesName = doc.GetElementsByTagName("services");
                        XmlNodeList ServicesVersion = doc.GetElementsByTagName("version");
                        XmlNodeList ServicesVersionCode = doc.GetElementsByTagName("versioncode");
                        XmlNodeList ServicesAuthor = doc.GetElementsByTagName("author");
                        Console.WriteLine("Services name: " + ServicesName[0].InnerText);
                        Console.WriteLine("Services version: " + ServicesVersion[0].InnerText);
                        Console.WriteLine("Services version code: " + ServicesVersionCode[0].InnerText);
                        Console.WriteLine("Services author: " + ServicesAuthor[0].InnerText);
                        Console.WriteLine("Reinstalling the ISO succeeded.");
                        return IsoCode.ISO_FORCE_REG_DONE;
                    }
                    // extract ISO file


                }
            }
            return IsoCode.ISO_REG_DONE;
        }
        IsoCode ICsefaISO.Loader()
        {
            // Extract the ISO file
            return IsoCode.ISO_LOAD_DONE;
            


        }
    }
}
