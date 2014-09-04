using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;

namespace BlackBox.Predefined
{

    public partial class BbSite : BbSpatialElement
    {

        public BbProject BbProject { get; set; }

        protected BbSite(
            string name,
            BbProject project
            )
            : this(Guid.NewGuid(), name, project)
        {

        }

        protected BbSite(
            Guid guid, string name, BbProject project)
            : this(guid, name, name, name, @"ELEMENT", project)
        {
        }

        protected BbSite(
            Guid guid, string name, string description, string longname, string compositionType, BbProject project)

        {
            Guid = guid;

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(BbHeaderSetting.Setting3D.DefaultBbPosition3D);

            IfcSpatialStructureElement = new IfcSite
            {
                GlobalId = IfcGloballyUniqueId.ConvertToIfcGuid(guid),
                OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                Name = name,
                Description = description,
                LongName = longname,
                ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                //                CompositionType = IfcElementCompositionEnum.ELEMENT,
            };

            if (compositionType.ToLower() == @"complex")
            {
                IfcSpatialStructureElement.CompositionType = IfcElementCompositionEnum.COMPLEX;
            }
            else if (compositionType.ToLower() == @"partial")
            {
                IfcSpatialStructureElement.CompositionType = IfcElementCompositionEnum.PARTIAL;
            }
            else
            {
                IfcSpatialStructureElement.CompositionType = IfcElementCompositionEnum.ELEMENT;
            }

            BbProject = project;


            if (true)
            {
                IfcRelAggregates = new IfcRelAggregates() { 
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                    RelatingObject = BbProject.IfcObject,
                    RelatedObjects = new List<IfcObjectDefinition>() { IfcSpatialStructureElement },
                };
            }


        }

        protected BbSite(BbProject project, IfcSite site, IfcRelAggregates ifcRelAggregates)
        {

            BbProject = project;
            IfcSpatialStructureElement = site;
            IfcRelAggregates = ifcRelAggregates;
            Guid = IfcGloballyUniqueId.ConvertToGuid(site.GlobalId);
        }


        public static ICollection<BbSite> Retrieve(BbProject project)
        {
            var refed = EarlyBindingInstanceModel.GetReferencedEntities(project.IfcObject.EIN);
            if (refed.Count <= 0) throw new InvalidDataException();

            var list = 
                (from agg in
                     (
                         from p21Instance in refed
                         where p21Instance.Value.GetType() == typeof(IfcRelAggregates)
                         select p21Instance.Value).OfType<IfcRelAggregates>()
                 from instance in agg.RelatedObjects
                 where instance.GetType() == typeof(IfcSite)
                 let site = instance as IfcSite
                 where site != null
                 select new BbSite(project, site, agg))
                .ToList();

            BbInstanceDB.AddToImport(list);

            return list;
        }

        public static BbSite Create(
            string name,
            BbProject project
        )
        {
            var s = new BbSite(name, project);
            BbInstanceDB.AddToExport(s);
            return s;
        }
    }

}
