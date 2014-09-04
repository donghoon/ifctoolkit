using BlackBox.Service;
using System.Collections.Generic;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    public class BbSlottedHole : BbOpening
    {
        protected BbSlottedHole(
            BbElement hostElement,
            BbCoordinate2D position,
            double centerToCenter,
            double radius,
            BbDirection2D refDirection,
            SemHoleLocation location,
            bool through
            )
            : base(
            hostElement, position, BbSlottedHoleProfile.Create(centerToCenter, radius, refDirection),
            location, through, "Slot Hole")
        {}

        private BbSlottedHole()
        {
        }

        public static BbSlottedHole Create(
            BbElement hostElement,
            BbCoordinate2D position,
            double centerToCenter,
            double radius,
            BbDirection2D refDirection,
            SemHoleLocation location,
            bool through
            )
        {
            var sl = new BbSlottedHole(hostElement, position, centerToCenter, radius, refDirection, location, through);
            BbInstanceDB.AddToExport(sl);
            return sl;
        }


        public static BbSlottedHole Create(
            BbElement hostElement,
            BbCoordinate2D position,
            double centerToCenter,
            double radius,
            BbDirection2D refDirection,
            SemHoleLocation location,
            bool through,
            BbPropertySet bbPropertySet,
            string featureSubType
            )
        {
            var sl = new BbSlottedHole(hostElement, position, centerToCenter, radius, refDirection, location, through);
            sl.AddSlottedHoleProperty(bbPropertySet, featureSubType, centerToCenter, centerToCenter + (radius * 2), radius);
            BbInstanceDB.AddToExport(sl);
            return sl;
        }

        public void AddSlottedHoleProperty(BbPropertySet bbPropertySet, string featureSubType,
                                            double slotHoleCenterToCenter,
                                            double slotHoleLength,
                                            double slotHoleWidth)
        {
            bbPropertySet.AddProperty(BbPropertyEnumerated.Create("FeatureSubtype", featureSubType, true));
            bbPropertySet.AddProperty(BbSingleProperty.Create("SlotHoleCenterToCenter", slotHoleCenterToCenter, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("SlotHoleLength", slotHoleLength, typeof(IfcPositiveLengthMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("SlotHoleWidth", slotHoleWidth, typeof(IfcPositiveLengthMeasure)));
        }

        public static ICollection<BbSlottedHole> Retrieve(BbElement element)
        {
            var ret = new List<BbSlottedHole>();
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelVoidsElement")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelVoidsElement").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelVoidsElement;
                if (theItem == null) continue;
                if (theItem.RelatingBuildingElement.EIN == element.IfcObject.EIN)
                {
                    var OpeningElement = theItem.RelatedOpeningElement as IfcOpeningElement;
                    // need modification
                    //if (theItem.Name == "Slot Hole")
                    //{
                    //    var semSlottedHole = new BbSlottedHole { ifcOpeningElement = OpeningElement, ifcRelVoidsElement = theItem };
                    //    //BbInstanceDB.Add(semSlottedHole);
                    //    ret.Add(semSlottedHole);

                    //    // Retrieve localPlacement of BbSlottedHole
                    //    var placement = semSlottedHole.ifcOpeningElement.ObjectPlacement as IfcLocalPlacement;
                    //    var objectLocalPlacement = new BbLocalPlacement3D { IfcLocalPlacement = placement };
                    //    semSlottedHole.ObjectBbLocalPlacement = objectLocalPlacement;

                    //    // Retrieve related Sems
                    //    var semPosition3D = BbFeature.RetrievePosition(semSlottedHole);
                    //    var semExtrudedGeometry = BbExtrudedGeometry.RetrieveFromFeature(semSlottedHole);
                    //    var semHoleProfile = BbSlottedHoleProfile.Retrieve(semExtrudedGeometry);

                    //}
                }
            }
            return ret;
        }

    }
}