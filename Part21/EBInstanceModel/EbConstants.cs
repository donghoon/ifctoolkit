namespace EbInstanceModel
{
    public static class EbConstants
    {
        public const string Em11MvdName = @"ViewDefinition[AISC_Steel_Detailing]";
        //public const string Ifc2X3Name = @"IFC2X3";
        //public const string Ifc4Name = @"IFC4";

        public const string DefaultFilenameString = "semOutput.ifc";
        public const string DefaultHeaderDescriptionString = "Conforms to IFC 2X3 and SEM Definition";
        public static string DefaultAuthor = SystemService.SystemUser;

        public static string DefaultPreprocessorName = @"SEM Toolkit";
        public static string DefaultOrganization = @"Georgia Tech";


        public static string Part21NSName = typeof (EbConstants).Namespace;

        public const string LParentheses = @"(";
        public const string RParentheses = @")";
        public const string Comma = @",";
        public const string Asterisk = @"*";
        public const string Dollar = @"$";
        public const string SemiColon = @";";
        public const string Sharp = @"#";
        public const string Equal = @"=";


        public const string ENDSECstr = @"ENDSEC;";
        public const string ENDISOstr = @"END-ISO-10303-21;";
        public const string ISOstr = @"ISO-10303-21;";
        public const string HEADERstr = @"HEADER;";
        public const string DATAstr = @"DATA;";


    }
}