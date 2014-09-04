using System.Collections.Generic;
using System.Linq;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbBuilding
    {
        protected BbBuilding(IfcBuilding ifcBulding)
            
        {
            

            var a = EarlyBindingInstanceModel.GetReferencedEntities(ifcBulding.EIN).Values;

            var b = (from x in a.OfType<IfcRelAggregates>()
                     where x.RelatingObject.GetType() == typeof(IfcSite)
                     select x).First() as IfcRelAggregates;

            IfcRelAggregates = b;


            if (b != null)
            {
                var sPrjGuid = BbInstanceDB.GetSemIdListByEin(b.RelatingObject.EIN).First();
                var aa = BbInstanceDB.GetSemById(sPrjGuid) as BbSite;
                BbSite = aa;


            }

            IfcSpatialStructureElement = ifcBulding;


        }



        public static ICollection<BbBuilding> Retrieve()
        {
            var ifcList = (from p21Instance in EarlyBindingInstanceModel.GetDataByType("IfcBuilding").Values
                           select p21Instance).ToList();

            
            var buildings = (
                from building in ifcList
                let si = building as IfcBuilding
                where building != null
                select new BbBuilding(si))
                .ToList();

            BbInstanceDB.AddToImport(buildings);

            return buildings;
        }
    }
}
