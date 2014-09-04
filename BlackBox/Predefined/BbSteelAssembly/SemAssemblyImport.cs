using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    /// <summary>
    /// Steel assembly.
    /// </summary>
    public partial class BbAssembly
    {
        protected BbAssembly(IfcElementAssembly ifcElementAssembly)
        {


            var a = EarlyBindingInstanceModel.GetReferencedEntities(ifcElementAssembly.EIN).Values;

            var b = (from x in a.OfType<IfcRelContainedInSpatialStructure>()
                     where x.RelatingStructure.GetType() == typeof(IfcBuildingStorey)
                     select x).First();

            IfcRelContainedInSpatialStructure = b;

            


            //if (b != null)
            //{
            //    var sPrjGuid = BbInstanceDB.GetSemIdListByEin(b.RelatingObject.EIN).First();

            //    var aa = BbInstanceDB.GetSemById(sPrjGuid) as BbBuilding;
            //    BbBuilding = aa;


            //}

            //IfcSpatialStructureElement = ifcElementAssembly;


        }



        public static ICollection<BbAssembly> Retrieve()
        {
            var ifcList = (from p21Instance in EarlyBindingInstanceModel.GetDataByType("IfcElementAssembly").Values
                           select p21Instance).ToList();



            var assemblies = (
                from building in ifcList
                let si = building as IfcElementAssembly
                where building != null
                select new BbAssembly(si))
                .ToList();

            BbInstanceDB.AddToImport(assemblies);

            return assemblies;
        }

    }
}
