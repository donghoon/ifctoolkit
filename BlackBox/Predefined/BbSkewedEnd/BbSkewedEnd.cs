using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;


namespace BlackBox.Predefined
{
    public class BbSkewedEnd : BbFeature
    {
        private IfcOpeningElement _ifcOpeningElement;
        private IfcRelVoidsElement _ifcRelVoidsElement;

        [EarlyBindingInstance]
        public override IfcObject IfcObject
        {
            get { return _ifcOpeningElement; }
            protected set
            {
                var a = value as IfcOpeningElement;
                if (a != null) _ifcOpeningElement = a;
            }
        }


        [EarlyBindingInstance]
        public IfcRelVoidsElement IfcRelVoidsElement
        {
            get { return _ifcRelVoidsElement; }
        }

        BbSkewedEnd(
            BbElement hostElement,
            BbPosition3D pos)
        {
            var mainPart = hostElement as BbPiece;
            if (mainPart == null)
                return;

            var width = mainPart.Length > mainPart.Profile.Width ? mainPart.Length : mainPart.Profile.Width;
            width = width * 100;
            var depth = mainPart.Length > mainPart.Profile.Depth ? mainPart.Length : mainPart.Profile.Depth;
            depth = depth* 100;
            var profile = BbNamedRectangleProfile.Create(width, depth);

            ObjectBbLocalPlacement = BbLocalPlacement3D.Create(
                hostElement.ObjectBbLocalPlacement, pos);




            //Direction3D exDir = Direction3D.Create(new[] {pos.Axis.X, pos.Axis.Y, pos.Axis.Z});

            BbExtrudedGeometry bbExtrudedGeometry = BbExtrudedGeometry.Create(
                profile,
                BbHeaderSetting.Setting3D.DefaultBbPosition3D,
                BbHeaderSetting.Setting3D.ZAxis,
                mainPart.Length);


            //IfcHalfSpaceSolid ifcHalfSpaceSolid = new IfcHalfSpaceSolid
            //    {
            //        BaseSurface = new IfcPlane
            //            {
            //                Position = pos.IfcAxis2Placement3D,
            //            },
            //            AgreementFlag = true,

            //    };

            //IfcShapeRepresentation ifcShapeRepresentation = new IfcShapeRepresentation
            //{
            //    ContextOfItems = HeaderSetting.Setting3D.GeometricRepresentationContext,
            //    RepresentationIdentifier = "Body",
            //    RepresentationType = "SweptSolid",
            //    //RepresentationIdentifier = "Body",
            //    //RepresentationType = "SolidModel",
            //    Items = new List<IfcRepresentationItem>(),
            //};
            //ifcShapeRepresentation.Items.Add(ifcHalfSpaceSolid);
			
            //IfcProductDefinitionShape ifcProductDefinitionShape = new IfcProductDefinitionShape
            //{
            //    // Name=
            //    // Description = 
            //    Representations = new List<IfcRepresentation>(),
            //};
            //ifcProductDefinitionShape.Representations.Add(ifcShapeRepresentation);

            _ifcOpeningElement = new IfcOpeningElement
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = hostElement.IfcObject.OwnerHistory,
                    // Name = 
                    // Description =
                    ObjectType = "Opening",
                    ObjectPlacement = ObjectBbLocalPlacement.IfcLocalPlacement,
                    Representation = bbExtrudedGeometry.IfcProductDefinitionShape,
                    //Representation = ifcProductDefinitionShape,
                };

            _ifcRelVoidsElement = new IfcRelVoidsElement
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = hostElement.IfcObject.OwnerHistory,
                    Name = "Skewed End",
                    RelatingBuildingElement = hostElement.IfcObject as IfcElement,
                    RelatedOpeningElement = _ifcOpeningElement,
                };
        }

        private BbSkewedEnd()
        {
        }

        public static BbSkewedEnd Create(BbElement hostElement,
                                       BbPosition3D position3D)
        {
            var cutSkewedEnd = new BbSkewedEnd(hostElement, position3D);
            BbInstanceDB.AddToExport(cutSkewedEnd);
            return cutSkewedEnd;
        }

        public static BbSkewedEnd Create(BbElement hostElement,
                               BbPosition3D position3D,
                               BbPropertySet bbPropertySet, double skewedAngleX, double skewedAngleY)
        {
            var cutSkewedEnd = new BbSkewedEnd(hostElement, position3D);
            cutSkewedEnd.AddSkewedEndProperty(bbPropertySet, skewedAngleX, skewedAngleY);
            BbInstanceDB.AddToExport(cutSkewedEnd);
            return cutSkewedEnd;
        }

        public void AddSkewedEndProperty(BbPropertySet bbPropertySet, double skewedAngleX, double skewedAngleY)
        {
            bbPropertySet.AddProperty(BbSingleProperty.Create("SkewedAngleX", skewedAngleX, typeof(IfcPositivePlaneAngleMeasure)));
            bbPropertySet.AddProperty(BbSingleProperty.Create("SkewedAngleY", skewedAngleY, typeof(IfcPositivePlaneAngleMeasure)));
        }

        public static ICollection<BbSkewedEnd> Retrieve(BbElement element) 
        {       
            var ret = new List<BbSkewedEnd>();
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
                //    if (theItem.Name == "Skewed End")
                //    {
                //        var semSkewedEnd = new BbSkewedEnd { ifcOpeningElement = OpeningElement, ifcRelVoidsElement = theItem };
                //        BbInstanceDB.AddToExport(semSkewedEnd);
                //        ret.Add(semSkewedEnd);

                //        // Retrieve localPlacement of BbSkewedEnd
                //        var placement = semSkewedEnd.ifcOpeningElement.ObjectPlacement as IfcLocalPlacement;
                //        var objectLocalPlacement = new BbLocalPlacement3D { IfcLocalPlacement = placement };
                //        semSkewedEnd.ObjectBbLocalPlacement = objectLocalPlacement;

                //        //Retrieve related Sems
                //        var semPosition3D = BbFeature.RetrievePosition(semSkewedEnd);
                //        var semExtrudedGeometry = BbExtrudedGeometry.RetrieveFromFeature(semSkewedEnd);
                //        var semRectangleprofile = BbNamedRectangleProfile.Retrieve(semExtrudedGeometry);
                //    }
                //}
            }                     
            return ret;
        }
    }
}