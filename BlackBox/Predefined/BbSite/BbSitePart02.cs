using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{
    public partial class BbSite
    {

        /// <summary>
        /// only for import
        /// </summary>
        /// <param name="ifcSite"></param>
        protected BbSite(IfcSite ifcSite)
        {

            Guid = IfcGloballyUniqueId.ConvertToGuid(ifcSite.GlobalId);

            var a = EarlyBindingInstanceModel.GetReferencedEntities(ifcSite.EIN).Values;

            var b = (from x in a.OfType<IfcRelAggregates>()
                where x.RelatingObject.GetType() == typeof (IfcProject)
                     select x).First() as IfcRelAggregates;

            IfcRelAggregates = b;

            
            if (b != null)
            {
                var sPrjGuid = BbInstanceDB.GetSemIdListByEin(b.RelatingObject.EIN).First();
                var aa = BbInstanceDB.GetSemById(sPrjGuid) as BbProject;
                BbProject = aa;

                
            }


            IfcSpatialStructureElement = ifcSite;

            

        }



        public static ICollection<BbSite> Retrieve()
        {
            var ifcList = (from p21 in EarlyBindingInstanceModel.GetDataByType("IfcSite").Values
                           select p21 as IfcSite).ToList();

            var sites = (
                from site in ifcList 
                select new BbSite(site))
                .ToList();

            BbInstanceDB.AddToImport(sites);

            return sites;
        }




    }
}
