using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using EbInstanceModel;
//using NLog;



namespace BlackBox.Service
{
    /// <summary>
    /// class def for storing sem instances
    /// </summary>
    public class BbInstanceDB
    {

        //private readonly static Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly Dictionary<uint, SortedSet<Guid>> _ifcToSemDictionary = new Dictionary<uint, SortedSet<Guid>>();
        private readonly Dictionary<Guid, SortedSet<uint>> _semToIfcDictionary = new Dictionary<Guid, SortedSet<uint>>();


        //private bool _isP21Outdated;
        
        private readonly BbInstanceList<BbBase> _bbInstanceList= new BbInstanceList<BbBase>();

        

        //public BbInstanceList<BbBase> Instances{
        //    get { return BbInstanceList; }
        //}

        /// <summary>
        /// Singleton for service
        /// </summary>

        public void ResetDb()
        {
            //_isP21Outdated = false;
            _bbInstanceList.Clear();
            EarlyBindingInstanceModel.Reset();
        }

        public void AddDbToExport(BbBase bbBase)
        {
            if (bbBase == null) return;
            _bbInstanceList.Add(bbBase);
            AddSemToExport(bbBase);
        }


        public void AddDbToImport(BbBase bbBase)
        {
            if(bbBase == null) return;
            _bbInstanceList.Add(bbBase);
            AddSemToImport(bbBase);
            
        }


        /// <summary>
        /// add Collection of BbBase
        /// 20130830 by donghoon
        /// </summary>
        /// <param name="bbBases"></param>
        public void AddDbToExport(IEnumerable<BbBase> bbBases)
        {
            if (bbBases == null) return;

            var a = bbBases.ToList();

            _bbInstanceList.Add(a);
            foreach (var bbBase in a)
            {
                AddSemToExport(bbBase);
            }
        }



        private uint AddSemToExport(BbBase bbBase)
        {
            uint retValue = 0;
            if (bbBase == null) return 0;

            foreach (PropertyInfo propertyInfo in bbBase.GetType().GetProperties())
            {
                if (IsEarlyBindingInstance(propertyInfo))
                {
                    var ins = propertyInfo.GetValue(bbBase, null) as P21Instance;
                    if (ins == null) continue;
                    //if (ins.EIN > 0) continue;
                    retValue = EarlyBindingInstanceModel.Add(ins);
                    if (!_semToIfcDictionary.ContainsKey(bbBase.Guid))
                    {
                        _semToIfcDictionary.Add(bbBase.Guid, new SortedSet<uint>() { ins.EIN });
                    }
                    _semToIfcDictionary[bbBase.Guid].Add(ins.EIN);
                    if (!_ifcToSemDictionary.ContainsKey(ins.EIN))
                    {
                        _ifcToSemDictionary.Add(ins.EIN, new SortedSet<Guid>() { bbBase.Guid });
                    }
                    _ifcToSemDictionary[ins.EIN].Add(bbBase.Guid);

                    continue;
                }

                if (IsBbComponents(propertyInfo))
                {
                    var lists = propertyInfo.GetValue(bbBase, null) as IList;
                    if (lists == null) continue;
                    if (lists.Count <= 0) continue;
                    foreach (var list in lists)
                    {
                        var sem = list as BbBase;
                        if (sem == null) continue;
                        retValue = AddSemToExport(sem);
                        //continue;
                    }
                }
            }
            return retValue;
        }


        private void AddSemToImport(BbBase bbBase)
        {
            //uint retValue = 0;
            if (bbBase == null) return; // 0;

            foreach (var propertyInfo in bbBase.GetType().GetProperties())
            {
                if (!IsEarlyBindingInstance(propertyInfo)) continue;
                var ins = propertyInfo.GetValue(bbBase, null) as P21Instance;
                if (ins == null) continue;

                // retValue = EarlyBindingInstanceModel.Add(ins);
                    
                if (!_semToIfcDictionary.ContainsKey(bbBase.Guid))
                {
                    _semToIfcDictionary.Add(bbBase.Guid, new SortedSet<uint>() { ins.EIN });
                }
                _semToIfcDictionary[bbBase.Guid].Add(ins.EIN);
                if (!_ifcToSemDictionary.ContainsKey(ins.EIN))
                {
                    _ifcToSemDictionary.Add(ins.EIN, new SortedSet<Guid>() { bbBase.Guid });
                }
                _ifcToSemDictionary[ins.EIN].Add(bbBase.Guid);



                //if (IsBbComponents(propertyInfo))
                //{
                //    var lists = propertyInfo.GetValue(BbBase, null) as IList;
                //    if (lists == null) continue;
                //    if (lists.Count <= 0) continue;
                //    foreach (var list in lists)
                //    {
                //        var sem = list as BbBase;
                //        if (sem == null) continue;
                //        retValue = AddSemToExport(sem);
                //        //continue;
                //    }
                //}
            }
            //return retValue;
        }

        public bool WriteDbToP21File(string filename)
        {
            try
            {
                //BbInstanceList.FillP21InstanceDB();
                //HeaderSection.SetHeader("mvdname", "filename", "test", "schemaversion");
                HeaderSection.SetHeader(EbConstants.Em11MvdName, Path.GetFileName(filename),
                EbConstants.DefaultOrganization, SchemaModel.RegisteredSchema.IFC2X3.ToString());
                return EarlyBindingInstanceModel.Write(filename);
            }
            catch (Exception ex)
            {
                var fileInfo = new StackFrame(true);
                //Logger.Debug(string.Format("File : {0}\nLine : {1}\nException : {2}\nTrace : {3}",
                //                           fileInfo.GetFileName(), fileInfo.GetFileLineNumber(), ex.Message,
                //                           ex.StackTrace));
                return false;
            }
        }

        public List<BbBase> GetExisting(Type semType)
        {
            throw new NotImplementedException();
        }


        public BbBase GetInstanceByIfcId(uint ein)
        {


            throw new NotImplementedException();
        }


        


        private static bool IsEarlyBindingInstance(PropertyInfo property)
        {
            //foreach (object attribute in property.GetCustomAttributes(true))
            //{
            //    if (attribute is EarlyBindingInstance)
            //    {
            //        return true;
            //    }
            //}
            return property.GetCustomAttributes(true).OfType<EarlyBindingInstance>().Any();
        }

        private static bool IsBbComponents(PropertyInfo property)
        {
            //foreach (object attribute in property.GetCustomAttributes(true))
            //{
            //    if (attribute is ComponentsCollection || attribute is SpatialContainmentsCollection)
            //    {
            //        return true;
            //    }
            //}
            return property.GetCustomAttributes(true).Any(attribute => attribute is EarlyBindingInstanceCollection || attribute is SpatialContainmentsCollection);
        }

        #region static functions


        private static readonly BbInstanceDB BbDb = new BbInstanceDB();

        public static BbInstanceTypeList<BbBase> GetTypedList(Type semType)
        {
            return !BbDb._bbInstanceList.Contains(semType) ? null : BbDb._bbInstanceList.GetTypes(semType);
        }

        public static void Reset()
        {
            BbDb.ResetDb();
        }

        ///// <summary>
        ///// fill up Instance dic new current db
        ///// </summary>
        //public static void MapToP21Instances()
        //{
        //    if (!BbDb._isP21Outdated) return;

        //    if (BbDb.BbInstanceList.Count > 0)
        //    {
        //        BbDb.BbInstanceList.Clear();
        //        Logger.Info("outdated instances are cleared");
        //    }
        //    foreach (var kvp in BbDb.BbInstanceList)
        //    {
        //        //EarlyBindingInstanceModel.AddSem(kvp.Value);
        //    }
        //}

        public static bool Read(string filename)
        {
            //var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            //if (directoryInfo == null) return false;
            //if (directoryInfo.Parent == null) return false;
            //var sampleLoc = directoryInfo.Parent.FullName;

            //var ebmodel = new EarlyBindingInstanceModel(filename);
            
            return true;
        }
        
        public static void AddToExport(BbBase bbBase)
        {
            BbDb.AddDbToExport(bbBase);
        }

        /// <summary>
        /// add collection of sembases to static DB
        /// 20130830 by donghoon
        /// </summary>
        /// <param name="semBases"></param>
        public static void AddToExport(IEnumerable<BbBase> semBases)
        {
            foreach (var semBase in semBases)
            {
                AddToExport(semBase);
            }
        }


        public static void AddToImport(BbBase bbBase)
        {
            BbDb.AddDbToImport(bbBase);
        }

        public static void AddToImport(IEnumerable<BbBase> semBases)
        {
            foreach (var semBase in semBases)
            {
                AddToImport(semBase);
            }
            
        }

        public static void Remove(BbBase bbBase)
        {
            //todo: implement
        }

        public static void Remove(Guid semBase)
        {
            //todo: implement
        }

        /// <summary>
        /// Write contents to P21 file
        /// </summary>
        /// <param name="filename">P21 file name to save</param>
        /// <returns></returns>
        public static bool Write(string filename)
        {
            return BbDb.WriteDbToP21File(filename);
        }


        public static IList<Guid> GetSemIdListByEin(uint ein)
        {
            var a = BbDb._ifcToSemDictionary[ein];
            if (a != null && a.Count > 0)
                return a.ToList();
            return null;
        }

        public static BbBase GetSemById(Guid semId)
        {
            return BbDb._bbInstanceList[semId];

        }



        //public static IList<BbBase> GetSemListByEin(uint ein)
        //{

        //}




        #endregion



        




    }
}
