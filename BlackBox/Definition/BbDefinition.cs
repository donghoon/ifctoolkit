using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using SchemaModel;
using System.Xml;



namespace BlackBox
{


    public partial class BbDefinition
    {

        //string _fileName;
        const string Ext = @".cs";


        //private Dictionary<string, SEntity> _mainEntities;
        //private List<string> _mainEntities = new List<string>();
        //private List<AttributeDefinition> _attributeMappingList = new List<AttributeDefinition>();
        //private List<BbTypeAttribute> _subBbMapppingList = new List<BbTypeAttribute>();
        //private string _creator;
        //private DateTime _createTime;
        //private static int _version = 1;

        public string FileName
        {
            get { return InterpretedName + Ext; }
        }

        public BbDefinition()
        {
           
        }

        public BbDefinition(string name, string description)
            : base(name, description)
        {
            //_fileName = this.Name + ext;

            //_mainEntities = new List<string>();
            ////_mainEntities = new Dictionary<string, SEntity>(StringComparer.InvariantCultureIgnoreCase);
            //_attributeMappingList = new List<AttributeMapping>();
            //_subBbMapppingList = new List<SubBbMapping> ();
        }


        public static BbDefinition Create(string name, string description)
        {
            var def = new BbDefinition(name, description);

            return def;
        }


        public void AddMapping(AttributeDefinition mapping)
        {
            if (mapping is EntityAttribute)
            {
                var m = mapping as EntityAttribute;

                //if (!EntityAttributes.Contains(m))
                //{
                //    EntityAttributes.Add(m);
                //}

                foreach (var a in EntityAttributes)
                {
                    if (a.Name.Equals(m.Name) && a.IfcEntityAttribute.Equals(m.IfcEntityAttribute))
                    { return; }
                }
                EntityAttributes.Add(m);
            }
            else if (mapping is BbTypeAttribute)
            {
                var n = mapping as BbTypeAttribute;
                foreach (var s in BbTypeAttributes)
                {
                    if (s.Name.Equals(n.Name))
                    {
                        return;
                    }
                }

                BbTypeAttributes.Add(n);
            }
        }



        public void addMainEntity(BbContainer context, string me)
        {
            //foreach (var s in SEntities)
            //{
            //    if (s.Name.Equals(me))
            //    {
            //        return;
            //    }
            //}

            if (SEntities.Any(s => s.Name.Equals(me)))
            {
                return;
            }


            var ent = context.Definitions.FirstOrDefault(b => b is SEntity && b.Name.ToLower() == me.ToLower()) as SEntity;
                if (ent == null) return;
                SEntities.Add(ent);
            
        }

        //public void addMainEntity(string key, SEntity value)
        //{
        //    if (!_mainEntities.ContainsKey(key))
        //        _mainEntities.Add(key, value);
        //}



        //public List<string> MainEntities
        //{
        //    get { return _mainEntities; }
        //    set { _mainEntities = value; }
        //}
        //public Dictionary<string, SEntity> MainEntities 
        //{
        //    get { return _mainEntities; }
        //}

        public void DeleteMainEntity(string s)
        {
            var a = SEntities.FirstOrDefault(b => b.Name.ToLower() == s.ToLower());
            if (a != null)
                SEntities.Remove(a);

            //if (_mainEntities.Contains(s))
            //    _mainEntities.Remove(s);
            //if (_mainEntities.ContainsKey(s))
            //    _mainEntities.Remove(s);
        }

        public List<EntityAttribute> AttributeMappingList
        {
            get { return EntityAttributes.ToList(); }
            
        }

        public void DeleteAttribute(string n)
        {
            var a = EntityAttributes.FirstOrDefault(b => b.Name.ToLower() == n.ToLower());
            if (a != null)
                EntityAttributes.Remove(a);
            //_attributeMappingList.RemoveAt(n);
            //return _attributeMappingList;
        }

        public List<BbTypeAttribute> BbTypeList
        {
            get { return BbTypeAttributes.ToList(); }
            
        }

        public void DeleteBbType(string n)
        {
            var a = BbTypeAttributes.FirstOrDefault(b => b.Name.ToLower() == n.ToLower());
            if (a != null)
                BbTypeAttributes.Remove(a);

            //_subBbMapppingList.RemoveAt(n);
            //return _subBbMapppingList;
        }


        //public string Creator 
        //{
        //    set { _creator = value; }
        //    get { return _creator; }
        //}
        //public DateTime CreateTime 
        //{
        //    set { _createTime = value; }
        //    get { return _createTime; }
        //}

        //public int Version
        //{
        //    set { _version = value; }
        //    get { return _version; }
        //}

        //public string SerializeBbDefinition()
        //{
        //    string json = "";
        //    if (!this.Equals(null))
        //        json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
        //    return json;
        //}

        //public static BbDefinition DeserializeBbDefinition(string serializedDef)
        //{
        //    if (serializedDef != null)
        //    {
        //        BbDefinition Bbdef = Newtonsoft.Json.JsonConvert.DeserializeObject<BbDefinition>(serializedDef);
        //        return Bbdef;
        //    }
        //    else
        //        return null;
        //}

    }


}

