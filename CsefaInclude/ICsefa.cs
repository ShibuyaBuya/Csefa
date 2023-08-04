using System;
using ISOCODE;
namespace ICsefa
{
    public interface ICsefaISO
    {
        IsoCode RIso(string iso, bool force);
        IsoCode Loader();
    }
}
