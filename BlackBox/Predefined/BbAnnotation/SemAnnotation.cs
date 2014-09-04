using System.Collections.Generic;
using IFC2X3;
using Sem.Service;
using EbInstanceModel;

namespace Sem.Predefined
{
    public class SemAnnotation : SemProduct
    {
        [EarlyBindingInstance]
        public IfcAnnotation IfcAnnotation{ get;  set; }

        [EarlyBindingInstance]
        public IfcRelAssignsToProduct IfcRelAssignsToProduct{ get;  set; }

        //public List<Element> Elements{get;set;}

        public SemElement Element{ get; set; }

        //SemLocalPlacement3D _objectSemLocalPlacement;
		
        //public override SemLocalPlacement3D ObjectSemLocalPlacement {
        //    get { return _objectSemLocalPlacement; }
        //    protected set { _objectSemLocalPlacement = value; }
        //}

        SemAnnotation (string name, string type, SemElement element, 
                    SemCoordinate3D position, SemDirection3D zAxis, SemDirection3D xAxis)
        {
            Element = element;

            SemPosition3D pos = SemPosition3D.Create (position, zAxis, xAxis);
			
            ObjectSemLocalPlacement = SemLocalPlacement3D.Create (
                Element.ObjectSemLocalPlacement, pos);

            var tg = SemTextGeometry.Create(name, SemPosition2D.DefaultPosition);


            IfcAnnotation = new IfcAnnotation{
                                                 GlobalId= IfcGloballyUniqueId.NewGuid(),
                                                 OwnerHistory=SemHeaderSetting.Setting3D.IfcOwnerHistory,
                                                 Name = name,
                                                 ObjectPlacement = ObjectSemLocalPlacement.IfcLocalPlacement,
                                                 Representation = tg.IfcProductDefinitionShape,
                                                 ObjectType = type,

                                             };


            IfcRelAssignsToProduct = new IfcRelAssignsToProduct{
                                                                   GlobalId= IfcGloballyUniqueId.NewGuid(),
                                                                   OwnerHistory=SemHeaderSetting.Setting3D.IfcOwnerHistory,
                                                                   RelatedObjects = new List<IfcObjectDefinition>(),
                                                                   RelatingProduct = IfcAnnotation,
                                                               };


            IfcRelAssignsToProduct.RelatedObjects.Add(element.IfcObject);

        }

        private SemAnnotation()
        {
        }

        public static SemAnnotation Create (string name, string type, SemElement element, 
                                         SemCoordinate3D position, SemDirection3D zAxis, SemDirection3D xAxis)
        {
            var ann = new SemAnnotation (name, type,  element, 
                                      position,  zAxis,  xAxis);

            SemInstanceDB.AddToExport (ann);
            return ann;
        }

        public static SemAnnotation Retrieve(SemMainPiece mainPiece)
        {
            var ret = new SemAnnotation();
            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelAssignsToProduct").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelAssignsToProduct;
                if (theItem == null) continue;
                var relatedObjects = theItem.RelatedObjects;
                foreach (var relatedObject in relatedObjects)
                {
                    if (relatedObject.EIN == mainPiece.IfcObject.EIN)
                    {
                        //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcAnnotation")) return null;
                        var annCollection = EarlyBindingInstanceModel.GetDataByType("IfcAnnotation").Values;
                        foreach (var annItem in annCollection)
                        {
                            if (annItem.EIN == theItem.RelatingProduct.EIN)
                            {
                                var annotation = annItem as IfcAnnotation;
                                if (annotation == null) continue;
                                var semAnnotation = new SemAnnotation { IfcAnnotation = annotation, IfcRelAssignsToProduct= theItem };
                                SemInstanceDB.AddToExport(semAnnotation);
                                ret = semAnnotation;
                                semAnnotation.Element = mainPiece;
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }
}