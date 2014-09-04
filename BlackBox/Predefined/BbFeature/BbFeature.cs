using System;
using IFC2X3;
using BlackBox.Service;
using System.Collections.Generic;

namespace BlackBox.Predefined
{

	/// <summary>
	/// Feature.
	/// </summary>
	public class BbFeature : BbProduct
	{

        //private IfcOpeningElement _ifcOpeningElement;


        //public static BbPosition3D RetrievePosition(BbFeature feature)
        //{
        //    var ret = new BbPosition3D();
        //    var localPlacement = feature._ifcOpeningElement.ObjectPlacement as IfcLocalPlacement;
        //    var position = localPlacement.RelativePlacement.AIfcAxis2Placement3D as IfcAxis2Placement3D;
        //    var semPosition = new BbPosition3D { ifcAxis2Placement3D = position };
        //    BbInstanceDB.AddToExport(semPosition);
        //    ret = semPosition;
        //    return ret;
        //}

	}
}

