using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SchemaModel;
using System.Xml;
//using Newtonsoft.Json;


/*
    EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"
 GO  
  
   
   insert into Definitions   select *   from OldSemDB.dbo.Definitions
   insert into Definitions_AttributeDefinition   select *   from OldSemDB.dbo.Definitions_AttributeDefinition
   insert into Definitions_EntityAttribute   select *   from OldSemDB.dbo.Definitions_EntityAttribute
   insert into Definitions_MvdDefinition   select *   from OldSemDB.dbo.Definitions_MvdDefinition
   insert into Definitions_SemTypeAttribute   select *   from OldSemDB.dbo.Definitions_SemTypeAttribute
   insert into Definitions_SEntity   select *   from OldSemDB.dbo.Definitions_SEntity
   insert into MvdExchanges   select *   from OldSemDB.dbo.MvdExchanges
   insert into NameSpaces   select *   from OldSemDB.dbo.NameSpaces
   insert into SemDefinitionNameSpace   select *   from OldSemDB.dbo.SemDefinitionNameSpace
   insert into SemDefinitionNameSpace1   select *   from OldSemDB.dbo.SemDefinitionNameSpace1
   insert into SEntitySemDefinition   select *   from OldSemDB.dbo.SEntitySemDefinition
   
  insert into Definitions_SemDefinition   ([Guid], [CreationDate], Creator, [FkSuperTypeGuid])
  select [Guid], [CreationDate], Creator, [FkSuperTypeGuid]   
  from OldSemDB.dbo.Definitions_SemDefinition
   GO

   exec sp_msforeachtable @command1="print '?'", @command2="ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"
   GO
-------------------------------------------------------------------------------------------------------------------
 * 
insert into Definitions ([Guid], Name, InterpretedName)
select [guid], name, simplename from sem_entity
go 

insert into Definitions_SEntity ([Guid], [Schema])
select [guid], '2x3' from sem_entity
go

insert into Definitions ([Guid], Name, InterpretedName, [Description])
select [guid], name, name, [description] from Latest_Sem_Definition
go 

insert into Definitions_SemDefinition ([Guid], CreationDate, Creator)
select [guid], creation_date, creator from Latest_Sem_Definition
go

insert into Definitions (Guid, Name, InterpretedName)
select b.[guid], Latest_Sem_Definition.name, Latest_Sem_Definition.name
from
(select a.[guid], a.comp_sem_guid
from
(select sem_composition.[guid], sem_composition.sem_guid, sem_composition.comp_sem_guid from sem_composition, Latest_Sem_Definition
where sem_composition.comp_sem_guid = Latest_Sem_Definition.guid) as a, Latest_Sem_Definition
where a.sem_guid = Latest_Sem_Definition.guid) as b, Latest_Sem_Definition
where b.comp_sem_guid = Latest_Sem_Definition.guid
go

insert into Definitions_AttributeDefinition ([Guid], DataType, LowerBound, UpperBound)
select a.[guid], 'sem', 1, 1
from
(select sem_composition.[guid], sem_composition.sem_guid, sem_composition.comp_sem_guid from sem_composition, Latest_Sem_Definition
where sem_composition.comp_sem_guid = Latest_Sem_Definition.guid) as a, Latest_Sem_Definition
where a.sem_guid = Latest_Sem_Definition.guid
go
 
insert into Definitions_SemTypeAttribute([Guid], [FkSemDefinitionGuid], [FkSemGuidInAttributes])
select a.[guid], a.comp_sem_guid, a.sem_guid
from
(select sem_composition.[guid], sem_composition.sem_guid, sem_composition.comp_sem_guid from sem_composition, Latest_Sem_Definition
where sem_composition.comp_sem_guid = Latest_Sem_Definition.guid) as a, Latest_Sem_Definition
where a.sem_guid = Latest_Sem_Definition.guid
go

update Definitions_SemDefinition
set
Definitions_SemDefinition.FkSuperTypeGuid = Latest_Sem_Definition.super
from 
Definitions_SemDefinition
inner join 
Latest_Sem_Definition
on 
Definitions_SemDefinition.[Guid] = Latest_Sem_Definition.[guid]
where Latest_Sem_Definition.[super] not like '00000000-0000-0000-0000-000000000000'


insert into NameSpaces ([Guid], [Name],[Description])
select [guid], [name],[description] from sem_namespace
go

insert into SemDefinitionNameSpace([SemDefinitions_Guid], [NameSpaces_Guid])
select [guid], [namespace_guid] from get_latest_sem_namespace_mapping
go
 
insert into MvdExchanges ([Guid], [ExchangeMaker], [EmNumber], [Title], [ProjectStage], [Disciplines], [DiscriptionPurpose], [DescriptionIncludes], [DescriptionDetail], [DescriptionMajor], [DescriptionSpecial], [SoftwareExport], [SoftwareImport], [SoftwareNotes], [CreationDate], [RelatedModel], [OfInterest], [IsDeleted], [NameSpaceGuid])
select [guid],[exchange_marker],[em_number],[title],[project_stage],[disciplines],[description_purpose] ,[description_includes] ,[description_detail] ,[description_major] ,[description_special] ,[software_export], [software_import],[software_notes], [creation_date],[related_model],[of_interest],[is_deleted],[domain] from aci_exchanges
go

insert into Definitions ([Guid], [Name],[Description])
select [guid], [name],[description] from mvd_definition
 
go

insert into Definitions_MvdDefinition ([Guid], [Creator],[CreationDate], [Version], [IsDeleted], [Definition],[MvdExchangeGuid])
select [guid], [creator],[creation_date], [version], [is_deleted], [definition] , [exchange_id] from mvd_definition
go
 * 
 * 
 */

namespace BlackBox
{
/// <summary>
/// 
/// 
/// 
/// 
/// 
/// </summary>
    public partial class Definition : ICSharpClass
    {
        //private Guid _guid;
        //readonly string _inputName;
        //readonly string _name;
        //static string _dbName ="";

        //public string Name
        //{
        //    get { return _name; }
        //}

        //public string InputName
        //{
        //    get { return _inputName; }
        //}

        //public string DbName 
        //{
        //    get { return _dbName; }
        //}

        //public System.Guid Guid
        //{
        //    get { return _guid; }
        //    set { _guid = value; }
        //}

        //public string Description { get; set; }


        public Definition()
        {
        }

        public Definition(string name)
            : this(name, null)
        {
        }

        public Definition(string name, string description)
            : this(Guid.NewGuid(), name, description)
        {

        }

        public Definition(Guid guid, string name, string description)
        {
            //if (_guid == Guid.Empty)
            //    _guid = Guid.NewGuid();

            //_inputName = name;

            // convert name to Title case


            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NoNullAllowedException("Name should have a least one Alphabet character");
            }

            Guid = guid == Guid.Empty ? Guid.NewGuid() : guid;

            //if (name.Length > 3 && name.Substring(0, 3).Equals("Sem"))
            //{
            //    string trim = "Sem";
            //    name = name.TrimStart(trim.ToCharArray());
            //}

            Name = CleanInput(name);

            Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower());

            InterpretedName = Name.Replace(" ", "");

            //if (_dbName.Equals(""))
            //    _dbName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            if (description != null && !string.IsNullOrWhiteSpace(description))
            {
                Description = CleanInput(description);
            }
        }

        string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            //return Regex.Replace(strIn, @"[^\w\.@-]", "");
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(strIn, String.Empty);

        }



        #region ICSharpClass implementation
        public void ToCSharpClass(System.IO.StreamWriter stream)
        {

        }
        #endregion
    }


    //	public class SemJson
    //	{
    //		
    //		public Guid Id;
    //		
    //		[JsonIgnoreAttribute]
    //		public string IdString
    //		{
    //			get { return Id.ToString(); }
    //			set { Guid.TryParse(value, out Id); }
    //		}
    //		
    //		
    //		public string name;
    //		
    //		public List<SemJson> children;
    //		
    //		public SemJson()
    //			: this(Guid.NewGuid(), "")
    //		{
    //			
    //		}
    //		
    //		public SemJson(string name)
    //			: this(Guid.NewGuid(), name)
    //		{
    //			
    //		}
    //		
    //		
    //		public SemJson(Guid guid, string name)
    //		{
    //			Id = guid;
    //			this.name = name;
    //			children = new List<SemJson>();
    //		}
    //		
    //		
    //		public string ToJson()
    //		{
    //			var serializer = new JsonSerializer();
    //			var stringWriter = new StringWriter();
    //			var writer = new JsonTextWriter(stringWriter);
    //			writer.QuoteName = false;
    //			serializer.Serialize(writer, this);
    //			writer.Close();
    //			return stringWriter.ToString();
    //
    //		}
    //		
    //		public static SemJson ReadJson(string jsonText)
    //		{
    //			return JsonConvert.DeserializeObject<SemJson>(jsonText);
    //
    //		}
    //	}





}
