using System.Collections.Generic;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbBuilding : BbSpatialElement
    {
       
        [EarlyBindingInstance]
        public override IfcSpatialStructureElement IfcSpatialStructureElement
        {
            get
            {
                return _ifcBuilding;
            }
            set
            {
                _ifcBuilding = value as IfcBuilding;
            }
        }

        
        private IfcBuilding _ifcBuilding;


        [EarlyBindingInstanceCollection]
        //public List<BbSpatialElement> Floors { get; set; }
        public BbSite BbSite { get; set; }
        //public BbProject semProject { get; set; }


        //BbBuilding(string name, BbProject project)
        //{
        //    ObjectBbLocalPlacement = BbLocalPlacement3D.Create(project.ObjectBbLocalPlacement, BbPosition3D.DefaultPosition);
        //    IfcSpatialStructureElement = new IfcBuilding
        //    {
        //        GlobalId = IfcGloballyUniqueId.NewGuid(),

        //        OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //        Name = name,
        //        //Description = "",
        //        //ObjectType = "",
        //        ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
        //        //Representation = 
        //        //LongName = "",
        //        CompositionType = IfcElementCompositionEnum.ELEMENT,
        //    };
        //    semProject = project;


        //    if (true)
        //    {
        //        IfcRelAggregates = new IfcRelAggregates()
        //        {
        //            GlobalId = IfcGloballyUniqueId.NewGuid(),
        //            OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
        //            RelatingObject = semProject.IfcObject,
        //            RelatedObjects = new List<IfcObjectDefinition>() { IfcSpatialStructureElement },
        //        };
        //    }        
        //}

        BbBuilding(
            string name,
            BbSite site)
        {
            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(site.ObjectBbLocalPlacement, BbHeaderSetting.Setting3D.DefaultBbPosition3D);
            IfcSpatialStructureElement = new IfcBuilding
            {
                GlobalId = IfcGloballyUniqueId.NewGuid(),

                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                //Description = "",
                //ObjectType = "",
                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                //Representation = 
                //LongName = "",
                CompositionType = IfcElementCompositionEnum.ELEMENT,
            };
            //BbSite.AddBuilding(this);
            BbSite = site;

            
            if (true)
            {
                IfcRelAggregates = new IfcRelAggregates() { 
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                    RelatingObject = BbSite.IfcSpatialStructureElement,
                    RelatedObjects = new List<IfcObjectDefinition>() { IfcSpatialStructureElement },
                };
            }
            
        }


        private BbBuilding()
        {
        }
        protected BbBuilding(BbSite site, IfcBuilding building, IfcRelAggregates ifcRelAggregates)
        {
            BbSite = site;
            IfcSpatialStructureElement = building;
            IfcRelAggregates = ifcRelAggregates;

        }

        public static ICollection<BbBuilding> Retrieve(BbSite site)
        {
            /*
            var ret = new List<BbBuilding>();
            if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcBuilding")) return null;
            var collection = EarlyBindingInstanceModel.TheModel.DataByType["IfcBuilding"].Values;

            foreach (var item in collection)
            {
                var theItem = item as IfcBuilding;
                if (theItem == null) continue;
                foreach (var building in site.Buildings)
                {
                    if (building.IfcSpatialStructureElement.EIN == theItem.EIN)
                    {
                        var semBuilding = new BbBuilding { _ifcBuilding = theItem };
                        var floor = RetrieveFloors(semBuilding);
                        semBuilding.Floors = floor;

                        BbInstanceDB.Add(semBuilding);
                        ret.Add(semBuilding);
                    }
                }
            }
            return ret;
             * */


            var refed = EarlyBindingInstanceModel.GetReferencedEntities(site.IfcSpatialStructureElement.EIN);
            //if (refed.Count <= 0) throw new InvalidDataException();

            var ret = new List<BbBuilding>();
            foreach (var p21Instance in refed)
            {
                if (p21Instance.Value.GetType() != typeof(IfcRelAggregates)) continue;
                var agg = p21Instance.Value as IfcRelAggregates;
                if (agg == null) continue;

                foreach (var instance in agg.RelatedObjects)
                {
                    if (instance.GetType() != typeof(IfcBuilding)) continue;
                    var building = instance as IfcBuilding;
                    if (building == null) continue;
                    var semBuilding = new BbBuilding(site, building, agg);
                    ret.Add(semBuilding);
                    BbInstanceDB.AddToExport(semBuilding);
                }
            }
            return ret;
            
        }


        public static BbBuilding Create(
            string name,
            BbSite bbSite)
        {
            var b = new BbBuilding(name, bbSite);
            BbInstanceDB.AddToExport(b);
            return b;
        }

        /*
        public void AddFloor(BbSpatialElement floor)
        {

            if (Floors == null)
            {
                Floors = new List<BbSpatialElement>();
            }
            Floors.Add(floor);
            if (IfcRelAggregates == null)
            {
                IfcRelAggregates = new IfcRelAggregates
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = _ifcBuilding.OwnerHistory,
                    RelatingObject = _ifcBuilding,
                    RelatedObjects = new List<IfcObjectDefinition>(),
                };
            }
            IfcRelAggregates.RelatedObjects.Add(floor.IfcSpatialStructureElement);
        }
        */

        //private static List<BbSpatialElement> RetrieveFloors(BbBuilding building)
        //{
        //    var floors = new List<BbSpatialElement>();

        //    //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAggregates")) return null;
        //    var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelAggregates").Values;
        //    //if (collection.Count != 1) throw new NotImplementedException();
        //    foreach (var item in collection)
        //    {
        //        var theItem = item as IfcRelAggregates;
        //        if (theItem == null) continue;
        //        if (theItem.RelatingObject.EIN == building._ifcBuilding.EIN)
        //        {
        //            foreach (var elem in theItem.RelatedObjects)
        //            {
        //                var element = elem as IfcSpatialStructureElement;
        //                if (element == null) continue;
        //                var floor = new BbSpatialElement { IfcSpatialStructureElement = element, IfcRelAggregates = theItem };
        //                BbInstanceDB.AddToExport(floor);
        //                floors.Add(floor);
        //            }
        //        }
        //    }

        //    return floors;
        //}
    }
}
