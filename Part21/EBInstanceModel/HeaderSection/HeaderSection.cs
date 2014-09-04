using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

using SchemaModel;


namespace EbInstanceModel
{



    public partial class HeaderSection
    {
        //private readonly static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();


        private static HeaderSection _instance; // = new Header();

        private FILE_SCHEMA _fileSchema;
        private FILE_DESCRIPTION _fileDescription;
        private FILE_NAME _fileName;
        private readonly List<HeaderInstance> _headerSection; // = new List<HeaderInstance>();




        public string Description
        {
            get { return _fileDescription.DESCRIPTION[0]; }
            set
            {
                _fileDescription.DESCRIPTION.Clear();
                _fileDescription.DESCRIPTION.Add(value);
            }
        }

        public IList<string> Descriptions
        {
            get { return _fileDescription.DESCRIPTION.Cast<string>().ToList(); }
            set
            {
                _fileDescription.DESCRIPTION.Clear();
                foreach (var item in value)
                {
                    _fileDescription.DESCRIPTION.Add(item);
                }
            }
        }

        public string ImplementationLevel
        {
            get { return _fileDescription.IMPLEMTATION_LEVEL.Value; }
            set { SetImpementationLevel(value); }
        }

        public int ImplementationVersion
        {
            get { return GetImplementationVersion(); }
        }

        public int ImplmentationMappingLevel
        {
            get { return GetImplementationMappingLevel(); }
        }

        public string Name
        {
            get { return _fileName.NAME; }
            set { _fileName.NAME = value; }
        }

        public static void SetName(string name)
        {
            _instance.Name = name;
        }


        public DateTime TimeStamp
        {
            get { return DateTime.Parse(_fileName.TIME_STAMP.Value); }
            set
            {
                _fileName.TIME_STAMP = new TIME_STAMP_TEXT() { Value = CurrentTime(value), };
            }
        }

        public string Author
        {
            get { return _fileName.AUTHOR[0].Value; }
        }

        public IList<string> AuthorFullList
        {
            get { return _fileName.AUTHOR.Cast<string>().ToList(); }
        }

        public string Organization
        {
            get { return _fileName.AUTHOR[0].Value; }
        }

        public IList<string> OrganizationFullList
        {
            get { return _fileName.ORGANIZATION.Cast<string>().ToList(); }
        }

        public string PreprocessorVersion
        {
            get { return _fileName.PREPROCESSOR_VERSION.Value; }
        }

        public string OriginatingSystem
        {
            get { return _fileName.ORIGINATING_SYSTEM; }
        }

        public string Authorization
        {
            get { return _fileName.AUTHORIZATION; }
        }

        public string Schema
        {
            get { return _fileSchema.SCHEMA_IDENTIFIERS[0].Value; }
            set
            {
                _fileSchema.SCHEMA_IDENTIFIERS.Clear();
                _fileSchema.SCHEMA_IDENTIFIERS.Add(new SCHEMA_NAME { Value = value });
            }
        }








        ///// <summary>Get or set header description field</summary>
        //public static string Description
        //{
        //    get
        //    {
        //        return instance._description;
        //    }
        //    set { instance._description = value; }
        //}

        ///// <summary>Get or set header name field</summary>
        //public static string Name
        //{
        //    get
        //    {
        //        return instance._name;
        //    }
        //    set { instance._name = value; }
        //}

        ///// <summary>Get or set header time-stamp field</summary>
        //public static DateTime TimeStamp
        //{
        //    get { return instance._timeStamp; }
        //    set
        //    {
        //        instance._timeStamp = value;
        //        instance._timeStampString = CurrentTime(value);
        //    }
        //}

        ///// <summary>Get or set header author field</summary>
        //public static string Author
        //{
        //    get
        //    {
        //        return instance._author;
        //    }
        //    set { instance._author = value; }
        //}

        ///// <summary>Get or set header organization field</summary>
        //public static string Organization
        //{
        //    get
        //    {
        //        return instance._organization;
        //    }
        //    set { instance._organization = value; }
        //}

        ///// <summary>Get or set header preprocessor version field</summary>
        //public static string PreprocessorVersion
        //{
        //    get
        //    {
        //        return instance._preprocessorVersion;
        //    }
        //    set { instance._preprocessorVersion = value; }
        //}

        ///// <summary>Get or set header originating system field</summary>
        //public static string OriginatingSystem
        //{
        //    get
        //    {
        //        return instance._originatingSystem;
        //    }
        //    set { instance._originatingSystem = value; }
        //}

        ///// <summary>Get or set header authorization field</summary>
        //public static string Authorization
        //{
        //    get
        //    {
        //        return instance._authorization;
        //    }
        //    set { instance._authorization = value; }
        //}

        ///// <summary>Get or set header schema field</summary>
        ///// <remarks>Currently only have IFC2X3, IFC2X2_FINAL</remarks>
        //public static string Schema
        //{
        //    get
        //    {
        //        return instance._schema;
        //    }
        //    set { instance._schema = value; }
        //}

        //public void Init()
        //{
        //    if (_instance == null) _instance = new HeaderSection();
        //}

        /// <summary>IfcDefaultEntities header constructor</summary>
        private HeaderSection()
            : this(EbConstants.DefaultHeaderDescriptionString, 2, 1,
                EbConstants.DefaultFilenameString, EbConstants.DefaultAuthor, EbConstants.DefaultAuthor,
                Assembly.GetExecutingAssembly().GetName().Name, EbConstants.DefaultAuthor,
                RegisteredSchema.IFC2X3.ToString())
        {
        }


        public static void SetHeader(string mvdName,
            string filename, string organization,
            string schemaVersion)
        {
            _instance = new HeaderSection(mvdName, 2, 1,
                filename, SystemService.SystemUser, organization, Assembly.GetExecutingAssembly().GetName().Name, SystemService.SystemUser,
                schemaVersion);
        }


        public static void SetHeader(FILE_SCHEMA fileSchema, FILE_DESCRIPTION fileDescription, FILE_NAME fileName)
        {
            _instance = new HeaderSection(fileSchema, fileDescription, fileName);
        }


        public static void WriteToP21(StreamWriter sw)
        {
            foreach (var header in _instance._headerSection)
            {
                header.WriteToP21(sw);
                sw.WriteLine(EbConstants.SemiColon);

            }
        }


        private HeaderSection(
            string headerDescription, int implementationLevel, int mappingLevel,
            string filename, string author, string organization, string originatingSystem, string authorization,
            string schemaVersion)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            _fileSchema = new FILE_SCHEMA()
            {
                SCHEMA_IDENTIFIERS = new List<SCHEMA_NAME> { new SCHEMA_NAME { Value = schemaVersion } }
            };

            _fileDescription = new FILE_DESCRIPTION()
            {
                DESCRIPTION = new List<STRING>() { headerDescription },
                IMPLEMTATION_LEVEL = string.Format("{0};{1}", implementationLevel, mappingLevel),
            };


            //var ts = new TIME_STAMP_TEXT { Value = DateTime.Now.ToString("s") };
            _fileName = new FILE_NAME
            {
                AUTHOR = new List<STRING>() { author },
                AUTHORIZATION = authorization, //SystemService.SystemUser,
                NAME = filename,
                ORGANIZATION = new List<STRING>() { organization }, // new List<STRING>() { fvi.CompanyName },
                ORIGINATING_SYSTEM = originatingSystem, //assembly.GetName().Name,
                PREPROCESSOR_VERSION = string.Format(CultureInfo.InvariantCulture, "{0} {1}", fvi.ProductName, fvi.ProductVersion),
                //TIME_STAMP = ts
            };
            TimeStamp = DateTime.Now;

            _headerSection = new List<HeaderInstance>() { _fileDescription, _fileName, _fileSchema };
            //_headerSection.Clear();
            //_headerSection.Add(_fileSchema);
            //_headerSection.Add(_fileDescription);
            //_headerSection.Add(_fileName);
        }

        private HeaderSection(FILE_SCHEMA fileSchema, FILE_DESCRIPTION fileDescription, FILE_NAME fileName)
        {
            _fileSchema = fileSchema;
            _fileDescription = fileDescription;
            _fileName = fileName;
            _headerSection = new List<HeaderInstance>() { _fileDescription, _fileName, _fileSchema };
        }


        private void SetImpementationLevel(string implementationLevel)
        {
            var version = ImplementationLevel.Remove(ImplementationLevel.IndexOf(';'));
            var mappingLevel = ImplementationLevel.Substring(ImplementationLevel.IndexOf(';') + 1);

            int vInt;
            int mInt;


            if (int.TryParse(version, out vInt) && int.TryParse(mappingLevel, out mInt))
            {
                _fileDescription.IMPLEMTATION_LEVEL = string.Format("{0};{1}", vInt, mInt);
            }
            else
            {
                throw new FormatException();
            }

        }

        private int GetImplementationVersion()
        {
            var version = ImplementationLevel.Remove(ImplementationLevel.IndexOf(';'));
            return int.Parse(version);
        }

        private int GetImplementationMappingLevel()
        {
            var version = ImplementationLevel.Substring(ImplementationLevel.IndexOf(';') + 1);
            return int.Parse(version);
        }

        /////// <summary>
        /////// Write IFC Header
        /////// </summary>
        /////// <param name="path">full file name and path to export</param>
        ////public static void WriteHeader(StreamWriter sw)
        ////{
        ////    //if (path == string.Empty) return;
        ////    //try
        ////    //{
        ////    //    FileInfo fi = new FileInfo(path);
        ////    //    instance._name = fi.Name;
        ////    //    using (var sw = new StreamWriter(path))
        ////    //    {
        ////            sw.WriteLine(EbConstants.ISOstr);
        ////            sw.WriteLine(EbConstants.HEADERstr);
        ////            GetHeaderDescription().WriteToP21(sw);
        ////            sw.WriteLine(EbConstants.SemiColon);
        ////            GetHeaderFilename().WriteToP21(sw);
        ////            sw.WriteLine(EbConstants.SemiColon);
        ////            GetHeaderFileSchema().WriteToP21(sw);
        ////            sw.WriteLine(EbConstants.SemiColon);
        ////            sw.WriteLine(EbConstants.ENDSECstr);
        ////            sw.WriteLine();
        ////            sw.WriteLine(EbConstants.DATAstr);
        ////    //    }
        ////    //}
        ////    //catch (Exception ex)
        ////    //{
        ////    //    var fileInfo = new StackFrame(true);
        ////    //    Logger.Debug(string.Format("File : {0}\nLine : {1}\nException : {2}\nTrace : {3}",
        ////    //                                   fileInfo.GetFileName(), fileInfo.GetFileLineNumber(), ex.Message,
        ////    //                                   ex.StackTrace));
        ////    //}
        ////}




        public static FILE_SCHEMA FileSchema
        {
            get { return _instance._fileSchema; }
            set { _instance._fileSchema = value; }
            //return new FILE_SCHEMA()
            //{
            //    SCHEMA_IDENTIFIERS = new List<SCHEMA_NAME> { new SCHEMA_NAME { Value = instance._schema } }
            //};
        }

        /// <summary>
        /// Set header description
        /// </summary>
        /// <returns></returns>
        public static FILE_DESCRIPTION FileDescription
        {
            get { return _instance._fileDescription; }
            set { _instance._fileDescription = value; }
            //return new FILE_DESCRIPTION()
            //{
            //    DESCRIPTION = new List<STRING>() { Description },
            //    IMPLEMTATION_LEVEL = "2;1",
            //};
        }

        /// <summary>
        /// Export header to output file. Must called prior exiting application.
        /// </summary>
        public static FILE_NAME FileName
        {
            get { return _instance._fileName; }
            set { _instance._fileName = value; }

            //var ts = new TIME_STAMP_TEXT { Value = TimeStamp.ToString("s") };
            //return new FILE_NAME
            //{
            //    AUTHOR = new List<STRING>() { Author },
            //    AUTHORIZATION = Authorization,
            //    NAME = Name,
            //    ORGANIZATION = new List<STRING>() { Organization },
            //    ORIGINATING_SYSTEM = OriginatingSystem,
            //    PREPROCESSOR_VERSION = PreprocessorVersion,
            //    TIME_STAMP = ts
            //};
        }


        public static IList<HeaderInstance> HeaderInstances
        {
            get { return _instance._headerSection; }
        }

        /// <summary>
        /// Converting DateTime to string
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        private static string CurrentTime(DateTime dateTime)
        {
            var date = dateTime.ToUniversalTime();
            var time = date.Year + "-" + date.Month.ToString("d2") + "-" + date.Day.ToString("d2") + "T" + date.Hour.ToString("d2") + ":" + date.Minute.ToString("d2") + ":" + date.Second.ToString("d2");
            return time;
        }
    }
}