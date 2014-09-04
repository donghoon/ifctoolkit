using IFC2X3;
using Sem.Service;
using System.Collections.Generic;
using EbInstanceModel;

namespace Sem.Predefined
{
    public class SemConnectedElements : SemBase
    {
        [EarlyBindingInstance]
        public IfcRelConnectsElements IfcRelConnectsElements { get; set; }

        SemConnectedElements(SemElement main, SemElement sub)
        {
            IfcRelConnectsElements = new IfcRelConnectsElements
                                         {
                                             GlobalId = IfcGloballyUniqueId.NewGuid(),
                                             OwnerHistory = SemHeaderSetting.Setting3D.IfcOwnerHistory,
                                             RelatingElement = main.IfcObject as IfcElement,
                                             RelatedElement = sub.IfcObject as IfcElement
                                         };
        }

        private SemConnectedElements()
        { }

        public static SemConnectedElements Create(SemElement main, SemElement sub)
        {
            var ce = new SemConnectedElements(main, sub);
            SemInstanceDB.AddToExport(ce);
            return ce;
        }

        public static ICollection<SemConnectedElements> Retrieve(SemElement assembly)
        {
            var ret = new List<SemConnectedElements>();

            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelConnectsElements")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelConnectsElements").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelConnectsElements;
                if (theItem == null) continue;
                if (theItem.RelatingElement.EIN == assembly.IfcObject.EIN)
                {
                    var connected = theItem as IfcRelConnectsElements;
                    if (connected == null) continue;
                    var semConnected = new SemConnectedElements { IfcRelConnectsElements = connected };
                    SemInstanceDB.AddToExport(semConnected);
                    ret.Add(semConnected);
                }
            }
            return ret;
        }

    }
}