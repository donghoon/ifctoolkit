//using System;
//using System.Collections.Generic;
//using EbInstanceModel;
//using Sem.Service;
//using IFC2X3;

//namespace Sem.Predefined
//{

//    public partial class BbProject : BbProduct
//    {
//        List<BbSpatialElement> _sites = new List<BbSpatialElement>();

//        [EarlyBindingInstance]
//        public IfcRelAggregates IfcRelAggregates { get; private set; }

//        [EarlyBindingInstance]
//        public IfcProject IfcProject { get; private set; }

//        [ComponentsCollection]
//        public List<BbSpatialElement> Sites
//        {
//            get { return _sites; }
//        }

//        BbProject(string name)
//        {
//            IfcProject = new IfcProject
//            {
//                //GlobalId = IfcGloballyUniqueId.ConvertToIfcGuid(guid),
//                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
//                Name = name,
//                //Description = "",
//                //ObjectType = "",
//                //LongName = "",
//                //Phase = "",
//                RepresentationContexts = new List<IfcRepresentationContext>(),
//                UnitsInContext = BbHeaderSetting.Setting3D.IFCUnitAssignment,
//            };

//            IfcProject.GlobalId = IfcGloballyUniqueId.NewGuid();

//            IfcProject.RepresentationContexts.Add(BbHeaderSetting.Setting3D.GeometricRepresentationContext);

//        }

//        private BbProject()
//        {
//        }



//        public static BbProject Retrieve()
//        {
//            var ret = new BbProject();

//            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcProject")) return null;
//            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcProject"].Values;
//            if (collection.Count != 1) throw new NotImplementedException();

//            foreach (var item in collection)
//            {
//                var theItem = item as IfcProject;
//                if (theItem == null) continue;
//                var semProject = new BbProject { IfcProject = theItem };

//                var sites = RetrieveSites(semProject);
//                semProject._sites = sites;

//                ret = semProject;
//                BbInstanceDB.Add(semProject);
//            }
//            return ret; 
//        }



//        private static List<BbSpatialElement> RetrieveSites(BbProject project)
//        {
//            var sites = new List<BbSpatialElement>();

//            if (EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAggregates"))
//            {
//                var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcRelAggregates"].Values;
//                //if (collection.Count != 1) throw new NotImplementedException();
//                foreach (var item in collection)
//                {
//                    var theItem = item as IfcRelAggregates;
//                    if (theItem == null) continue;
//                    if (theItem.RelatingObject.EIN == project.IfcProject.EIN)
//                    {
//                        foreach (var a in theItem.RelatedObjects)
//                        {
//                            var element = a as IfcSpatialStructureElement;
//                            if (element == null) continue;
//                            var site = new BbSpatialElement { IfcSpatialStructureElement = element , IfcRelAggregates = theItem };
//                            BbInstanceDB.Add(site);
//                            sites.Add(site);
//                        }
//                    }
//                }
//            }
//            return sites;
//        }




//        public void AddSite()
//        {
//            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAggregates")) return;

//            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcRelAggregates"].Values;

//            var ret = new List<IfcRelAggregates>();
//            foreach (var item in collection)
//            {
//                var theItem = item as IfcRelAggregates;
//                if (theItem == null) continue;
//                if (theItem.RelatingObject.EIN != IfcProject.EIN) continue;
//                IfcRelAggregates = theItem;
//                foreach (var relItem in theItem.RelatedObjects)
//                {
//                    if (relItem is IfcSpatialStructureElement)
//                    {
//                    }
//                }
//                return;
//            }
//        }


//        public void AddSite(BbSpatialElement site)
//        {

//            if (IfcRelAggregates == null)
//            {
//                IfcRelAggregates = new IfcRelAggregates
//                {
//                    GlobalId = IfcGloballyUniqueId.NewGuid(),
//                    OwnerHistory = IfcProject.OwnerHistory,
//                    RelatingObject = IfcProject,
//                    RelatedObjects = new List<IfcObjectDefinition>(),
//                };
//            }
//            _sites.Add(site);
//            IfcRelAggregates.RelatedObjects.Add(site.IfcSpatialStructureElement);
//        }

//        public static BbProject Create(
//            string name)
//        {
//            var p = new BbProject(name);
//            BbInstanceDB.Add(p);
//            return p;
//        }



//    }

//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbProject : BbProduct
    {

        private IfcProject _ifcProject;

        [EarlyBindingInstance]
        public override IfcObject IfcObject {
            get { return _ifcProject; }
            protected set
            {
                base.IfcObject = _ifcProject = value as IfcProject;
            }
        }

        //protected BbProject()
        //{
        //}

        //protected BbProject(string name)
        //    : this(Guid.NewGuid(), name, null, null, null, null)
        //{
        //}

        protected BbProject(IfcProject ifcProject)
        {
            _ifcProject = ifcProject;
        }

        protected BbProject(Guid guid, string name, string description, string objectType, string longname, string phase)
            //: this()
        {
            _ifcProject = new IfcProject
            {
                GlobalId = IfcGloballyUniqueId.ConvertToIfcGuid(guid),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                Description = description,
                ObjectType = objectType,
                LongName = longname,
                Phase = phase,
                RepresentationContexts = new List<IfcRepresentationContext>(),
                UnitsInContext = BbHeaderSetting.Setting3D.IfcUnitAssignment,
            };
            _ifcProject.RepresentationContexts.Add(BbHeaderSetting.Setting3D.GeometricRepresentationContext);
        }

        public static void Retrieve()
        {
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcProject");
            //if (collection.Count <= 0) throw new InvalidDataException();

            //if (collection.Count != 1)
            //    throw new InvalidDataException();

            //var theItem = collection.First();

            //var proj = theItem.Value as IfcProject;
            //var sProj = new BbProject(proj);
            //BbInstanceDB.Add(sProj);
            //return sProj;


            foreach (var sproject in collection.Select(kvp => kvp.Value).OfType<IfcProject>().Select(project => new BbProject(project)))
            {
                BbInstanceDB.AddToImport(sproject);
            }

        }

        public static BbProject Create(string name)
        {
            return Create(Guid.NewGuid(), name, null, null, null, null) ;
        }

        public static BbProject Create(Guid guid, string name, string description, string objectType, string longname, string phase)
        {
            var p = new BbProject(guid, name, description, objectType, longname, phase);
            BbInstanceDB.AddToExport(p);
            return p;
        }
    }
}

