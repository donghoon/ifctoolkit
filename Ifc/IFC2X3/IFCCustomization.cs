//using System;

namespace IFC2X3
{
    public partial class Testing
    {
        public static void Test2X3()
        {
            var ifcOrganization = new IfcOrganization();
            ifcOrganization.Name = "Georgia Tech";

        }
    }

    #region not used functions

    //public static class IFCWriter
    //{
    //    #region tools

    //    public static void WriteStartEidNs(XmlWriter xmlWriter, string tag, uint eid)
    //    {
    //        xmlWriter.WriteStartElement(CPDNaming.IFCNameSpaceIDString, tag, CPDNaming.IFCNameSpaceString);
    //        xmlWriter.WriteAttributeString(
    //            CPDNaming.EntityInstanceNameString,
    //            string.Format(
    //            CPDNaming.EntityInstanceNamePrefix + "{0}", eid));
    //    }

    //    public static void WriteStartNs(XmlWriter xmlWriter, string tag)
    //    {
    //        xmlWriter.WriteStartElement(CPDNaming.IFCNameSpaceIDString, tag, CPDNaming.IFCNameSpaceString);
    //    }

    //    public static void WriteStart(XmlWriter xmlWriter, string tag)
    //    {
    //        xmlWriter.WriteStartElement(tag);
    //    }

    //    public static void WriteEnd(XmlWriter xmlWriter)
    //    {
    //        xmlWriter.WriteEndElement();
    //    }

    //    public static void WriteValue(XmlWriter xmlWriter, string tag, object value)
    //    {
    //        xmlWriter.WriteStartElement(CPDNaming.IFCNameSpaceIDString, tag, CPDNaming.IFCNameSpaceString);
    //        xmlWriter.WriteValue(value);
    //        xmlWriter.WriteEndElement();
    //    }

    //    public static void WriteCollectionString(XmlWriter xmlWriter, string tag, IEnumerable<string> values)
    //    {
    //        xmlWriter.WriteStartElement(CPDNaming.IFCNameSpaceIDString, tag, CPDNaming.IFCNameSpaceString);
    //        foreach (var value in values)
    //        {
    //            xmlWriter.WriteStartElement(CPDNaming.PropertyCollectionString);
    //            xmlWriter.WriteValue(value);
    //            xmlWriter.WriteEndElement();
    //        }
    //        xmlWriter.WriteEndElement();
    //    }
    //    #endregion
    //}

    //public class LOGICAL : BASETYPE
    //{
    //    public short Value { get; set; }

    //    public LOGICAL()
    //        :this(0)
    //    {
    //    }

    //    public LOGICAL(bool value)
    //    {
    //        if (value)
    //            Value = 1;
    //        else
    //            Value = -1;
    //    }

    //    public LOGICAL(short value)
    //    {
    //        switch (value)
    //        {
    //            case 1:
    //                Value = 1;
    //                break;
    //            case -1:
    //                Value = -1;
    //                break;
    //            default:
    //                Value = 0;
    //                break;
    //        }
    //    }

    //    public static implicit operator LOGICAL(bool value)
    //    {
    //        return new LOGICAL(value);
    //    }

    //    public static implicit operator bool(LOGICAL cpdValueBool)
    //    {
    //        return cpdValueBool.Value == 1;
    //    }

    //    public static bool operator ==(LOGICAL one, LOGICAL two)
    //    {
    //        return one != null && (two != null && (one.Value == two.Value));
    //    }

    //    public static bool operator !=(LOGICAL one, LOGICAL two)
    //    {
    //        if (one == null || two == null)
    //            return false;
    //        if (one.Value == two.Value)
    //            return false;
    //        return true;
    //    }

    //    public override string ToString()
    //    {
    //        string ret;
    //        switch (Value)
    //        {
    //            case 1:
    //                ret = "true";
    //                break;
    //            case -1:
    //                ret = "false";
    //                break;
    //            default:
    //                ret = "undecided";
    //                break;
    //        }
    //        return ret;
    //    }

    //    public override int CompareTo(object obj)
    //    {
    //        if (obj == null) return 1;

    //        var rea = obj as LOGICAL;
    //        return rea == null ? 1 : Value.CompareTo(rea.Value);
    //    }
    //}

    //    public partial interface IFCVALUE : IXmlSerializable
    //    {
    //    }

    //    public partial class IFCAMOUNTOFSUBSTANCEMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //    public partial class IFCAREAMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCCONTEXTDEPENDENTMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCCOUNTMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCDESCRIPTIVEMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCELECTRICCURRENTMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCLENGTHMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCLUMINOUSINTENSITYMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCMASSMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCNORMALISEDRATIOMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCNUMERICMEASURE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCPARAMETERVALUE
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }

    //    }
    //    public partial class IFCPLANEANGLEMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCPOSITIVELENGTHMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCPOSITIVEPLANEANGLEMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCPOSITIVERATIOMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCRATIOMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCSOLIDANGLEMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCTHERMODYNAMICTEMPERATUREMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCTIMEMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCVOLUMEMEASURE
    //{
    //    public XmlSchema GetSchema()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReadXml(XmlReader reader)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WriteXml(XmlWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //    public partial class IFCCOMPLEXNUMBER

    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class IFCNAMEDUNIT
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class IFCINTEGER
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCREAL
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCBOOLEAN
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCIDENTIFIER
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCTEXT
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCLABEL
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public partial class
    //IFCLOGICAL
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //IfcVolumetricFlowRateMeasure,
    //IfcTimeStamp,
    //IfcThermalTransmittanceMeasure,
    //IfcThermalResistanceMeasure,
    //IfcThermalAdmittanceMeasure,
    //IfcPressureMeasure,
    //IfcPowerMeasure,
    //IfcMassFlowRateMeasure,
    //IfcMassDensityMeasure,
    //IfcLinearVelocityMeasure,
    //IfcKinematicViscosityMeasure,
    //IfcIntegerCountRateMeasure,
    //IfcHeatFluxDensityMeasure,
    //IfcFrequencyMeasure,
    //IfcEnergyMeasure,
    //IfcElectricVoltageMeasure,
    //IfcDynamicViscosityMeasure,
    //IfcCompoundPlaneAngleMeasure,
    //IfcAngularVelocityMeasure,
    //IfcThermalConductivityMeasure,
    //IfcMolecularWeightMeasure,
    //IfcVaporPermeabilityMeasure,
    //IfcMoistureDiffusivityMeasure,
    //IfcIsothermalMoistureCapacityMeasure,
    //IfcSpecificHeatCapacityMeasure,
    //IfcMonetaryMeasure,
    //IfcMagneticFluxDensityMeasure,
    //IfcMagneticFluxMeasure,
    //IfcLuminousFluxMeasure,
    //IfcForceMeasure,
    //IfcInductanceMeasure,
    //IfcIlluminanceMeasure,
    //IfcElectricResistanceMeasure,
    //IfcElectricConductanceMeasure,
    //IfcElectricChargeMeasure,
    //IfcDoseEquivalentMeasure,
    //IfcElectricCapacitanceMeasure,
    //IfcAbsorbedDoseMeasure,
    //IfcRadioActivityMeasure,
    //IfcRotationalFrequencyMeasure,
    //IfcTorqueMeasure,
    //IfcAccelerationMeasure,
    //IfcLinearForceMeasure,
    //IfcLinearStiffnessMeasure,
    //IfcModulusOfSubgradeReactionMeasure,
    //IfcModulusOfElasticityMeasure,
    //IfcMomentOfInertiaMeasure,
    //IfcPlanarForceMeasure,
    //IfcRotationalStiffnessMeasure,
    //IfcShearModulusMeasure,
    //IfcLinearMomentMeasure,
    //IfcLuminousIntensityDistributionMeasure,
    //IfcCurvatureMeasure,
    //IfcMassPerLengthMeasure,
    //IfcModulusOfLinearSubgradeReactionMeasure,
    //IfcModulusOfRotationalSubgradeReactionMeasure,
    //IfcRotationalMassMeasure,
    //IfcSectionalAreaIntegralMeasure,
    //IfcSectionModulusMeasure,
    //IfcTemperatureGradientMeasure,
    //IfcThermalExpansionCoefficientMeasure,
    //IfcWarpingConstantMeasure,
    //IfcWarpingMomentMeasure,
    //IfcSoundPowerMeasure,
    //IfcSoundPressureMeasure,
    //IfcHeatingValueMeasure,
    //IfcPHMeasure,
    //IfcIonConcentrationMeasure

    //    public partial class IFCMEASUREWITHUNIT : IXmlSerializable
    //    {
    //        public XmlSchema GetSchema()
    //        {
    //            return null;
    //        }

    //        public void ReadXml(XmlReader reader)
    //        {
    //            throw new NotImplementedException();

    //        }

    //        public void WriteXml(XmlWriter writer)
    //        {
    //            var strType = VALUECOMPONENT.GetType().Name;

    //            writer.WriteStartElement(strType);

    //            writer.WriteEndElement();
    //            strType = UNITCOMPONENT.GetType().Name;
    //            writer.WriteStartElement(strType);

    //            writer.WriteEndElement();

    //        }
    //    }

    #endregion not used functions
}