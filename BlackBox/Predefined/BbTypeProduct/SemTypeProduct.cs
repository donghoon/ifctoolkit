using System;
using System.Collections.Generic;
using IFC2X3;
using Sem.Service;

namespace Sem.Predefined
{
	/// <summary>
	/// Piece mark.
	/// </summary>
    public class SemTypeProduct : SemBase
    {
		[EarlyBindingInstance]
		public IfcRelDefinesByType IfcRelDefinesByType { get; set; }

        [EarlyBindingInstance]
        public IfcTypeProduct IfcTypeProduct { get; set; }


        public List<SemElement> DefinedElements { get; set; } 

	    protected SemTypeProduct (string name, string pieceMark, Type type)
            :this() // Q2
		{
		    string typeName = type.FullName + "Type";

		    var oh = Activator.CreateInstance(type.Assembly.FullName, typeName);
            IfcTypeProduct = oh.Unwrap() as IfcTypeProduct;

            if (IfcTypeProduct == null) return;

            IfcTypeProduct.GlobalId = IfcGloballyUniqueId.NewGuid();
            IfcTypeProduct.OwnerHistory = SemHeaderSetting.Setting3D.IfcOwnerHistory;
	        IfcTypeProduct.Name = name;
            IfcTypeProduct.Tag = pieceMark;
		}

        protected SemTypeProduct() 
        {
            DefinedElements = new List<SemElement>();
        }

        public static SemTypeProduct Create(string name, string pieceMark, Type type)
		{
			var piece = new SemTypeProduct(name, pieceMark, type);
            if (piece.IfcRelDefinesByType == null) return null;
			SemInstanceDB.AddToExport(piece);
			return piece;
		}

	    public void Defines(SemElement element)
	    {
	        if (IfcRelDefinesByType == null)
            {
                IfcRelDefinesByType = new IfcRelDefinesByType
                    {
                        GlobalId = IfcGloballyUniqueId.NewGuid(),
                        OwnerHistory = SemHeaderSetting.Setting3D.IfcOwnerHistory,
                        RelatingType = IfcTypeProduct,
                    };
                IfcRelDefinesByType.RelatedObjects  = new List<IfcObject>();
	        }

	        if (DefinedElements == null)
	        {
                DefinedElements = new List<SemElement>();
	        }
            DefinedElements.Add(element);
	        IfcRelDefinesByType.RelatedObjects.Add(element.IfcObject);
	    }



    }
}