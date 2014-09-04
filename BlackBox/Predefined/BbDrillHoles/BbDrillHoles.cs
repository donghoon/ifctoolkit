using BlackBox.Service;
using System.Collections.Generic;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    /// <summary>
	/// Drill holes.
	/// </summary>
    public class BbDrillHoles : BbOpening
    {


		protected BbDrillHoles (
			BbElement hostElement,
			BbCoordinate2D position,
			double radius,
			SemHoleLocation location,
			bool through
		)
            : base(hostElement, position, BbBbNamedCircleProfile.Create(radius), location, through, "Drill Hole")
		{

		}

        private BbDrillHoles()
        {
        }

        public static BbDrillHoles Create(BbElement hostElement,
                                BbCoordinate2D position,
                                double radius,
                                SemHoleLocation location,
                                bool through)
        {
            var hole = new BbDrillHoles(hostElement, position, radius, location, through);
            BbInstanceDB.AddToExport(hole);
            return hole;
        }

        //public static BbDrillHoles Create(BbElement hostElement,
        //                                BbCoordinate2D position,
        //                                double radius,
        //                                SemHoleLocation location,
        //                                bool through,
        //                                BbPropertySet semPropertySet,
        //                                string featureSubType,                                       
        //                                double partialHoleDepth)
        //{
        //    var hole = new BbDrillHoles(hostElement, position, radius, location, through);
        //    hole.AddDrillHoleProperty(semPropertySet, featureSubType, (radius * 2), through, partialHoleDepth);
        //    BbInstanceDB.AddToExport(hole);
        //    return hole;
        //}

        //public void AddDrillHoleProperty(BbPropertySet semPropertySet, string featureSubType,
        //                        double boltHoleDiameter,
        //                        bool partialHoleIndicator,
        //                        double partialHoleDepth)
        //{
        //    semPropertySet.AddProperty(BbPropertyEnumerated.Create("FeatureSubtype", featureSubType, true));
        //    semPropertySet.AddProperty(BbSingleProperty.Create("BoltHoleDiameter", boltHoleDiameter, typeof(IfcPositiveLengthMeasure)));
        //    semPropertySet.AddProperty(BbSingleProperty.Create("PartialHoleIndicator", partialHoleIndicator));
        //    semPropertySet.AddProperty(BbSingleProperty.Create("PartialHoleDepth", partialHoleDepth, typeof(IfcPositiveLengthMeasure)));

        //}


        public static ICollection<BbDrillHoles> Retrieve(BbElement element) 
        {
            var ret = new List<BbDrillHoles>();
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelVoidsElement")) return null;
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelVoidsElement").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelVoidsElement;
                if (theItem == null) continue;

                // need modification
                //if (theItem.RelatingBuildingElement.EIN == element.IfcObject.EIN)
                //{
                //    var OpeningElement = theItem.RelatedOpeningElement as IfcOpeningElement;
                //    if (theItem.Name == "Drill Hole")
                //    {
                //        var semDrillHole = new BbDrillHoles { ifcOpeningElement = OpeningElement, ifcRelVoidsElement = theItem };
                //        //BbInstanceDB.Add(semDrillHole);
                //        ret.Add(semDrillHole);

                //        // Retrieve localPlacement of BbDrillHoles
                //        var placement = semDrillHole.ifcOpeningElement.ObjectPlacement as IfcLocalPlacement;
                //        var objectLocalPlacement = new BbLocalPlacement3D { IfcLocalPlacement = placement };
                //        semDrillHole.ObjectBbLocalPlacement = objectLocalPlacement;

                //        // Retrieve related Sems
                //        var semPosition3D = BbFeature.RetrievePosition(semDrillHole);
                //        var semExtrudedGeometry = BbExtrudedGeometry.RetrieveFromFeature(semDrillHole);
                //        var semCircleProfile = BbBbNamedCircleProfile.Retrieve(semExtrudedGeometry);
                //        //BbCoordinate2D
                //    }
                //}
            }
            return ret;
        }

    }
}