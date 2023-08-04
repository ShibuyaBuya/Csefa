namespace Ci 
{
    using System;
    using System.IO.Compression;
    using System.Runtime;
    using ICsefa;
    using ISOCODE;
    
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
            if (File.Exists(isoFolder + "/csefa.iso")){
                if (!force){
                    return IsoCode.ISO_REG_FAIL_ISO_EXISTS;
                }
                else if (force){
                    Console.WriteLine("Force mode is enabled. Overwriting the ISO file... Reinstalling the ISO...");
                    Console.WriteLine("This may take a while...");
                    File.Delete(isoFolder + "/csefa.iso");
                    if (File.Exists(isoFolder + "/csefa.iso")){
                        Console.WriteLine("Deleting the ISO file failed.");
                        return IsoCode.ISO_FORCE_REG_FAIL;
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
