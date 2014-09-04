using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbFloor
    {
        protected BbFloor(IfcBuildingStorey ifcBuildingStorey)
            
        {
            

            var a = EarlyBindingInstanceModel.GetReferencedEntities(ifcBuildingStorey.EIN).Values;

            var b = (from x in a.OfType<IfcRelAggregates>()
                     where x.RelatingObject.GetType() == typeof(IfcBuilding)
                     select x).First() as IfcRelAggregates;

            IfcRelAggregates = b;


            if (b != null)
            {
                var sPrjGuid = BbInstanceDB.GetSemIdListByEin(b.RelatingObject.EIN).First();
                var aa = BbInstanceDB.GetSemById(sPrjGuid) as BbBuilding;
                BbBuilding = aa;


            }

            IfcSpatialStructureElement = ifcBuildingStorey;


        }



        public static ICollection<BbFloor> Retrieve()
        {
            var ifcList = (from p21Instance in EarlyBindingInstanceModel.GetDataByType("IfcBuildingStorey").Values
                           select p21Instance).ToList();

            
            var buildings = (
                from building in ifcList
                let si = building as IfcBuildingStorey
                where building != null
                select new BbFloor(si))
                .ToList();

            BbInstanceDB.AddToImport(buildings);

            return buildings;
        }

    }
}
