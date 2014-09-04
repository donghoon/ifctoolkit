using System.Collections.Generic;
using BlackBox.Service;
using IFC2X3;
using EbInstanceModel;

namespace BlackBox.Predefined
{
    /// <summary>
    /// Sem definition for material
    /// </summary>
    public partial class BbMaterial : BbBase
    {
        [EarlyBindingInstance]
        public IfcMaterial IfcMaterial { get; private set; }


        [EarlyBindingInstance]
        public IfcRelAssociatesMaterial IfcRelAssociatesMaterial { get; private set; }


        [EarlyBindingInstance]
        public IfcMaterialClassificationRelationship IfcMaterialClassificationRelationship { get; private set; }

        [EarlyBindingInstance]
        public IfcClassification IfcClassification { get; private set; }

        [EarlyBindingInstance]
        public IfcClassificationReference IfcClassificationReference { get; private set; }

        private List<BbElement> elements;

        public string Name
        {
            get { return IfcMaterial.Name; }
            set { IfcMaterial.Name = value; }
        }

        public string MaterialID { get; private set; }
        public string MaterialCert { get; private set; }
        public string MaterialGrade { get; private set; }
        public string MaterialType { get; private set; }
        public BbPropertySet BbPropertySet { get; private set; }

        /// <summary>
        /// do not use obsolete
        /// </summary>
        /// <param name="location"></param>
        /// <param name="itemReference"></param>
        /// <param name="name"></param>
        BbMaterial(string location, string itemReference, string name)
        {

            IfcMaterial = new IfcMaterial
                            {
                                Name = name
                            };

            IfcMaterialClassificationRelationship
                = new IfcMaterialClassificationRelationship
                      {
                          MaterialClassifications = new List<IfcClassificationNotationSelect>(),
                          ClassifiedMaterial = IfcMaterial,
                      };

            IfcClassificationReference
                = new IfcClassificationReference
                      {
                          Location = location,
                          ItemReference = itemReference,
                          Name = name,
                      };

            var ns
                = new IfcClassificationNotationSelect
                         {
                             Value = IfcClassificationReference,
                         };

            IfcMaterialClassificationRelationship.MaterialClassifications.Add(ns);
            //var ifcMaterialLayer = new IfcMaterialLayer
            //    {
            //        Material = IfcMaterial,
            //        LayerThickness = new IfcPositiveLengthMeasure { Value = 0.0 },

            //    };

            //var ifcMaterialLayerSet = new IfcMaterialLayerSet
            //    {
            //        MaterialLayers = new List<IfcMaterialLayer>(),

            //    };
            //ifcMaterialLayerSet.MaterialLayers.Add(ifcMaterialLayer);
            //var ifcMaterialLayerSetUsage = new IfcMaterialLayerSetUsage
            //    {
            //        ForLayerSet = ifcMaterialLayerSet,
            //        LayerSetDirection = IfcLayerSetDirectionEnum.
            //    };


        }

        private BbMaterial() 
        {
        }


        BbMaterial(string name)
        {

            IfcMaterial = new IfcMaterial
                            {
                                Name = name
                            };
        }

        public static BbMaterial Create(string location, string itemReference, string name)
        {
            var material = new BbMaterial(location, itemReference, name);

            BbInstanceDB.AddToExport(material);

            return material;
        }

        public static BbMaterial Create(string name,
            BbPropertySet bbPropertySet,
                                        string materialID,
                                        string materialCert,
                                        string materialGrade,
                                        string materialType)
        {
            var material = new BbMaterial(name);
            material.AddMaterialProperty(bbPropertySet, materialID, materialCert, materialGrade, materialType);

            BbInstanceDB.AddToExport(material);

            return material;
        }

        public void AddMaterialProperty(
            BbPropertySet bbPropertySet,
            string materialID,
                                        string materialCert,
                                        string materialGrade,
                                        string materialType)
        {
            BbPropertySet = bbPropertySet;
            MaterialID = materialID;
            MaterialCert = materialCert;
            MaterialGrade = materialGrade;
            MaterialType = materialType;
            
            if (!string.IsNullOrWhiteSpace(materialID))
                BbPropertySet.AddProperty(BbSingleProperty.Create("Material ID", materialID, true));
            if (!string.IsNullOrWhiteSpace(materialCert))
                BbPropertySet.AddProperty(BbSingleProperty.Create("Material Certification", materialCert, true));
            if (!string.IsNullOrWhiteSpace(materialGrade))
                BbPropertySet.AddProperty(BbSingleProperty.Create("Material Grade", materialGrade, true));
            if (!string.IsNullOrWhiteSpace(materialType))
                BbPropertySet.AddProperty(BbSingleProperty.Create("Material Type", materialType, true));

            
        }


        public void AssociateTo(BbElement element)
        {

            if (IfcRelAssociatesMaterial == null)
            {
                IfcRelAssociatesMaterial = new IfcRelAssociatesMaterial
                {
                    GlobalId = IfcGloballyUniqueId.NewGuid(),
                    OwnerHistory = BbHeaderSetting.Setting3D.IfcOwnerHistory,
                    RelatingMaterial = new IfcMaterialSelect(),
                    RelatedObjects = new List<IfcRoot>(),
                };
                IfcRelAssociatesMaterial.RelatingMaterial.Value = IfcMaterial;
            }

            if (elements == null)
            {
                elements = new List<BbElement>();
            }

            elements.Add(element);
            IfcRelAssociatesMaterial.RelatedObjects.Add(element.IfcObject);

            AssignTo(element);
        }


         void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

        // todo material representation

        public override bool Validate(bool doValidate)
        {
            if (IfcMaterial == null) return false;

            // todo validation of IfcMaterial itself, should do it in itself or here?

            // todo validate EIN here? for IfcMaterial.EIN

            if (string.IsNullOrWhiteSpace(Name)) return false;

            return true;
        }

        public static BbMaterial Retrieve(BbElement element)
        {
            var ret = new BbMaterial();
            //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcRelAssociatesMaterial")) return null;

            var collection = EarlyBindingInstanceModel.GetDataByType("IfcRelAssociatesMaterial").Values;
            //if (collection.Count != 1) throw new NotImplementedException();
            foreach (var item in collection)
            {
                var theItem = item as IfcRelAssociatesMaterial;
                if (theItem == null) continue;
                //if (theItem.RelatingMaterial.AIfcMaterial.EIN == element.IfcElement.EIN)
                foreach (var a in theItem.RelatedObjects)
                {
                    if (a.EIN == element.IfcObject.EIN)
                    {

                        //if (!EarlyBindingInstanceModel.TheModel.DataByType.ContainsKey("IfcMaterial")) return null;

                        var collection2 = EarlyBindingInstanceModel.GetDataByType("IfcMaterial").Values;
                        foreach (var item2 in collection2)
                        {
                            if (item2.EIN == theItem.RelatingMaterial.AIfcMaterial.EIN)
                            {
                                var material = item as IfcMaterial;
                                if (material == null) continue;
                                var pieceMaterial = new BbMaterial { IfcMaterial = material };
                                BbInstanceDB.AddToExport(pieceMaterial);
                                ret = pieceMaterial;
                            }
                        }

                    }
                    else { ret = null; }
                }
            }

            return ret;
        }
    }
}