namespace ISOCODE
{
    public enum IsoCode
    {
        ISO_EXISTS = 893,
        ISO_NOT_EXISTS = 894,
        ISO_NOT_FOUND = 895,
        ISO_CORRUPT = 896,
        ISO_INCORRECT = 897,
        ISO_INVALID = 898,
        ISO_NOT_SUPPORTED = 899,
        ISO_NOT_INCLUDE_INIXC = 900,
        ISO_NOT_INCLUDE_ICS = 901,
        ISO_WRONG_PATH = 902,
        ISO_CSEFA_VERSION_NOT_SUPPORTED = 904,
        ISO_FAIL_UPDATE = 905,
        ISO_FAIL_MOVE = 906,
        ISO_REG_FAIL = 907,
        ISO_REG_DONE = 908,
        ISO_REG_FAIL_SYSTEM_ISO = 909,
        ISO_NEED_REINSTALL = 910,
        ISO_CHANGE_DONE = 912,
        ISO_CHANGE_FAIL = 913,
        ISO_LOAD_FAIL = 914,
        ISO_LOAD_DONE = 915,
        ISO_LOAD_FAIL_CAUSE_ABORT = 916,
        ISO_FORCE_LOAD = 917,
        ISO_FORCE_LOAD_FAIL = 918,
        ISO_FORCE_DENIED = 919,
        ISO_FORCE_REG_DONE = 920,
        ISO_FORCE_REG_FAIL = 921,
        ISO_SAME_VERSION = 922,
        ISO_REINSTALL_DONE = 923,
        ISO_REINSTALL_FAIL = 924,
        ISO_FORMAT_DONE = 925,
        ISO_FORMAT_FAIL = 926,
        ISO_FORMAT_FAIL_NOT_PERMITTED = 927,
        ISO_MEED_AS_ADMIN = 928,
        ISO_REG_FAIL_ISO_EXISTS = 929,
        ISO_PROGRAM_NOT_FOUND = 930,
        ISO_PROGRAM_NOT_FOUND_IN_ISO = 931,
        ISO_PROGRAM_UNSUPPORTED = 932,
        ISO_PROGRAM_1XCS_UNSUPPORTED = 933,
        ISO_PROGRAM_1_5XCS_UNSUPPORTED = 934,
        ISO_PROGRAM_NOT_FOUND_IN_SERVICE_XML = 935


    }
    public class IsoCodeMean
    {
        public string ICM(IsoCode code){
            //Will parse the IsoCode to a string e.g ISO_EXISTS will be parsed to "ISO_EXISTS"
            switch (code)
            {
                case IsoCode.ISO_EXISTS:
                    return "ISO_EXISTS";
                case IsoCode.ISO_NOT_EXISTS:
                    return "ISO_NOT_EXISTS";
                case IsoCode.ISO_NOT_FOUND:
                    return "ISO_NOT_FOUND";
                case IsoCode.ISO_CORRUPT:
                    return "ISO_CORRUPT";
                case IsoCode.ISO_INCORRECT:
                    return "ISO_INCORRECT";
                case IsoCode.ISO_INVALID:
                    return "ISO_INVALID";
                case IsoCode.ISO_NOT_SUPPORTED:
                    return "ISO_NOT_SUPPORTED";
                case IsoCode.ISO_NOT_INCLUDE_INIXC:
                    return "ISO_NOT_INCLUDE_INIXC";
                case IsoCode.ISO_NOT_INCLUDE_ICS:
                    return "ISO_NOT_INCLUDE_ICS";
                case IsoCode.ISO_WRONG_PATH:
                    return "ISO_WRONG_PATH";
                case IsoCode.ISO_CSEFA_VERSION_NOT_SUPPORTED:
                    return "ISO_CSEFA_VERSION_NOT_SUPPORTED";
                case IsoCode.ISO_FAIL_UPDATE:
                    return "ISO_FAIL_UPDATE";
                case IsoCode.ISO_FAIL_MOVE:
                    return "ISO_FAIL_MOVE";
                case IsoCode.ISO_REG_FAIL:
                    return "ISO_REG_FAIL";
                case IsoCode.ISO_REG_DONE:
                    return "ISO_REG_DONE";
                case IsoCode.ISO_REG_FAIL_SYSTEM_ISO:
                    return "ISO_REG_FAIL_SYSTEM_ISO";
                case IsoCode.ISO_NEED_REINSTALL:
                    return "ISO_NEED_REINSTALL";
                case IsoCode.ISO_CHANGE_DONE:
                    return "ISO_CHANGE_DONE";
                case IsoCode.ISO_CHANGE_FAIL:
                    return "ISO_CHANGE_FAIL";
                case IsoCode.ISO_LOAD_FAIL:
                    return "ISO_LOAD_FAIL";
                case IsoCode.ISO_LOAD_DONE:
                    return "ISO_LOAD_DONE";
                case IsoCode.ISO_LOAD_FAIL_CAUSE_ABORT:
                    return "ISO_LOAD_FAIL_CAUSE_ABORT";
                case IsoCode.ISO_FORCE_LOAD:
                    return "ISO_FORCE_LOAD";
                case IsoCode.ISO_FORCE_LOAD_FAIL:
                    return "ISO_FORCE_LOAD_FAIL";
                case IsoCode.ISO_FORCE_DENIED:
                    return "ISO_FORCE_DENIED";
                case IsoCode.ISO_FORCE_REG_DONE:
                    return "ISO_FORCE_REG_DONE";
                case IsoCode.ISO_FORCE_REG_FAIL:
                    return "ISO_FORCE_REG_FAIL";
                case IsoCode.ISO_SAME_VERSION:
                    return "ISO_SAME_VERSION";
                case IsoCode.ISO_REINSTALL_DONE:
                    return "ISO_REINSTALL_DONE";
                case IsoCode.ISO_REINSTALL_FAIL:
                    return "ISO_REINSTALL_FAIL";
                case IsoCode.ISO_FORMAT_DONE:
                    return "ISO_FORMAT_DONE";
                case IsoCode.ISO_FORMAT_FAIL:
                    return "ISO_FORMAT_FAIL";
                case IsoCode.ISO_FORMAT_FAIL_NOT_PERMITTED:
                    return "ISO_FORMAT_FAIL_NOT_PERMITTED";
                case IsoCode.ISO_MEED_AS_ADMIN:
                    return "ISO_MEED_AS_ADMIN";
                case IsoCode.ISO_REG_FAIL_ISO_EXISTS:
                    return "ISO_REG_FAIL_ISO_EXISTS";
                case IsoCode.ISO_PROGRAM_NOT_FOUND:
                    return "ISO_PROGRAM_NOT_FOUND";
                case IsoCode.ISO_PROGRAM_NOT_FOUND_IN_ISO:
                    return "ISO_PROGRAM_NOT_FOUND_IN_ISO";
                case IsoCode.ISO_PROGRAM_UNSUPPORTED:
                    return "ISO_PROGRAM_UNSUPPORTED";
                case IsoCode.ISO_PROGRAM_1XCS_UNSUPPORTED:
                    return "ISO_PROGRAM_1XCS_UNSUPPORTED";
                case IsoCode.ISO_PROGRAM_1_5XCS_UNSUPPORTED:
                    return "ISO_PROGRAM_1_5XCS_UNSUPPORTED";
                case IsoCode.ISO_PROGRAM_NOT_FOUND_IN_SERVICE_XML:
                    return "ISO_PROGRAM_NOT_FOUND_IN_SERVICE_XML";
            }
            return "";

        }
    }
}