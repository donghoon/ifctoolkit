/*
 *
 *	< IFC - ISO 10303 (STEP) Part 21 instance file reader >
 *	Copyright (C) <2012>  <Donghoon Yang>
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 *
 *
 *	This file is generated with SchemaModel.SData.CSharpClassMaker
 *	included in this program.
 *
 */



using System;
using System.IO;
using System.Collections.Generic;
using EbInstanceModel;


namespace IFC2X3
{

	public partial class IfcAbsorbedDoseMeasure : REAL
	{
		public IfcAbsorbedDoseMeasure(){}

		{
			return new IfcAbsorbedDoseMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAbsorbedDoseMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAccelerationMeasure : REAL
	{
		public IfcAccelerationMeasure(){}

		{
			return new IfcAccelerationMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAccelerationMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAmountOfSubstanceMeasure : REAL
	{
		public IfcAmountOfSubstanceMeasure(){}

		{
			return new IfcAmountOfSubstanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAmountOfSubstanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAngularVelocityMeasure : REAL
	{
		public IfcAngularVelocityMeasure(){}

		{
			return new IfcAngularVelocityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAngularVelocityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAreaMeasure : REAL
	{
		public IfcAreaMeasure(){}

		{
			return new IfcAreaMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAreaMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcBoolean : BOOLEAN
	{
		public IfcBoolean(){}

		{
			return new IfcBoolean{ Value = value };
		}
		public static implicit operator bool(IfcBoolean obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcBoxAlignment : IfcLabel
	{
		public static implicit operator IfcBoxAlignment(string value)
		{
			return new IfcBoxAlignment{ Value = value };
		}
		public static implicit operator string(IfcBoxAlignment obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcComplexNumber : List<REAL>
	{
		public bool IsDerived;
	}

	public partial class IfcCompoundPlaneAngleMeasure : List<INTEGER>
	{
		public bool IsDerived;
	}

	public partial class IfcContextDependentMeasure : REAL
	{
		public IfcContextDependentMeasure(){}

		{
			return new IfcContextDependentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcContextDependentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcCountMeasure : NUMBER
	{
		public IfcCountMeasure(){}

		{
			return new IfcCountMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcCountMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcCurvatureMeasure : REAL
	{
		public IfcCurvatureMeasure(){}

		{
			return new IfcCurvatureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcCurvatureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDayInMonthNumber : INTEGER
	{
		public IfcDayInMonthNumber(){}

		{
			return new IfcDayInMonthNumber{ Value = value };
		}
		public static implicit operator int(IfcDayInMonthNumber obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDaylightSavingHour : INTEGER
	{
		public IfcDaylightSavingHour(){}

		{
			return new IfcDaylightSavingHour{ Value = value };
		}
		public static implicit operator int(IfcDaylightSavingHour obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDescriptiveMeasure : STRING
	{
		public IfcDescriptiveMeasure(){}

		{
			return new IfcDescriptiveMeasure{ Value = value };
		}
		public static implicit operator string(IfcDescriptiveMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDimensionCount : INTEGER
	{
		public IfcDimensionCount(){}

		{
			return new IfcDimensionCount{ Value = value };
		}
		public static implicit operator int(IfcDimensionCount obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDoseEquivalentMeasure : REAL
	{
		public IfcDoseEquivalentMeasure(){}

		{
			return new IfcDoseEquivalentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcDoseEquivalentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDynamicViscosityMeasure : REAL
	{
		public IfcDynamicViscosityMeasure(){}

		{
			return new IfcDynamicViscosityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcDynamicViscosityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricCapacitanceMeasure : REAL
	{
		public IfcElectricCapacitanceMeasure(){}

		{
			return new IfcElectricCapacitanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricCapacitanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricChargeMeasure : REAL
	{
		public IfcElectricChargeMeasure(){}

		{
			return new IfcElectricChargeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricChargeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricConductanceMeasure : REAL
	{
		public IfcElectricConductanceMeasure(){}

		{
			return new IfcElectricConductanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricConductanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricCurrentMeasure : REAL
	{
		public IfcElectricCurrentMeasure(){}

		{
			return new IfcElectricCurrentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricCurrentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricResistanceMeasure : REAL
	{
		public IfcElectricResistanceMeasure(){}

		{
			return new IfcElectricResistanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricResistanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricVoltageMeasure : REAL
	{
		public IfcElectricVoltageMeasure(){}

		{
			return new IfcElectricVoltageMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricVoltageMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcEnergyMeasure : REAL
	{
		public IfcEnergyMeasure(){}

		{
			return new IfcEnergyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcEnergyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontStyle : STRING
	{
		public IfcFontStyle(){}

		{
			return new IfcFontStyle{ Value = value };
		}
		public static implicit operator string(IfcFontStyle obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontVariant : STRING
	{
		public IfcFontVariant(){}

		{
			return new IfcFontVariant{ Value = value };
		}
		public static implicit operator string(IfcFontVariant obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontWeight : STRING
	{
		public IfcFontWeight(){}

		{
			return new IfcFontWeight{ Value = value };
		}
		public static implicit operator string(IfcFontWeight obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcForceMeasure : REAL
	{
		public IfcForceMeasure(){}

		{
			return new IfcForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFrequencyMeasure : REAL
	{
		public IfcFrequencyMeasure(){}

		{
			return new IfcFrequencyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcFrequencyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcGloballyUniqueId : STRING
	{
		public IfcGloballyUniqueId(){}

		{
			return new IfcGloballyUniqueId{ Value = value };
		}
		public static implicit operator string(IfcGloballyUniqueId obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcHeatFluxDensityMeasure : REAL
	{
		public IfcHeatFluxDensityMeasure(){}

		{
			return new IfcHeatFluxDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcHeatFluxDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcHeatingValueMeasure : REAL
	{
		public IfcHeatingValueMeasure(){}

		{
			return new IfcHeatingValueMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcHeatingValueMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcHourInDay : INTEGER
	{
		public IfcHourInDay(){}

		{
			return new IfcHourInDay{ Value = value };
		}
		public static implicit operator int(IfcHourInDay obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIdentifier : STRING
	{
		public IfcIdentifier(){}

		{
			return new IfcIdentifier{ Value = value };
		}
		public static implicit operator string(IfcIdentifier obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIlluminanceMeasure : REAL
	{
		public IfcIlluminanceMeasure(){}

		{
			return new IfcIlluminanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIlluminanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcInductanceMeasure : REAL
	{
		public IfcInductanceMeasure(){}

		{
			return new IfcInductanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcInductanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcInteger : INTEGER
	{
		public IfcInteger(){}

		{
			return new IfcInteger{ Value = value };
		}
		public static implicit operator int(IfcInteger obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIntegerCountRateMeasure : INTEGER
	{
		public IfcIntegerCountRateMeasure(){}

		{
			return new IfcIntegerCountRateMeasure{ Value = value };
		}
		public static implicit operator int(IfcIntegerCountRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIonConcentrationMeasure : REAL
	{
		public IfcIonConcentrationMeasure(){}

		{
			return new IfcIonConcentrationMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIonConcentrationMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIsothermalMoistureCapacityMeasure : REAL
	{
		public IfcIsothermalMoistureCapacityMeasure(){}

		{
			return new IfcIsothermalMoistureCapacityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIsothermalMoistureCapacityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcKinematicViscosityMeasure : REAL
	{
		public IfcKinematicViscosityMeasure(){}

		{
			return new IfcKinematicViscosityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcKinematicViscosityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLabel : STRING
	{
		public IfcLabel(){}

		{
			return new IfcLabel{ Value = value };
		}
		public static implicit operator string(IfcLabel obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLengthMeasure : REAL
	{
		public IfcLengthMeasure(){}

		{
			return new IfcLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearForceMeasure : REAL
	{
		public IfcLinearForceMeasure(){}

		{
			return new IfcLinearForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearMomentMeasure : REAL
	{
		public IfcLinearMomentMeasure(){}

		{
			return new IfcLinearMomentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearMomentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearStiffnessMeasure : REAL
	{
		public IfcLinearStiffnessMeasure(){}

		{
			return new IfcLinearStiffnessMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearStiffnessMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearVelocityMeasure : REAL
	{
		public IfcLinearVelocityMeasure(){}

		{
			return new IfcLinearVelocityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearVelocityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLogical : LOGICAL
	{
		public IfcLogical(){}

		{
			return new IfcLogical{ Value = value };
		}
		public static implicit operator int(IfcLogical obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousFluxMeasure : REAL
	{
		public IfcLuminousFluxMeasure(){}

		{
			return new IfcLuminousFluxMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousFluxMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousIntensityDistributionMeasure : REAL
	{
		public IfcLuminousIntensityDistributionMeasure(){}

		{
			return new IfcLuminousIntensityDistributionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousIntensityDistributionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousIntensityMeasure : REAL
	{
		public IfcLuminousIntensityMeasure(){}

		{
			return new IfcLuminousIntensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousIntensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMagneticFluxDensityMeasure : REAL
	{
		public IfcMagneticFluxDensityMeasure(){}

		{
			return new IfcMagneticFluxDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMagneticFluxDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMagneticFluxMeasure : REAL
	{
		public IfcMagneticFluxMeasure(){}

		{
			return new IfcMagneticFluxMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMagneticFluxMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassDensityMeasure : REAL
	{
		public IfcMassDensityMeasure(){}

		{
			return new IfcMassDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassFlowRateMeasure : REAL
	{
		public IfcMassFlowRateMeasure(){}

		{
			return new IfcMassFlowRateMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassFlowRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassMeasure : REAL
	{
		public IfcMassMeasure(){}

		{
			return new IfcMassMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassPerLengthMeasure : REAL
	{
		public IfcMassPerLengthMeasure(){}

		{
			return new IfcMassPerLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassPerLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMinuteInHour : INTEGER
	{
		public IfcMinuteInHour(){}

		{
			return new IfcMinuteInHour{ Value = value };
		}
		public static implicit operator int(IfcMinuteInHour obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfElasticityMeasure : REAL
	{
		public IfcModulusOfElasticityMeasure(){}

		{
			return new IfcModulusOfElasticityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfElasticityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfLinearSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfLinearSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfLinearSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfLinearSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfRotationalSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfRotationalSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfRotationalSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfRotationalSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMoistureDiffusivityMeasure : REAL
	{
		public IfcMoistureDiffusivityMeasure(){}

		{
			return new IfcMoistureDiffusivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMoistureDiffusivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMolecularWeightMeasure : REAL
	{
		public IfcMolecularWeightMeasure(){}

		{
			return new IfcMolecularWeightMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMolecularWeightMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMomentOfInertiaMeasure : REAL
	{
		public IfcMomentOfInertiaMeasure(){}

		{
			return new IfcMomentOfInertiaMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMomentOfInertiaMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMonetaryMeasure : REAL
	{
		public IfcMonetaryMeasure(){}

		{
			return new IfcMonetaryMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMonetaryMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMonthInYearNumber : INTEGER
	{
		public IfcMonthInYearNumber(){}

		{
			return new IfcMonthInYearNumber{ Value = value };
		}
		public static implicit operator int(IfcMonthInYearNumber obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcNormalisedRatioMeasure : IfcRatioMeasure
	{
		public static implicit operator IfcNormalisedRatioMeasure(double value)
		{
			return new IfcNormalisedRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcNormalisedRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcNumericMeasure : NUMBER
	{
		public IfcNumericMeasure(){}

		{
			return new IfcNumericMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcNumericMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPHMeasure : REAL
	{
		public IfcPHMeasure(){}

		{
			return new IfcPHMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPHMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcParameterValue : REAL
	{
		public IfcParameterValue(){}

		{
			return new IfcParameterValue{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcParameterValue obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPlanarForceMeasure : REAL
	{
		public IfcPlanarForceMeasure(){}

		{
			return new IfcPlanarForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPlanarForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPlaneAngleMeasure : REAL
	{
		public IfcPlaneAngleMeasure(){}

		{
			return new IfcPlaneAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPlaneAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositiveLengthMeasure : IfcLengthMeasure
	{
		public static implicit operator IfcPositiveLengthMeasure(double value)
		{
			return new IfcPositiveLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositiveLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositivePlaneAngleMeasure : IfcPlaneAngleMeasure
	{
		public static implicit operator IfcPositivePlaneAngleMeasure(double value)
		{
			return new IfcPositivePlaneAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositivePlaneAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositiveRatioMeasure : IfcRatioMeasure
	{
		public static implicit operator IfcPositiveRatioMeasure(double value)
		{
			return new IfcPositiveRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositiveRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPowerMeasure : REAL
	{
		public IfcPowerMeasure(){}

		{
			return new IfcPowerMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPowerMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPresentableText : STRING
	{
		public IfcPresentableText(){}

		{
			return new IfcPresentableText{ Value = value };
		}
		public static implicit operator string(IfcPresentableText obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPressureMeasure : REAL
	{
		public IfcPressureMeasure(){}

		{
			return new IfcPressureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPressureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRadioActivityMeasure : REAL
	{
		public IfcRadioActivityMeasure(){}

		{
			return new IfcRadioActivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRadioActivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRatioMeasure : REAL
	{
		public IfcRatioMeasure(){}

		{
			return new IfcRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcReal : REAL
	{
		public IfcReal(){}

		{
			return new IfcReal{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcReal obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalFrequencyMeasure : REAL
	{
		public IfcRotationalFrequencyMeasure(){}

		{
			return new IfcRotationalFrequencyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalFrequencyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalMassMeasure : REAL
	{
		public IfcRotationalMassMeasure(){}

		{
			return new IfcRotationalMassMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalMassMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalStiffnessMeasure : REAL
	{
		public IfcRotationalStiffnessMeasure(){}

		{
			return new IfcRotationalStiffnessMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalStiffnessMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSecondInMinute : REAL
	{
		public IfcSecondInMinute(){}

		{
			return new IfcSecondInMinute{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSecondInMinute obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSectionModulusMeasure : REAL
	{
		public IfcSectionModulusMeasure(){}

		{
			return new IfcSectionModulusMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSectionModulusMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSectionalAreaIntegralMeasure : REAL
	{
		public IfcSectionalAreaIntegralMeasure(){}

		{
			return new IfcSectionalAreaIntegralMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSectionalAreaIntegralMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcShearModulusMeasure : REAL
	{
		public IfcShearModulusMeasure(){}

		{
			return new IfcShearModulusMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcShearModulusMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSolidAngleMeasure : REAL
	{
		public IfcSolidAngleMeasure(){}

		{
			return new IfcSolidAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSolidAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPowerMeasure : REAL
	{
		public IfcSoundPowerMeasure(){}

		{
			return new IfcSoundPowerMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPowerMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPressureMeasure : REAL
	{
		public IfcSoundPressureMeasure(){}

		{
			return new IfcSoundPressureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPressureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecificHeatCapacityMeasure : REAL
	{
		public IfcSpecificHeatCapacityMeasure(){}

		{
			return new IfcSpecificHeatCapacityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecificHeatCapacityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecularExponent : REAL
	{
		public IfcSpecularExponent(){}

		{
			return new IfcSpecularExponent{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecularExponent obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecularRoughness : REAL
	{
		public IfcSpecularRoughness(){}

		{
			return new IfcSpecularRoughness{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecularRoughness obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTemperatureGradientMeasure : REAL
	{
		public IfcTemperatureGradientMeasure(){}

		{
			return new IfcTemperatureGradientMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTemperatureGradientMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcText : STRING
	{
		public IfcText(){}

		{
			return new IfcText{ Value = value };
		}
		public static implicit operator string(IfcText obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextAlignment : STRING
	{
		public IfcTextAlignment(){}

		{
			return new IfcTextAlignment{ Value = value };
		}
		public static implicit operator string(IfcTextAlignment obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextDecoration : STRING
	{
		public IfcTextDecoration(){}

		{
			return new IfcTextDecoration{ Value = value };
		}
		public static implicit operator string(IfcTextDecoration obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextFontName : STRING
	{
		public IfcTextFontName(){}

		{
			return new IfcTextFontName{ Value = value };
		}
		public static implicit operator string(IfcTextFontName obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextTransformation : STRING
	{
		public IfcTextTransformation(){}

		{
			return new IfcTextTransformation{ Value = value };
		}
		public static implicit operator string(IfcTextTransformation obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalAdmittanceMeasure : REAL
	{
		public IfcThermalAdmittanceMeasure(){}

		{
			return new IfcThermalAdmittanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalAdmittanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalConductivityMeasure : REAL
	{
		public IfcThermalConductivityMeasure(){}

		{
			return new IfcThermalConductivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalConductivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalExpansionCoefficientMeasure : REAL
	{
		public IfcThermalExpansionCoefficientMeasure(){}

		{
			return new IfcThermalExpansionCoefficientMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalExpansionCoefficientMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalResistanceMeasure : REAL
	{
		public IfcThermalResistanceMeasure(){}

		{
			return new IfcThermalResistanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalResistanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalTransmittanceMeasure : REAL
	{
		public IfcThermalTransmittanceMeasure(){}

		{
			return new IfcThermalTransmittanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalTransmittanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermodynamicTemperatureMeasure : REAL
	{
		public IfcThermodynamicTemperatureMeasure(){}

		{
			return new IfcThermodynamicTemperatureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermodynamicTemperatureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTimeMeasure : REAL
	{
		public IfcTimeMeasure(){}

		{
			return new IfcTimeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTimeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTimeStamp : INTEGER
	{
		public IfcTimeStamp(){}

		{
			return new IfcTimeStamp{ Value = value };
		}
		public static implicit operator int(IfcTimeStamp obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTorqueMeasure : REAL
	{
		public IfcTorqueMeasure(){}

		{
			return new IfcTorqueMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTorqueMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVaporPermeabilityMeasure : REAL
	{
		public IfcVaporPermeabilityMeasure(){}

		{
			return new IfcVaporPermeabilityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVaporPermeabilityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVolumeMeasure : REAL
	{
		public IfcVolumeMeasure(){}

		{
			return new IfcVolumeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVolumeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVolumetricFlowRateMeasure : REAL
	{
		public IfcVolumetricFlowRateMeasure(){}

		{
			return new IfcVolumetricFlowRateMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVolumetricFlowRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcWarpingConstantMeasure : REAL
	{
		public IfcWarpingConstantMeasure(){}

		{
			return new IfcWarpingConstantMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcWarpingConstantMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcWarpingMomentMeasure : REAL
	{
		public IfcWarpingMomentMeasure(){}

		{
			return new IfcWarpingMomentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcWarpingMomentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcYearNumber : INTEGER
	{
		public IfcYearNumber(){}

		{
			return new IfcYearNumber{ Value = value };
		}
		public static implicit operator int(IfcYearNumber obj)
		{
			return obj.Value;
		}
	}

	public class IfcActionSourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActionSourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActionSourceTypeEnum DEAD_LOAD_G = new IfcActionSourceTypeEnum( "DEAD_LOAD_G" );
		public static readonly IfcActionSourceTypeEnum COMPLETION_G1 = new IfcActionSourceTypeEnum( "COMPLETION_G1" );
		public static readonly IfcActionSourceTypeEnum LIVE_LOAD_Q = new IfcActionSourceTypeEnum( "LIVE_LOAD_Q" );
		public static readonly IfcActionSourceTypeEnum SNOW_S = new IfcActionSourceTypeEnum( "SNOW_S" );
		public static readonly IfcActionSourceTypeEnum WIND_W = new IfcActionSourceTypeEnum( "WIND_W" );
		public static readonly IfcActionSourceTypeEnum PRESTRESSING_P = new IfcActionSourceTypeEnum( "PRESTRESSING_P" );
		public static readonly IfcActionSourceTypeEnum SETTLEMENT_U = new IfcActionSourceTypeEnum( "SETTLEMENT_U" );
		public static readonly IfcActionSourceTypeEnum TEMPERATURE_T = new IfcActionSourceTypeEnum( "TEMPERATURE_T" );
		public static readonly IfcActionSourceTypeEnum EARTHQUAKE_E = new IfcActionSourceTypeEnum( "EARTHQUAKE_E" );
		public static readonly IfcActionSourceTypeEnum FIRE = new IfcActionSourceTypeEnum( "FIRE" );
		public static readonly IfcActionSourceTypeEnum IMPULSE = new IfcActionSourceTypeEnum( "IMPULSE" );
		public static readonly IfcActionSourceTypeEnum IMPACT = new IfcActionSourceTypeEnum( "IMPACT" );
		public static readonly IfcActionSourceTypeEnum TRANSPORT = new IfcActionSourceTypeEnum( "TRANSPORT" );
		public static readonly IfcActionSourceTypeEnum ERECTION = new IfcActionSourceTypeEnum( "ERECTION" );
		public static readonly IfcActionSourceTypeEnum PROPPING = new IfcActionSourceTypeEnum( "PROPPING" );
		public static readonly IfcActionSourceTypeEnum SYSTEM_IMPERFECTION = new IfcActionSourceTypeEnum( "SYSTEM_IMPERFECTION" );
		public static readonly IfcActionSourceTypeEnum SHRINKAGE = new IfcActionSourceTypeEnum( "SHRINKAGE" );
		public static readonly IfcActionSourceTypeEnum CREEP = new IfcActionSourceTypeEnum( "CREEP" );
		public static readonly IfcActionSourceTypeEnum LACK_OF_FIT = new IfcActionSourceTypeEnum( "LACK_OF_FIT" );
		public static readonly IfcActionSourceTypeEnum BUOYANCY = new IfcActionSourceTypeEnum( "BUOYANCY" );
		public static readonly IfcActionSourceTypeEnum ICE = new IfcActionSourceTypeEnum( "ICE" );
		public static readonly IfcActionSourceTypeEnum CURRENT = new IfcActionSourceTypeEnum( "CURRENT" );
		public static readonly IfcActionSourceTypeEnum WAVE = new IfcActionSourceTypeEnum( "WAVE" );
		public static readonly IfcActionSourceTypeEnum RAIN = new IfcActionSourceTypeEnum( "RAIN" );
		public static readonly IfcActionSourceTypeEnum BRAKES = new IfcActionSourceTypeEnum( "BRAKES" );
		public static readonly IfcActionSourceTypeEnum USERDEFINED = new IfcActionSourceTypeEnum( "USERDEFINED" );
		public static readonly IfcActionSourceTypeEnum NOTDEFINED = new IfcActionSourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcActionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActionTypeEnum PERMANENT_G = new IfcActionTypeEnum( "PERMANENT_G" );
		public static readonly IfcActionTypeEnum VARIABLE_Q = new IfcActionTypeEnum( "VARIABLE_Q" );
		public static readonly IfcActionTypeEnum EXTRAORDINARY_A = new IfcActionTypeEnum( "EXTRAORDINARY_A" );
		public static readonly IfcActionTypeEnum USERDEFINED = new IfcActionTypeEnum( "USERDEFINED" );
		public static readonly IfcActionTypeEnum NOTDEFINED = new IfcActionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcActuatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActuatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActuatorTypeEnum ELECTRICACTUATOR = new IfcActuatorTypeEnum( "ELECTRICACTUATOR" );
		public static readonly IfcActuatorTypeEnum HANDOPERATEDACTUATOR = new IfcActuatorTypeEnum( "HANDOPERATEDACTUATOR" );
		public static readonly IfcActuatorTypeEnum HYDRAULICACTUATOR = new IfcActuatorTypeEnum( "HYDRAULICACTUATOR" );
		public static readonly IfcActuatorTypeEnum PNEUMATICACTUATOR = new IfcActuatorTypeEnum( "PNEUMATICACTUATOR" );
		public static readonly IfcActuatorTypeEnum THERMOSTATICACTUATOR = new IfcActuatorTypeEnum( "THERMOSTATICACTUATOR" );
		public static readonly IfcActuatorTypeEnum USERDEFINED = new IfcActuatorTypeEnum( "USERDEFINED" );
		public static readonly IfcActuatorTypeEnum NOTDEFINED = new IfcActuatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAddressTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAddressTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAddressTypeEnum OFFICE = new IfcAddressTypeEnum( "OFFICE" );
		public static readonly IfcAddressTypeEnum SITE = new IfcAddressTypeEnum( "SITE" );
		public static readonly IfcAddressTypeEnum HOME = new IfcAddressTypeEnum( "HOME" );
		public static readonly IfcAddressTypeEnum DISTRIBUTIONPOINT = new IfcAddressTypeEnum( "DISTRIBUTIONPOINT" );
		public static readonly IfcAddressTypeEnum USERDEFINED = new IfcAddressTypeEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAheadOrBehind : BaseType
	{
	private readonly string ename;
		private IfcAheadOrBehind (string enumName)
		{ ename = enumName; }
		public static readonly IfcAheadOrBehind AHEAD = new IfcAheadOrBehind( "AHEAD" );
		public static readonly IfcAheadOrBehind BEHIND = new IfcAheadOrBehind( "BEHIND" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirTerminalBoxTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirTerminalBoxTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirTerminalBoxTypeEnum CONSTANTFLOW = new IfcAirTerminalBoxTypeEnum( "CONSTANTFLOW" );
		public static readonly IfcAirTerminalBoxTypeEnum VARIABLEFLOWPRESSUREDEPENDANT = new IfcAirTerminalBoxTypeEnum( "VARIABLEFLOWPRESSUREDEPENDANT" );
		public static readonly IfcAirTerminalBoxTypeEnum VARIABLEFLOWPRESSUREINDEPENDANT = new IfcAirTerminalBoxTypeEnum( "VARIABLEFLOWPRESSUREINDEPENDANT" );
		public static readonly IfcAirTerminalBoxTypeEnum USERDEFINED = new IfcAirTerminalBoxTypeEnum( "USERDEFINED" );
		public static readonly IfcAirTerminalBoxTypeEnum NOTDEFINED = new IfcAirTerminalBoxTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirTerminalTypeEnum GRILLE = new IfcAirTerminalTypeEnum( "GRILLE" );
		public static readonly IfcAirTerminalTypeEnum REGISTER = new IfcAirTerminalTypeEnum( "REGISTER" );
		public static readonly IfcAirTerminalTypeEnum DIFFUSER = new IfcAirTerminalTypeEnum( "DIFFUSER" );
		public static readonly IfcAirTerminalTypeEnum EYEBALL = new IfcAirTerminalTypeEnum( "EYEBALL" );
		public static readonly IfcAirTerminalTypeEnum IRIS = new IfcAirTerminalTypeEnum( "IRIS" );
		public static readonly IfcAirTerminalTypeEnum LINEARGRILLE = new IfcAirTerminalTypeEnum( "LINEARGRILLE" );
		public static readonly IfcAirTerminalTypeEnum LINEARDIFFUSER = new IfcAirTerminalTypeEnum( "LINEARDIFFUSER" );
		public static readonly IfcAirTerminalTypeEnum USERDEFINED = new IfcAirTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcAirTerminalTypeEnum NOTDEFINED = new IfcAirTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirToAirHeatRecoveryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirToAirHeatRecoveryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATECOUNTERFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATECOUNTERFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATECROSSFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATECROSSFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATEPARALLELFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATEPARALLELFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum ROTARYWHEEL = new IfcAirToAirHeatRecoveryTypeEnum( "ROTARYWHEEL" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum RUNAROUNDCOILLOOP = new IfcAirToAirHeatRecoveryTypeEnum( "RUNAROUNDCOILLOOP" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum HEATPIPE = new IfcAirToAirHeatRecoveryTypeEnum( "HEATPIPE" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum TWINTOWERENTHALPYRECOVERYLOOPS = new IfcAirToAirHeatRecoveryTypeEnum( "TWINTOWERENTHALPYRECOVERYLOOPS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum THERMOSIPHONSEALEDTUBEHEATEXCHANGERS = new IfcAirToAirHeatRecoveryTypeEnum( "THERMOSIPHONSEALEDTUBEHEATEXCHANGERS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum THERMOSIPHONCOILTYPEHEATEXCHANGERS = new IfcAirToAirHeatRecoveryTypeEnum( "THERMOSIPHONCOILTYPEHEATEXCHANGERS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum USERDEFINED = new IfcAirToAirHeatRecoveryTypeEnum( "USERDEFINED" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum NOTDEFINED = new IfcAirToAirHeatRecoveryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAlarmTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAlarmTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAlarmTypeEnum BELL = new IfcAlarmTypeEnum( "BELL" );
		public static readonly IfcAlarmTypeEnum BREAKGLASSBUTTON = new IfcAlarmTypeEnum( "BREAKGLASSBUTTON" );
		public static readonly IfcAlarmTypeEnum LIGHT = new IfcAlarmTypeEnum( "LIGHT" );
		public static readonly IfcAlarmTypeEnum MANUALPULLBOX = new IfcAlarmTypeEnum( "MANUALPULLBOX" );
		public static readonly IfcAlarmTypeEnum SIREN = new IfcAlarmTypeEnum( "SIREN" );
		public static readonly IfcAlarmTypeEnum WHISTLE = new IfcAlarmTypeEnum( "WHISTLE" );
		public static readonly IfcAlarmTypeEnum USERDEFINED = new IfcAlarmTypeEnum( "USERDEFINED" );
		public static readonly IfcAlarmTypeEnum NOTDEFINED = new IfcAlarmTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAnalysisModelTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAnalysisModelTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAnalysisModelTypeEnum IN_PLANE_LOADING_2D = new IfcAnalysisModelTypeEnum( "IN_PLANE_LOADING_2D" );
		public static readonly IfcAnalysisModelTypeEnum OUT_PLANE_LOADING_2D = new IfcAnalysisModelTypeEnum( "OUT_PLANE_LOADING_2D" );
		public static readonly IfcAnalysisModelTypeEnum LOADING_3D = new IfcAnalysisModelTypeEnum( "LOADING_3D" );
		public static readonly IfcAnalysisModelTypeEnum USERDEFINED = new IfcAnalysisModelTypeEnum( "USERDEFINED" );
		public static readonly IfcAnalysisModelTypeEnum NOTDEFINED = new IfcAnalysisModelTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAnalysisTheoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAnalysisTheoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAnalysisTheoryTypeEnum FIRST_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "FIRST_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum SECOND_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "SECOND_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum THIRD_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "THIRD_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum FULL_NONLINEAR_THEORY = new IfcAnalysisTheoryTypeEnum( "FULL_NONLINEAR_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum USERDEFINED = new IfcAnalysisTheoryTypeEnum( "USERDEFINED" );
		public static readonly IfcAnalysisTheoryTypeEnum NOTDEFINED = new IfcAnalysisTheoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcArithmeticOperatorEnum : BaseType
	{
	private readonly string ename;
		private IfcArithmeticOperatorEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcArithmeticOperatorEnum ADD = new IfcArithmeticOperatorEnum( "ADD" );
		public static readonly IfcArithmeticOperatorEnum DIVIDE = new IfcArithmeticOperatorEnum( "DIVIDE" );
		public static readonly IfcArithmeticOperatorEnum MULTIPLY = new IfcArithmeticOperatorEnum( "MULTIPLY" );
		public static readonly IfcArithmeticOperatorEnum SUBTRACT = new IfcArithmeticOperatorEnum( "SUBTRACT" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAssemblyPlaceEnum : BaseType
	{
	private readonly string ename;
		private IfcAssemblyPlaceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAssemblyPlaceEnum SITE = new IfcAssemblyPlaceEnum( "SITE" );
		public static readonly IfcAssemblyPlaceEnum FACTORY = new IfcAssemblyPlaceEnum( "FACTORY" );
		public static readonly IfcAssemblyPlaceEnum NOTDEFINED = new IfcAssemblyPlaceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBSplineCurveForm : BaseType
	{
	private readonly string ename;
		private IfcBSplineCurveForm (string enumName)
		{ ename = enumName; }
		public static readonly IfcBSplineCurveForm POLYLINE_FORM = new IfcBSplineCurveForm( "POLYLINE_FORM" );
		public static readonly IfcBSplineCurveForm CIRCULAR_ARC = new IfcBSplineCurveForm( "CIRCULAR_ARC" );
		public static readonly IfcBSplineCurveForm ELLIPTIC_ARC = new IfcBSplineCurveForm( "ELLIPTIC_ARC" );
		public static readonly IfcBSplineCurveForm PARABOLIC_ARC = new IfcBSplineCurveForm( "PARABOLIC_ARC" );
		public static readonly IfcBSplineCurveForm HYPERBOLIC_ARC = new IfcBSplineCurveForm( "HYPERBOLIC_ARC" );
		public static readonly IfcBSplineCurveForm UNSPECIFIED = new IfcBSplineCurveForm( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBeamTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBeamTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBeamTypeEnum BEAM = new IfcBeamTypeEnum( "BEAM" );
		public static readonly IfcBeamTypeEnum JOIST = new IfcBeamTypeEnum( "JOIST" );
		public static readonly IfcBeamTypeEnum LINTEL = new IfcBeamTypeEnum( "LINTEL" );
		public static readonly IfcBeamTypeEnum T_BEAM = new IfcBeamTypeEnum( "T_BEAM" );
		public static readonly IfcBeamTypeEnum USERDEFINED = new IfcBeamTypeEnum( "USERDEFINED" );
		public static readonly IfcBeamTypeEnum NOTDEFINED = new IfcBeamTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBenchmarkEnum : BaseType
	{
	private readonly string ename;
		private IfcBenchmarkEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBenchmarkEnum GREATERTHAN = new IfcBenchmarkEnum( "GREATERTHAN" );
		public static readonly IfcBenchmarkEnum GREATERTHANOREQUALTO = new IfcBenchmarkEnum( "GREATERTHANOREQUALTO" );
		public static readonly IfcBenchmarkEnum LESSTHAN = new IfcBenchmarkEnum( "LESSTHAN" );
		public static readonly IfcBenchmarkEnum LESSTHANOREQUALTO = new IfcBenchmarkEnum( "LESSTHANOREQUALTO" );
		public static readonly IfcBenchmarkEnum EQUALTO = new IfcBenchmarkEnum( "EQUALTO" );
		public static readonly IfcBenchmarkEnum NOTEQUALTO = new IfcBenchmarkEnum( "NOTEQUALTO" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBoilerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBoilerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBoilerTypeEnum WATER = new IfcBoilerTypeEnum( "WATER" );
		public static readonly IfcBoilerTypeEnum STEAM = new IfcBoilerTypeEnum( "STEAM" );
		public static readonly IfcBoilerTypeEnum USERDEFINED = new IfcBoilerTypeEnum( "USERDEFINED" );
		public static readonly IfcBoilerTypeEnum NOTDEFINED = new IfcBoilerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBooleanOperator : BaseType
	{
	private readonly string ename;
		private IfcBooleanOperator (string enumName)
		{ ename = enumName; }
		public static readonly IfcBooleanOperator UNION = new IfcBooleanOperator( "UNION" );
		public static readonly IfcBooleanOperator INTERSECTION = new IfcBooleanOperator( "INTERSECTION" );
		public static readonly IfcBooleanOperator DIFFERENCE = new IfcBooleanOperator( "DIFFERENCE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBuildingElementProxyTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBuildingElementProxyTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBuildingElementProxyTypeEnum USERDEFINED = new IfcBuildingElementProxyTypeEnum( "USERDEFINED" );
		public static readonly IfcBuildingElementProxyTypeEnum NOTDEFINED = new IfcBuildingElementProxyTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableCarrierFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableCarrierFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableCarrierFittingTypeEnum BEND = new IfcCableCarrierFittingTypeEnum( "BEND" );
		public static readonly IfcCableCarrierFittingTypeEnum CROSS = new IfcCableCarrierFittingTypeEnum( "CROSS" );
		public static readonly IfcCableCarrierFittingTypeEnum REDUCER = new IfcCableCarrierFittingTypeEnum( "REDUCER" );
		public static readonly IfcCableCarrierFittingTypeEnum TEE = new IfcCableCarrierFittingTypeEnum( "TEE" );
		public static readonly IfcCableCarrierFittingTypeEnum USERDEFINED = new IfcCableCarrierFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcCableCarrierFittingTypeEnum NOTDEFINED = new IfcCableCarrierFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableCarrierSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableCarrierSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableCarrierSegmentTypeEnum CABLELADDERSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLELADDERSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CABLETRAYSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLETRAYSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CABLETRUNKINGSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLETRUNKINGSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CONDUITSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CONDUITSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum USERDEFINED = new IfcCableCarrierSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcCableCarrierSegmentTypeEnum NOTDEFINED = new IfcCableCarrierSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableSegmentTypeEnum CABLESEGMENT = new IfcCableSegmentTypeEnum( "CABLESEGMENT" );
		public static readonly IfcCableSegmentTypeEnum CONDUCTORSEGMENT = new IfcCableSegmentTypeEnum( "CONDUCTORSEGMENT" );
		public static readonly IfcCableSegmentTypeEnum USERDEFINED = new IfcCableSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcCableSegmentTypeEnum NOTDEFINED = new IfcCableSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcChangeActionEnum : BaseType
	{
	private readonly string ename;
		private IfcChangeActionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcChangeActionEnum NOCHANGE = new IfcChangeActionEnum( "NOCHANGE" );
		public static readonly IfcChangeActionEnum MODIFIED = new IfcChangeActionEnum( "MODIFIED" );
		public static readonly IfcChangeActionEnum ADDED = new IfcChangeActionEnum( "ADDED" );
		public static readonly IfcChangeActionEnum DELETED = new IfcChangeActionEnum( "DELETED" );
		public static readonly IfcChangeActionEnum MODIFIEDADDED = new IfcChangeActionEnum( "MODIFIEDADDED" );
		public static readonly IfcChangeActionEnum MODIFIEDDELETED = new IfcChangeActionEnum( "MODIFIEDDELETED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcChillerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcChillerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcChillerTypeEnum AIRCOOLED = new IfcChillerTypeEnum( "AIRCOOLED" );
		public static readonly IfcChillerTypeEnum WATERCOOLED = new IfcChillerTypeEnum( "WATERCOOLED" );
		public static readonly IfcChillerTypeEnum HEATRECOVERY = new IfcChillerTypeEnum( "HEATRECOVERY" );
		public static readonly IfcChillerTypeEnum USERDEFINED = new IfcChillerTypeEnum( "USERDEFINED" );
		public static readonly IfcChillerTypeEnum NOTDEFINED = new IfcChillerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoilTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoilTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoilTypeEnum DXCOOLINGCOIL = new IfcCoilTypeEnum( "DXCOOLINGCOIL" );
		public static readonly IfcCoilTypeEnum WATERCOOLINGCOIL = new IfcCoilTypeEnum( "WATERCOOLINGCOIL" );
		public static readonly IfcCoilTypeEnum STEAMHEATINGCOIL = new IfcCoilTypeEnum( "STEAMHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum WATERHEATINGCOIL = new IfcCoilTypeEnum( "WATERHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum ELECTRICHEATINGCOIL = new IfcCoilTypeEnum( "ELECTRICHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum GASHEATINGCOIL = new IfcCoilTypeEnum( "GASHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum USERDEFINED = new IfcCoilTypeEnum( "USERDEFINED" );
		public static readonly IfcCoilTypeEnum NOTDEFINED = new IfcCoilTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcColumnTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcColumnTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcColumnTypeEnum COLUMN = new IfcColumnTypeEnum( "COLUMN" );
		public static readonly IfcColumnTypeEnum USERDEFINED = new IfcColumnTypeEnum( "USERDEFINED" );
		public static readonly IfcColumnTypeEnum NOTDEFINED = new IfcColumnTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCompressorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCompressorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCompressorTypeEnum DYNAMIC = new IfcCompressorTypeEnum( "DYNAMIC" );
		public static readonly IfcCompressorTypeEnum RECIPROCATING = new IfcCompressorTypeEnum( "RECIPROCATING" );
		public static readonly IfcCompressorTypeEnum ROTARY = new IfcCompressorTypeEnum( "ROTARY" );
		public static readonly IfcCompressorTypeEnum SCROLL = new IfcCompressorTypeEnum( "SCROLL" );
		public static readonly IfcCompressorTypeEnum TROCHOIDAL = new IfcCompressorTypeEnum( "TROCHOIDAL" );
		public static readonly IfcCompressorTypeEnum SINGLESTAGE = new IfcCompressorTypeEnum( "SINGLESTAGE" );
		public static readonly IfcCompressorTypeEnum BOOSTER = new IfcCompressorTypeEnum( "BOOSTER" );
		public static readonly IfcCompressorTypeEnum OPENTYPE = new IfcCompressorTypeEnum( "OPENTYPE" );
		public static readonly IfcCompressorTypeEnum HERMETIC = new IfcCompressorTypeEnum( "HERMETIC" );
		public static readonly IfcCompressorTypeEnum SEMIHERMETIC = new IfcCompressorTypeEnum( "SEMIHERMETIC" );
		public static readonly IfcCompressorTypeEnum WELDEDSHELLHERMETIC = new IfcCompressorTypeEnum( "WELDEDSHELLHERMETIC" );
		public static readonly IfcCompressorTypeEnum ROLLINGPISTON = new IfcCompressorTypeEnum( "ROLLINGPISTON" );
		public static readonly IfcCompressorTypeEnum ROTARYVANE = new IfcCompressorTypeEnum( "ROTARYVANE" );
		public static readonly IfcCompressorTypeEnum SINGLESCREW = new IfcCompressorTypeEnum( "SINGLESCREW" );
		public static readonly IfcCompressorTypeEnum TWINSCREW = new IfcCompressorTypeEnum( "TWINSCREW" );
		public static readonly IfcCompressorTypeEnum USERDEFINED = new IfcCompressorTypeEnum( "USERDEFINED" );
		public static readonly IfcCompressorTypeEnum NOTDEFINED = new IfcCompressorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCondenserTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCondenserTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCondenserTypeEnum WATERCOOLEDSHELLTUBE = new IfcCondenserTypeEnum( "WATERCOOLEDSHELLTUBE" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDSHELLCOIL = new IfcCondenserTypeEnum( "WATERCOOLEDSHELLCOIL" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDTUBEINTUBE = new IfcCondenserTypeEnum( "WATERCOOLEDTUBEINTUBE" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDBRAZEDPLATE = new IfcCondenserTypeEnum( "WATERCOOLEDBRAZEDPLATE" );
		public static readonly IfcCondenserTypeEnum AIRCOOLED = new IfcCondenserTypeEnum( "AIRCOOLED" );
		public static readonly IfcCondenserTypeEnum EVAPORATIVECOOLED = new IfcCondenserTypeEnum( "EVAPORATIVECOOLED" );
		public static readonly IfcCondenserTypeEnum USERDEFINED = new IfcCondenserTypeEnum( "USERDEFINED" );
		public static readonly IfcCondenserTypeEnum NOTDEFINED = new IfcCondenserTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConnectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcConnectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConnectionTypeEnum ATPATH = new IfcConnectionTypeEnum( "ATPATH" );
		public static readonly IfcConnectionTypeEnum ATSTART = new IfcConnectionTypeEnum( "ATSTART" );
		public static readonly IfcConnectionTypeEnum ATEND = new IfcConnectionTypeEnum( "ATEND" );
		public static readonly IfcConnectionTypeEnum NOTDEFINED = new IfcConnectionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConstraintEnum : BaseType
	{
	private readonly string ename;
		private IfcConstraintEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConstraintEnum HARD = new IfcConstraintEnum( "HARD" );
		public static readonly IfcConstraintEnum SOFT = new IfcConstraintEnum( "SOFT" );
		public static readonly IfcConstraintEnum ADVISORY = new IfcConstraintEnum( "ADVISORY" );
		public static readonly IfcConstraintEnum USERDEFINED = new IfcConstraintEnum( "USERDEFINED" );
		public static readonly IfcConstraintEnum NOTDEFINED = new IfcConstraintEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcControllerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcControllerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcControllerTypeEnum FLOATING = new IfcControllerTypeEnum( "FLOATING" );
		public static readonly IfcControllerTypeEnum PROPORTIONAL = new IfcControllerTypeEnum( "PROPORTIONAL" );
		public static readonly IfcControllerTypeEnum PROPORTIONALINTEGRAL = new IfcControllerTypeEnum( "PROPORTIONALINTEGRAL" );
		public static readonly IfcControllerTypeEnum PROPORTIONALINTEGRALDERIVATIVE = new IfcControllerTypeEnum( "PROPORTIONALINTEGRALDERIVATIVE" );
		public static readonly IfcControllerTypeEnum TIMEDTWOPOSITION = new IfcControllerTypeEnum( "TIMEDTWOPOSITION" );
		public static readonly IfcControllerTypeEnum TWOPOSITION = new IfcControllerTypeEnum( "TWOPOSITION" );
		public static readonly IfcControllerTypeEnum USERDEFINED = new IfcControllerTypeEnum( "USERDEFINED" );
		public static readonly IfcControllerTypeEnum NOTDEFINED = new IfcControllerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCooledBeamTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCooledBeamTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCooledBeamTypeEnum ACTIVE = new IfcCooledBeamTypeEnum( "ACTIVE" );
		public static readonly IfcCooledBeamTypeEnum PASSIVE = new IfcCooledBeamTypeEnum( "PASSIVE" );
		public static readonly IfcCooledBeamTypeEnum USERDEFINED = new IfcCooledBeamTypeEnum( "USERDEFINED" );
		public static readonly IfcCooledBeamTypeEnum NOTDEFINED = new IfcCooledBeamTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoolingTowerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoolingTowerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoolingTowerTypeEnum NATURALDRAFT = new IfcCoolingTowerTypeEnum( "NATURALDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum MECHANICALINDUCEDDRAFT = new IfcCoolingTowerTypeEnum( "MECHANICALINDUCEDDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum MECHANICALFORCEDDRAFT = new IfcCoolingTowerTypeEnum( "MECHANICALFORCEDDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum USERDEFINED = new IfcCoolingTowerTypeEnum( "USERDEFINED" );
		public static readonly IfcCoolingTowerTypeEnum NOTDEFINED = new IfcCoolingTowerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCostScheduleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCostScheduleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCostScheduleTypeEnum BUDGET = new IfcCostScheduleTypeEnum( "BUDGET" );
		public static readonly IfcCostScheduleTypeEnum COSTPLAN = new IfcCostScheduleTypeEnum( "COSTPLAN" );
		public static readonly IfcCostScheduleTypeEnum ESTIMATE = new IfcCostScheduleTypeEnum( "ESTIMATE" );
		public static readonly IfcCostScheduleTypeEnum TENDER = new IfcCostScheduleTypeEnum( "TENDER" );
		public static readonly IfcCostScheduleTypeEnum PRICEDBILLOFQUANTITIES = new IfcCostScheduleTypeEnum( "PRICEDBILLOFQUANTITIES" );
		public static readonly IfcCostScheduleTypeEnum UNPRICEDBILLOFQUANTITIES = new IfcCostScheduleTypeEnum( "UNPRICEDBILLOFQUANTITIES" );
		public static readonly IfcCostScheduleTypeEnum SCHEDULEOFRATES = new IfcCostScheduleTypeEnum( "SCHEDULEOFRATES" );
		public static readonly IfcCostScheduleTypeEnum USERDEFINED = new IfcCostScheduleTypeEnum( "USERDEFINED" );
		public static readonly IfcCostScheduleTypeEnum NOTDEFINED = new IfcCostScheduleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoveringTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoveringTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoveringTypeEnum CEILING = new IfcCoveringTypeEnum( "CEILING" );
		public static readonly IfcCoveringTypeEnum FLOORING = new IfcCoveringTypeEnum( "FLOORING" );
		public static readonly IfcCoveringTypeEnum CLADDING = new IfcCoveringTypeEnum( "CLADDING" );
		public static readonly IfcCoveringTypeEnum ROOFING = new IfcCoveringTypeEnum( "ROOFING" );
		public static readonly IfcCoveringTypeEnum INSULATION = new IfcCoveringTypeEnum( "INSULATION" );
		public static readonly IfcCoveringTypeEnum MEMBRANE = new IfcCoveringTypeEnum( "MEMBRANE" );
		public static readonly IfcCoveringTypeEnum SLEEVING = new IfcCoveringTypeEnum( "SLEEVING" );
		public static readonly IfcCoveringTypeEnum WRAPPING = new IfcCoveringTypeEnum( "WRAPPING" );
		public static readonly IfcCoveringTypeEnum USERDEFINED = new IfcCoveringTypeEnum( "USERDEFINED" );
		public static readonly IfcCoveringTypeEnum NOTDEFINED = new IfcCoveringTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCurrencyEnum : BaseType
	{
	private readonly string ename;
		private IfcCurrencyEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCurrencyEnum AED = new IfcCurrencyEnum( "AED" );
		public static readonly IfcCurrencyEnum AES = new IfcCurrencyEnum( "AES" );
		public static readonly IfcCurrencyEnum ATS = new IfcCurrencyEnum( "ATS" );
		public static readonly IfcCurrencyEnum AUD = new IfcCurrencyEnum( "AUD" );
		public static readonly IfcCurrencyEnum BBD = new IfcCurrencyEnum( "BBD" );
		public static readonly IfcCurrencyEnum BEG = new IfcCurrencyEnum( "BEG" );
		public static readonly IfcCurrencyEnum BGL = new IfcCurrencyEnum( "BGL" );
		public static readonly IfcCurrencyEnum BHD = new IfcCurrencyEnum( "BHD" );
		public static readonly IfcCurrencyEnum BMD = new IfcCurrencyEnum( "BMD" );
		public static readonly IfcCurrencyEnum BND = new IfcCurrencyEnum( "BND" );
		public static readonly IfcCurrencyEnum BRL = new IfcCurrencyEnum( "BRL" );
		public static readonly IfcCurrencyEnum BSD = new IfcCurrencyEnum( "BSD" );
		public static readonly IfcCurrencyEnum BWP = new IfcCurrencyEnum( "BWP" );
		public static readonly IfcCurrencyEnum BZD = new IfcCurrencyEnum( "BZD" );
		public static readonly IfcCurrencyEnum CAD = new IfcCurrencyEnum( "CAD" );
		public static readonly IfcCurrencyEnum CBD = new IfcCurrencyEnum( "CBD" );
		public static readonly IfcCurrencyEnum CHF = new IfcCurrencyEnum( "CHF" );
		public static readonly IfcCurrencyEnum CLP = new IfcCurrencyEnum( "CLP" );
		public static readonly IfcCurrencyEnum CNY = new IfcCurrencyEnum( "CNY" );
		public static readonly IfcCurrencyEnum CYS = new IfcCurrencyEnum( "CYS" );
		public static readonly IfcCurrencyEnum CZK = new IfcCurrencyEnum( "CZK" );
		public static readonly IfcCurrencyEnum DDP = new IfcCurrencyEnum( "DDP" );
		public static readonly IfcCurrencyEnum DEM = new IfcCurrencyEnum( "DEM" );
		public static readonly IfcCurrencyEnum DKK = new IfcCurrencyEnum( "DKK" );
		public static readonly IfcCurrencyEnum EGL = new IfcCurrencyEnum( "EGL" );
		public static readonly IfcCurrencyEnum EST = new IfcCurrencyEnum( "EST" );
		public static readonly IfcCurrencyEnum EUR = new IfcCurrencyEnum( "EUR" );
		public static readonly IfcCurrencyEnum FAK = new IfcCurrencyEnum( "FAK" );
		public static readonly IfcCurrencyEnum FIM = new IfcCurrencyEnum( "FIM" );
		public static readonly IfcCurrencyEnum FJD = new IfcCurrencyEnum( "FJD" );
		public static readonly IfcCurrencyEnum FKP = new IfcCurrencyEnum( "FKP" );
		public static readonly IfcCurrencyEnum FRF = new IfcCurrencyEnum( "FRF" );
		public static readonly IfcCurrencyEnum GBP = new IfcCurrencyEnum( "GBP" );
		public static readonly IfcCurrencyEnum GIP = new IfcCurrencyEnum( "GIP" );
		public static readonly IfcCurrencyEnum GMD = new IfcCurrencyEnum( "GMD" );
		public static readonly IfcCurrencyEnum GRX = new IfcCurrencyEnum( "GRX" );
		public static readonly IfcCurrencyEnum HKD = new IfcCurrencyEnum( "HKD" );
		public static readonly IfcCurrencyEnum HUF = new IfcCurrencyEnum( "HUF" );
		public static readonly IfcCurrencyEnum ICK = new IfcCurrencyEnum( "ICK" );
		public static readonly IfcCurrencyEnum IDR = new IfcCurrencyEnum( "IDR" );
		public static readonly IfcCurrencyEnum ILS = new IfcCurrencyEnum( "ILS" );
		public static readonly IfcCurrencyEnum INR = new IfcCurrencyEnum( "INR" );
		public static readonly IfcCurrencyEnum IRP = new IfcCurrencyEnum( "IRP" );
		public static readonly IfcCurrencyEnum ITL = new IfcCurrencyEnum( "ITL" );
		public static readonly IfcCurrencyEnum JMD = new IfcCurrencyEnum( "JMD" );
		public static readonly IfcCurrencyEnum JOD = new IfcCurrencyEnum( "JOD" );
		public static readonly IfcCurrencyEnum JPY = new IfcCurrencyEnum( "JPY" );
		public static readonly IfcCurrencyEnum KES = new IfcCurrencyEnum( "KES" );
		public static readonly IfcCurrencyEnum KRW = new IfcCurrencyEnum( "KRW" );
		public static readonly IfcCurrencyEnum KWD = new IfcCurrencyEnum( "KWD" );
		public static readonly IfcCurrencyEnum KYD = new IfcCurrencyEnum( "KYD" );
		public static readonly IfcCurrencyEnum LKR = new IfcCurrencyEnum( "LKR" );
		public static readonly IfcCurrencyEnum LUF = new IfcCurrencyEnum( "LUF" );
		public static readonly IfcCurrencyEnum MTL = new IfcCurrencyEnum( "MTL" );
		public static readonly IfcCurrencyEnum MUR = new IfcCurrencyEnum( "MUR" );
		public static readonly IfcCurrencyEnum MXN = new IfcCurrencyEnum( "MXN" );
		public static readonly IfcCurrencyEnum MYR = new IfcCurrencyEnum( "MYR" );
		public static readonly IfcCurrencyEnum NLG = new IfcCurrencyEnum( "NLG" );
		public static readonly IfcCurrencyEnum NZD = new IfcCurrencyEnum( "NZD" );
		public static readonly IfcCurrencyEnum OMR = new IfcCurrencyEnum( "OMR" );
		public static readonly IfcCurrencyEnum PGK = new IfcCurrencyEnum( "PGK" );
		public static readonly IfcCurrencyEnum PHP = new IfcCurrencyEnum( "PHP" );
		public static readonly IfcCurrencyEnum PKR = new IfcCurrencyEnum( "PKR" );
		public static readonly IfcCurrencyEnum PLN = new IfcCurrencyEnum( "PLN" );
		public static readonly IfcCurrencyEnum PTN = new IfcCurrencyEnum( "PTN" );
		public static readonly IfcCurrencyEnum QAR = new IfcCurrencyEnum( "QAR" );
		public static readonly IfcCurrencyEnum RUR = new IfcCurrencyEnum( "RUR" );
		public static readonly IfcCurrencyEnum SAR = new IfcCurrencyEnum( "SAR" );
		public static readonly IfcCurrencyEnum SCR = new IfcCurrencyEnum( "SCR" );
		public static readonly IfcCurrencyEnum SEK = new IfcCurrencyEnum( "SEK" );
		public static readonly IfcCurrencyEnum SGD = new IfcCurrencyEnum( "SGD" );
		public static readonly IfcCurrencyEnum SKP = new IfcCurrencyEnum( "SKP" );
		public static readonly IfcCurrencyEnum THB = new IfcCurrencyEnum( "THB" );
		public static readonly IfcCurrencyEnum TRL = new IfcCurrencyEnum( "TRL" );
		public static readonly IfcCurrencyEnum TTD = new IfcCurrencyEnum( "TTD" );
		public static readonly IfcCurrencyEnum TWD = new IfcCurrencyEnum( "TWD" );
		public static readonly IfcCurrencyEnum USD = new IfcCurrencyEnum( "USD" );
		public static readonly IfcCurrencyEnum VEB = new IfcCurrencyEnum( "VEB" );
		public static readonly IfcCurrencyEnum VND = new IfcCurrencyEnum( "VND" );
		public static readonly IfcCurrencyEnum XEU = new IfcCurrencyEnum( "XEU" );
		public static readonly IfcCurrencyEnum ZAR = new IfcCurrencyEnum( "ZAR" );
		public static readonly IfcCurrencyEnum ZWD = new IfcCurrencyEnum( "ZWD" );
		public static readonly IfcCurrencyEnum NOK = new IfcCurrencyEnum( "NOK" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCurtainWallTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCurtainWallTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCurtainWallTypeEnum USERDEFINED = new IfcCurtainWallTypeEnum( "USERDEFINED" );
		public static readonly IfcCurtainWallTypeEnum NOTDEFINED = new IfcCurtainWallTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDamperTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDamperTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDamperTypeEnum CONTROLDAMPER = new IfcDamperTypeEnum( "CONTROLDAMPER" );
		public static readonly IfcDamperTypeEnum FIREDAMPER = new IfcDamperTypeEnum( "FIREDAMPER" );
		public static readonly IfcDamperTypeEnum SMOKEDAMPER = new IfcDamperTypeEnum( "SMOKEDAMPER" );
		public static readonly IfcDamperTypeEnum FIRESMOKEDAMPER = new IfcDamperTypeEnum( "FIRESMOKEDAMPER" );
		public static readonly IfcDamperTypeEnum BACKDRAFTDAMPER = new IfcDamperTypeEnum( "BACKDRAFTDAMPER" );
		public static readonly IfcDamperTypeEnum RELIEFDAMPER = new IfcDamperTypeEnum( "RELIEFDAMPER" );
		public static readonly IfcDamperTypeEnum BLASTDAMPER = new IfcDamperTypeEnum( "BLASTDAMPER" );
		public static readonly IfcDamperTypeEnum GRAVITYDAMPER = new IfcDamperTypeEnum( "GRAVITYDAMPER" );
		public static readonly IfcDamperTypeEnum GRAVITYRELIEFDAMPER = new IfcDamperTypeEnum( "GRAVITYRELIEFDAMPER" );
		public static readonly IfcDamperTypeEnum BALANCINGDAMPER = new IfcDamperTypeEnum( "BALANCINGDAMPER" );
		public static readonly IfcDamperTypeEnum FUMEHOODEXHAUST = new IfcDamperTypeEnum( "FUMEHOODEXHAUST" );
		public static readonly IfcDamperTypeEnum USERDEFINED = new IfcDamperTypeEnum( "USERDEFINED" );
		public static readonly IfcDamperTypeEnum NOTDEFINED = new IfcDamperTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDataOriginEnum : BaseType
	{
	private readonly string ename;
		private IfcDataOriginEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDataOriginEnum MEASURED = new IfcDataOriginEnum( "MEASURED" );
		public static readonly IfcDataOriginEnum PREDICTED = new IfcDataOriginEnum( "PREDICTED" );
		public static readonly IfcDataOriginEnum SIMULATED = new IfcDataOriginEnum( "SIMULATED" );
		public static readonly IfcDataOriginEnum USERDEFINED = new IfcDataOriginEnum( "USERDEFINED" );
		public static readonly IfcDataOriginEnum NOTDEFINED = new IfcDataOriginEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDerivedUnitEnum : BaseType
	{
	private readonly string ename;
		private IfcDerivedUnitEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDerivedUnitEnum ANGULARVELOCITYUNIT = new IfcDerivedUnitEnum( "ANGULARVELOCITYUNIT" );
		public static readonly IfcDerivedUnitEnum COMPOUNDPLANEANGLEUNIT = new IfcDerivedUnitEnum( "COMPOUNDPLANEANGLEUNIT" );
		public static readonly IfcDerivedUnitEnum DYNAMICVISCOSITYUNIT = new IfcDerivedUnitEnum( "DYNAMICVISCOSITYUNIT" );
		public static readonly IfcDerivedUnitEnum HEATFLUXDENSITYUNIT = new IfcDerivedUnitEnum( "HEATFLUXDENSITYUNIT" );
		public static readonly IfcDerivedUnitEnum INTEGERCOUNTRATEUNIT = new IfcDerivedUnitEnum( "INTEGERCOUNTRATEUNIT" );
		public static readonly IfcDerivedUnitEnum ISOTHERMALMOISTURECAPACITYUNIT = new IfcDerivedUnitEnum( "ISOTHERMALMOISTURECAPACITYUNIT" );
		public static readonly IfcDerivedUnitEnum KINEMATICVISCOSITYUNIT = new IfcDerivedUnitEnum( "KINEMATICVISCOSITYUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARVELOCITYUNIT = new IfcDerivedUnitEnum( "LINEARVELOCITYUNIT" );
		public static readonly IfcDerivedUnitEnum MASSDENSITYUNIT = new IfcDerivedUnitEnum( "MASSDENSITYUNIT" );
		public static readonly IfcDerivedUnitEnum MASSFLOWRATEUNIT = new IfcDerivedUnitEnum( "MASSFLOWRATEUNIT" );
		public static readonly IfcDerivedUnitEnum MOISTUREDIFFUSIVITYUNIT = new IfcDerivedUnitEnum( "MOISTUREDIFFUSIVITYUNIT" );
		public static readonly IfcDerivedUnitEnum MOLECULARWEIGHTUNIT = new IfcDerivedUnitEnum( "MOLECULARWEIGHTUNIT" );
		public static readonly IfcDerivedUnitEnum SPECIFICHEATCAPACITYUNIT = new IfcDerivedUnitEnum( "SPECIFICHEATCAPACITYUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALADMITTANCEUNIT = new IfcDerivedUnitEnum( "THERMALADMITTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALCONDUCTANCEUNIT = new IfcDerivedUnitEnum( "THERMALCONDUCTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALRESISTANCEUNIT = new IfcDerivedUnitEnum( "THERMALRESISTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALTRANSMITTANCEUNIT = new IfcDerivedUnitEnum( "THERMALTRANSMITTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum VAPORPERMEABILITYUNIT = new IfcDerivedUnitEnum( "VAPORPERMEABILITYUNIT" );
		public static readonly IfcDerivedUnitEnum VOLUMETRICFLOWRATEUNIT = new IfcDerivedUnitEnum( "VOLUMETRICFLOWRATEUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALFREQUENCYUNIT = new IfcDerivedUnitEnum( "ROTATIONALFREQUENCYUNIT" );
		public static readonly IfcDerivedUnitEnum TORQUEUNIT = new IfcDerivedUnitEnum( "TORQUEUNIT" );
		public static readonly IfcDerivedUnitEnum MOMENTOFINERTIAUNIT = new IfcDerivedUnitEnum( "MOMENTOFINERTIAUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARMOMENTUNIT = new IfcDerivedUnitEnum( "LINEARMOMENTUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARFORCEUNIT = new IfcDerivedUnitEnum( "LINEARFORCEUNIT" );
		public static readonly IfcDerivedUnitEnum PLANARFORCEUNIT = new IfcDerivedUnitEnum( "PLANARFORCEUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFELASTICITYUNIT = new IfcDerivedUnitEnum( "MODULUSOFELASTICITYUNIT" );
		public static readonly IfcDerivedUnitEnum SHEARMODULUSUNIT = new IfcDerivedUnitEnum( "SHEARMODULUSUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARSTIFFNESSUNIT = new IfcDerivedUnitEnum( "LINEARSTIFFNESSUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALSTIFFNESSUNIT = new IfcDerivedUnitEnum( "ROTATIONALSTIFFNESSUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum ACCELERATIONUNIT = new IfcDerivedUnitEnum( "ACCELERATIONUNIT" );
		public static readonly IfcDerivedUnitEnum CURVATUREUNIT = new IfcDerivedUnitEnum( "CURVATUREUNIT" );
		public static readonly IfcDerivedUnitEnum HEATINGVALUEUNIT = new IfcDerivedUnitEnum( "HEATINGVALUEUNIT" );
		public static readonly IfcDerivedUnitEnum IONCONCENTRATIONUNIT = new IfcDerivedUnitEnum( "IONCONCENTRATIONUNIT" );
		public static readonly IfcDerivedUnitEnum LUMINOUSINTENSITYDISTRIBUTIONUNIT = new IfcDerivedUnitEnum( "LUMINOUSINTENSITYDISTRIBUTIONUNIT" );
		public static readonly IfcDerivedUnitEnum MASSPERLENGTHUNIT = new IfcDerivedUnitEnum( "MASSPERLENGTHUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFLINEARSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFLINEARSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFROTATIONALSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFROTATIONALSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum PHUNIT = new IfcDerivedUnitEnum( "PHUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALMASSUNIT = new IfcDerivedUnitEnum( "ROTATIONALMASSUNIT" );
		public static readonly IfcDerivedUnitEnum SECTIONAREAINTEGRALUNIT = new IfcDerivedUnitEnum( "SECTIONAREAINTEGRALUNIT" );
		public static readonly IfcDerivedUnitEnum SECTIONMODULUSUNIT = new IfcDerivedUnitEnum( "SECTIONMODULUSUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPOWERUNIT = new IfcDerivedUnitEnum( "SOUNDPOWERUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPRESSUREUNIT = new IfcDerivedUnitEnum( "SOUNDPRESSUREUNIT" );
		public static readonly IfcDerivedUnitEnum TEMPERATUREGRADIENTUNIT = new IfcDerivedUnitEnum( "TEMPERATUREGRADIENTUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALEXPANSIONCOEFFICIENTUNIT = new IfcDerivedUnitEnum( "THERMALEXPANSIONCOEFFICIENTUNIT" );
		public static readonly IfcDerivedUnitEnum WARPINGCONSTANTUNIT = new IfcDerivedUnitEnum( "WARPINGCONSTANTUNIT" );
		public static readonly IfcDerivedUnitEnum WARPINGMOMENTUNIT = new IfcDerivedUnitEnum( "WARPINGMOMENTUNIT" );
		public static readonly IfcDerivedUnitEnum USERDEFINED = new IfcDerivedUnitEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDimensionExtentUsage : BaseType
	{
	private readonly string ename;
		private IfcDimensionExtentUsage (string enumName)
		{ ename = enumName; }
		public static readonly IfcDimensionExtentUsage ORIGIN = new IfcDimensionExtentUsage( "ORIGIN" );
		public static readonly IfcDimensionExtentUsage TARGET = new IfcDimensionExtentUsage( "TARGET" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDirectionSenseEnum : BaseType
	{
	private readonly string ename;
		private IfcDirectionSenseEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDirectionSenseEnum POSITIVE = new IfcDirectionSenseEnum( "POSITIVE" );
		public static readonly IfcDirectionSenseEnum NEGATIVE = new IfcDirectionSenseEnum( "NEGATIVE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDistributionChamberElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDistributionChamberElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDistributionChamberElementTypeEnum FORMEDDUCT = new IfcDistributionChamberElementTypeEnum( "FORMEDDUCT" );
		public static readonly IfcDistributionChamberElementTypeEnum INSPECTIONCHAMBER = new IfcDistributionChamberElementTypeEnum( "INSPECTIONCHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum INSPECTIONPIT = new IfcDistributionChamberElementTypeEnum( "INSPECTIONPIT" );
		public static readonly IfcDistributionChamberElementTypeEnum MANHOLE = new IfcDistributionChamberElementTypeEnum( "MANHOLE" );
		public static readonly IfcDistributionChamberElementTypeEnum METERCHAMBER = new IfcDistributionChamberElementTypeEnum( "METERCHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum SUMP = new IfcDistributionChamberElementTypeEnum( "SUMP" );
		public static readonly IfcDistributionChamberElementTypeEnum TRENCH = new IfcDistributionChamberElementTypeEnum( "TRENCH" );
		public static readonly IfcDistributionChamberElementTypeEnum VALVECHAMBER = new IfcDistributionChamberElementTypeEnum( "VALVECHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum USERDEFINED = new IfcDistributionChamberElementTypeEnum( "USERDEFINED" );
		public static readonly IfcDistributionChamberElementTypeEnum NOTDEFINED = new IfcDistributionChamberElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDocumentConfidentialityEnum : BaseType
	{
	private readonly string ename;
		private IfcDocumentConfidentialityEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDocumentConfidentialityEnum PUBLIC = new IfcDocumentConfidentialityEnum( "PUBLIC" );
		public static readonly IfcDocumentConfidentialityEnum RESTRICTED = new IfcDocumentConfidentialityEnum( "RESTRICTED" );
		public static readonly IfcDocumentConfidentialityEnum CONFIDENTIAL = new IfcDocumentConfidentialityEnum( "CONFIDENTIAL" );
		public static readonly IfcDocumentConfidentialityEnum PERSONAL = new IfcDocumentConfidentialityEnum( "PERSONAL" );
		public static readonly IfcDocumentConfidentialityEnum USERDEFINED = new IfcDocumentConfidentialityEnum( "USERDEFINED" );
		public static readonly IfcDocumentConfidentialityEnum NOTDEFINED = new IfcDocumentConfidentialityEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDocumentStatusEnum : BaseType
	{
	private readonly string ename;
		private IfcDocumentStatusEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDocumentStatusEnum DRAFT = new IfcDocumentStatusEnum( "DRAFT" );
		public static readonly IfcDocumentStatusEnum FINALDRAFT = new IfcDocumentStatusEnum( "FINALDRAFT" );
		public static readonly IfcDocumentStatusEnum FINAL = new IfcDocumentStatusEnum( "FINAL" );
		public static readonly IfcDocumentStatusEnum REVISION = new IfcDocumentStatusEnum( "REVISION" );
		public static readonly IfcDocumentStatusEnum NOTDEFINED = new IfcDocumentStatusEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorPanelOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorPanelOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorPanelOperationEnum SWINGING = new IfcDoorPanelOperationEnum( "SWINGING" );
		public static readonly IfcDoorPanelOperationEnum DOUBLE_ACTING = new IfcDoorPanelOperationEnum( "DOUBLE_ACTING" );
		public static readonly IfcDoorPanelOperationEnum SLIDING = new IfcDoorPanelOperationEnum( "SLIDING" );
		public static readonly IfcDoorPanelOperationEnum FOLDING = new IfcDoorPanelOperationEnum( "FOLDING" );
		public static readonly IfcDoorPanelOperationEnum REVOLVING = new IfcDoorPanelOperationEnum( "REVOLVING" );
		public static readonly IfcDoorPanelOperationEnum ROLLINGUP = new IfcDoorPanelOperationEnum( "ROLLINGUP" );
		public static readonly IfcDoorPanelOperationEnum USERDEFINED = new IfcDoorPanelOperationEnum( "USERDEFINED" );
		public static readonly IfcDoorPanelOperationEnum NOTDEFINED = new IfcDoorPanelOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorPanelPositionEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorPanelPositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorPanelPositionEnum LEFT = new IfcDoorPanelPositionEnum( "LEFT" );
		public static readonly IfcDoorPanelPositionEnum MIDDLE = new IfcDoorPanelPositionEnum( "MIDDLE" );
		public static readonly IfcDoorPanelPositionEnum RIGHT = new IfcDoorPanelPositionEnum( "RIGHT" );
		public static readonly IfcDoorPanelPositionEnum NOTDEFINED = new IfcDoorPanelPositionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorStyleConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorStyleConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM = new IfcDoorStyleConstructionEnum( "ALUMINIUM" );
		public static readonly IfcDoorStyleConstructionEnum HIGH_GRADE_STEEL = new IfcDoorStyleConstructionEnum( "HIGH_GRADE_STEEL" );
		public static readonly IfcDoorStyleConstructionEnum STEEL = new IfcDoorStyleConstructionEnum( "STEEL" );
		public static readonly IfcDoorStyleConstructionEnum WOOD = new IfcDoorStyleConstructionEnum( "WOOD" );
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM_WOOD = new IfcDoorStyleConstructionEnum( "ALUMINIUM_WOOD" );
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM_PLASTIC = new IfcDoorStyleConstructionEnum( "ALUMINIUM_PLASTIC" );
		public static readonly IfcDoorStyleConstructionEnum PLASTIC = new IfcDoorStyleConstructionEnum( "PLASTIC" );
		public static readonly IfcDoorStyleConstructionEnum USERDEFINED = new IfcDoorStyleConstructionEnum( "USERDEFINED" );
		public static readonly IfcDoorStyleConstructionEnum NOTDEFINED = new IfcDoorStyleConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorStyleOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorStyleOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorStyleOperationEnum SINGLE_SWING_LEFT = new IfcDoorStyleOperationEnum( "SINGLE_SWING_LEFT" );
		public static readonly IfcDoorStyleOperationEnum SINGLE_SWING_RIGHT = new IfcDoorStyleOperationEnum( "SINGLE_SWING_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_SWING_LEFT = new IfcDoorStyleOperationEnum( "DOUBLE_SWING_LEFT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_SWING_RIGHT = new IfcDoorStyleOperationEnum( "DOUBLE_SWING_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_DOUBLE_SWING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_DOUBLE_SWING" );
		public static readonly IfcDoorStyleOperationEnum SLIDING_TO_LEFT = new IfcDoorStyleOperationEnum( "SLIDING_TO_LEFT" );
		public static readonly IfcDoorStyleOperationEnum SLIDING_TO_RIGHT = new IfcDoorStyleOperationEnum( "SLIDING_TO_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SLIDING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SLIDING" );
		public static readonly IfcDoorStyleOperationEnum FOLDING_TO_LEFT = new IfcDoorStyleOperationEnum( "FOLDING_TO_LEFT" );
		public static readonly IfcDoorStyleOperationEnum FOLDING_TO_RIGHT = new IfcDoorStyleOperationEnum( "FOLDING_TO_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_FOLDING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_FOLDING" );
		public static readonly IfcDoorStyleOperationEnum REVOLVING = new IfcDoorStyleOperationEnum( "REVOLVING" );
		public static readonly IfcDoorStyleOperationEnum ROLLINGUP = new IfcDoorStyleOperationEnum( "ROLLINGUP" );
		public static readonly IfcDoorStyleOperationEnum USERDEFINED = new IfcDoorStyleOperationEnum( "USERDEFINED" );
		public static readonly IfcDoorStyleOperationEnum NOTDEFINED = new IfcDoorStyleOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctFittingTypeEnum BEND = new IfcDuctFittingTypeEnum( "BEND" );
		public static readonly IfcDuctFittingTypeEnum CONNECTOR = new IfcDuctFittingTypeEnum( "CONNECTOR" );
		public static readonly IfcDuctFittingTypeEnum ENTRY = new IfcDuctFittingTypeEnum( "ENTRY" );
		public static readonly IfcDuctFittingTypeEnum EXIT = new IfcDuctFittingTypeEnum( "EXIT" );
		public static readonly IfcDuctFittingTypeEnum JUNCTION = new IfcDuctFittingTypeEnum( "JUNCTION" );
		public static readonly IfcDuctFittingTypeEnum OBSTRUCTION = new IfcDuctFittingTypeEnum( "OBSTRUCTION" );
		public static readonly IfcDuctFittingTypeEnum TRANSITION = new IfcDuctFittingTypeEnum( "TRANSITION" );
		public static readonly IfcDuctFittingTypeEnum USERDEFINED = new IfcDuctFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctFittingTypeEnum NOTDEFINED = new IfcDuctFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctSegmentTypeEnum RIGIDSEGMENT = new IfcDuctSegmentTypeEnum( "RIGIDSEGMENT" );
		public static readonly IfcDuctSegmentTypeEnum FLEXIBLESEGMENT = new IfcDuctSegmentTypeEnum( "FLEXIBLESEGMENT" );
		public static readonly IfcDuctSegmentTypeEnum USERDEFINED = new IfcDuctSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctSegmentTypeEnum NOTDEFINED = new IfcDuctSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctSilencerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctSilencerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctSilencerTypeEnum FLATOVAL = new IfcDuctSilencerTypeEnum( "FLATOVAL" );
		public static readonly IfcDuctSilencerTypeEnum RECTANGULAR = new IfcDuctSilencerTypeEnum( "RECTANGULAR" );
		public static readonly IfcDuctSilencerTypeEnum ROUND = new IfcDuctSilencerTypeEnum( "ROUND" );
		public static readonly IfcDuctSilencerTypeEnum USERDEFINED = new IfcDuctSilencerTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctSilencerTypeEnum NOTDEFINED = new IfcDuctSilencerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricApplianceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricApplianceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricApplianceTypeEnum COMPUTER = new IfcElectricApplianceTypeEnum( "COMPUTER" );
		public static readonly IfcElectricApplianceTypeEnum DIRECTWATERHEATER = new IfcElectricApplianceTypeEnum( "DIRECTWATERHEATER" );
		public static readonly IfcElectricApplianceTypeEnum DISHWASHER = new IfcElectricApplianceTypeEnum( "DISHWASHER" );
		public static readonly IfcElectricApplianceTypeEnum ELECTRICCOOKER = new IfcElectricApplianceTypeEnum( "ELECTRICCOOKER" );
		public static readonly IfcElectricApplianceTypeEnum ELECTRICHEATER = new IfcElectricApplianceTypeEnum( "ELECTRICHEATER" );
		public static readonly IfcElectricApplianceTypeEnum FACSIMILE = new IfcElectricApplianceTypeEnum( "FACSIMILE" );
		public static readonly IfcElectricApplianceTypeEnum FREESTANDINGFAN = new IfcElectricApplianceTypeEnum( "FREESTANDINGFAN" );
		public static readonly IfcElectricApplianceTypeEnum FREEZER = new IfcElectricApplianceTypeEnum( "FREEZER" );
		public static readonly IfcElectricApplianceTypeEnum FRIDGE_FREEZER = new IfcElectricApplianceTypeEnum( "FRIDGE_FREEZER" );
		public static readonly IfcElectricApplianceTypeEnum HANDDRYER = new IfcElectricApplianceTypeEnum( "HANDDRYER" );
		public static readonly IfcElectricApplianceTypeEnum INDIRECTWATERHEATER = new IfcElectricApplianceTypeEnum( "INDIRECTWATERHEATER" );
		public static readonly IfcElectricApplianceTypeEnum MICROWAVE = new IfcElectricApplianceTypeEnum( "MICROWAVE" );
		public static readonly IfcElectricApplianceTypeEnum PHOTOCOPIER = new IfcElectricApplianceTypeEnum( "PHOTOCOPIER" );
		public static readonly IfcElectricApplianceTypeEnum PRINTER = new IfcElectricApplianceTypeEnum( "PRINTER" );
		public static readonly IfcElectricApplianceTypeEnum REFRIGERATOR = new IfcElectricApplianceTypeEnum( "REFRIGERATOR" );
		public static readonly IfcElectricApplianceTypeEnum RADIANTHEATER = new IfcElectricApplianceTypeEnum( "RADIANTHEATER" );
		public static readonly IfcElectricApplianceTypeEnum SCANNER = new IfcElectricApplianceTypeEnum( "SCANNER" );
		public static readonly IfcElectricApplianceTypeEnum TELEPHONE = new IfcElectricApplianceTypeEnum( "TELEPHONE" );
		public static readonly IfcElectricApplianceTypeEnum TUMBLEDRYER = new IfcElectricApplianceTypeEnum( "TUMBLEDRYER" );
		public static readonly IfcElectricApplianceTypeEnum TV = new IfcElectricApplianceTypeEnum( "TV" );
		public static readonly IfcElectricApplianceTypeEnum VENDINGMACHINE = new IfcElectricApplianceTypeEnum( "VENDINGMACHINE" );
		public static readonly IfcElectricApplianceTypeEnum WASHINGMACHINE = new IfcElectricApplianceTypeEnum( "WASHINGMACHINE" );
		public static readonly IfcElectricApplianceTypeEnum WATERHEATER = new IfcElectricApplianceTypeEnum( "WATERHEATER" );
		public static readonly IfcElectricApplianceTypeEnum WATERCOOLER = new IfcElectricApplianceTypeEnum( "WATERCOOLER" );
		public static readonly IfcElectricApplianceTypeEnum USERDEFINED = new IfcElectricApplianceTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricApplianceTypeEnum NOTDEFINED = new IfcElectricApplianceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricCurrentEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricCurrentEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricCurrentEnum ALTERNATING = new IfcElectricCurrentEnum( "ALTERNATING" );
		public static readonly IfcElectricCurrentEnum DIRECT = new IfcElectricCurrentEnum( "DIRECT" );
		public static readonly IfcElectricCurrentEnum NOTDEFINED = new IfcElectricCurrentEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricDistributionPointFunctionEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricDistributionPointFunctionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricDistributionPointFunctionEnum ALARMPANEL = new IfcElectricDistributionPointFunctionEnum( "ALARMPANEL" );
		public static readonly IfcElectricDistributionPointFunctionEnum CONSUMERUNIT = new IfcElectricDistributionPointFunctionEnum( "CONSUMERUNIT" );
		public static readonly IfcElectricDistributionPointFunctionEnum CONTROLPANEL = new IfcElectricDistributionPointFunctionEnum( "CONTROLPANEL" );
		public static readonly IfcElectricDistributionPointFunctionEnum DISTRIBUTIONBOARD = new IfcElectricDistributionPointFunctionEnum( "DISTRIBUTIONBOARD" );
		public static readonly IfcElectricDistributionPointFunctionEnum GASDETECTORPANEL = new IfcElectricDistributionPointFunctionEnum( "GASDETECTORPANEL" );
		public static readonly IfcElectricDistributionPointFunctionEnum INDICATORPANEL = new IfcElectricDistributionPointFunctionEnum( "INDICATORPANEL" );
		public static readonly IfcElectricDistributionPointFunctionEnum MIMICPANEL = new IfcElectricDistributionPointFunctionEnum( "MIMICPANEL" );
		public static readonly IfcElectricDistributionPointFunctionEnum MOTORCONTROLCENTRE = new IfcElectricDistributionPointFunctionEnum( "MOTORCONTROLCENTRE" );
		public static readonly IfcElectricDistributionPointFunctionEnum SWITCHBOARD = new IfcElectricDistributionPointFunctionEnum( "SWITCHBOARD" );
		public static readonly IfcElectricDistributionPointFunctionEnum USERDEFINED = new IfcElectricDistributionPointFunctionEnum( "USERDEFINED" );
		public static readonly IfcElectricDistributionPointFunctionEnum NOTDEFINED = new IfcElectricDistributionPointFunctionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricFlowStorageDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricFlowStorageDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricFlowStorageDeviceTypeEnum BATTERY = new IfcElectricFlowStorageDeviceTypeEnum( "BATTERY" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum CAPACITORBANK = new IfcElectricFlowStorageDeviceTypeEnum( "CAPACITORBANK" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum HARMONICFILTER = new IfcElectricFlowStorageDeviceTypeEnum( "HARMONICFILTER" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum INDUCTORBANK = new IfcElectricFlowStorageDeviceTypeEnum( "INDUCTORBANK" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum UPS = new IfcElectricFlowStorageDeviceTypeEnum( "UPS" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum USERDEFINED = new IfcElectricFlowStorageDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum NOTDEFINED = new IfcElectricFlowStorageDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricGeneratorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricGeneratorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricGeneratorTypeEnum USERDEFINED = new IfcElectricGeneratorTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricGeneratorTypeEnum NOTDEFINED = new IfcElectricGeneratorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricHeaterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricHeaterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricHeaterTypeEnum ELECTRICPOINTHEATER = new IfcElectricHeaterTypeEnum( "ELECTRICPOINTHEATER" );
		public static readonly IfcElectricHeaterTypeEnum ELECTRICCABLEHEATER = new IfcElectricHeaterTypeEnum( "ELECTRICCABLEHEATER" );
		public static readonly IfcElectricHeaterTypeEnum ELECTRICMATHEATER = new IfcElectricHeaterTypeEnum( "ELECTRICMATHEATER" );
		public static readonly IfcElectricHeaterTypeEnum USERDEFINED = new IfcElectricHeaterTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricHeaterTypeEnum NOTDEFINED = new IfcElectricHeaterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricMotorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricMotorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricMotorTypeEnum DC = new IfcElectricMotorTypeEnum( "DC" );
		public static readonly IfcElectricMotorTypeEnum INDUCTION = new IfcElectricMotorTypeEnum( "INDUCTION" );
		public static readonly IfcElectricMotorTypeEnum POLYPHASE = new IfcElectricMotorTypeEnum( "POLYPHASE" );
		public static readonly IfcElectricMotorTypeEnum RELUCTANCESYNCHRONOUS = new IfcElectricMotorTypeEnum( "RELUCTANCESYNCHRONOUS" );
		public static readonly IfcElectricMotorTypeEnum SYNCHRONOUS = new IfcElectricMotorTypeEnum( "SYNCHRONOUS" );
		public static readonly IfcElectricMotorTypeEnum USERDEFINED = new IfcElectricMotorTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricMotorTypeEnum NOTDEFINED = new IfcElectricMotorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricTimeControlTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricTimeControlTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricTimeControlTypeEnum TIMECLOCK = new IfcElectricTimeControlTypeEnum( "TIMECLOCK" );
		public static readonly IfcElectricTimeControlTypeEnum TIMEDELAY = new IfcElectricTimeControlTypeEnum( "TIMEDELAY" );
		public static readonly IfcElectricTimeControlTypeEnum RELAY = new IfcElectricTimeControlTypeEnum( "RELAY" );
		public static readonly IfcElectricTimeControlTypeEnum USERDEFINED = new IfcElectricTimeControlTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricTimeControlTypeEnum NOTDEFINED = new IfcElectricTimeControlTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElementAssemblyTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElementAssemblyTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElementAssemblyTypeEnum ACCESSORY_ASSEMBLY = new IfcElementAssemblyTypeEnum( "ACCESSORY_ASSEMBLY" );
		public static readonly IfcElementAssemblyTypeEnum ARCH = new IfcElementAssemblyTypeEnum( "ARCH" );
		public static readonly IfcElementAssemblyTypeEnum BEAM_GRID = new IfcElementAssemblyTypeEnum( "BEAM_GRID" );
		public static readonly IfcElementAssemblyTypeEnum BRACED_FRAME = new IfcElementAssemblyTypeEnum( "BRACED_FRAME" );
		public static readonly IfcElementAssemblyTypeEnum GIRDER = new IfcElementAssemblyTypeEnum( "GIRDER" );
		public static readonly IfcElementAssemblyTypeEnum REINFORCEMENT_UNIT = new IfcElementAssemblyTypeEnum( "REINFORCEMENT_UNIT" );
		public static readonly IfcElementAssemblyTypeEnum RIGID_FRAME = new IfcElementAssemblyTypeEnum( "RIGID_FRAME" );
		public static readonly IfcElementAssemblyTypeEnum SLAB_FIELD = new IfcElementAssemblyTypeEnum( "SLAB_FIELD" );
		public static readonly IfcElementAssemblyTypeEnum TRUSS = new IfcElementAssemblyTypeEnum( "TRUSS" );
		public static readonly IfcElementAssemblyTypeEnum USERDEFINED = new IfcElementAssemblyTypeEnum( "USERDEFINED" );
		public static readonly IfcElementAssemblyTypeEnum NOTDEFINED = new IfcElementAssemblyTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElementCompositionEnum : BaseType
	{
	private readonly string ename;
		private IfcElementCompositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElementCompositionEnum COMPLEX = new IfcElementCompositionEnum( "COMPLEX" );
		public static readonly IfcElementCompositionEnum ELEMENT = new IfcElementCompositionEnum( "ELEMENT" );
		public static readonly IfcElementCompositionEnum PARTIAL = new IfcElementCompositionEnum( "PARTIAL" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEnergySequenceEnum : BaseType
	{
	private readonly string ename;
		private IfcEnergySequenceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEnergySequenceEnum PRIMARY = new IfcEnergySequenceEnum( "PRIMARY" );
		public static readonly IfcEnergySequenceEnum SECONDARY = new IfcEnergySequenceEnum( "SECONDARY" );
		public static readonly IfcEnergySequenceEnum TERTIARY = new IfcEnergySequenceEnum( "TERTIARY" );
		public static readonly IfcEnergySequenceEnum AUXILIARY = new IfcEnergySequenceEnum( "AUXILIARY" );
		public static readonly IfcEnergySequenceEnum USERDEFINED = new IfcEnergySequenceEnum( "USERDEFINED" );
		public static readonly IfcEnergySequenceEnum NOTDEFINED = new IfcEnergySequenceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEnvironmentalImpactCategoryEnum : BaseType
	{
	private readonly string ename;
		private IfcEnvironmentalImpactCategoryEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEnvironmentalImpactCategoryEnum COMBINEDVALUE = new IfcEnvironmentalImpactCategoryEnum( "COMBINEDVALUE" );
		public static readonly IfcEnvironmentalImpactCategoryEnum DISPOSAL = new IfcEnvironmentalImpactCategoryEnum( "DISPOSAL" );
		public static readonly IfcEnvironmentalImpactCategoryEnum EXTRACTION = new IfcEnvironmentalImpactCategoryEnum( "EXTRACTION" );
		public static readonly IfcEnvironmentalImpactCategoryEnum INSTALLATION = new IfcEnvironmentalImpactCategoryEnum( "INSTALLATION" );
		public static readonly IfcEnvironmentalImpactCategoryEnum MANUFACTURE = new IfcEnvironmentalImpactCategoryEnum( "MANUFACTURE" );
		public static readonly IfcEnvironmentalImpactCategoryEnum TRANSPORTATION = new IfcEnvironmentalImpactCategoryEnum( "TRANSPORTATION" );
		public static readonly IfcEnvironmentalImpactCategoryEnum USERDEFINED = new IfcEnvironmentalImpactCategoryEnum( "USERDEFINED" );
		public static readonly IfcEnvironmentalImpactCategoryEnum NOTDEFINED = new IfcEnvironmentalImpactCategoryEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEvaporativeCoolerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEvaporativeCoolerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVEAIRWASHER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVEAIRWASHER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVEPACKAGEAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVEPACKAGEAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVEWETCOIL = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVEWETCOIL" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTDIRECTCOMBINATION = new IfcEvaporativeCoolerTypeEnum( "INDIRECTDIRECTCOMBINATION" );
		public static readonly IfcEvaporativeCoolerTypeEnum USERDEFINED = new IfcEvaporativeCoolerTypeEnum( "USERDEFINED" );
		public static readonly IfcEvaporativeCoolerTypeEnum NOTDEFINED = new IfcEvaporativeCoolerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEvaporatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEvaporatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONSHELLANDTUBE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONSHELLANDTUBE" );
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONTUBEINTUBE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONTUBEINTUBE" );
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONBRAZEDPLATE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONBRAZEDPLATE" );
		public static readonly IfcEvaporatorTypeEnum FLOODEDSHELLANDTUBE = new IfcEvaporatorTypeEnum( "FLOODEDSHELLANDTUBE" );
		public static readonly IfcEvaporatorTypeEnum SHELLANDCOIL = new IfcEvaporatorTypeEnum( "SHELLANDCOIL" );
		public static readonly IfcEvaporatorTypeEnum USERDEFINED = new IfcEvaporatorTypeEnum( "USERDEFINED" );
		public static readonly IfcEvaporatorTypeEnum NOTDEFINED = new IfcEvaporatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFanTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFanTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFanTypeEnum CENTRIFUGALFORWARDCURVED = new IfcFanTypeEnum( "CENTRIFUGALFORWARDCURVED" );
		public static readonly IfcFanTypeEnum CENTRIFUGALRADIAL = new IfcFanTypeEnum( "CENTRIFUGALRADIAL" );
		public static readonly IfcFanTypeEnum CENTRIFUGALBACKWARDINCLINEDCURVED = new IfcFanTypeEnum( "CENTRIFUGALBACKWARDINCLINEDCURVED" );
		public static readonly IfcFanTypeEnum CENTRIFUGALAIRFOIL = new IfcFanTypeEnum( "CENTRIFUGALAIRFOIL" );
		public static readonly IfcFanTypeEnum TUBEAXIAL = new IfcFanTypeEnum( "TUBEAXIAL" );
		public static readonly IfcFanTypeEnum VANEAXIAL = new IfcFanTypeEnum( "VANEAXIAL" );
		public static readonly IfcFanTypeEnum PROPELLORAXIAL = new IfcFanTypeEnum( "PROPELLORAXIAL" );
		public static readonly IfcFanTypeEnum USERDEFINED = new IfcFanTypeEnum( "USERDEFINED" );
		public static readonly IfcFanTypeEnum NOTDEFINED = new IfcFanTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFilterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFilterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFilterTypeEnum AIRPARTICLEFILTER = new IfcFilterTypeEnum( "AIRPARTICLEFILTER" );
		public static readonly IfcFilterTypeEnum ODORFILTER = new IfcFilterTypeEnum( "ODORFILTER" );
		public static readonly IfcFilterTypeEnum OILFILTER = new IfcFilterTypeEnum( "OILFILTER" );
		public static readonly IfcFilterTypeEnum STRAINER = new IfcFilterTypeEnum( "STRAINER" );
		public static readonly IfcFilterTypeEnum WATERFILTER = new IfcFilterTypeEnum( "WATERFILTER" );
		public static readonly IfcFilterTypeEnum USERDEFINED = new IfcFilterTypeEnum( "USERDEFINED" );
		public static readonly IfcFilterTypeEnum NOTDEFINED = new IfcFilterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFireSuppressionTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFireSuppressionTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFireSuppressionTerminalTypeEnum BREECHINGINLET = new IfcFireSuppressionTerminalTypeEnum( "BREECHINGINLET" );
		public static readonly IfcFireSuppressionTerminalTypeEnum FIREHYDRANT = new IfcFireSuppressionTerminalTypeEnum( "FIREHYDRANT" );
		public static readonly IfcFireSuppressionTerminalTypeEnum HOSEREEL = new IfcFireSuppressionTerminalTypeEnum( "HOSEREEL" );
		public static readonly IfcFireSuppressionTerminalTypeEnum SPRINKLER = new IfcFireSuppressionTerminalTypeEnum( "SPRINKLER" );
		public static readonly IfcFireSuppressionTerminalTypeEnum SPRINKLERDEFLECTOR = new IfcFireSuppressionTerminalTypeEnum( "SPRINKLERDEFLECTOR" );
		public static readonly IfcFireSuppressionTerminalTypeEnum USERDEFINED = new IfcFireSuppressionTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcFireSuppressionTerminalTypeEnum NOTDEFINED = new IfcFireSuppressionTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowDirectionEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowDirectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowDirectionEnum SOURCE = new IfcFlowDirectionEnum( "SOURCE" );
		public static readonly IfcFlowDirectionEnum SINK = new IfcFlowDirectionEnum( "SINK" );
		public static readonly IfcFlowDirectionEnum SOURCEANDSINK = new IfcFlowDirectionEnum( "SOURCEANDSINK" );
		public static readonly IfcFlowDirectionEnum NOTDEFINED = new IfcFlowDirectionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowInstrumentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowInstrumentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowInstrumentTypeEnum PRESSUREGAUGE = new IfcFlowInstrumentTypeEnum( "PRESSUREGAUGE" );
		public static readonly IfcFlowInstrumentTypeEnum THERMOMETER = new IfcFlowInstrumentTypeEnum( "THERMOMETER" );
		public static readonly IfcFlowInstrumentTypeEnum AMMETER = new IfcFlowInstrumentTypeEnum( "AMMETER" );
		public static readonly IfcFlowInstrumentTypeEnum FREQUENCYMETER = new IfcFlowInstrumentTypeEnum( "FREQUENCYMETER" );
		public static readonly IfcFlowInstrumentTypeEnum POWERFACTORMETER = new IfcFlowInstrumentTypeEnum( "POWERFACTORMETER" );
		public static readonly IfcFlowInstrumentTypeEnum PHASEANGLEMETER = new IfcFlowInstrumentTypeEnum( "PHASEANGLEMETER" );
		public static readonly IfcFlowInstrumentTypeEnum VOLTMETER_PEAK = new IfcFlowInstrumentTypeEnum( "VOLTMETER_PEAK" );
		public static readonly IfcFlowInstrumentTypeEnum VOLTMETER_RMS = new IfcFlowInstrumentTypeEnum( "VOLTMETER_RMS" );
		public static readonly IfcFlowInstrumentTypeEnum USERDEFINED = new IfcFlowInstrumentTypeEnum( "USERDEFINED" );
		public static readonly IfcFlowInstrumentTypeEnum NOTDEFINED = new IfcFlowInstrumentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowMeterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowMeterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowMeterTypeEnum ELECTRICMETER = new IfcFlowMeterTypeEnum( "ELECTRICMETER" );
		public static readonly IfcFlowMeterTypeEnum ENERGYMETER = new IfcFlowMeterTypeEnum( "ENERGYMETER" );
		public static readonly IfcFlowMeterTypeEnum FLOWMETER = new IfcFlowMeterTypeEnum( "FLOWMETER" );
		public static readonly IfcFlowMeterTypeEnum GASMETER = new IfcFlowMeterTypeEnum( "GASMETER" );
		public static readonly IfcFlowMeterTypeEnum OILMETER = new IfcFlowMeterTypeEnum( "OILMETER" );
		public static readonly IfcFlowMeterTypeEnum WATERMETER = new IfcFlowMeterTypeEnum( "WATERMETER" );
		public static readonly IfcFlowMeterTypeEnum USERDEFINED = new IfcFlowMeterTypeEnum( "USERDEFINED" );
		public static readonly IfcFlowMeterTypeEnum NOTDEFINED = new IfcFlowMeterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFootingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFootingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFootingTypeEnum FOOTING_BEAM = new IfcFootingTypeEnum( "FOOTING_BEAM" );
		public static readonly IfcFootingTypeEnum PAD_FOOTING = new IfcFootingTypeEnum( "PAD_FOOTING" );
		public static readonly IfcFootingTypeEnum PILE_CAP = new IfcFootingTypeEnum( "PILE_CAP" );
		public static readonly IfcFootingTypeEnum STRIP_FOOTING = new IfcFootingTypeEnum( "STRIP_FOOTING" );
		public static readonly IfcFootingTypeEnum USERDEFINED = new IfcFootingTypeEnum( "USERDEFINED" );
		public static readonly IfcFootingTypeEnum NOTDEFINED = new IfcFootingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGasTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcGasTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGasTerminalTypeEnum GASAPPLIANCE = new IfcGasTerminalTypeEnum( "GASAPPLIANCE" );
		public static readonly IfcGasTerminalTypeEnum GASBOOSTER = new IfcGasTerminalTypeEnum( "GASBOOSTER" );
		public static readonly IfcGasTerminalTypeEnum GASBURNER = new IfcGasTerminalTypeEnum( "GASBURNER" );
		public static readonly IfcGasTerminalTypeEnum USERDEFINED = new IfcGasTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcGasTerminalTypeEnum NOTDEFINED = new IfcGasTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGeometricProjectionEnum : BaseType
	{
	private readonly string ename;
		private IfcGeometricProjectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGeometricProjectionEnum GRAPH_VIEW = new IfcGeometricProjectionEnum( "GRAPH_VIEW" );
		public static readonly IfcGeometricProjectionEnum SKETCH_VIEW = new IfcGeometricProjectionEnum( "SKETCH_VIEW" );
		public static readonly IfcGeometricProjectionEnum MODEL_VIEW = new IfcGeometricProjectionEnum( "MODEL_VIEW" );
		public static readonly IfcGeometricProjectionEnum PLAN_VIEW = new IfcGeometricProjectionEnum( "PLAN_VIEW" );
		public static readonly IfcGeometricProjectionEnum REFLECTED_PLAN_VIEW = new IfcGeometricProjectionEnum( "REFLECTED_PLAN_VIEW" );
		public static readonly IfcGeometricProjectionEnum SECTION_VIEW = new IfcGeometricProjectionEnum( "SECTION_VIEW" );
		public static readonly IfcGeometricProjectionEnum ELEVATION_VIEW = new IfcGeometricProjectionEnum( "ELEVATION_VIEW" );
		public static readonly IfcGeometricProjectionEnum USERDEFINED = new IfcGeometricProjectionEnum( "USERDEFINED" );
		public static readonly IfcGeometricProjectionEnum NOTDEFINED = new IfcGeometricProjectionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGlobalOrLocalEnum : BaseType
	{
	private readonly string ename;
		private IfcGlobalOrLocalEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGlobalOrLocalEnum GLOBAL_COORDS = new IfcGlobalOrLocalEnum( "GLOBAL_COORDS" );
		public static readonly IfcGlobalOrLocalEnum LOCAL_COORDS = new IfcGlobalOrLocalEnum( "LOCAL_COORDS" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcHeatExchangerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcHeatExchangerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcHeatExchangerTypeEnum PLATE = new IfcHeatExchangerTypeEnum( "PLATE" );
		public static readonly IfcHeatExchangerTypeEnum SHELLANDTUBE = new IfcHeatExchangerTypeEnum( "SHELLANDTUBE" );
		public static readonly IfcHeatExchangerTypeEnum USERDEFINED = new IfcHeatExchangerTypeEnum( "USERDEFINED" );
		public static readonly IfcHeatExchangerTypeEnum NOTDEFINED = new IfcHeatExchangerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcHumidifierTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcHumidifierTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcHumidifierTypeEnum STEAMINJECTION = new IfcHumidifierTypeEnum( "STEAMINJECTION" );
		public static readonly IfcHumidifierTypeEnum ADIABATICAIRWASHER = new IfcHumidifierTypeEnum( "ADIABATICAIRWASHER" );
		public static readonly IfcHumidifierTypeEnum ADIABATICPAN = new IfcHumidifierTypeEnum( "ADIABATICPAN" );
		public static readonly IfcHumidifierTypeEnum ADIABATICWETTEDELEMENT = new IfcHumidifierTypeEnum( "ADIABATICWETTEDELEMENT" );
		public static readonly IfcHumidifierTypeEnum ADIABATICATOMIZING = new IfcHumidifierTypeEnum( "ADIABATICATOMIZING" );
		public static readonly IfcHumidifierTypeEnum ADIABATICULTRASONIC = new IfcHumidifierTypeEnum( "ADIABATICULTRASONIC" );
		public static readonly IfcHumidifierTypeEnum ADIABATICRIGIDMEDIA = new IfcHumidifierTypeEnum( "ADIABATICRIGIDMEDIA" );
		public static readonly IfcHumidifierTypeEnum ADIABATICCOMPRESSEDAIRNOZZLE = new IfcHumidifierTypeEnum( "ADIABATICCOMPRESSEDAIRNOZZLE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDELECTRIC = new IfcHumidifierTypeEnum( "ASSISTEDELECTRIC" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDNATURALGAS = new IfcHumidifierTypeEnum( "ASSISTEDNATURALGAS" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDPROPANE = new IfcHumidifierTypeEnum( "ASSISTEDPROPANE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDBUTANE = new IfcHumidifierTypeEnum( "ASSISTEDBUTANE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDSTEAM = new IfcHumidifierTypeEnum( "ASSISTEDSTEAM" );
		public static readonly IfcHumidifierTypeEnum USERDEFINED = new IfcHumidifierTypeEnum( "USERDEFINED" );
		public static readonly IfcHumidifierTypeEnum NOTDEFINED = new IfcHumidifierTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcInternalOrExternalEnum : BaseType
	{
	private readonly string ename;
		private IfcInternalOrExternalEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcInternalOrExternalEnum INTERNAL = new IfcInternalOrExternalEnum( "INTERNAL" );
		public static readonly IfcInternalOrExternalEnum EXTERNAL = new IfcInternalOrExternalEnum( "EXTERNAL" );
		public static readonly IfcInternalOrExternalEnum NOTDEFINED = new IfcInternalOrExternalEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcInventoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcInventoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcInventoryTypeEnum ASSETINVENTORY = new IfcInventoryTypeEnum( "ASSETINVENTORY" );
		public static readonly IfcInventoryTypeEnum SPACEINVENTORY = new IfcInventoryTypeEnum( "SPACEINVENTORY" );
		public static readonly IfcInventoryTypeEnum FURNITUREINVENTORY = new IfcInventoryTypeEnum( "FURNITUREINVENTORY" );
		public static readonly IfcInventoryTypeEnum USERDEFINED = new IfcInventoryTypeEnum( "USERDEFINED" );
		public static readonly IfcInventoryTypeEnum NOTDEFINED = new IfcInventoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcJunctionBoxTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcJunctionBoxTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcJunctionBoxTypeEnum USERDEFINED = new IfcJunctionBoxTypeEnum( "USERDEFINED" );
		public static readonly IfcJunctionBoxTypeEnum NOTDEFINED = new IfcJunctionBoxTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLampTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLampTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLampTypeEnum COMPACTFLUORESCENT = new IfcLampTypeEnum( "COMPACTFLUORESCENT" );
		public static readonly IfcLampTypeEnum FLUORESCENT = new IfcLampTypeEnum( "FLUORESCENT" );
		public static readonly IfcLampTypeEnum HIGHPRESSUREMERCURY = new IfcLampTypeEnum( "HIGHPRESSUREMERCURY" );
		public static readonly IfcLampTypeEnum HIGHPRESSURESODIUM = new IfcLampTypeEnum( "HIGHPRESSURESODIUM" );
		public static readonly IfcLampTypeEnum METALHALIDE = new IfcLampTypeEnum( "METALHALIDE" );
		public static readonly IfcLampTypeEnum TUNGSTENFILAMENT = new IfcLampTypeEnum( "TUNGSTENFILAMENT" );
		public static readonly IfcLampTypeEnum USERDEFINED = new IfcLampTypeEnum( "USERDEFINED" );
		public static readonly IfcLampTypeEnum NOTDEFINED = new IfcLampTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLayerSetDirectionEnum : BaseType
	{
	private readonly string ename;
		private IfcLayerSetDirectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLayerSetDirectionEnum AXIS1 = new IfcLayerSetDirectionEnum( "AXIS1" );
		public static readonly IfcLayerSetDirectionEnum AXIS2 = new IfcLayerSetDirectionEnum( "AXIS2" );
		public static readonly IfcLayerSetDirectionEnum AXIS3 = new IfcLayerSetDirectionEnum( "AXIS3" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightDistributionCurveEnum : BaseType
	{
	private readonly string ename;
		private IfcLightDistributionCurveEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightDistributionCurveEnum TYPE_A = new IfcLightDistributionCurveEnum( "TYPE_A" );
		public static readonly IfcLightDistributionCurveEnum TYPE_B = new IfcLightDistributionCurveEnum( "TYPE_B" );
		public static readonly IfcLightDistributionCurveEnum TYPE_C = new IfcLightDistributionCurveEnum( "TYPE_C" );
		public static readonly IfcLightDistributionCurveEnum NOTDEFINED = new IfcLightDistributionCurveEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightEmissionSourceEnum : BaseType
	{
	private readonly string ename;
		private IfcLightEmissionSourceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightEmissionSourceEnum COMPACTFLUORESCENT = new IfcLightEmissionSourceEnum( "COMPACTFLUORESCENT" );
		public static readonly IfcLightEmissionSourceEnum FLUORESCENT = new IfcLightEmissionSourceEnum( "FLUORESCENT" );
		public static readonly IfcLightEmissionSourceEnum HIGHPRESSUREMERCURY = new IfcLightEmissionSourceEnum( "HIGHPRESSUREMERCURY" );
		public static readonly IfcLightEmissionSourceEnum HIGHPRESSURESODIUM = new IfcLightEmissionSourceEnum( "HIGHPRESSURESODIUM" );
		public static readonly IfcLightEmissionSourceEnum LIGHTEMITTINGDIODE = new IfcLightEmissionSourceEnum( "LIGHTEMITTINGDIODE" );
		public static readonly IfcLightEmissionSourceEnum LOWPRESSURESODIUM = new IfcLightEmissionSourceEnum( "LOWPRESSURESODIUM" );
		public static readonly IfcLightEmissionSourceEnum LOWVOLTAGEHALOGEN = new IfcLightEmissionSourceEnum( "LOWVOLTAGEHALOGEN" );
		public static readonly IfcLightEmissionSourceEnum MAINVOLTAGEHALOGEN = new IfcLightEmissionSourceEnum( "MAINVOLTAGEHALOGEN" );
		public static readonly IfcLightEmissionSourceEnum METALHALIDE = new IfcLightEmissionSourceEnum( "METALHALIDE" );
		public static readonly IfcLightEmissionSourceEnum TUNGSTENFILAMENT = new IfcLightEmissionSourceEnum( "TUNGSTENFILAMENT" );
		public static readonly IfcLightEmissionSourceEnum NOTDEFINED = new IfcLightEmissionSourceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightFixtureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLightFixtureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightFixtureTypeEnum POINTSOURCE = new IfcLightFixtureTypeEnum( "POINTSOURCE" );
		public static readonly IfcLightFixtureTypeEnum DIRECTIONSOURCE = new IfcLightFixtureTypeEnum( "DIRECTIONSOURCE" );
		public static readonly IfcLightFixtureTypeEnum USERDEFINED = new IfcLightFixtureTypeEnum( "USERDEFINED" );
		public static readonly IfcLightFixtureTypeEnum NOTDEFINED = new IfcLightFixtureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLoadGroupTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLoadGroupTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLoadGroupTypeEnum LOAD_GROUP = new IfcLoadGroupTypeEnum( "LOAD_GROUP" );
		public static readonly IfcLoadGroupTypeEnum LOAD_CASE = new IfcLoadGroupTypeEnum( "LOAD_CASE" );
		public static readonly IfcLoadGroupTypeEnum LOAD_COMBINATION_GROUP = new IfcLoadGroupTypeEnum( "LOAD_COMBINATION_GROUP" );
		public static readonly IfcLoadGroupTypeEnum LOAD_COMBINATION = new IfcLoadGroupTypeEnum( "LOAD_COMBINATION" );
		public static readonly IfcLoadGroupTypeEnum USERDEFINED = new IfcLoadGroupTypeEnum( "USERDEFINED" );
		public static readonly IfcLoadGroupTypeEnum NOTDEFINED = new IfcLoadGroupTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLogicalOperatorEnum : BaseType
	{
	private readonly string ename;
		private IfcLogicalOperatorEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLogicalOperatorEnum LOGICALAND = new IfcLogicalOperatorEnum( "LOGICALAND" );
		public static readonly IfcLogicalOperatorEnum LOGICALOR = new IfcLogicalOperatorEnum( "LOGICALOR" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMemberTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMemberTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMemberTypeEnum BRACE = new IfcMemberTypeEnum( "BRACE" );
		public static readonly IfcMemberTypeEnum CHORD = new IfcMemberTypeEnum( "CHORD" );
		public static readonly IfcMemberTypeEnum COLLAR = new IfcMemberTypeEnum( "COLLAR" );
		public static readonly IfcMemberTypeEnum MEMBER = new IfcMemberTypeEnum( "MEMBER" );
		public static readonly IfcMemberTypeEnum MULLION = new IfcMemberTypeEnum( "MULLION" );
		public static readonly IfcMemberTypeEnum PLATE = new IfcMemberTypeEnum( "PLATE" );
		public static readonly IfcMemberTypeEnum POST = new IfcMemberTypeEnum( "POST" );
		public static readonly IfcMemberTypeEnum PURLIN = new IfcMemberTypeEnum( "PURLIN" );
		public static readonly IfcMemberTypeEnum RAFTER = new IfcMemberTypeEnum( "RAFTER" );
		public static readonly IfcMemberTypeEnum STRINGER = new IfcMemberTypeEnum( "STRINGER" );
		public static readonly IfcMemberTypeEnum STRUT = new IfcMemberTypeEnum( "STRUT" );
		public static readonly IfcMemberTypeEnum STUD = new IfcMemberTypeEnum( "STUD" );
		public static readonly IfcMemberTypeEnum USERDEFINED = new IfcMemberTypeEnum( "USERDEFINED" );
		public static readonly IfcMemberTypeEnum NOTDEFINED = new IfcMemberTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMotorConnectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMotorConnectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMotorConnectionTypeEnum BELTDRIVE = new IfcMotorConnectionTypeEnum( "BELTDRIVE" );
		public static readonly IfcMotorConnectionTypeEnum COUPLING = new IfcMotorConnectionTypeEnum( "COUPLING" );
		public static readonly IfcMotorConnectionTypeEnum DIRECTDRIVE = new IfcMotorConnectionTypeEnum( "DIRECTDRIVE" );
		public static readonly IfcMotorConnectionTypeEnum USERDEFINED = new IfcMotorConnectionTypeEnum( "USERDEFINED" );
		public static readonly IfcMotorConnectionTypeEnum NOTDEFINED = new IfcMotorConnectionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcNullStyle : BaseType
	{
	private readonly string ename;
		private IfcNullStyle (string enumName)
		{ ename = enumName; }
		public static readonly IfcNullStyle NULL = new IfcNullStyle( "NULL" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcObjectTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcObjectTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcObjectTypeEnum PRODUCT = new IfcObjectTypeEnum( "PRODUCT" );
		public static readonly IfcObjectTypeEnum PROCESS = new IfcObjectTypeEnum( "PROCESS" );
		public static readonly IfcObjectTypeEnum CONTROL = new IfcObjectTypeEnum( "CONTROL" );
		public static readonly IfcObjectTypeEnum RESOURCE = new IfcObjectTypeEnum( "RESOURCE" );
		public static readonly IfcObjectTypeEnum ACTOR = new IfcObjectTypeEnum( "ACTOR" );
		public static readonly IfcObjectTypeEnum GROUP = new IfcObjectTypeEnum( "GROUP" );
		public static readonly IfcObjectTypeEnum PROJECT = new IfcObjectTypeEnum( "PROJECT" );
		public static readonly IfcObjectTypeEnum NOTDEFINED = new IfcObjectTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcObjectiveEnum : BaseType
	{
	private readonly string ename;
		private IfcObjectiveEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcObjectiveEnum CODECOMPLIANCE = new IfcObjectiveEnum( "CODECOMPLIANCE" );
		public static readonly IfcObjectiveEnum DESIGNINTENT = new IfcObjectiveEnum( "DESIGNINTENT" );
		public static readonly IfcObjectiveEnum HEALTHANDSAFETY = new IfcObjectiveEnum( "HEALTHANDSAFETY" );
		public static readonly IfcObjectiveEnum REQUIREMENT = new IfcObjectiveEnum( "REQUIREMENT" );
		public static readonly IfcObjectiveEnum SPECIFICATION = new IfcObjectiveEnum( "SPECIFICATION" );
		public static readonly IfcObjectiveEnum TRIGGERCONDITION = new IfcObjectiveEnum( "TRIGGERCONDITION" );
		public static readonly IfcObjectiveEnum USERDEFINED = new IfcObjectiveEnum( "USERDEFINED" );
		public static readonly IfcObjectiveEnum NOTDEFINED = new IfcObjectiveEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcOccupantTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcOccupantTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcOccupantTypeEnum ASSIGNEE = new IfcOccupantTypeEnum( "ASSIGNEE" );
		public static readonly IfcOccupantTypeEnum ASSIGNOR = new IfcOccupantTypeEnum( "ASSIGNOR" );
		public static readonly IfcOccupantTypeEnum LESSEE = new IfcOccupantTypeEnum( "LESSEE" );
		public static readonly IfcOccupantTypeEnum LESSOR = new IfcOccupantTypeEnum( "LESSOR" );
		public static readonly IfcOccupantTypeEnum LETTINGAGENT = new IfcOccupantTypeEnum( "LETTINGAGENT" );
		public static readonly IfcOccupantTypeEnum OWNER = new IfcOccupantTypeEnum( "OWNER" );
		public static readonly IfcOccupantTypeEnum TENANT = new IfcOccupantTypeEnum( "TENANT" );
		public static readonly IfcOccupantTypeEnum USERDEFINED = new IfcOccupantTypeEnum( "USERDEFINED" );
		public static readonly IfcOccupantTypeEnum NOTDEFINED = new IfcOccupantTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcOutletTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcOutletTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcOutletTypeEnum AUDIOVISUALOUTLET = new IfcOutletTypeEnum( "AUDIOVISUALOUTLET" );
		public static readonly IfcOutletTypeEnum COMMUNICATIONSOUTLET = new IfcOutletTypeEnum( "COMMUNICATIONSOUTLET" );
		public static readonly IfcOutletTypeEnum POWEROUTLET = new IfcOutletTypeEnum( "POWEROUTLET" );
		public static readonly IfcOutletTypeEnum USERDEFINED = new IfcOutletTypeEnum( "USERDEFINED" );
		public static readonly IfcOutletTypeEnum NOTDEFINED = new IfcOutletTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPermeableCoveringOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcPermeableCoveringOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPermeableCoveringOperationEnum GRILL = new IfcPermeableCoveringOperationEnum( "GRILL" );
		public static readonly IfcPermeableCoveringOperationEnum LOUVER = new IfcPermeableCoveringOperationEnum( "LOUVER" );
		public static readonly IfcPermeableCoveringOperationEnum SCREEN = new IfcPermeableCoveringOperationEnum( "SCREEN" );
		public static readonly IfcPermeableCoveringOperationEnum USERDEFINED = new IfcPermeableCoveringOperationEnum( "USERDEFINED" );
		public static readonly IfcPermeableCoveringOperationEnum NOTDEFINED = new IfcPermeableCoveringOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPhysicalOrVirtualEnum : BaseType
	{
	private readonly string ename;
		private IfcPhysicalOrVirtualEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPhysicalOrVirtualEnum PHYSICAL = new IfcPhysicalOrVirtualEnum( "PHYSICAL" );
		public static readonly IfcPhysicalOrVirtualEnum VIRTUAL = new IfcPhysicalOrVirtualEnum( "VIRTUAL" );
		public static readonly IfcPhysicalOrVirtualEnum NOTDEFINED = new IfcPhysicalOrVirtualEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPileConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcPileConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPileConstructionEnum CAST_IN_PLACE = new IfcPileConstructionEnum( "CAST_IN_PLACE" );
		public static readonly IfcPileConstructionEnum COMPOSITE = new IfcPileConstructionEnum( "COMPOSITE" );
		public static readonly IfcPileConstructionEnum PRECAST_CONCRETE = new IfcPileConstructionEnum( "PRECAST_CONCRETE" );
		public static readonly IfcPileConstructionEnum PREFAB_STEEL = new IfcPileConstructionEnum( "PREFAB_STEEL" );
		public static readonly IfcPileConstructionEnum USERDEFINED = new IfcPileConstructionEnum( "USERDEFINED" );
		public static readonly IfcPileConstructionEnum NOTDEFINED = new IfcPileConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPileTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPileTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPileTypeEnum COHESION = new IfcPileTypeEnum( "COHESION" );
		public static readonly IfcPileTypeEnum FRICTION = new IfcPileTypeEnum( "FRICTION" );
		public static readonly IfcPileTypeEnum SUPPORT = new IfcPileTypeEnum( "SUPPORT" );
		public static readonly IfcPileTypeEnum USERDEFINED = new IfcPileTypeEnum( "USERDEFINED" );
		public static readonly IfcPileTypeEnum NOTDEFINED = new IfcPileTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPipeFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPipeFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPipeFittingTypeEnum BEND = new IfcPipeFittingTypeEnum( "BEND" );
		public static readonly IfcPipeFittingTypeEnum CONNECTOR = new IfcPipeFittingTypeEnum( "CONNECTOR" );
		public static readonly IfcPipeFittingTypeEnum ENTRY = new IfcPipeFittingTypeEnum( "ENTRY" );
		public static readonly IfcPipeFittingTypeEnum EXIT = new IfcPipeFittingTypeEnum( "EXIT" );
		public static readonly IfcPipeFittingTypeEnum JUNCTION = new IfcPipeFittingTypeEnum( "JUNCTION" );
		public static readonly IfcPipeFittingTypeEnum OBSTRUCTION = new IfcPipeFittingTypeEnum( "OBSTRUCTION" );
		public static readonly IfcPipeFittingTypeEnum TRANSITION = new IfcPipeFittingTypeEnum( "TRANSITION" );
		public static readonly IfcPipeFittingTypeEnum USERDEFINED = new IfcPipeFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcPipeFittingTypeEnum NOTDEFINED = new IfcPipeFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPipeSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPipeSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPipeSegmentTypeEnum FLEXIBLESEGMENT = new IfcPipeSegmentTypeEnum( "FLEXIBLESEGMENT" );
		public static readonly IfcPipeSegmentTypeEnum RIGIDSEGMENT = new IfcPipeSegmentTypeEnum( "RIGIDSEGMENT" );
		public static readonly IfcPipeSegmentTypeEnum GUTTER = new IfcPipeSegmentTypeEnum( "GUTTER" );
		public static readonly IfcPipeSegmentTypeEnum SPOOL = new IfcPipeSegmentTypeEnum( "SPOOL" );
		public static readonly IfcPipeSegmentTypeEnum USERDEFINED = new IfcPipeSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcPipeSegmentTypeEnum NOTDEFINED = new IfcPipeSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPlateTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPlateTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPlateTypeEnum CURTAIN_PANEL = new IfcPlateTypeEnum( "CURTAIN_PANEL" );
		public static readonly IfcPlateTypeEnum SHEET = new IfcPlateTypeEnum( "SHEET" );
		public static readonly IfcPlateTypeEnum USERDEFINED = new IfcPlateTypeEnum( "USERDEFINED" );
		public static readonly IfcPlateTypeEnum NOTDEFINED = new IfcPlateTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProcedureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProcedureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProcedureTypeEnum ADVICE_CAUTION = new IfcProcedureTypeEnum( "ADVICE_CAUTION" );
		public static readonly IfcProcedureTypeEnum ADVICE_NOTE = new IfcProcedureTypeEnum( "ADVICE_NOTE" );
		public static readonly IfcProcedureTypeEnum ADVICE_WARNING = new IfcProcedureTypeEnum( "ADVICE_WARNING" );
		public static readonly IfcProcedureTypeEnum CALIBRATION = new IfcProcedureTypeEnum( "CALIBRATION" );
		public static readonly IfcProcedureTypeEnum DIAGNOSTIC = new IfcProcedureTypeEnum( "DIAGNOSTIC" );
		public static readonly IfcProcedureTypeEnum SHUTDOWN = new IfcProcedureTypeEnum( "SHUTDOWN" );
		public static readonly IfcProcedureTypeEnum STARTUP = new IfcProcedureTypeEnum( "STARTUP" );
		public static readonly IfcProcedureTypeEnum USERDEFINED = new IfcProcedureTypeEnum( "USERDEFINED" );
		public static readonly IfcProcedureTypeEnum NOTDEFINED = new IfcProcedureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProfileTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProfileTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProfileTypeEnum CURVE = new IfcProfileTypeEnum( "CURVE" );
		public static readonly IfcProfileTypeEnum AREA = new IfcProfileTypeEnum( "AREA" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectOrderRecordTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectOrderRecordTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectOrderRecordTypeEnum CHANGE = new IfcProjectOrderRecordTypeEnum( "CHANGE" );
		public static readonly IfcProjectOrderRecordTypeEnum MAINTENANCE = new IfcProjectOrderRecordTypeEnum( "MAINTENANCE" );
		public static readonly IfcProjectOrderRecordTypeEnum MOVE = new IfcProjectOrderRecordTypeEnum( "MOVE" );
		public static readonly IfcProjectOrderRecordTypeEnum PURCHASE = new IfcProjectOrderRecordTypeEnum( "PURCHASE" );
		public static readonly IfcProjectOrderRecordTypeEnum WORK = new IfcProjectOrderRecordTypeEnum( "WORK" );
		public static readonly IfcProjectOrderRecordTypeEnum USERDEFINED = new IfcProjectOrderRecordTypeEnum( "USERDEFINED" );
		public static readonly IfcProjectOrderRecordTypeEnum NOTDEFINED = new IfcProjectOrderRecordTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectOrderTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectOrderTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectOrderTypeEnum CHANGEORDER = new IfcProjectOrderTypeEnum( "CHANGEORDER" );
		public static readonly IfcProjectOrderTypeEnum MAINTENANCEWORKORDER = new IfcProjectOrderTypeEnum( "MAINTENANCEWORKORDER" );
		public static readonly IfcProjectOrderTypeEnum MOVEORDER = new IfcProjectOrderTypeEnum( "MOVEORDER" );
		public static readonly IfcProjectOrderTypeEnum PURCHASEORDER = new IfcProjectOrderTypeEnum( "PURCHASEORDER" );
		public static readonly IfcProjectOrderTypeEnum WORKORDER = new IfcProjectOrderTypeEnum( "WORKORDER" );
		public static readonly IfcProjectOrderTypeEnum USERDEFINED = new IfcProjectOrderTypeEnum( "USERDEFINED" );
		public static readonly IfcProjectOrderTypeEnum NOTDEFINED = new IfcProjectOrderTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectedOrTrueLengthEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectedOrTrueLengthEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectedOrTrueLengthEnum PROJECTED_LENGTH = new IfcProjectedOrTrueLengthEnum( "PROJECTED_LENGTH" );
		public static readonly IfcProjectedOrTrueLengthEnum TRUE_LENGTH = new IfcProjectedOrTrueLengthEnum( "TRUE_LENGTH" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPropertySourceEnum : BaseType
	{
	private readonly string ename;
		private IfcPropertySourceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPropertySourceEnum DESIGN = new IfcPropertySourceEnum( "DESIGN" );
		public static readonly IfcPropertySourceEnum DESIGNMAXIMUM = new IfcPropertySourceEnum( "DESIGNMAXIMUM" );
		public static readonly IfcPropertySourceEnum DESIGNMINIMUM = new IfcPropertySourceEnum( "DESIGNMINIMUM" );
		public static readonly IfcPropertySourceEnum SIMULATED = new IfcPropertySourceEnum( "SIMULATED" );
		public static readonly IfcPropertySourceEnum ASBUILT = new IfcPropertySourceEnum( "ASBUILT" );
		public static readonly IfcPropertySourceEnum COMMISSIONING = new IfcPropertySourceEnum( "COMMISSIONING" );
		public static readonly IfcPropertySourceEnum MEASURED = new IfcPropertySourceEnum( "MEASURED" );
		public static readonly IfcPropertySourceEnum USERDEFINED = new IfcPropertySourceEnum( "USERDEFINED" );
		public static readonly IfcPropertySourceEnum NOTKNOWN = new IfcPropertySourceEnum( "NOTKNOWN" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProtectiveDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProtectiveDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProtectiveDeviceTypeEnum FUSEDISCONNECTOR = new IfcProtectiveDeviceTypeEnum( "FUSEDISCONNECTOR" );
		public static readonly IfcProtectiveDeviceTypeEnum CIRCUITBREAKER = new IfcProtectiveDeviceTypeEnum( "CIRCUITBREAKER" );
		public static readonly IfcProtectiveDeviceTypeEnum EARTHFAILUREDEVICE = new IfcProtectiveDeviceTypeEnum( "EARTHFAILUREDEVICE" );
		public static readonly IfcProtectiveDeviceTypeEnum RESIDUALCURRENTCIRCUITBREAKER = new IfcProtectiveDeviceTypeEnum( "RESIDUALCURRENTCIRCUITBREAKER" );
		public static readonly IfcProtectiveDeviceTypeEnum RESIDUALCURRENTSWITCH = new IfcProtectiveDeviceTypeEnum( "RESIDUALCURRENTSWITCH" );
		public static readonly IfcProtectiveDeviceTypeEnum VARISTOR = new IfcProtectiveDeviceTypeEnum( "VARISTOR" );
		public static readonly IfcProtectiveDeviceTypeEnum USERDEFINED = new IfcProtectiveDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcProtectiveDeviceTypeEnum NOTDEFINED = new IfcProtectiveDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPumpTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPumpTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPumpTypeEnum CIRCULATOR = new IfcPumpTypeEnum( "CIRCULATOR" );
		public static readonly IfcPumpTypeEnum ENDSUCTION = new IfcPumpTypeEnum( "ENDSUCTION" );
		public static readonly IfcPumpTypeEnum SPLITCASE = new IfcPumpTypeEnum( "SPLITCASE" );
		public static readonly IfcPumpTypeEnum VERTICALINLINE = new IfcPumpTypeEnum( "VERTICALINLINE" );
		public static readonly IfcPumpTypeEnum VERTICALTURBINE = new IfcPumpTypeEnum( "VERTICALTURBINE" );
		public static readonly IfcPumpTypeEnum USERDEFINED = new IfcPumpTypeEnum( "USERDEFINED" );
		public static readonly IfcPumpTypeEnum NOTDEFINED = new IfcPumpTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRailingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRailingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRailingTypeEnum HANDRAIL = new IfcRailingTypeEnum( "HANDRAIL" );
		public static readonly IfcRailingTypeEnum GUARDRAIL = new IfcRailingTypeEnum( "GUARDRAIL" );
		public static readonly IfcRailingTypeEnum BALUSTRADE = new IfcRailingTypeEnum( "BALUSTRADE" );
		public static readonly IfcRailingTypeEnum USERDEFINED = new IfcRailingTypeEnum( "USERDEFINED" );
		public static readonly IfcRailingTypeEnum NOTDEFINED = new IfcRailingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRampFlightTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRampFlightTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRampFlightTypeEnum STRAIGHT = new IfcRampFlightTypeEnum( "STRAIGHT" );
		public static readonly IfcRampFlightTypeEnum SPIRAL = new IfcRampFlightTypeEnum( "SPIRAL" );
		public static readonly IfcRampFlightTypeEnum USERDEFINED = new IfcRampFlightTypeEnum( "USERDEFINED" );
		public static readonly IfcRampFlightTypeEnum NOTDEFINED = new IfcRampFlightTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRampTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRampTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRampTypeEnum STRAIGHT_RUN_RAMP = new IfcRampTypeEnum( "STRAIGHT_RUN_RAMP" );
		public static readonly IfcRampTypeEnum TWO_STRAIGHT_RUN_RAMP = new IfcRampTypeEnum( "TWO_STRAIGHT_RUN_RAMP" );
		public static readonly IfcRampTypeEnum QUARTER_TURN_RAMP = new IfcRampTypeEnum( "QUARTER_TURN_RAMP" );
		public static readonly IfcRampTypeEnum TWO_QUARTER_TURN_RAMP = new IfcRampTypeEnum( "TWO_QUARTER_TURN_RAMP" );
		public static readonly IfcRampTypeEnum HALF_TURN_RAMP = new IfcRampTypeEnum( "HALF_TURN_RAMP" );
		public static readonly IfcRampTypeEnum SPIRAL_RAMP = new IfcRampTypeEnum( "SPIRAL_RAMP" );
		public static readonly IfcRampTypeEnum USERDEFINED = new IfcRampTypeEnum( "USERDEFINED" );
		public static readonly IfcRampTypeEnum NOTDEFINED = new IfcRampTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReflectanceMethodEnum : BaseType
	{
	private readonly string ename;
		private IfcReflectanceMethodEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReflectanceMethodEnum BLINN = new IfcReflectanceMethodEnum( "BLINN" );
		public static readonly IfcReflectanceMethodEnum FLAT = new IfcReflectanceMethodEnum( "FLAT" );
		public static readonly IfcReflectanceMethodEnum GLASS = new IfcReflectanceMethodEnum( "GLASS" );
		public static readonly IfcReflectanceMethodEnum MATT = new IfcReflectanceMethodEnum( "MATT" );
		public static readonly IfcReflectanceMethodEnum METAL = new IfcReflectanceMethodEnum( "METAL" );
		public static readonly IfcReflectanceMethodEnum MIRROR = new IfcReflectanceMethodEnum( "MIRROR" );
		public static readonly IfcReflectanceMethodEnum PHONG = new IfcReflectanceMethodEnum( "PHONG" );
		public static readonly IfcReflectanceMethodEnum PLASTIC = new IfcReflectanceMethodEnum( "PLASTIC" );
		public static readonly IfcReflectanceMethodEnum STRAUSS = new IfcReflectanceMethodEnum( "STRAUSS" );
		public static readonly IfcReflectanceMethodEnum NOTDEFINED = new IfcReflectanceMethodEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingBarRoleEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingBarRoleEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingBarRoleEnum MAIN = new IfcReinforcingBarRoleEnum( "MAIN" );
		public static readonly IfcReinforcingBarRoleEnum SHEAR = new IfcReinforcingBarRoleEnum( "SHEAR" );
		public static readonly IfcReinforcingBarRoleEnum LIGATURE = new IfcReinforcingBarRoleEnum( "LIGATURE" );
		public static readonly IfcReinforcingBarRoleEnum STUD = new IfcReinforcingBarRoleEnum( "STUD" );
		public static readonly IfcReinforcingBarRoleEnum PUNCHING = new IfcReinforcingBarRoleEnum( "PUNCHING" );
		public static readonly IfcReinforcingBarRoleEnum EDGE = new IfcReinforcingBarRoleEnum( "EDGE" );
		public static readonly IfcReinforcingBarRoleEnum RING = new IfcReinforcingBarRoleEnum( "RING" );
		public static readonly IfcReinforcingBarRoleEnum USERDEFINED = new IfcReinforcingBarRoleEnum( "USERDEFINED" );
		public static readonly IfcReinforcingBarRoleEnum NOTDEFINED = new IfcReinforcingBarRoleEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingBarSurfaceEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingBarSurfaceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingBarSurfaceEnum PLAIN = new IfcReinforcingBarSurfaceEnum( "PLAIN" );
		public static readonly IfcReinforcingBarSurfaceEnum TEXTURED = new IfcReinforcingBarSurfaceEnum( "TEXTURED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcResourceConsumptionEnum : BaseType
	{
	private readonly string ename;
		private IfcResourceConsumptionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcResourceConsumptionEnum CONSUMED = new IfcResourceConsumptionEnum( "CONSUMED" );
		public static readonly IfcResourceConsumptionEnum PARTIALLYCONSUMED = new IfcResourceConsumptionEnum( "PARTIALLYCONSUMED" );
		public static readonly IfcResourceConsumptionEnum NOTCONSUMED = new IfcResourceConsumptionEnum( "NOTCONSUMED" );
		public static readonly IfcResourceConsumptionEnum OCCUPIED = new IfcResourceConsumptionEnum( "OCCUPIED" );
		public static readonly IfcResourceConsumptionEnum PARTIALLYOCCUPIED = new IfcResourceConsumptionEnum( "PARTIALLYOCCUPIED" );
		public static readonly IfcResourceConsumptionEnum NOTOCCUPIED = new IfcResourceConsumptionEnum( "NOTOCCUPIED" );
		public static readonly IfcResourceConsumptionEnum USERDEFINED = new IfcResourceConsumptionEnum( "USERDEFINED" );
		public static readonly IfcResourceConsumptionEnum NOTDEFINED = new IfcResourceConsumptionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRibPlateDirectionEnum : BaseType
	{
	private readonly string ename;
		private IfcRibPlateDirectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRibPlateDirectionEnum DIRECTION_X = new IfcRibPlateDirectionEnum( "DIRECTION_X" );
		public static readonly IfcRibPlateDirectionEnum DIRECTION_Y = new IfcRibPlateDirectionEnum( "DIRECTION_Y" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRoleEnum : BaseType
	{
	private readonly string ename;
		private IfcRoleEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRoleEnum SUPPLIER = new IfcRoleEnum( "SUPPLIER" );
		public static readonly IfcRoleEnum MANUFACTURER = new IfcRoleEnum( "MANUFACTURER" );
		public static readonly IfcRoleEnum CONTRACTOR = new IfcRoleEnum( "CONTRACTOR" );
		public static readonly IfcRoleEnum SUBCONTRACTOR = new IfcRoleEnum( "SUBCONTRACTOR" );
		public static readonly IfcRoleEnum ARCHITECT = new IfcRoleEnum( "ARCHITECT" );
		public static readonly IfcRoleEnum STRUCTURALENGINEER = new IfcRoleEnum( "STRUCTURALENGINEER" );
		public static readonly IfcRoleEnum COSTENGINEER = new IfcRoleEnum( "COSTENGINEER" );
		public static readonly IfcRoleEnum CLIENT = new IfcRoleEnum( "CLIENT" );
		public static readonly IfcRoleEnum BUILDINGOWNER = new IfcRoleEnum( "BUILDINGOWNER" );
		public static readonly IfcRoleEnum BUILDINGOPERATOR = new IfcRoleEnum( "BUILDINGOPERATOR" );
		public static readonly IfcRoleEnum MECHANICALENGINEER = new IfcRoleEnum( "MECHANICALENGINEER" );
		public static readonly IfcRoleEnum ELECTRICALENGINEER = new IfcRoleEnum( "ELECTRICALENGINEER" );
		public static readonly IfcRoleEnum PROJECTMANAGER = new IfcRoleEnum( "PROJECTMANAGER" );
		public static readonly IfcRoleEnum FACILITIESMANAGER = new IfcRoleEnum( "FACILITIESMANAGER" );
		public static readonly IfcRoleEnum CIVILENGINEER = new IfcRoleEnum( "CIVILENGINEER" );
		public static readonly IfcRoleEnum COMISSIONINGENGINEER = new IfcRoleEnum( "COMISSIONINGENGINEER" );
		public static readonly IfcRoleEnum ENGINEER = new IfcRoleEnum( "ENGINEER" );
		public static readonly IfcRoleEnum OWNER = new IfcRoleEnum( "OWNER" );
		public static readonly IfcRoleEnum CONSULTANT = new IfcRoleEnum( "CONSULTANT" );
		public static readonly IfcRoleEnum CONSTRUCTIONMANAGER = new IfcRoleEnum( "CONSTRUCTIONMANAGER" );
		public static readonly IfcRoleEnum FIELDCONSTRUCTIONMANAGER = new IfcRoleEnum( "FIELDCONSTRUCTIONMANAGER" );
		public static readonly IfcRoleEnum RESELLER = new IfcRoleEnum( "RESELLER" );
		public static readonly IfcRoleEnum USERDEFINED = new IfcRoleEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRoofTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRoofTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRoofTypeEnum FLAT_ROOF = new IfcRoofTypeEnum( "FLAT_ROOF" );
		public static readonly IfcRoofTypeEnum SHED_ROOF = new IfcRoofTypeEnum( "SHED_ROOF" );
		public static readonly IfcRoofTypeEnum GABLE_ROOF = new IfcRoofTypeEnum( "GABLE_ROOF" );
		public static readonly IfcRoofTypeEnum HIP_ROOF = new IfcRoofTypeEnum( "HIP_ROOF" );
		public static readonly IfcRoofTypeEnum HIPPED_GABLE_ROOF = new IfcRoofTypeEnum( "HIPPED_GABLE_ROOF" );
		public static readonly IfcRoofTypeEnum GAMBREL_ROOF = new IfcRoofTypeEnum( "GAMBREL_ROOF" );
		public static readonly IfcRoofTypeEnum MANSARD_ROOF = new IfcRoofTypeEnum( "MANSARD_ROOF" );
		public static readonly IfcRoofTypeEnum BARREL_ROOF = new IfcRoofTypeEnum( "BARREL_ROOF" );
		public static readonly IfcRoofTypeEnum RAINBOW_ROOF = new IfcRoofTypeEnum( "RAINBOW_ROOF" );
		public static readonly IfcRoofTypeEnum BUTTERFLY_ROOF = new IfcRoofTypeEnum( "BUTTERFLY_ROOF" );
		public static readonly IfcRoofTypeEnum PAVILION_ROOF = new IfcRoofTypeEnum( "PAVILION_ROOF" );
		public static readonly IfcRoofTypeEnum DOME_ROOF = new IfcRoofTypeEnum( "DOME_ROOF" );
		public static readonly IfcRoofTypeEnum FREEFORM = new IfcRoofTypeEnum( "FREEFORM" );
		public static readonly IfcRoofTypeEnum NOTDEFINED = new IfcRoofTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSIPrefix : BaseType
	{
	private readonly string ename;
		private IfcSIPrefix (string enumName)
		{ ename = enumName; }
		public static readonly IfcSIPrefix EXA = new IfcSIPrefix( "EXA" );
		public static readonly IfcSIPrefix PETA = new IfcSIPrefix( "PETA" );
		public static readonly IfcSIPrefix TERA = new IfcSIPrefix( "TERA" );
		public static readonly IfcSIPrefix GIGA = new IfcSIPrefix( "GIGA" );
		public static readonly IfcSIPrefix MEGA = new IfcSIPrefix( "MEGA" );
		public static readonly IfcSIPrefix KILO = new IfcSIPrefix( "KILO" );
		public static readonly IfcSIPrefix HECTO = new IfcSIPrefix( "HECTO" );
		public static readonly IfcSIPrefix DECA = new IfcSIPrefix( "DECA" );
		public static readonly IfcSIPrefix DECI = new IfcSIPrefix( "DECI" );
		public static readonly IfcSIPrefix CENTI = new IfcSIPrefix( "CENTI" );
		public static readonly IfcSIPrefix MILLI = new IfcSIPrefix( "MILLI" );
		public static readonly IfcSIPrefix MICRO = new IfcSIPrefix( "MICRO" );
		public static readonly IfcSIPrefix NANO = new IfcSIPrefix( "NANO" );
		public static readonly IfcSIPrefix PICO = new IfcSIPrefix( "PICO" );
		public static readonly IfcSIPrefix FEMTO = new IfcSIPrefix( "FEMTO" );
		public static readonly IfcSIPrefix ATTO = new IfcSIPrefix( "ATTO" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSIUnitName : BaseType
	{
	private readonly string ename;
		private IfcSIUnitName (string enumName)
		{ ename = enumName; }
		public static readonly IfcSIUnitName AMPERE = new IfcSIUnitName( "AMPERE" );
		public static readonly IfcSIUnitName BECQUEREL = new IfcSIUnitName( "BECQUEREL" );
		public static readonly IfcSIUnitName CANDELA = new IfcSIUnitName( "CANDELA" );
		public static readonly IfcSIUnitName COULOMB = new IfcSIUnitName( "COULOMB" );
		public static readonly IfcSIUnitName CUBIC_METRE = new IfcSIUnitName( "CUBIC_METRE" );
		public static readonly IfcSIUnitName DEGREE_CELSIUS = new IfcSIUnitName( "DEGREE_CELSIUS" );
		public static readonly IfcSIUnitName FARAD = new IfcSIUnitName( "FARAD" );
		public static readonly IfcSIUnitName GRAM = new IfcSIUnitName( "GRAM" );
		public static readonly IfcSIUnitName GRAY = new IfcSIUnitName( "GRAY" );
		public static readonly IfcSIUnitName HENRY = new IfcSIUnitName( "HENRY" );
		public static readonly IfcSIUnitName HERTZ = new IfcSIUnitName( "HERTZ" );
		public static readonly IfcSIUnitName JOULE = new IfcSIUnitName( "JOULE" );
		public static readonly IfcSIUnitName KELVIN = new IfcSIUnitName( "KELVIN" );
		public static readonly IfcSIUnitName LUMEN = new IfcSIUnitName( "LUMEN" );
		public static readonly IfcSIUnitName LUX = new IfcSIUnitName( "LUX" );
		public static readonly IfcSIUnitName METRE = new IfcSIUnitName( "METRE" );
		public static readonly IfcSIUnitName MOLE = new IfcSIUnitName( "MOLE" );
		public static readonly IfcSIUnitName NEWTON = new IfcSIUnitName( "NEWTON" );
		public static readonly IfcSIUnitName OHM = new IfcSIUnitName( "OHM" );
		public static readonly IfcSIUnitName PASCAL = new IfcSIUnitName( "PASCAL" );
		public static readonly IfcSIUnitName RADIAN = new IfcSIUnitName( "RADIAN" );
		public static readonly IfcSIUnitName SECOND = new IfcSIUnitName( "SECOND" );
		public static readonly IfcSIUnitName SIEMENS = new IfcSIUnitName( "SIEMENS" );
		public static readonly IfcSIUnitName SIEVERT = new IfcSIUnitName( "SIEVERT" );
		public static readonly IfcSIUnitName SQUARE_METRE = new IfcSIUnitName( "SQUARE_METRE" );
		public static readonly IfcSIUnitName STERADIAN = new IfcSIUnitName( "STERADIAN" );
		public static readonly IfcSIUnitName TESLA = new IfcSIUnitName( "TESLA" );
		public static readonly IfcSIUnitName VOLT = new IfcSIUnitName( "VOLT" );
		public static readonly IfcSIUnitName WATT = new IfcSIUnitName( "WATT" );
		public static readonly IfcSIUnitName WEBER = new IfcSIUnitName( "WEBER" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSanitaryTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSanitaryTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSanitaryTerminalTypeEnum BATH = new IfcSanitaryTerminalTypeEnum( "BATH" );
		public static readonly IfcSanitaryTerminalTypeEnum BIDET = new IfcSanitaryTerminalTypeEnum( "BIDET" );
		public static readonly IfcSanitaryTerminalTypeEnum CISTERN = new IfcSanitaryTerminalTypeEnum( "CISTERN" );
		public static readonly IfcSanitaryTerminalTypeEnum SHOWER = new IfcSanitaryTerminalTypeEnum( "SHOWER" );
		public static readonly IfcSanitaryTerminalTypeEnum SINK = new IfcSanitaryTerminalTypeEnum( "SINK" );
		public static readonly IfcSanitaryTerminalTypeEnum SANITARYFOUNTAIN = new IfcSanitaryTerminalTypeEnum( "SANITARYFOUNTAIN" );
		public static readonly IfcSanitaryTerminalTypeEnum TOILETPAN = new IfcSanitaryTerminalTypeEnum( "TOILETPAN" );
		public static readonly IfcSanitaryTerminalTypeEnum URINAL = new IfcSanitaryTerminalTypeEnum( "URINAL" );
		public static readonly IfcSanitaryTerminalTypeEnum WASHHANDBASIN = new IfcSanitaryTerminalTypeEnum( "WASHHANDBASIN" );
		public static readonly IfcSanitaryTerminalTypeEnum WCSEAT = new IfcSanitaryTerminalTypeEnum( "WCSEAT" );
		public static readonly IfcSanitaryTerminalTypeEnum USERDEFINED = new IfcSanitaryTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcSanitaryTerminalTypeEnum NOTDEFINED = new IfcSanitaryTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSectionTypeEnum UNIFORM = new IfcSectionTypeEnum( "UNIFORM" );
		public static readonly IfcSectionTypeEnum TAPERED = new IfcSectionTypeEnum( "TAPERED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSensorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSensorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSensorTypeEnum CO2SENSOR = new IfcSensorTypeEnum( "CO2SENSOR" );
		public static readonly IfcSensorTypeEnum FIRESENSOR = new IfcSensorTypeEnum( "FIRESENSOR" );
		public static readonly IfcSensorTypeEnum FLOWSENSOR = new IfcSensorTypeEnum( "FLOWSENSOR" );
		public static readonly IfcSensorTypeEnum GASSENSOR = new IfcSensorTypeEnum( "GASSENSOR" );
		public static readonly IfcSensorTypeEnum HEATSENSOR = new IfcSensorTypeEnum( "HEATSENSOR" );
		public static readonly IfcSensorTypeEnum HUMIDITYSENSOR = new IfcSensorTypeEnum( "HUMIDITYSENSOR" );
		public static readonly IfcSensorTypeEnum LIGHTSENSOR = new IfcSensorTypeEnum( "LIGHTSENSOR" );
		public static readonly IfcSensorTypeEnum MOISTURESENSOR = new IfcSensorTypeEnum( "MOISTURESENSOR" );
		public static readonly IfcSensorTypeEnum MOVEMENTSENSOR = new IfcSensorTypeEnum( "MOVEMENTSENSOR" );
		public static readonly IfcSensorTypeEnum PRESSURESENSOR = new IfcSensorTypeEnum( "PRESSURESENSOR" );
		public static readonly IfcSensorTypeEnum SMOKESENSOR = new IfcSensorTypeEnum( "SMOKESENSOR" );
		public static readonly IfcSensorTypeEnum SOUNDSENSOR = new IfcSensorTypeEnum( "SOUNDSENSOR" );
		public static readonly IfcSensorTypeEnum TEMPERATURESENSOR = new IfcSensorTypeEnum( "TEMPERATURESENSOR" );
		public static readonly IfcSensorTypeEnum USERDEFINED = new IfcSensorTypeEnum( "USERDEFINED" );
		public static readonly IfcSensorTypeEnum NOTDEFINED = new IfcSensorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSequenceEnum : BaseType
	{
	private readonly string ename;
		private IfcSequenceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSequenceEnum START_START = new IfcSequenceEnum( "START_START" );
		public static readonly IfcSequenceEnum START_FINISH = new IfcSequenceEnum( "START_FINISH" );
		public static readonly IfcSequenceEnum FINISH_START = new IfcSequenceEnum( "FINISH_START" );
		public static readonly IfcSequenceEnum FINISH_FINISH = new IfcSequenceEnum( "FINISH_FINISH" );
		public static readonly IfcSequenceEnum NOTDEFINED = new IfcSequenceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcServiceLifeFactorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcServiceLifeFactorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcServiceLifeFactorTypeEnum A_QUALITYOFCOMPONENTS = new IfcServiceLifeFactorTypeEnum( "A_QUALITYOFCOMPONENTS" );
		public static readonly IfcServiceLifeFactorTypeEnum B_DESIGNLEVEL = new IfcServiceLifeFactorTypeEnum( "B_DESIGNLEVEL" );
		public static readonly IfcServiceLifeFactorTypeEnum C_WORKEXECUTIONLEVEL = new IfcServiceLifeFactorTypeEnum( "C_WORKEXECUTIONLEVEL" );
		public static readonly IfcServiceLifeFactorTypeEnum D_INDOORENVIRONMENT = new IfcServiceLifeFactorTypeEnum( "D_INDOORENVIRONMENT" );
		public static readonly IfcServiceLifeFactorTypeEnum E_OUTDOORENVIRONMENT = new IfcServiceLifeFactorTypeEnum( "E_OUTDOORENVIRONMENT" );
		public static readonly IfcServiceLifeFactorTypeEnum F_INUSECONDITIONS = new IfcServiceLifeFactorTypeEnum( "F_INUSECONDITIONS" );
		public static readonly IfcServiceLifeFactorTypeEnum G_MAINTENANCELEVEL = new IfcServiceLifeFactorTypeEnum( "G_MAINTENANCELEVEL" );
		public static readonly IfcServiceLifeFactorTypeEnum USERDEFINED = new IfcServiceLifeFactorTypeEnum( "USERDEFINED" );
		public static readonly IfcServiceLifeFactorTypeEnum NOTDEFINED = new IfcServiceLifeFactorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcServiceLifeTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcServiceLifeTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcServiceLifeTypeEnum ACTUALSERVICELIFE = new IfcServiceLifeTypeEnum( "ACTUALSERVICELIFE" );
		public static readonly IfcServiceLifeTypeEnum EXPECTEDSERVICELIFE = new IfcServiceLifeTypeEnum( "EXPECTEDSERVICELIFE" );
		public static readonly IfcServiceLifeTypeEnum OPTIMISTICREFERENCESERVICELIFE = new IfcServiceLifeTypeEnum( "OPTIMISTICREFERENCESERVICELIFE" );
		public static readonly IfcServiceLifeTypeEnum PESSIMISTICREFERENCESERVICELIFE = new IfcServiceLifeTypeEnum( "PESSIMISTICREFERENCESERVICELIFE" );
		public static readonly IfcServiceLifeTypeEnum REFERENCESERVICELIFE = new IfcServiceLifeTypeEnum( "REFERENCESERVICELIFE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSlabTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSlabTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSlabTypeEnum FLOOR = new IfcSlabTypeEnum( "FLOOR" );
		public static readonly IfcSlabTypeEnum ROOF = new IfcSlabTypeEnum( "ROOF" );
		public static readonly IfcSlabTypeEnum LANDING = new IfcSlabTypeEnum( "LANDING" );
		public static readonly IfcSlabTypeEnum BASESLAB = new IfcSlabTypeEnum( "BASESLAB" );
		public static readonly IfcSlabTypeEnum USERDEFINED = new IfcSlabTypeEnum( "USERDEFINED" );
		public static readonly IfcSlabTypeEnum NOTDEFINED = new IfcSlabTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSoundScaleEnum : BaseType
	{
	private readonly string ename;
		private IfcSoundScaleEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSoundScaleEnum DBA = new IfcSoundScaleEnum( "DBA" );
		public static readonly IfcSoundScaleEnum DBB = new IfcSoundScaleEnum( "DBB" );
		public static readonly IfcSoundScaleEnum DBC = new IfcSoundScaleEnum( "DBC" );
		public static readonly IfcSoundScaleEnum NC = new IfcSoundScaleEnum( "NC" );
		public static readonly IfcSoundScaleEnum NR = new IfcSoundScaleEnum( "NR" );
		public static readonly IfcSoundScaleEnum USERDEFINED = new IfcSoundScaleEnum( "USERDEFINED" );
		public static readonly IfcSoundScaleEnum NOTDEFINED = new IfcSoundScaleEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSpaceHeaterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSpaceHeaterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSpaceHeaterTypeEnum SECTIONALRADIATOR = new IfcSpaceHeaterTypeEnum( "SECTIONALRADIATOR" );
		public static readonly IfcSpaceHeaterTypeEnum PANELRADIATOR = new IfcSpaceHeaterTypeEnum( "PANELRADIATOR" );
		public static readonly IfcSpaceHeaterTypeEnum TUBULARRADIATOR = new IfcSpaceHeaterTypeEnum( "TUBULARRADIATOR" );
		public static readonly IfcSpaceHeaterTypeEnum CONVECTOR = new IfcSpaceHeaterTypeEnum( "CONVECTOR" );
		public static readonly IfcSpaceHeaterTypeEnum BASEBOARDHEATER = new IfcSpaceHeaterTypeEnum( "BASEBOARDHEATER" );
		public static readonly IfcSpaceHeaterTypeEnum FINNEDTUBEUNIT = new IfcSpaceHeaterTypeEnum( "FINNEDTUBEUNIT" );
		public static readonly IfcSpaceHeaterTypeEnum UNITHEATER = new IfcSpaceHeaterTypeEnum( "UNITHEATER" );
		public static readonly IfcSpaceHeaterTypeEnum USERDEFINED = new IfcSpaceHeaterTypeEnum( "USERDEFINED" );
		public static readonly IfcSpaceHeaterTypeEnum NOTDEFINED = new IfcSpaceHeaterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSpaceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSpaceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSpaceTypeEnum USERDEFINED = new IfcSpaceTypeEnum( "USERDEFINED" );
		public static readonly IfcSpaceTypeEnum NOTDEFINED = new IfcSpaceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStackTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStackTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStackTerminalTypeEnum BIRDCAGE = new IfcStackTerminalTypeEnum( "BIRDCAGE" );
		public static readonly IfcStackTerminalTypeEnum COWL = new IfcStackTerminalTypeEnum( "COWL" );
		public static readonly IfcStackTerminalTypeEnum RAINWATERHOPPER = new IfcStackTerminalTypeEnum( "RAINWATERHOPPER" );
		public static readonly IfcStackTerminalTypeEnum USERDEFINED = new IfcStackTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcStackTerminalTypeEnum NOTDEFINED = new IfcStackTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStairFlightTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStairFlightTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStairFlightTypeEnum STRAIGHT = new IfcStairFlightTypeEnum( "STRAIGHT" );
		public static readonly IfcStairFlightTypeEnum WINDER = new IfcStairFlightTypeEnum( "WINDER" );
		public static readonly IfcStairFlightTypeEnum SPIRAL = new IfcStairFlightTypeEnum( "SPIRAL" );
		public static readonly IfcStairFlightTypeEnum CURVED = new IfcStairFlightTypeEnum( "CURVED" );
		public static readonly IfcStairFlightTypeEnum FREEFORM = new IfcStairFlightTypeEnum( "FREEFORM" );
		public static readonly IfcStairFlightTypeEnum USERDEFINED = new IfcStairFlightTypeEnum( "USERDEFINED" );
		public static readonly IfcStairFlightTypeEnum NOTDEFINED = new IfcStairFlightTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStairTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStairTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStairTypeEnum STRAIGHT_RUN_STAIR = new IfcStairTypeEnum( "STRAIGHT_RUN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_STRAIGHT_RUN_STAIR = new IfcStairTypeEnum( "TWO_STRAIGHT_RUN_STAIR" );
		public static readonly IfcStairTypeEnum QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum QUARTER_TURN_STAIR = new IfcStairTypeEnum( "QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum HALF_WINDING_STAIR = new IfcStairTypeEnum( "HALF_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum HALF_TURN_STAIR = new IfcStairTypeEnum( "HALF_TURN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "TWO_QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum TWO_QUARTER_TURN_STAIR = new IfcStairTypeEnum( "TWO_QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum THREE_QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "THREE_QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum THREE_QUARTER_TURN_STAIR = new IfcStairTypeEnum( "THREE_QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum SPIRAL_STAIR = new IfcStairTypeEnum( "SPIRAL_STAIR" );
		public static readonly IfcStairTypeEnum DOUBLE_RETURN_STAIR = new IfcStairTypeEnum( "DOUBLE_RETURN_STAIR" );
		public static readonly IfcStairTypeEnum CURVED_RUN_STAIR = new IfcStairTypeEnum( "CURVED_RUN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_CURVED_RUN_STAIR = new IfcStairTypeEnum( "TWO_CURVED_RUN_STAIR" );
		public static readonly IfcStairTypeEnum USERDEFINED = new IfcStairTypeEnum( "USERDEFINED" );
		public static readonly IfcStairTypeEnum NOTDEFINED = new IfcStairTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStateEnum : BaseType
	{
	private readonly string ename;
		private IfcStateEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStateEnum READWRITE = new IfcStateEnum( "READWRITE" );
		public static readonly IfcStateEnum READONLY = new IfcStateEnum( "READONLY" );
		public static readonly IfcStateEnum LOCKED = new IfcStateEnum( "LOCKED" );
		public static readonly IfcStateEnum READWRITELOCKED = new IfcStateEnum( "READWRITELOCKED" );
		public static readonly IfcStateEnum READONLYLOCKED = new IfcStateEnum( "READONLYLOCKED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralCurveTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralCurveTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralCurveTypeEnum RIGID_JOINED_MEMBER = new IfcStructuralCurveTypeEnum( "RIGID_JOINED_MEMBER" );
		public static readonly IfcStructuralCurveTypeEnum PIN_JOINED_MEMBER = new IfcStructuralCurveTypeEnum( "PIN_JOINED_MEMBER" );
		public static readonly IfcStructuralCurveTypeEnum CABLE = new IfcStructuralCurveTypeEnum( "CABLE" );
		public static readonly IfcStructuralCurveTypeEnum TENSION_MEMBER = new IfcStructuralCurveTypeEnum( "TENSION_MEMBER" );
		public static readonly IfcStructuralCurveTypeEnum COMPRESSION_MEMBER = new IfcStructuralCurveTypeEnum( "COMPRESSION_MEMBER" );
		public static readonly IfcStructuralCurveTypeEnum USERDEFINED = new IfcStructuralCurveTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralCurveTypeEnum NOTDEFINED = new IfcStructuralCurveTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralSurfaceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralSurfaceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralSurfaceTypeEnum BENDING_ELEMENT = new IfcStructuralSurfaceTypeEnum( "BENDING_ELEMENT" );
		public static readonly IfcStructuralSurfaceTypeEnum MEMBRANE_ELEMENT = new IfcStructuralSurfaceTypeEnum( "MEMBRANE_ELEMENT" );
		public static readonly IfcStructuralSurfaceTypeEnum SHELL = new IfcStructuralSurfaceTypeEnum( "SHELL" );
		public static readonly IfcStructuralSurfaceTypeEnum USERDEFINED = new IfcStructuralSurfaceTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralSurfaceTypeEnum NOTDEFINED = new IfcStructuralSurfaceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSurfaceSide : BaseType
	{
	private readonly string ename;
		private IfcSurfaceSide (string enumName)
		{ ename = enumName; }
		public static readonly IfcSurfaceSide POSITIVE = new IfcSurfaceSide( "POSITIVE" );
		public static readonly IfcSurfaceSide NEGATIVE = new IfcSurfaceSide( "NEGATIVE" );
		public static readonly IfcSurfaceSide BOTH = new IfcSurfaceSide( "BOTH" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSurfaceTextureEnum : BaseType
	{
	private readonly string ename;
		private IfcSurfaceTextureEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSurfaceTextureEnum BUMP = new IfcSurfaceTextureEnum( "BUMP" );
		public static readonly IfcSurfaceTextureEnum OPACITY = new IfcSurfaceTextureEnum( "OPACITY" );
		public static readonly IfcSurfaceTextureEnum REFLECTION = new IfcSurfaceTextureEnum( "REFLECTION" );
		public static readonly IfcSurfaceTextureEnum SELFILLUMINATION = new IfcSurfaceTextureEnum( "SELFILLUMINATION" );
		public static readonly IfcSurfaceTextureEnum SHININESS = new IfcSurfaceTextureEnum( "SHININESS" );
		public static readonly IfcSurfaceTextureEnum SPECULAR = new IfcSurfaceTextureEnum( "SPECULAR" );
		public static readonly IfcSurfaceTextureEnum TEXTURE = new IfcSurfaceTextureEnum( "TEXTURE" );
		public static readonly IfcSurfaceTextureEnum TRANSPARENCYMAP = new IfcSurfaceTextureEnum( "TRANSPARENCYMAP" );
		public static readonly IfcSurfaceTextureEnum NOTDEFINED = new IfcSurfaceTextureEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSwitchingDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSwitchingDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSwitchingDeviceTypeEnum CONTACTOR = new IfcSwitchingDeviceTypeEnum( "CONTACTOR" );
		public static readonly IfcSwitchingDeviceTypeEnum EMERGENCYSTOP = new IfcSwitchingDeviceTypeEnum( "EMERGENCYSTOP" );
		public static readonly IfcSwitchingDeviceTypeEnum STARTER = new IfcSwitchingDeviceTypeEnum( "STARTER" );
		public static readonly IfcSwitchingDeviceTypeEnum SWITCHDISCONNECTOR = new IfcSwitchingDeviceTypeEnum( "SWITCHDISCONNECTOR" );
		public static readonly IfcSwitchingDeviceTypeEnum TOGGLESWITCH = new IfcSwitchingDeviceTypeEnum( "TOGGLESWITCH" );
		public static readonly IfcSwitchingDeviceTypeEnum USERDEFINED = new IfcSwitchingDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcSwitchingDeviceTypeEnum NOTDEFINED = new IfcSwitchingDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTankTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTankTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTankTypeEnum PREFORMED = new IfcTankTypeEnum( "PREFORMED" );
		public static readonly IfcTankTypeEnum SECTIONAL = new IfcTankTypeEnum( "SECTIONAL" );
		public static readonly IfcTankTypeEnum EXPANSION = new IfcTankTypeEnum( "EXPANSION" );
		public static readonly IfcTankTypeEnum PRESSUREVESSEL = new IfcTankTypeEnum( "PRESSUREVESSEL" );
		public static readonly IfcTankTypeEnum USERDEFINED = new IfcTankTypeEnum( "USERDEFINED" );
		public static readonly IfcTankTypeEnum NOTDEFINED = new IfcTankTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTendonTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTendonTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTendonTypeEnum STRAND = new IfcTendonTypeEnum( "STRAND" );
		public static readonly IfcTendonTypeEnum WIRE = new IfcTendonTypeEnum( "WIRE" );
		public static readonly IfcTendonTypeEnum BAR = new IfcTendonTypeEnum( "BAR" );
		public static readonly IfcTendonTypeEnum COATED = new IfcTendonTypeEnum( "COATED" );
		public static readonly IfcTendonTypeEnum USERDEFINED = new IfcTendonTypeEnum( "USERDEFINED" );
		public static readonly IfcTendonTypeEnum NOTDEFINED = new IfcTendonTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTextPath : BaseType
	{
	private readonly string ename;
		private IfcTextPath (string enumName)
		{ ename = enumName; }
		public static readonly IfcTextPath LEFT = new IfcTextPath( "LEFT" );
		public static readonly IfcTextPath RIGHT = new IfcTextPath( "RIGHT" );
		public static readonly IfcTextPath UP = new IfcTextPath( "UP" );
		public static readonly IfcTextPath DOWN = new IfcTextPath( "DOWN" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcThermalLoadSourceEnum : BaseType
	{
	private readonly string ename;
		private IfcThermalLoadSourceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcThermalLoadSourceEnum PEOPLE = new IfcThermalLoadSourceEnum( "PEOPLE" );
		public static readonly IfcThermalLoadSourceEnum LIGHTING = new IfcThermalLoadSourceEnum( "LIGHTING" );
		public static readonly IfcThermalLoadSourceEnum EQUIPMENT = new IfcThermalLoadSourceEnum( "EQUIPMENT" );
		public static readonly IfcThermalLoadSourceEnum VENTILATIONINDOORAIR = new IfcThermalLoadSourceEnum( "VENTILATIONINDOORAIR" );
		public static readonly IfcThermalLoadSourceEnum VENTILATIONOUTSIDEAIR = new IfcThermalLoadSourceEnum( "VENTILATIONOUTSIDEAIR" );
		public static readonly IfcThermalLoadSourceEnum RECIRCULATEDAIR = new IfcThermalLoadSourceEnum( "RECIRCULATEDAIR" );
		public static readonly IfcThermalLoadSourceEnum EXHAUSTAIR = new IfcThermalLoadSourceEnum( "EXHAUSTAIR" );
		public static readonly IfcThermalLoadSourceEnum AIREXCHANGERATE = new IfcThermalLoadSourceEnum( "AIREXCHANGERATE" );
		public static readonly IfcThermalLoadSourceEnum DRYBULBTEMPERATURE = new IfcThermalLoadSourceEnum( "DRYBULBTEMPERATURE" );
		public static readonly IfcThermalLoadSourceEnum RELATIVEHUMIDITY = new IfcThermalLoadSourceEnum( "RELATIVEHUMIDITY" );
		public static readonly IfcThermalLoadSourceEnum INFILTRATION = new IfcThermalLoadSourceEnum( "INFILTRATION" );
		public static readonly IfcThermalLoadSourceEnum USERDEFINED = new IfcThermalLoadSourceEnum( "USERDEFINED" );
		public static readonly IfcThermalLoadSourceEnum NOTDEFINED = new IfcThermalLoadSourceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcThermalLoadTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcThermalLoadTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcThermalLoadTypeEnum SENSIBLE = new IfcThermalLoadTypeEnum( "SENSIBLE" );
		public static readonly IfcThermalLoadTypeEnum LATENT = new IfcThermalLoadTypeEnum( "LATENT" );
		public static readonly IfcThermalLoadTypeEnum RADIANT = new IfcThermalLoadTypeEnum( "RADIANT" );
		public static readonly IfcThermalLoadTypeEnum NOTDEFINED = new IfcThermalLoadTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTimeSeriesDataTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTimeSeriesDataTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTimeSeriesDataTypeEnum CONTINUOUS = new IfcTimeSeriesDataTypeEnum( "CONTINUOUS" );
		public static readonly IfcTimeSeriesDataTypeEnum DISCRETE = new IfcTimeSeriesDataTypeEnum( "DISCRETE" );
		public static readonly IfcTimeSeriesDataTypeEnum DISCRETEBINARY = new IfcTimeSeriesDataTypeEnum( "DISCRETEBINARY" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISEBINARY = new IfcTimeSeriesDataTypeEnum( "PIECEWISEBINARY" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISECONSTANT = new IfcTimeSeriesDataTypeEnum( "PIECEWISECONSTANT" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISECONTINUOUS = new IfcTimeSeriesDataTypeEnum( "PIECEWISECONTINUOUS" );
		public static readonly IfcTimeSeriesDataTypeEnum NOTDEFINED = new IfcTimeSeriesDataTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTimeSeriesScheduleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTimeSeriesScheduleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTimeSeriesScheduleTypeEnum ANNUAL = new IfcTimeSeriesScheduleTypeEnum( "ANNUAL" );
		public static readonly IfcTimeSeriesScheduleTypeEnum MONTHLY = new IfcTimeSeriesScheduleTypeEnum( "MONTHLY" );
		public static readonly IfcTimeSeriesScheduleTypeEnum WEEKLY = new IfcTimeSeriesScheduleTypeEnum( "WEEKLY" );
		public static readonly IfcTimeSeriesScheduleTypeEnum DAILY = new IfcTimeSeriesScheduleTypeEnum( "DAILY" );
		public static readonly IfcTimeSeriesScheduleTypeEnum USERDEFINED = new IfcTimeSeriesScheduleTypeEnum( "USERDEFINED" );
		public static readonly IfcTimeSeriesScheduleTypeEnum NOTDEFINED = new IfcTimeSeriesScheduleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransformerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTransformerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransformerTypeEnum CURRENT = new IfcTransformerTypeEnum( "CURRENT" );
		public static readonly IfcTransformerTypeEnum FREQUENCY = new IfcTransformerTypeEnum( "FREQUENCY" );
		public static readonly IfcTransformerTypeEnum VOLTAGE = new IfcTransformerTypeEnum( "VOLTAGE" );
		public static readonly IfcTransformerTypeEnum USERDEFINED = new IfcTransformerTypeEnum( "USERDEFINED" );
		public static readonly IfcTransformerTypeEnum NOTDEFINED = new IfcTransformerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransitionCode : BaseType
	{
	private readonly string ename;
		private IfcTransitionCode (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransitionCode DISCONTINUOUS = new IfcTransitionCode( "DISCONTINUOUS" );
		public static readonly IfcTransitionCode CONTINUOUS = new IfcTransitionCode( "CONTINUOUS" );
		public static readonly IfcTransitionCode CONTSAMEGRADIENT = new IfcTransitionCode( "CONTSAMEGRADIENT" );
		public static readonly IfcTransitionCode CONTSAMEGRADIENTSAMECURVATURE = new IfcTransitionCode( "CONTSAMEGRADIENTSAMECURVATURE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransportElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTransportElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransportElementTypeEnum ELEVATOR = new IfcTransportElementTypeEnum( "ELEVATOR" );
		public static readonly IfcTransportElementTypeEnum ESCALATOR = new IfcTransportElementTypeEnum( "ESCALATOR" );
		public static readonly IfcTransportElementTypeEnum MOVINGWALKWAY = new IfcTransportElementTypeEnum( "MOVINGWALKWAY" );
		public static readonly IfcTransportElementTypeEnum USERDEFINED = new IfcTransportElementTypeEnum( "USERDEFINED" );
		public static readonly IfcTransportElementTypeEnum NOTDEFINED = new IfcTransportElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTrimmingPreference : BaseType
	{
	private readonly string ename;
		private IfcTrimmingPreference (string enumName)
		{ ename = enumName; }
		public static readonly IfcTrimmingPreference CARTESIAN = new IfcTrimmingPreference( "CARTESIAN" );
		public static readonly IfcTrimmingPreference PARAMETER = new IfcTrimmingPreference( "PARAMETER" );
		public static readonly IfcTrimmingPreference UNSPECIFIED = new IfcTrimmingPreference( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTubeBundleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTubeBundleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTubeBundleTypeEnum FINNED = new IfcTubeBundleTypeEnum( "FINNED" );
		public static readonly IfcTubeBundleTypeEnum USERDEFINED = new IfcTubeBundleTypeEnum( "USERDEFINED" );
		public static readonly IfcTubeBundleTypeEnum NOTDEFINED = new IfcTubeBundleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcUnitEnum : BaseType
	{
	private readonly string ename;
		private IfcUnitEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcUnitEnum ABSORBEDDOSEUNIT = new IfcUnitEnum( "ABSORBEDDOSEUNIT" );
		public static readonly IfcUnitEnum AMOUNTOFSUBSTANCEUNIT = new IfcUnitEnum( "AMOUNTOFSUBSTANCEUNIT" );
		public static readonly IfcUnitEnum AREAUNIT = new IfcUnitEnum( "AREAUNIT" );
		public static readonly IfcUnitEnum DOSEEQUIVALENTUNIT = new IfcUnitEnum( "DOSEEQUIVALENTUNIT" );
		public static readonly IfcUnitEnum ELECTRICCAPACITANCEUNIT = new IfcUnitEnum( "ELECTRICCAPACITANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCHARGEUNIT = new IfcUnitEnum( "ELECTRICCHARGEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCONDUCTANCEUNIT = new IfcUnitEnum( "ELECTRICCONDUCTANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCURRENTUNIT = new IfcUnitEnum( "ELECTRICCURRENTUNIT" );
		public static readonly IfcUnitEnum ELECTRICRESISTANCEUNIT = new IfcUnitEnum( "ELECTRICRESISTANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICVOLTAGEUNIT = new IfcUnitEnum( "ELECTRICVOLTAGEUNIT" );
		public static readonly IfcUnitEnum ENERGYUNIT = new IfcUnitEnum( "ENERGYUNIT" );
		public static readonly IfcUnitEnum FORCEUNIT = new IfcUnitEnum( "FORCEUNIT" );
		public static readonly IfcUnitEnum FREQUENCYUNIT = new IfcUnitEnum( "FREQUENCYUNIT" );
		public static readonly IfcUnitEnum ILLUMINANCEUNIT = new IfcUnitEnum( "ILLUMINANCEUNIT" );
		public static readonly IfcUnitEnum INDUCTANCEUNIT = new IfcUnitEnum( "INDUCTANCEUNIT" );
		public static readonly IfcUnitEnum LENGTHUNIT = new IfcUnitEnum( "LENGTHUNIT" );
		public static readonly IfcUnitEnum LUMINOUSFLUXUNIT = new IfcUnitEnum( "LUMINOUSFLUXUNIT" );
		public static readonly IfcUnitEnum LUMINOUSINTENSITYUNIT = new IfcUnitEnum( "LUMINOUSINTENSITYUNIT" );
		public static readonly IfcUnitEnum MAGNETICFLUXDENSITYUNIT = new IfcUnitEnum( "MAGNETICFLUXDENSITYUNIT" );
		public static readonly IfcUnitEnum MAGNETICFLUXUNIT = new IfcUnitEnum( "MAGNETICFLUXUNIT" );
		public static readonly IfcUnitEnum MASSUNIT = new IfcUnitEnum( "MASSUNIT" );
		public static readonly IfcUnitEnum PLANEANGLEUNIT = new IfcUnitEnum( "PLANEANGLEUNIT" );
		public static readonly IfcUnitEnum POWERUNIT = new IfcUnitEnum( "POWERUNIT" );
		public static readonly IfcUnitEnum PRESSUREUNIT = new IfcUnitEnum( "PRESSUREUNIT" );
		public static readonly IfcUnitEnum RADIOACTIVITYUNIT = new IfcUnitEnum( "RADIOACTIVITYUNIT" );
		public static readonly IfcUnitEnum SOLIDANGLEUNIT = new IfcUnitEnum( "SOLIDANGLEUNIT" );
		public static readonly IfcUnitEnum THERMODYNAMICTEMPERATUREUNIT = new IfcUnitEnum( "THERMODYNAMICTEMPERATUREUNIT" );
		public static readonly IfcUnitEnum TIMEUNIT = new IfcUnitEnum( "TIMEUNIT" );
		public static readonly IfcUnitEnum VOLUMEUNIT = new IfcUnitEnum( "VOLUMEUNIT" );
		public static readonly IfcUnitEnum USERDEFINED = new IfcUnitEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcUnitaryEquipmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcUnitaryEquipmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcUnitaryEquipmentTypeEnum AIRHANDLER = new IfcUnitaryEquipmentTypeEnum( "AIRHANDLER" );
		public static readonly IfcUnitaryEquipmentTypeEnum AIRCONDITIONINGUNIT = new IfcUnitaryEquipmentTypeEnum( "AIRCONDITIONINGUNIT" );
		public static readonly IfcUnitaryEquipmentTypeEnum SPLITSYSTEM = new IfcUnitaryEquipmentTypeEnum( "SPLITSYSTEM" );
		public static readonly IfcUnitaryEquipmentTypeEnum ROOFTOPUNIT = new IfcUnitaryEquipmentTypeEnum( "ROOFTOPUNIT" );
		public static readonly IfcUnitaryEquipmentTypeEnum USERDEFINED = new IfcUnitaryEquipmentTypeEnum( "USERDEFINED" );
		public static readonly IfcUnitaryEquipmentTypeEnum NOTDEFINED = new IfcUnitaryEquipmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcValveTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcValveTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcValveTypeEnum AIRRELEASE = new IfcValveTypeEnum( "AIRRELEASE" );
		public static readonly IfcValveTypeEnum ANTIVACUUM = new IfcValveTypeEnum( "ANTIVACUUM" );
		public static readonly IfcValveTypeEnum CHANGEOVER = new IfcValveTypeEnum( "CHANGEOVER" );
		public static readonly IfcValveTypeEnum CHECK = new IfcValveTypeEnum( "CHECK" );
		public static readonly IfcValveTypeEnum COMMISSIONING = new IfcValveTypeEnum( "COMMISSIONING" );
		public static readonly IfcValveTypeEnum DIVERTING = new IfcValveTypeEnum( "DIVERTING" );
		public static readonly IfcValveTypeEnum DRAWOFFCOCK = new IfcValveTypeEnum( "DRAWOFFCOCK" );
		public static readonly IfcValveTypeEnum DOUBLECHECK = new IfcValveTypeEnum( "DOUBLECHECK" );
		public static readonly IfcValveTypeEnum DOUBLEREGULATING = new IfcValveTypeEnum( "DOUBLEREGULATING" );
		public static readonly IfcValveTypeEnum FAUCET = new IfcValveTypeEnum( "FAUCET" );
		public static readonly IfcValveTypeEnum FLUSHING = new IfcValveTypeEnum( "FLUSHING" );
		public static readonly IfcValveTypeEnum GASCOCK = new IfcValveTypeEnum( "GASCOCK" );
		public static readonly IfcValveTypeEnum GASTAP = new IfcValveTypeEnum( "GASTAP" );
		public static readonly IfcValveTypeEnum ISOLATING = new IfcValveTypeEnum( "ISOLATING" );
		public static readonly IfcValveTypeEnum MIXING = new IfcValveTypeEnum( "MIXING" );
		public static readonly IfcValveTypeEnum PRESSUREREDUCING = new IfcValveTypeEnum( "PRESSUREREDUCING" );
		public static readonly IfcValveTypeEnum PRESSURERELIEF = new IfcValveTypeEnum( "PRESSURERELIEF" );
		public static readonly IfcValveTypeEnum REGULATING = new IfcValveTypeEnum( "REGULATING" );
		public static readonly IfcValveTypeEnum SAFETYCUTOFF = new IfcValveTypeEnum( "SAFETYCUTOFF" );
		public static readonly IfcValveTypeEnum STEAMTRAP = new IfcValveTypeEnum( "STEAMTRAP" );
		public static readonly IfcValveTypeEnum STOPCOCK = new IfcValveTypeEnum( "STOPCOCK" );
		public static readonly IfcValveTypeEnum USERDEFINED = new IfcValveTypeEnum( "USERDEFINED" );
		public static readonly IfcValveTypeEnum NOTDEFINED = new IfcValveTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcVibrationIsolatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcVibrationIsolatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcVibrationIsolatorTypeEnum COMPRESSION = new IfcVibrationIsolatorTypeEnum( "COMPRESSION" );
		public static readonly IfcVibrationIsolatorTypeEnum SPRING = new IfcVibrationIsolatorTypeEnum( "SPRING" );
		public static readonly IfcVibrationIsolatorTypeEnum USERDEFINED = new IfcVibrationIsolatorTypeEnum( "USERDEFINED" );
		public static readonly IfcVibrationIsolatorTypeEnum NOTDEFINED = new IfcVibrationIsolatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWallTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWallTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWallTypeEnum STANDARD = new IfcWallTypeEnum( "STANDARD" );
		public static readonly IfcWallTypeEnum POLYGONAL = new IfcWallTypeEnum( "POLYGONAL" );
		public static readonly IfcWallTypeEnum SHEAR = new IfcWallTypeEnum( "SHEAR" );
		public static readonly IfcWallTypeEnum ELEMENTEDWALL = new IfcWallTypeEnum( "ELEMENTEDWALL" );
		public static readonly IfcWallTypeEnum PLUMBINGWALL = new IfcWallTypeEnum( "PLUMBINGWALL" );
		public static readonly IfcWallTypeEnum USERDEFINED = new IfcWallTypeEnum( "USERDEFINED" );
		public static readonly IfcWallTypeEnum NOTDEFINED = new IfcWallTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWasteTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWasteTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWasteTerminalTypeEnum FLOORTRAP = new IfcWasteTerminalTypeEnum( "FLOORTRAP" );
		public static readonly IfcWasteTerminalTypeEnum FLOORWASTE = new IfcWasteTerminalTypeEnum( "FLOORWASTE" );
		public static readonly IfcWasteTerminalTypeEnum GULLYSUMP = new IfcWasteTerminalTypeEnum( "GULLYSUMP" );
		public static readonly IfcWasteTerminalTypeEnum GULLYTRAP = new IfcWasteTerminalTypeEnum( "GULLYTRAP" );
		public static readonly IfcWasteTerminalTypeEnum GREASEINTERCEPTOR = new IfcWasteTerminalTypeEnum( "GREASEINTERCEPTOR" );
		public static readonly IfcWasteTerminalTypeEnum OILINTERCEPTOR = new IfcWasteTerminalTypeEnum( "OILINTERCEPTOR" );
		public static readonly IfcWasteTerminalTypeEnum PETROLINTERCEPTOR = new IfcWasteTerminalTypeEnum( "PETROLINTERCEPTOR" );
		public static readonly IfcWasteTerminalTypeEnum ROOFDRAIN = new IfcWasteTerminalTypeEnum( "ROOFDRAIN" );
		public static readonly IfcWasteTerminalTypeEnum WASTEDISPOSALUNIT = new IfcWasteTerminalTypeEnum( "WASTEDISPOSALUNIT" );
		public static readonly IfcWasteTerminalTypeEnum WASTETRAP = new IfcWasteTerminalTypeEnum( "WASTETRAP" );
		public static readonly IfcWasteTerminalTypeEnum USERDEFINED = new IfcWasteTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcWasteTerminalTypeEnum NOTDEFINED = new IfcWasteTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowPanelOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowPanelOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowPanelOperationEnum SIDEHUNGRIGHTHAND = new IfcWindowPanelOperationEnum( "SIDEHUNGRIGHTHAND" );
		public static readonly IfcWindowPanelOperationEnum SIDEHUNGLEFTHAND = new IfcWindowPanelOperationEnum( "SIDEHUNGLEFTHAND" );
		public static readonly IfcWindowPanelOperationEnum TILTANDTURNRIGHTHAND = new IfcWindowPanelOperationEnum( "TILTANDTURNRIGHTHAND" );
		public static readonly IfcWindowPanelOperationEnum TILTANDTURNLEFTHAND = new IfcWindowPanelOperationEnum( "TILTANDTURNLEFTHAND" );
		public static readonly IfcWindowPanelOperationEnum TOPHUNG = new IfcWindowPanelOperationEnum( "TOPHUNG" );
		public static readonly IfcWindowPanelOperationEnum BOTTOMHUNG = new IfcWindowPanelOperationEnum( "BOTTOMHUNG" );
		public static readonly IfcWindowPanelOperationEnum PIVOTHORIZONTAL = new IfcWindowPanelOperationEnum( "PIVOTHORIZONTAL" );
		public static readonly IfcWindowPanelOperationEnum PIVOTVERTICAL = new IfcWindowPanelOperationEnum( "PIVOTVERTICAL" );
		public static readonly IfcWindowPanelOperationEnum SLIDINGHORIZONTAL = new IfcWindowPanelOperationEnum( "SLIDINGHORIZONTAL" );
		public static readonly IfcWindowPanelOperationEnum SLIDINGVERTICAL = new IfcWindowPanelOperationEnum( "SLIDINGVERTICAL" );
		public static readonly IfcWindowPanelOperationEnum REMOVABLECASEMENT = new IfcWindowPanelOperationEnum( "REMOVABLECASEMENT" );
		public static readonly IfcWindowPanelOperationEnum FIXEDCASEMENT = new IfcWindowPanelOperationEnum( "FIXEDCASEMENT" );
		public static readonly IfcWindowPanelOperationEnum OTHEROPERATION = new IfcWindowPanelOperationEnum( "OTHEROPERATION" );
		public static readonly IfcWindowPanelOperationEnum NOTDEFINED = new IfcWindowPanelOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowPanelPositionEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowPanelPositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowPanelPositionEnum LEFT = new IfcWindowPanelPositionEnum( "LEFT" );
		public static readonly IfcWindowPanelPositionEnum MIDDLE = new IfcWindowPanelPositionEnum( "MIDDLE" );
		public static readonly IfcWindowPanelPositionEnum RIGHT = new IfcWindowPanelPositionEnum( "RIGHT" );
		public static readonly IfcWindowPanelPositionEnum BOTTOM = new IfcWindowPanelPositionEnum( "BOTTOM" );
		public static readonly IfcWindowPanelPositionEnum TOP = new IfcWindowPanelPositionEnum( "TOP" );
		public static readonly IfcWindowPanelPositionEnum NOTDEFINED = new IfcWindowPanelPositionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowStyleConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowStyleConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowStyleConstructionEnum ALUMINIUM = new IfcWindowStyleConstructionEnum( "ALUMINIUM" );
		public static readonly IfcWindowStyleConstructionEnum HIGH_GRADE_STEEL = new IfcWindowStyleConstructionEnum( "HIGH_GRADE_STEEL" );
		public static readonly IfcWindowStyleConstructionEnum STEEL = new IfcWindowStyleConstructionEnum( "STEEL" );
		public static readonly IfcWindowStyleConstructionEnum WOOD = new IfcWindowStyleConstructionEnum( "WOOD" );
		public static readonly IfcWindowStyleConstructionEnum ALUMINIUM_WOOD = new IfcWindowStyleConstructionEnum( "ALUMINIUM_WOOD" );
		public static readonly IfcWindowStyleConstructionEnum PLASTIC = new IfcWindowStyleConstructionEnum( "PLASTIC" );
		public static readonly IfcWindowStyleConstructionEnum OTHER_CONSTRUCTION = new IfcWindowStyleConstructionEnum( "OTHER_CONSTRUCTION" );
		public static readonly IfcWindowStyleConstructionEnum NOTDEFINED = new IfcWindowStyleConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowStyleOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowStyleOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowStyleOperationEnum SINGLE_PANEL = new IfcWindowStyleOperationEnum( "SINGLE_PANEL" );
		public static readonly IfcWindowStyleOperationEnum DOUBLE_PANEL_VERTICAL = new IfcWindowStyleOperationEnum( "DOUBLE_PANEL_VERTICAL" );
		public static readonly IfcWindowStyleOperationEnum DOUBLE_PANEL_HORIZONTAL = new IfcWindowStyleOperationEnum( "DOUBLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_VERTICAL = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_VERTICAL" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_BOTTOM = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_BOTTOM" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_TOP = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_TOP" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_LEFT = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_LEFT" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_RIGHT = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_RIGHT" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_HORIZONTAL = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowStyleOperationEnum USERDEFINED = new IfcWindowStyleOperationEnum( "USERDEFINED" );
		public static readonly IfcWindowStyleOperationEnum NOTDEFINED = new IfcWindowStyleOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWorkControlTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWorkControlTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWorkControlTypeEnum ACTUAL = new IfcWorkControlTypeEnum( "ACTUAL" );
		public static readonly IfcWorkControlTypeEnum BASELINE = new IfcWorkControlTypeEnum( "BASELINE" );
		public static readonly IfcWorkControlTypeEnum PLANNED = new IfcWorkControlTypeEnum( "PLANNED" );
		public static readonly IfcWorkControlTypeEnum USERDEFINED = new IfcWorkControlTypeEnum( "USERDEFINED" );
		public static readonly IfcWorkControlTypeEnum NOTDEFINED = new IfcWorkControlTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcActorSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOrganization AIfcOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPerson AIfcPerson;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPersonAndOrganization AIfcPersonAndOrganization;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcAppliedValueSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureWithUnit AIfcMeasureWithUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMonetaryMeasure AIfcMonetaryMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcAxis2Placement
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAxis2Placement2D AIfcAxis2Placement2D;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAxis2Placement3D AIfcAxis2Placement3D;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcBooleanOperand
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBooleanResult AIfcBooleanResult;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCsgPrimitive3D AIfcCsgPrimitive3D;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHalfSpaceSolid AIfcHalfSpaceSolid;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSolidModel AIfcSolidModel;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCharacterStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTextStyleForDefinedFont AIfcTextStyleForDefinedFont;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcClassificationNotationSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassificationNotation AIfcClassificationNotation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassificationReference AIfcClassificationReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcColour
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColourSpecification AIfcColourSpecification;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedColour AIfcPreDefinedColour;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcColourOrFactor
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColourRgb AIfcColourRgb;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcConditionCriterionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLabel AIfcLabel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureWithUnit AIfcMeasureWithUnit;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCsgSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBooleanResult AIfcBooleanResult;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCsgPrimitive3D AIfcCsgPrimitive3D;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveFontOrScaledCurveFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFontAndScaling AIfcCurveStyleFontAndScaling;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFontSelect AIfcCurveStyleFontSelect;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveOrEdgeCurve
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoundedCurve AIfcBoundedCurve;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcEdgeCurve AIfcEdgeCurve;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveStyleFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFont AIfcCurveStyleFont;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedCurveFont AIfcPreDefinedCurveFont;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDateTimeSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCalendarDate AIfcCalendarDate;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDateAndTime AIfcDateAndTime;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLocalTime AIfcLocalTime;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDefinedSymbolSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedSymbol AIfcExternallyDefinedSymbol;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedSymbol AIfcPreDefinedSymbol;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDerivedMeasureValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAbsorbedDoseMeasure AIfcAbsorbedDoseMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAccelerationMeasure AIfcAccelerationMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAngularVelocityMeasure AIfcAngularVelocityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCompoundPlaneAngleMeasure AIfcCompoundPlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurvatureMeasure AIfcCurvatureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDoseEquivalentMeasure AIfcDoseEquivalentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDynamicViscosityMeasure AIfcDynamicViscosityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricCapacitanceMeasure AIfcElectricCapacitanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricChargeMeasure AIfcElectricChargeMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricConductanceMeasure AIfcElectricConductanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricResistanceMeasure AIfcElectricResistanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricVoltageMeasure AIfcElectricVoltageMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcEnergyMeasure AIfcEnergyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcForceMeasure AIfcForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFrequencyMeasure AIfcFrequencyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHeatFluxDensityMeasure AIfcHeatFluxDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHeatingValueMeasure AIfcHeatingValueMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIlluminanceMeasure AIfcIlluminanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcInductanceMeasure AIfcInductanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIntegerCountRateMeasure AIfcIntegerCountRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIonConcentrationMeasure AIfcIonConcentrationMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIsothermalMoistureCapacityMeasure AIfcIsothermalMoistureCapacityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcKinematicViscosityMeasure AIfcKinematicViscosityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearForceMeasure AIfcLinearForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearMomentMeasure AIfcLinearMomentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearStiffnessMeasure AIfcLinearStiffnessMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearVelocityMeasure AIfcLinearVelocityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousFluxMeasure AIfcLuminousFluxMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousIntensityDistributionMeasure AIfcLuminousIntensityDistributionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMagneticFluxDensityMeasure AIfcMagneticFluxDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMagneticFluxMeasure AIfcMagneticFluxMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassDensityMeasure AIfcMassDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassFlowRateMeasure AIfcMassFlowRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassPerLengthMeasure AIfcMassPerLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfElasticityMeasure AIfcModulusOfElasticityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfLinearSubgradeReactionMeasure AIfcModulusOfLinearSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfRotationalSubgradeReactionMeasure AIfcModulusOfRotationalSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfSubgradeReactionMeasure AIfcModulusOfSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMoistureDiffusivityMeasure AIfcMoistureDiffusivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMolecularWeightMeasure AIfcMolecularWeightMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMomentOfInertiaMeasure AIfcMomentOfInertiaMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMonetaryMeasure AIfcMonetaryMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPHMeasure AIfcPHMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlanarForceMeasure AIfcPlanarForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPowerMeasure AIfcPowerMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPressureMeasure AIfcPressureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRadioActivityMeasure AIfcRadioActivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalFrequencyMeasure AIfcRotationalFrequencyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalMassMeasure AIfcRotationalMassMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalStiffnessMeasure AIfcRotationalStiffnessMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSectionalAreaIntegralMeasure AIfcSectionalAreaIntegralMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSectionModulusMeasure AIfcSectionModulusMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcShearModulusMeasure AIfcShearModulusMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPowerMeasure AIfcSoundPowerMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPressureMeasure AIfcSoundPressureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecificHeatCapacityMeasure AIfcSpecificHeatCapacityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTemperatureGradientMeasure AIfcTemperatureGradientMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalAdmittanceMeasure AIfcThermalAdmittanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalConductivityMeasure AIfcThermalConductivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalExpansionCoefficientMeasure AIfcThermalExpansionCoefficientMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalResistanceMeasure AIfcThermalResistanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalTransmittanceMeasure AIfcThermalTransmittanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeStamp AIfcTimeStamp;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTorqueMeasure AIfcTorqueMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVaporPermeabilityMeasure AIfcVaporPermeabilityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVolumetricFlowRateMeasure AIfcVolumetricFlowRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcWarpingConstantMeasure AIfcWarpingConstantMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcWarpingMomentMeasure AIfcWarpingMomentMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDocumentSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDocumentInformation AIfcDocumentInformation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDocumentReference AIfcDocumentReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDraughtingCalloutElement
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAnnotationCurveOccurrence AIfcAnnotationCurveOccurrence;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAnnotationSymbolOccurrence AIfcAnnotationSymbolOccurrence;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAnnotationTextOccurrence AIfcAnnotationTextOccurrence;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcFillAreaStyleTileShapeSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyleTileSymbolWithStyle AIfcFillAreaStyleTileSymbolWithStyle;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcFillStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColour AIfcColour;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedHatchStyle AIfcExternallyDefinedHatchStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyleHatching AIfcFillAreaStyleHatching;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyleTiles AIfcFillAreaStyleTiles;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcGeometricSetSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurve AIfcCurve;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPoint AIfcPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurface AIfcSurface;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcHatchLineDistanceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOneDirectionRepeatFactor AIfcOneDirectionRepeatFactor;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLayeredItem
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRepresentation AIfcRepresentation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRepresentationItem AIfcRepresentationItem;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLibrarySelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLibraryInformation AIfcLibraryInformation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLibraryReference AIfcLibraryReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLightDistributionDataSourceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalReference AIfcExternalReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLightIntensityDistribution AIfcLightIntensityDistribution;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMaterialSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterial AIfcMaterial;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialLayer AIfcMaterialLayer;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialLayerSet AIfcMaterialLayerSet;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialLayerSetUsage AIfcMaterialLayerSetUsage;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialList AIfcMaterialList;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMeasureValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAmountOfSubstanceMeasure AIfcAmountOfSubstanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAreaMeasure AIfcAreaMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcComplexNumber AIfcComplexNumber;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcContextDependentMeasure AIfcContextDependentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCountMeasure AIfcCountMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDescriptiveMeasure AIfcDescriptiveMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricCurrentMeasure AIfcElectricCurrentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLengthMeasure AIfcLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousIntensityMeasure AIfcLuminousIntensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassMeasure AIfcMassMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNumericMeasure AIfcNumericMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcParameterValue AIfcParameterValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlaneAngleMeasure AIfcPlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositivePlaneAngleMeasure AIfcPositivePlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveRatioMeasure AIfcPositiveRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSolidAngleMeasure AIfcSolidAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermodynamicTemperatureMeasure AIfcThermodynamicTemperatureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeMeasure AIfcTimeMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVolumeMeasure AIfcVolumeMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMetricValueSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCostValue AIfcCostValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDateTimeSelect AIfcDateTimeSelect;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureWithUnit AIfcMeasureWithUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTable AIfcTable;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcText AIfcText;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeSeries AIfcTimeSeries;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcObjectReferenceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAddress AIfcAddress;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAppliedValue AIfcAppliedValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCalendarDate AIfcCalendarDate;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDateAndTime AIfcDateAndTime;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalReference AIfcExternalReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLocalTime AIfcLocalTime;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterial AIfcMaterial;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialLayer AIfcMaterialLayer;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialList AIfcMaterialList;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOrganization AIfcOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPerson AIfcPerson;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPersonAndOrganization AIfcPersonAndOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeSeries AIfcTimeSeries;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcOrientationSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDirection AIfcDirection;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlaneAngleMeasure AIfcPlaneAngleMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcPointOrVertexPoint
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPoint AIfcPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVertexPoint AIfcVertexPoint;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcPresentationStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyle AIfcCurveStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyle AIfcFillAreaStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNullStyle AIfcNullStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyle AIfcSurfaceStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSymbolStyle AIfcSymbolStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTextStyle AIfcTextStyle;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcShell
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClosedShell AIfcClosedShell;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOpenShell AIfcOpenShell;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSimpleValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIdentifier AIfcIdentifier;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcInteger AIfcInteger;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLabel AIfcLabel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLogical AIfcLogical;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcReal AIfcReal;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcText AIfcText;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSizeSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDescriptiveMeasure AIfcDescriptiveMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLengthMeasure AIfcLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveRatioMeasure AIfcPositiveRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSpecularHighlightSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecularExponent AIfcSpecularExponent;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecularRoughness AIfcSpecularRoughness;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcStructuralActivityAssignmentSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElement AIfcElement;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcStructuralItem AIfcStructuralItem;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSurfaceOrFaceSurface
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFaceBasedSurfaceModel AIfcFaceBasedSurfaceModel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFaceSurface AIfcFaceSurface;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurface AIfcSurface;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSurfaceStyleElementSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedSurfaceStyle AIfcExternallyDefinedSurfaceStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleLighting AIfcSurfaceStyleLighting;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleRefraction AIfcSurfaceStyleRefraction;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleShading AIfcSurfaceStyleShading;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleWithTextures AIfcSurfaceStyleWithTextures;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSymbolStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColour AIfcColour;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTextFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedTextFont AIfcExternallyDefinedTextFont;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedTextFont AIfcPreDefinedTextFont;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTextStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTextStyleTextModel AIfcTextStyleTextModel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTextStyleWithBoxCharacteristics AIfcTextStyleWithBoxCharacteristics;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTrimmingSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCartesianPoint AIfcCartesianPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcParameterValue AIfcParameterValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcUnit
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDerivedUnit AIfcDerivedUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMonetaryUnit AIfcMonetaryUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNamedUnit AIfcNamedUnit;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDerivedMeasureValue AIfcDerivedMeasureValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureValue AIfcMeasureValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSimpleValue AIfcSimpleValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcVectorOrDirection
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDirection AIfcDirection;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVector AIfcVector;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	public partial class Ifc2DCompositeCurve : IfcCompositeCurve

		public Ifc2DCompositeCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeCurve : IfcBoundedCurve

		public IfcCompositeCurve(){}

		public List< IfcCompositeCurveSegment> Segments;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActionRequest : IfcControl

		public IfcActionRequest(){}

		public IfcIdentifier RequestID;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RequestID == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RequestID.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RequestID.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcControl : IfcObject

		public IfcControl(){}

		public List< IfcRelAssignsToControl> Controls;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActor : IfcObject

		public IfcActor(){}

		public IfcActorSelect TheActor;

		[InverseAttribute]
		public List< IfcRelAssignsToActor> IsActingUpon;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TheActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TheActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TheActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOccupant : IfcActor

		public IfcOccupant(){}

		public IfcOccupantTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TheActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TheActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TheActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObject : IfcObjectDefinition

		public IfcObject(){}

		public IfcLabel ObjectType;

		[InverseAttribute]
		public List< IfcRelDefines> IsDefinedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActorRole : P21Instance

		public IfcActorRole(){}

		public IfcRoleEnum Role;

		[ImmediateAttribute]
		public IfcLabel UserDefinedRole;

		[ImmediateAttribute]
		public IfcText Description;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Role == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Role.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Role.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedRole == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedRole.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedRole.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActuatorType : IfcDistributionControlElementType

		public IfcActuatorType(){}

		public IfcActuatorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionControlElementType : IfcDistributionElementType

		public IfcDistributionControlElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAddress : P21Instance

		public IfcAddress(){}

		public IfcAddressTypeEnum Purpose;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcLabel UserDefinedPurpose;

		[InverseAttribute]
		public List< IfcPerson> OfPerson;

		[InverseAttribute]
		public List< IfcOrganization> OfOrganization;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPostalAddress : IfcAddress

		public IfcPostalAddress(){}

		public IfcLabel InternalLocation;

		[ImmediateAttribute]
		public List< IfcLabel> AddressLines;

		[ImmediateAttribute]
		public IfcLabel PostalBox;

		[ImmediateAttribute]
		public IfcLabel Town;

		[ImmediateAttribute]
		public IfcLabel Region;

		[ImmediateAttribute]
		public IfcLabel PostalCode;

		[ImmediateAttribute]
		public IfcLabel Country;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InternalLocation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InternalLocation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InternalLocation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			AddressLines.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PostalBox == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PostalBox.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PostalBox.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Town == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Town.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Town.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Region == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Region.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Region.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PostalCode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PostalCode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PostalCode.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Country == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Country.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Country.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTelecomAddress : IfcAddress

		public IfcTelecomAddress(){}

		public List< IfcLabel> TelephoneNumbers;

		[ImmediateAttribute]
		public List< IfcLabel> FacsimileNumbers;

		[ImmediateAttribute]
		public IfcLabel PagerNumber;

		[ImmediateAttribute]
		public List< IfcLabel> ElectronicMailAddresses;

		[ImmediateAttribute]
		public IfcLabel WWWHomePageURL;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			TelephoneNumbers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			FacsimileNumbers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PagerNumber == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PagerNumber.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PagerNumber.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ElectronicMailAddresses.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (WWWHomePageURL == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WWWHomePageURL.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WWWHomePageURL.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminalBoxType : IfcFlowControllerType

		public IfcAirTerminalBoxType(){}

		public IfcAirTerminalBoxTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowControllerType : IfcDistributionFlowElementType

		public IfcFlowControllerType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminalType : IfcFlowTerminalType

		public IfcAirTerminalType(){}

		public IfcAirTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTerminalType : IfcDistributionFlowElementType

		public IfcFlowTerminalType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType

		public IfcAirToAirHeatRecoveryType(){}

		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnergyConversionDeviceType : IfcDistributionFlowElementType

		public IfcEnergyConversionDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAlarmType : IfcDistributionControlElementType

		public IfcAlarmType(){}

		public IfcAlarmTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAngularDimension : IfcDimensionCurveDirectedCallout

		public IfcAngularDimension(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionCurveDirectedCallout : IfcDraughtingCallout

		public IfcDimensionCurveDirectedCallout(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotation : IfcProduct

		public IfcAnnotation(){}

		public List< IfcRelContainedInSpatialStructure> ContainedInStructure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProduct : IfcObject

		public IfcProduct(){}

		public IfcObjectPlacement ObjectPlacement;

		[ImmediateAttribute]
		public IfcProductRepresentation Representation;

		[InverseAttribute]
		public List< IfcRelAssignsToProduct> ReferencedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationCurveOccurrence : IfcAnnotationOccurrence

		public IfcAnnotationCurveOccurrence(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionCurve : IfcAnnotationCurveOccurrence

		public IfcDimensionCurve(){}

		public List< IfcTerminatorSymbol> AnnotatedBySymbols;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectionCurve : IfcAnnotationCurveOccurrence

		public IfcProjectionCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationOccurrence : IfcStyledItem

		public IfcAnnotationOccurrence(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationFillArea : IfcGeometricRepresentationItem

		public IfcAnnotationFillArea(){}

		public IfcCurve OuterBoundary;

		[ImmediateAttribute]
		public List< IfcCurve> InnerBoundaries;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (OuterBoundary == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterBoundary.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterBoundary.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerBoundaries.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricRepresentationItem : IfcRepresentationItem

		public IfcGeometricRepresentationItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationFillAreaOccurrence : IfcAnnotationOccurrence

		public IfcAnnotationFillAreaOccurrence(){}

		public IfcPoint FillStyleTarget;

		[ImmediateAttribute]
		public IfcGlobalOrLocalEnum GlobalOrLocal;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FillStyleTarget == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FillStyleTarget.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FillStyleTarget.EIN); }
			p21File.Write(EbConstants.Comma);
			if (GlobalOrLocal == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalOrLocal.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalOrLocal.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationSurfaceOccurrence : IfcAnnotationOccurrence

		public IfcAnnotationSurfaceOccurrence(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationSymbolOccurrence : IfcAnnotationOccurrence

		public IfcAnnotationSymbolOccurrence(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationTextOccurrence : IfcAnnotationOccurrence

		public IfcAnnotationTextOccurrence(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStyledItem : IfcRepresentationItem

		public IfcStyledItem(){}

		public IfcRepresentationItem Item;

		[ImmediateAttribute]
		public List< IfcPresentationStyleAssignment> Styles;

		[ImmediateAttribute]
		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationSurface : IfcGeometricRepresentationItem

		public IfcAnnotationSurface(){}

		public IfcGeometricRepresentationItem Item;

		[ImmediateAttribute]
		public IfcTextureCoordinate TextureCoordinates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TextureCoordinates == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureCoordinates.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureCoordinates.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence

		public IfcTerminatorSymbol(){}

		public IfcAnnotationCurveOccurrence AnnotatedCurve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AnnotatedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AnnotatedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + AnnotatedCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApplication : P21Instance

		public IfcApplication(){}

		public IfcOrganization ApplicationDeveloper;

		[ImmediateAttribute]
		public IfcLabel Version;

		[ImmediateAttribute]
		public IfcLabel ApplicationFullName;

		[ImmediateAttribute]
		public IfcIdentifier ApplicationIdentifier;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ApplicationDeveloper == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationDeveloper.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ApplicationDeveloper.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Version == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Version.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Version.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicationFullName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationFullName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicationFullName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicationIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicationIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAppliedValue : P21Instance

		public IfcAppliedValue(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcAppliedValueSelect AppliedValue;

		[ImmediateAttribute]
		public IfcMeasureWithUnit UnitBasis;

		[ImmediateAttribute]
		public IfcDateTimeSelect ApplicableDate;

		[ImmediateAttribute]
		public IfcDateTimeSelect FixedUntilDate;

		[InverseAttribute]
		public List< IfcReferencesValueDocument> ValuesReferenced;

		[InverseAttribute]
		public List< IfcAppliedValueRelationship> ValueOfComponents;

		[InverseAttribute]
		public List< IfcAppliedValueRelationship> IsComponentIn;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AppliedValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AppliedValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AppliedValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UnitBasis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitBasis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitBasis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FixedUntilDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FixedUntilDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FixedUntilDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostValue : IfcAppliedValue

		public IfcCostValue(){}

		public IfcLabel CostType;

		[ImmediateAttribute]
		public IfcText Condition;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AppliedValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AppliedValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AppliedValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UnitBasis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitBasis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitBasis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FixedUntilDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FixedUntilDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FixedUntilDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CostType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CostType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CostType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Condition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Condition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Condition.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnvironmentalImpactValue : IfcAppliedValue

		public IfcEnvironmentalImpactValue(){}

		public IfcLabel ImpactType;

		[ImmediateAttribute]
		public IfcEnvironmentalImpactCategoryEnum Category;

		[ImmediateAttribute]
		public IfcLabel UserDefinedCategory;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AppliedValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AppliedValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AppliedValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UnitBasis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitBasis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitBasis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FixedUntilDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FixedUntilDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FixedUntilDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ImpactType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ImpactType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ImpactType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Category == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Category.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Category.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedCategory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedCategory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedCategory.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAppliedValueRelationship : P21Instance

		public IfcAppliedValueRelationship(){}

		public IfcAppliedValue ComponentOfTotal;

		[ImmediateAttribute]
		public List< IfcAppliedValue> Components;

		[ImmediateAttribute]
		public IfcArithmeticOperatorEnum ArithmeticOperator;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ComponentOfTotal == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ComponentOfTotal.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ComponentOfTotal.EIN); }
			p21File.Write(EbConstants.Comma);
			Components.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (ArithmeticOperator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ArithmeticOperator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ArithmeticOperator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApproval : P21Instance

		public IfcApproval(){}

		public IfcText Description;

		[ImmediateAttribute]
		public IfcDateTimeSelect ApprovalDateTime;

		[ImmediateAttribute]
		public IfcLabel ApprovalStatus;

		[ImmediateAttribute]
		public IfcLabel ApprovalLevel;

		[ImmediateAttribute]
		public IfcText ApprovalQualifier;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcIdentifier Identifier;

		[InverseAttribute]
		public List< IfcApprovalActorRelationship> Actors;

		[InverseAttribute]
		public List< IfcApprovalRelationship> IsRelatedWith;

		[InverseAttribute]
		public List< IfcApprovalRelationship> Relates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApprovalDateTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApprovalDateTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApprovalDateTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApprovalStatus == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApprovalStatus.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApprovalStatus.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApprovalLevel == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApprovalLevel.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApprovalLevel.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApprovalQualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApprovalQualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApprovalQualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApprovalActorRelationship : P21Instance

		public IfcApprovalActorRelationship(){}

		public IfcActorSelect Actor;

		[ImmediateAttribute]
		public IfcApproval Approval;

		[ImmediateAttribute]
		public IfcActorRole Role;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Actor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Actor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Actor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Approval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Approval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Approval.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Role == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Role.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Role.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApprovalPropertyRelationship : P21Instance

		public IfcApprovalPropertyRelationship(){}

		public List< IfcProperty> ApprovedProperties;

		[ImmediateAttribute]
		public IfcApproval Approval;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			ApprovedProperties.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Approval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Approval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Approval.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApprovalRelationship : P21Instance

		public IfcApprovalRelationship(){}

		public IfcApproval RelatedApproval;

		[ImmediateAttribute]
		public IfcApproval RelatingApproval;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RelatedApproval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedApproval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedApproval.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatingApproval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingApproval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingApproval.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryClosedProfileDef : IfcProfileDef

		public IfcArbitraryClosedProfileDef(){}

		public IfcCurve OuterCurve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OuterCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef

		public IfcArbitraryProfileDefWithVoids(){}

		public List< IfcCurve> InnerCurves;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OuterCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerCurves.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProfileDef : P21Instance

		public IfcProfileDef(){}

		public IfcProfileTypeEnum ProfileType;

		[ImmediateAttribute]
		public IfcLabel ProfileName;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryOpenProfileDef : IfcProfileDef

		public IfcArbitraryOpenProfileDef(){}

		public IfcBoundedCurve Curve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Curve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Curve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Curve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef

		public IfcCenterLineProfileDef(){}

		public IfcPositiveLengthMeasure Thickness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Curve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Curve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Curve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Thickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Thickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Thickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAsset : IfcGroup

		public IfcAsset(){}

		public IfcIdentifier AssetID;

		[ImmediateAttribute]
		public IfcCostValue OriginalValue;

		[ImmediateAttribute]
		public IfcCostValue CurrentValue;

		[ImmediateAttribute]
		public IfcCostValue TotalReplacementCost;

		[ImmediateAttribute]
		public IfcActorSelect Owner;

		[ImmediateAttribute]
		public IfcActorSelect User;

		[ImmediateAttribute]
		public IfcPerson ResponsiblePerson;

		[ImmediateAttribute]
		public IfcCalendarDate IncorporationDate;

		[ImmediateAttribute]
		public IfcCostValue DepreciatedValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AssetID == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AssetID.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AssetID.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OriginalValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OriginalValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OriginalValue.EIN); }
			p21File.Write(EbConstants.Comma);
			if (CurrentValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurrentValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + CurrentValue.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TotalReplacementCost == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TotalReplacementCost.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TotalReplacementCost.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Owner.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Owner.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Owner.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (User.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (User.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ User.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResponsiblePerson == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResponsiblePerson.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ResponsiblePerson.EIN); }
			p21File.Write(EbConstants.Comma);
			if (IncorporationDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IncorporationDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + IncorporationDate.EIN); }
			p21File.Write(EbConstants.Comma);
			if (DepreciatedValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DepreciatedValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + DepreciatedValue.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGroup : IfcObject

		public IfcGroup(){}

		public IfcRelAssignsToGroup IsGroupedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAsymmetricIShapeProfileDef : IfcIShapeProfileDef

		public IfcAsymmetricIShapeProfileDef(){}

		public IfcPositiveLengthMeasure TopFlangeWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TopFlangeThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TopFlangeFilletRadius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WebThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WebThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WebThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FlangeThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlangeThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlangeThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeFilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeFilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeFilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcIShapeProfileDef : IfcParameterizedProfileDef

		public IfcIShapeProfileDef(){}

		public IfcPositiveLengthMeasure OverallWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallDepth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WebThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure FlangeThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure FilletRadius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WebThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WebThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WebThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FlangeThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlangeThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlangeThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis1Placement : IfcPlacement

		public IfcAxis1Placement(){}

		public IfcDirection Axis;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlacement : IfcGeometricRepresentationItem

		public IfcPlacement(){}

		public IfcCartesianPoint Location;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis2Placement2D : IfcPlacement

		public IfcAxis2Placement2D(){}

		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis2Placement3D : IfcPlacement

		public IfcAxis2Placement3D(){}

		public IfcDirection Axis;

		[ImmediateAttribute]
		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBSplineCurve : IfcBoundedCurve

		public IfcBSplineCurve(){}

		public INTEGER Degree;

		[ImmediateAttribute]
		public List< IfcCartesianPoint> ControlPointsList;

		[ImmediateAttribute]
		public IfcBSplineCurveForm CurveForm;

		[ImmediateAttribute]
		public LOGICAL ClosedCurve;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBezierCurve : IfcBSplineCurve

		public IfcBezierCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundedCurve : IfcCurve

		public IfcBoundedCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBeam : IfcBuildingElement

		public IfcBeam(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElement : IfcElement

		public IfcBuildingElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBeamType : IfcBuildingElementType

		public IfcBeamType(){}

		public IfcBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementType : IfcElementType

		public IfcBuildingElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRationalBezierCurve : IfcBezierCurve

		public IfcRationalBezierCurve(){}

		public List< REAL> WeightsData;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			WeightsData.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBlobTexture : IfcSurfaceTexture

		public IfcBlobTexture(){}

		public IfcIdentifier RasterFormat;

		[ImmediateAttribute]
		public BOOLEAN RasterCode;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RepeatT == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatT.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatT.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TextureType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureTransform == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureTransform.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureTransform.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RasterFormat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RasterFormat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RasterFormat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RasterCode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RasterCode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RasterCode.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSurfaceTexture : P21Instance

		public IfcSurfaceTexture(){}

		public BOOLEAN RepeatS;

		[ImmediateAttribute]
		public BOOLEAN RepeatT;

		[ImmediateAttribute]
		public IfcSurfaceTextureEnum TextureType;

		[ImmediateAttribute]
		public IfcCartesianTransformationOperator2D TextureTransform;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RepeatT == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatT.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatT.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TextureType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureTransform == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureTransform.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureTransform.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBlock : IfcCsgPrimitive3D

		public IfcBlock(){}

		public IfcPositiveLengthMeasure XLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ZLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ZLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ZLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ZLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCsgPrimitive3D : IfcGeometricRepresentationItem

		public IfcCsgPrimitive3D(){}

		public IfcAxis2Placement3D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoilerType : IfcEnergyConversionDeviceType

		public IfcBoilerType(){}

		public IfcBoilerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBooleanClippingResult : IfcBooleanResult

		public IfcBooleanClippingResult(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Operator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FirstOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FirstOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FirstOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SecondOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SecondOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SecondOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBooleanResult : IfcGeometricRepresentationItem

		public IfcBooleanResult(){}

		public IfcBooleanOperator Operator;

		[ImmediateAttribute]
		public IfcBooleanOperand FirstOperand;

		[ImmediateAttribute]
		public IfcBooleanOperand SecondOperand;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Operator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FirstOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FirstOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FirstOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SecondOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SecondOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SecondOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryCondition : P21Instance

		public IfcBoundaryCondition(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryEdgeCondition : IfcBoundaryCondition

		public IfcBoundaryEdgeCondition(){}

		public IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthX;

		[ImmediateAttribute]
		public IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthY;

		[ImmediateAttribute]
		public IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthZ;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthX;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthY;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByLengthX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByLengthX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByLengthX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByLengthY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByLengthY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByLengthY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByLengthZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByLengthZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByLengthZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryFaceCondition : IfcBoundaryCondition

		public IfcBoundaryFaceCondition(){}

		public IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaX;

		[ImmediateAttribute]
		public IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaY;

		[ImmediateAttribute]
		public IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByAreaX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByAreaX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByAreaX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByAreaY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByAreaY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByAreaY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessByAreaZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessByAreaZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessByAreaZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryNodeCondition : IfcBoundaryCondition

		public IfcBoundaryNodeCondition(){}

		public IfcLinearStiffnessMeasure LinearStiffnessX;

		[ImmediateAttribute]
		public IfcLinearStiffnessMeasure LinearStiffnessY;

		[ImmediateAttribute]
		public IfcLinearStiffnessMeasure LinearStiffnessZ;

		[ImmediateAttribute]
		public IfcRotationalStiffnessMeasure RotationalStiffnessX;

		[ImmediateAttribute]
		public IfcRotationalStiffnessMeasure RotationalStiffnessY;

		[ImmediateAttribute]
		public IfcRotationalStiffnessMeasure RotationalStiffnessZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition

		public IfcBoundaryNodeConditionWarping(){}

		public IfcWarpingMomentMeasure WarpingStiffness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LinearStiffnessZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LinearStiffnessZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LinearStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WarpingStiffness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WarpingStiffness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WarpingStiffness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPolyline : IfcBoundedCurve

		public IfcPolyline(){}

		public List< IfcCartesianPoint> Points;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Points.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTrimmedCurve : IfcBoundedCurve

		public IfcTrimmedCurve(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public List< IfcTrimmingSelect> Trim1;

		[ImmediateAttribute]
		public List< IfcTrimmingSelect> Trim2;

		[ImmediateAttribute]
		public BOOLEAN SenseAgreement;

		[ImmediateAttribute]
		public IfcTrimmingPreference MasterRepresentation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			Trim1.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			Trim2.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SenseAgreement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SenseAgreement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SenseAgreement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MasterRepresentation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MasterRepresentation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MasterRepresentation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurve : IfcGeometricRepresentationItem

		public IfcCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundedSurface : IfcSurface

		public IfcBoundedSurface(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveBoundedPlane : IfcBoundedSurface

		public IfcCurveBoundedPlane(){}

		public IfcPlane BasisSurface;

		[ImmediateAttribute]
		public IfcCurve OuterBoundary;

		[ImmediateAttribute]
		public List< IfcCurve> InnerBoundaries;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OuterBoundary == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterBoundary.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterBoundary.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerBoundaries.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRectangularTrimmedSurface : IfcBoundedSurface

		public IfcRectangularTrimmedSurface(){}

		public IfcSurface BasisSurface;

		[ImmediateAttribute]
		public IfcParameterValue U1;

		[ImmediateAttribute]
		public IfcParameterValue V1;

		[ImmediateAttribute]
		public IfcParameterValue U2;

		[ImmediateAttribute]
		public IfcParameterValue V2;

		[ImmediateAttribute]
		public BOOLEAN Usense;

		[ImmediateAttribute]
		public BOOLEAN Vsense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (U1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (U1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ U1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (V1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (V1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ V1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (U2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (U2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ U2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (V2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (V2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ V2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Usense.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Vsense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Vsense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Vsense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSurface : IfcGeometricRepresentationItem

		public IfcSurface(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundingBox : IfcGeometricRepresentationItem

		public IfcBoundingBox(){}

		public IfcCartesianPoint Corner;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure XDim;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YDim;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ZDim;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Corner == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Corner.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Corner.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ZDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ZDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ZDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoxedHalfSpace : IfcHalfSpaceSolid

		public IfcBoxedHalfSpace(){}

		public IfcBoundingBox Enclosure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BaseSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AgreementFlag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AgreementFlag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AgreementFlag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Enclosure == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Enclosure.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Enclosure.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcHalfSpaceSolid : IfcGeometricRepresentationItem

		public IfcHalfSpaceSolid(){}

		public IfcSurface BaseSurface;

		[ImmediateAttribute]
		public BOOLEAN AgreementFlag;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BaseSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AgreementFlag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AgreementFlag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AgreementFlag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuilding : IfcSpatialStructureElement

		public IfcBuilding(){}

		public IfcLengthMeasure ElevationOfRefHeight;

		[ImmediateAttribute]
		public IfcLengthMeasure ElevationOfTerrain;

		[ImmediateAttribute]
		public IfcPostalAddress BuildingAddress;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElevationOfRefHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElevationOfRefHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElevationOfRefHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElevationOfTerrain == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElevationOfTerrain.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElevationOfTerrain.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BuildingAddress == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BuildingAddress.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BuildingAddress.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSpatialStructureElement : IfcProduct

		public IfcSpatialStructureElement(){}

		public IfcLabel LongName;

		[ImmediateAttribute]
		public IfcElementCompositionEnum CompositionType;

		[InverseAttribute]
		public List< IfcRelReferencedInSpatialStructure> ReferencesElements;

		[InverseAttribute]
		public List< IfcRelServicesBuildings> ServicedBySystems;

		[InverseAttribute]
		public List< IfcRelContainedInSpatialStructure> ContainsElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementComponent : IfcBuildingElement

		public IfcBuildingElementComponent(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementProxy : IfcBuildingElement

		public IfcBuildingElementProxy(){}

		public IfcElementCompositionEnum CompositionType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColumn : IfcBuildingElement

		public IfcColumn(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCovering : IfcBuildingElement

		public IfcCovering(){}

		public IfcCoveringTypeEnum PredefinedType;

		[InverseAttribute]
		public List< IfcRelCoversSpaces> CoversSpaces;

		[InverseAttribute]
		public List< IfcRelCoversBldgElements> Covers;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurtainWall : IfcBuildingElement

		public IfcCurtainWall(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoor : IfcBuildingElement

		public IfcDoor(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallWidth;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFooting : IfcBuildingElement

		public IfcFooting(){}

		public IfcFootingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMember : IfcBuildingElement

		public IfcMember(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPile : IfcBuildingElement

		public IfcPile(){}

		public IfcPileTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcPileConstructionEnum ConstructionType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstructionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstructionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstructionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlate : IfcBuildingElement

		public IfcPlate(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRailing : IfcBuildingElement

		public IfcRailing(){}

		public IfcRailingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRamp : IfcBuildingElement

		public IfcRamp(){}

		public IfcRampTypeEnum ShapeType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShapeType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRampFlight : IfcBuildingElement

		public IfcRampFlight(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRoof : IfcBuildingElement

		public IfcRoof(){}

		public IfcRoofTypeEnum ShapeType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShapeType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSlab : IfcBuildingElement

		public IfcSlab(){}

		public IfcSlabTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStair : IfcBuildingElement

		public IfcStair(){}

		public IfcStairTypeEnum ShapeType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShapeType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStairFlight : IfcBuildingElement

		public IfcStairFlight(){}

		public INTEGER NumberOfRiser;

		[ImmediateAttribute]
		public INTEGER NumberOfTreads;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure RiserHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TreadLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NumberOfRiser == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NumberOfRiser.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NumberOfRiser.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NumberOfTreads == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NumberOfTreads.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NumberOfTreads.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RiserHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RiserHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RiserHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TreadLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TreadLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TreadLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWall : IfcBuildingElement

		public IfcWall(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWindow : IfcBuildingElement

		public IfcWindow(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallWidth;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElement : IfcProduct

		public IfcElement(){}

		public IfcIdentifier Tag;

		[InverseAttribute]
		public List< IfcRelConnectsStructuralElement> HasStructuralMember;

		[InverseAttribute]
		public List< IfcRelFillsElement> FillsVoids;

		[InverseAttribute]
		public List< IfcRelConnectsElements> ConnectedTo;

		[InverseAttribute]
		public List< IfcRelCoversBldgElements> HasCoverings;

		[InverseAttribute]
		public List< IfcRelProjectsElement> HasProjections;

		[InverseAttribute]
		public List< IfcRelReferencedInSpatialStructure> ReferencedInStructures;

		[InverseAttribute]
		public List< IfcRelConnectsPortToElement> HasPorts;

		[InverseAttribute]
		public List< IfcRelVoidsElement> HasOpenings;

		[InverseAttribute]
		public List< IfcRelConnectsWithRealizingElements> IsConnectionRealization;

		[InverseAttribute]
		public List< IfcRelSpaceBoundary> ProvidesBoundaries;

		[InverseAttribute]
		public List< IfcRelConnectsElements> ConnectedFrom;

		[InverseAttribute]
		public List< IfcRelContainedInSpatialStructure> ContainedInStructure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementPart : IfcBuildingElementComponent

		public IfcBuildingElementPart(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcReinforcingElement : IfcBuildingElementComponent

		public IfcReinforcingElement(){}

		public IfcLabel SteelGrade;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SteelGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SteelGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SteelGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementProxyType : IfcBuildingElementType

		public IfcBuildingElementProxyType(){}

		public IfcBuildingElementProxyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColumnType : IfcBuildingElementType

		public IfcColumnType(){}

		public IfcColumnTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoveringType : IfcBuildingElementType

		public IfcCoveringType(){}

		public IfcCoveringTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurtainWallType : IfcBuildingElementType

		public IfcCurtainWallType(){}

		public IfcCurtainWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMemberType : IfcBuildingElementType

		public IfcMemberType(){}

		public IfcMemberTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlateType : IfcBuildingElementType

		public IfcPlateType(){}

		public IfcPlateTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRailingType : IfcBuildingElementType

		public IfcRailingType(){}

		public IfcRailingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRampFlightType : IfcBuildingElementType

		public IfcRampFlightType(){}

		public IfcRampFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSlabType : IfcBuildingElementType

		public IfcSlabType(){}

		public IfcSlabTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStairFlightType : IfcBuildingElementType

		public IfcStairFlightType(){}

		public IfcStairFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWallType : IfcBuildingElementType

		public IfcWallType(){}

		public IfcWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementType : IfcTypeProduct

		public IfcElementType(){}

		public IfcLabel ElementType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingStorey : IfcSpatialStructureElement

		public IfcBuildingStorey(){}

		public IfcLengthMeasure Elevation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Elevation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Elevation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Elevation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCShapeProfileDef : IfcParameterizedProfileDef

		public IfcCShapeProfileDef(){}

		public IfcPositiveLengthMeasure Depth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Width;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WallThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Girth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure InternalFilletRadius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInX;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Depth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Depth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Depth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Width == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Width.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Width.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WallThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WallThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WallThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Girth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Girth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Girth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InternalFilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InternalFilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InternalFilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcParameterizedProfileDef : IfcProfileDef

		public IfcParameterizedProfileDef(){}

		public IfcAxis2Placement2D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierFittingType : IfcFlowFittingType

		public IfcCableCarrierFittingType(){}

		public IfcCableCarrierFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowFittingType : IfcDistributionFlowElementType

		public IfcFlowFittingType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierSegmentType : IfcFlowSegmentType

		public IfcCableCarrierSegmentType(){}

		public IfcCableCarrierSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowSegmentType : IfcDistributionFlowElementType

		public IfcFlowSegmentType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableSegmentType : IfcFlowSegmentType

		public IfcCableSegmentType(){}

		public IfcCableSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCalendarDate : P21Instance

		public IfcCalendarDate(){}

		public IfcDayInMonthNumber DayComponent;

		[ImmediateAttribute]
		public IfcMonthInYearNumber MonthComponent;

		[ImmediateAttribute]
		public IfcYearNumber YearComponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (DayComponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DayComponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DayComponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MonthComponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MonthComponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MonthComponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YearComponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YearComponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YearComponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianPoint : IfcPoint

		public IfcCartesianPoint(){}

		public List< IfcLengthMeasure> Coordinates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Coordinates.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPoint : IfcGeometricRepresentationItem

		public IfcPoint(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem

		public IfcCartesianTransformationOperator(){}

		public IfcDirection Axis1;

		[ImmediateAttribute]
		public IfcDirection Axis2;

		[ImmediateAttribute]
		public IfcCartesianPoint LocalOrigin;

		[ImmediateAttribute]
		public REAL Scale;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator

		public IfcCartesianTransformationOperator2D(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator

		public IfcCartesianTransformationOperator3D(){}

		public IfcDirection Axis3;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Axis3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis3.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D

		public IfcCartesianTransformationOperator2DnonUniform(){}

		public REAL Scale2;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scale2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale2.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D

		public IfcCartesianTransformationOperator3DnonUniform(){}

		public REAL Scale2;

		[ImmediateAttribute]
		public REAL Scale3;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Axis3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis3.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scale3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale3.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChamferEdgeFeature : IfcEdgeFeature

		public IfcChamferEdgeFeature(){}

		public IfcPositiveLengthMeasure Width;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Height;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FeatureLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FeatureLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FeatureLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Width == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Width.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Width.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdgeFeature : IfcFeatureElementSubtraction

		public IfcEdgeFeature(){}

		public IfcPositiveLengthMeasure FeatureLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FeatureLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FeatureLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FeatureLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChillerType : IfcEnergyConversionDeviceType

		public IfcChillerType(){}

		public IfcChillerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircle : IfcConic

		public IfcCircle(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConic : IfcCurve

		public IfcConic(){}

		public IfcAxis2Placement Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircleHollowProfileDef : IfcCircleProfileDef

		public IfcCircleHollowProfileDef(){}

		public IfcPositiveLengthMeasure WallThickness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WallThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WallThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WallThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircleProfileDef : IfcParameterizedProfileDef

		public IfcCircleProfileDef(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassification : P21Instance

		public IfcClassification(){}

		public IfcLabel Source;

		[ImmediateAttribute]
		public IfcLabel Edition;

		[ImmediateAttribute]
		public IfcCalendarDate EditionDate;

		[ImmediateAttribute]
		public IfcLabel Name;

		[InverseAttribute]
		public List< IfcClassificationItem> Contains;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Source == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Source.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Source.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Edition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Edition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Edition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EditionDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EditionDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EditionDate.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationItem : P21Instance

		public IfcClassificationItem(){}

		public IfcClassificationNotationFacet Notation;

		[ImmediateAttribute]
		public IfcClassification ItemOf;

		[ImmediateAttribute]
		public IfcLabel Title;

		[InverseAttribute]
		public List< IfcClassificationItemRelationship> IsClassifiedItemIn;

		[InverseAttribute]
		public List< IfcClassificationItemRelationship> IsClassifyingItemIn;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Notation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Notation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Notation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ItemOf == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemOf.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ItemOf.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Title == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Title.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Title.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationItemRelationship : P21Instance

		public IfcClassificationItemRelationship(){}

		public IfcClassificationItem RelatingItem;

		[ImmediateAttribute]
		public List< IfcClassificationItem> RelatedItems;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RelatingItem == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingItem.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingItem.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedItems.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationNotation : P21Instance

		public IfcClassificationNotation(){}

		public List< IfcClassificationNotationFacet> NotationFacets;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			NotationFacets.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationNotationFacet : P21Instance

		public IfcClassificationNotationFacet(){}

		public IfcLabel NotationValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (NotationValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NotationValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NotationValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationReference : IfcExternalReference

		public IfcClassificationReference(){}

		public IfcClassification ReferencedSource;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ReferencedSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ReferencedSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ReferencedSource.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternalReference : P21Instance

		public IfcExternalReference(){}

		public IfcLabel Location;

		[ImmediateAttribute]
		public IfcIdentifier ItemReference;

		[ImmediateAttribute]
		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClosedShell : IfcConnectedFaceSet

		public IfcClosedShell(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectedFaceSet : IfcTopologicalRepresentationItem

		public IfcConnectedFaceSet(){}

		public List< IfcFace> CfsFaces;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoilType : IfcEnergyConversionDeviceType

		public IfcCoilType(){}

		public IfcCoilTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColourRgb : IfcColourSpecification

		public IfcColourRgb(){}

		public IfcNormalisedRatioMeasure Red;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Green;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Blue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Red == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Red.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Red.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Green == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Green.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Green.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Blue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Blue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Blue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColourSpecification : P21Instance

		public IfcColourSpecification(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcComplexProperty : IfcProperty

		public IfcComplexProperty(){}

		public IfcIdentifier UsageName;

		[ImmediateAttribute]
		public List< IfcProperty> HasProperties;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UsageName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UsageName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UsageName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasProperties.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProperty : P21Instance

		public IfcProperty(){}

		public IfcIdentifier Name;

		[ImmediateAttribute]
		public IfcText Description;

		[InverseAttribute]
		public List< IfcPropertyDependencyRelationship> PropertyForDependance;

		[InverseAttribute]
		public List< IfcPropertyDependencyRelationship> PropertyDependsOn;

		[InverseAttribute]
		public List< IfcComplexProperty> PartOfComplex;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeCurveSegment : IfcGeometricRepresentationItem

		public IfcCompositeCurveSegment(){}

		public IfcTransitionCode Transition;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		[ImmediateAttribute]
		public IfcCurve ParentCurve;

		[InverseAttribute]
		public List< IfcCompositeCurve> UsingCurves;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Transition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Transition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Transition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeProfileDef : IfcProfileDef

		public IfcCompositeProfileDef(){}

		public List< IfcProfileDef> Profiles;

		[ImmediateAttribute]
		public IfcLabel Label;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Profiles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Label == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Label.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Label.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompressorType : IfcFlowMovingDeviceType

		public IfcCompressorType(){}

		public IfcCompressorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowMovingDeviceType : IfcDistributionFlowElementType

		public IfcFlowMovingDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCondenserType : IfcEnergyConversionDeviceType

		public IfcCondenserType(){}

		public IfcCondenserTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCondition : IfcGroup

		public IfcCondition(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConditionCriterion : IfcControl

		public IfcConditionCriterion(){}

		public IfcConditionCriterionSelect Criterion;

		[ImmediateAttribute]
		public IfcDateTimeSelect CriterionDateTime;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Criterion.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Criterion.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Criterion.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CriterionDateTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CriterionDateTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CriterionDateTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEllipse : IfcConic

		public IfcEllipse(){}

		public IfcPositiveLengthMeasure SemiAxis1;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure SemiAxis2;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis2.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOpenShell : IfcConnectedFaceSet

		public IfcOpenShell(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTopologicalRepresentationItem : IfcRepresentationItem

		public IfcTopologicalRepresentationItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionCurveGeometry : IfcConnectionGeometry

		public IfcConnectionCurveGeometry(){}

		public IfcCurveOrEdgeCurve CurveOnRelatingElement;

		[ImmediateAttribute]
		public IfcCurveOrEdgeCurve CurveOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (CurveOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionGeometry : P21Instance

		public IfcConnectionGeometry(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionPointGeometry : IfcConnectionGeometry

		public IfcConnectionPointGeometry(){}

		public IfcPointOrVertexPoint PointOnRelatingElement;

		[ImmediateAttribute]
		public IfcPointOrVertexPoint PointOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (PointOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PointOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionPortGeometry : IfcConnectionGeometry

		public IfcConnectionPortGeometry(){}

		public IfcAxis2Placement LocationAtRelatingElement;

		[ImmediateAttribute]
		public IfcAxis2Placement LocationAtRelatedElement;

		[ImmediateAttribute]
		public IfcProfileDef ProfileOfPort;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (LocationAtRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocationAtRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LocationAtRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LocationAtRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocationAtRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LocationAtRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileOfPort == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileOfPort.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ProfileOfPort.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionSurfaceGeometry : IfcConnectionGeometry

		public IfcConnectionSurfaceGeometry(){}

		public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement;

		[ImmediateAttribute]
		public IfcSurfaceOrFaceSurface SurfaceOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SurfaceOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SurfaceOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry

		public IfcConnectionPointEccentricity(){}

		public IfcLengthMeasure EccentricityInX;

		[ImmediateAttribute]
		public IfcLengthMeasure EccentricityInY;

		[ImmediateAttribute]
		public IfcLengthMeasure EccentricityInZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (PointOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PointOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstraint : P21Instance

		public IfcConstraint(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcConstraintEnum ConstraintGrade;

		[ImmediateAttribute]
		public IfcLabel ConstraintSource;

		[ImmediateAttribute]
		public IfcActorSelect CreatingActor;

		[ImmediateAttribute]
		public IfcDateTimeSelect CreationTime;

		[ImmediateAttribute]
		public IfcLabel UserDefinedGrade;

		[InverseAttribute]
		public List< IfcConstraintClassificationRelationship> ClassifiedAs;

		[InverseAttribute]
		public List< IfcConstraintRelationship> RelatesConstraints;

		[InverseAttribute]
		public List< IfcConstraintRelationship> IsRelatedWith;

		[InverseAttribute]
		public List< IfcPropertyConstraintRelationship> PropertiesForConstraint;

		[InverseAttribute]
		public List< IfcConstraintAggregationRelationship> Aggregates;

		[InverseAttribute]
		public List< IfcConstraintAggregationRelationship> IsAggregatedIn;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMetric : IfcConstraint

		public IfcMetric(){}

		public IfcBenchmarkEnum Benchmark;

		[ImmediateAttribute]
		public IfcLabel ValueSource;

		[ImmediateAttribute]
		public IfcMetricValueSelect DataValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Benchmark == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Benchmark.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Benchmark.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ValueSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValueSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ValueSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DataValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DataValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DataValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObjective : IfcConstraint

		public IfcObjective(){}

		public IfcMetric BenchmarkValues;

		[ImmediateAttribute]
		public IfcMetric ResultValues;

		[ImmediateAttribute]
		public IfcObjectiveEnum ObjectiveQualifier;

		[ImmediateAttribute]
		public IfcLabel UserDefinedQualifier;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BenchmarkValues == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BenchmarkValues.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BenchmarkValues.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ResultValues == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResultValues.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ResultValues.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ObjectiveQualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectiveQualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectiveQualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedQualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedQualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedQualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstraintAggregationRelationship : P21Instance

		public IfcConstraintAggregationRelationship(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcConstraint RelatingConstraint;

		[ImmediateAttribute]
		public List< IfcConstraint> RelatedConstraints;

		[ImmediateAttribute]
		public IfcLogicalOperatorEnum LogicalAggregator;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingConstraint == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingConstraint.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingConstraint.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedConstraints.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (LogicalAggregator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LogicalAggregator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LogicalAggregator.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstraintClassificationRelationship : P21Instance

		public IfcConstraintClassificationRelationship(){}

		public IfcConstraint ClassifiedConstraint;

		[ImmediateAttribute]
		public List< IfcClassificationNotationSelect> RelatedClassifications;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ClassifiedConstraint == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClassifiedConstraint.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ClassifiedConstraint.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedClassifications.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstraintRelationship : P21Instance

		public IfcConstraintRelationship(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcConstraint RelatingConstraint;

		[ImmediateAttribute]
		public List< IfcConstraint> RelatedConstraints;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingConstraint == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingConstraint.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingConstraint.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedConstraints.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionEquipmentResource : IfcConstructionResource

		public IfcConstructionEquipmentResource(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionResource : IfcResource

		public IfcConstructionResource(){}

		public IfcIdentifier ResourceIdentifier;

		[ImmediateAttribute]
		public IfcLabel ResourceGroup;

		[ImmediateAttribute]
		public IfcResourceConsumptionEnum ResourceConsumption;

		[ImmediateAttribute]
		public IfcMeasureWithUnit BaseQuantity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionMaterialResource : IfcConstructionResource

		public IfcConstructionMaterialResource(){}

		public List< IfcActorSelect> Suppliers;

		[ImmediateAttribute]
		public IfcRatioMeasure UsageRatio;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			Suppliers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UsageRatio == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UsageRatio.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UsageRatio.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionProductResource : IfcConstructionResource

		public IfcConstructionProductResource(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCrewResource : IfcConstructionResource

		public IfcCrewResource(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLaborResource : IfcConstructionResource

		public IfcLaborResource(){}

		public IfcText SkillSet;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SkillSet == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SkillSet.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SkillSet.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSubContractResource : IfcConstructionResource

		public IfcSubContractResource(){}

		public IfcActorSelect SubContractor;

		[ImmediateAttribute]
		public IfcText JobDescription;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceGroup.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceConsumption == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceConsumption.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceConsumption.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SubContractor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SubContractor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SubContractor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (JobDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (JobDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ JobDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcResource : IfcObject

		public IfcResource(){}

		public List< IfcRelAssignsToResource> ResourceOf;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcContextDependentUnit : IfcNamedUnit

		public IfcContextDependentUnit(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcNamedUnit : P21Instance

		public IfcNamedUnit(){}

		public IfcDimensionalExponents Dimensions;

		[ImmediateAttribute]
		public IfcUnitEnum UnitType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostItem : IfcControl

		public IfcCostItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostSchedule : IfcControl

		public IfcCostSchedule(){}

		public IfcActorSelect SubmittedBy;

		[ImmediateAttribute]
		public IfcActorSelect PreparedBy;

		[ImmediateAttribute]
		public IfcDateTimeSelect SubmittedOn;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public List< IfcActorSelect> TargetUsers;

		[ImmediateAttribute]
		public IfcDateTimeSelect UpdateDate;

		[ImmediateAttribute]
		public IfcIdentifier ID;

		[ImmediateAttribute]
		public IfcCostScheduleTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SubmittedBy.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SubmittedBy.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SubmittedBy.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PreparedBy.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PreparedBy.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PreparedBy.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SubmittedOn.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SubmittedOn.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SubmittedOn.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			TargetUsers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UpdateDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UpdateDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UpdateDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ID == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ID.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ID.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEquipmentStandard : IfcControl

		public IfcEquipmentStandard(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFurnitureStandard : IfcControl

		public IfcFurnitureStandard(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPerformanceHistory : IfcControl

		public IfcPerformanceHistory(){}

		public IfcLabel LifeCyclePhase;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LifeCyclePhase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LifeCyclePhase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LifeCyclePhase.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPermit : IfcControl

		public IfcPermit(){}

		public IfcIdentifier PermitID;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PermitID == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PermitID.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PermitID.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectOrder : IfcControl

		public IfcProjectOrder(){}

		public IfcIdentifier ID;

		[ImmediateAttribute]
		public IfcProjectOrderTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcLabel Status;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ID == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ID.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ID.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectOrderRecord : IfcControl

		public IfcProjectOrderRecord(){}

		public List< IfcRelAssignsToProjectOrder> Records;

		[ImmediateAttribute]
		public IfcProjectOrderRecordTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Records.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcScheduleTimeControl : IfcControl

		public IfcScheduleTimeControl(){}

		public IfcDateTimeSelect ActualStart;

		[ImmediateAttribute]
		public IfcDateTimeSelect EarlyStart;

		[ImmediateAttribute]
		public IfcDateTimeSelect LateStart;

		[ImmediateAttribute]
		public IfcDateTimeSelect ScheduleStart;

		[ImmediateAttribute]
		public IfcDateTimeSelect ActualFinish;

		[ImmediateAttribute]
		public IfcDateTimeSelect EarlyFinish;

		[ImmediateAttribute]
		public IfcDateTimeSelect LateFinish;

		[ImmediateAttribute]
		public IfcDateTimeSelect ScheduleFinish;

		[ImmediateAttribute]
		public IfcTimeMeasure ScheduleDuration;

		[ImmediateAttribute]
		public IfcTimeMeasure ActualDuration;

		[ImmediateAttribute]
		public IfcTimeMeasure RemainingTime;

		[ImmediateAttribute]
		public IfcTimeMeasure FreeFloat;

		[ImmediateAttribute]
		public IfcTimeMeasure TotalFloat;

		[ImmediateAttribute]
		public BOOLEAN IsCritical;

		[ImmediateAttribute]
		public IfcDateTimeSelect StatusTime;

		[ImmediateAttribute]
		public IfcTimeMeasure StartFloat;

		[ImmediateAttribute]
		public IfcTimeMeasure FinishFloat;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure Completion;

		[InverseAttribute]
		public IfcRelAssignsTasks ScheduleTimeControlAssigned;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ActualStart.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ActualStart.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ActualStart.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EarlyStart.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EarlyStart.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EarlyStart.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LateStart.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LateStart.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LateStart.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ScheduleStart.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ScheduleStart.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ScheduleStart.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ActualFinish.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ActualFinish.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ActualFinish.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EarlyFinish.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EarlyFinish.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EarlyFinish.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LateFinish.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LateFinish.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LateFinish.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ScheduleFinish.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ScheduleFinish.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ScheduleFinish.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ScheduleDuration == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ScheduleDuration.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ScheduleDuration.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ActualDuration == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ActualDuration.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ActualDuration.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RemainingTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RemainingTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RemainingTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FreeFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FreeFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FreeFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TotalFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TotalFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TotalFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (IsCritical == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IsCritical.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IsCritical.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StatusTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StatusTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StatusTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StartFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FinishFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FinishFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FinishFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Completion == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Completion.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Completion.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcServiceLife : IfcControl

		public IfcServiceLife(){}

		public IfcServiceLifeTypeEnum ServiceLifeType;

		[ImmediateAttribute]
		public IfcTimeMeasure ServiceLifeDuration;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ServiceLifeType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ServiceLifeType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ServiceLifeType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ServiceLifeDuration == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ServiceLifeDuration.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ServiceLifeDuration.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSpaceProgram : IfcControl

		public IfcSpaceProgram(){}

		public IfcIdentifier SpaceProgramIdentifier;

		[ImmediateAttribute]
		public IfcAreaMeasure MaxRequiredArea;

		[ImmediateAttribute]
		public IfcAreaMeasure MinRequiredArea;

		[ImmediateAttribute]
		public IfcSpatialStructureElement RequestedLocation;

		[ImmediateAttribute]
		public IfcAreaMeasure StandardRequiredArea;

		[InverseAttribute]
		public List< IfcRelInteractionRequirements> HasInteractionReqsFrom;

		[InverseAttribute]
		public List< IfcRelInteractionRequirements> HasInteractionReqsTo;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SpaceProgramIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SpaceProgramIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SpaceProgramIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaxRequiredArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaxRequiredArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaxRequiredArea.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinRequiredArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinRequiredArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinRequiredArea.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RequestedLocation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RequestedLocation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RequestedLocation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (StandardRequiredArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StandardRequiredArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StandardRequiredArea.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTimeSeriesSchedule : IfcControl

		public IfcTimeSeriesSchedule(){}

		public List< IfcDateTimeSelect> ApplicableDates;

		[ImmediateAttribute]
		public IfcTimeSeriesScheduleTypeEnum TimeSeriesScheduleType;

		[ImmediateAttribute]
		public IfcTimeSeries TimeSeries;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ApplicableDates.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (TimeSeriesScheduleType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeSeriesScheduleType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeSeriesScheduleType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TimeSeries.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWorkControl : IfcControl

		public IfcWorkControl(){}

		public IfcIdentifier Identifier;

		[ImmediateAttribute]
		public IfcDateTimeSelect CreationDate;

		[ImmediateAttribute]
		public List< IfcPerson> Creators;

		[ImmediateAttribute]
		public IfcLabel Purpose;

		[ImmediateAttribute]
		public IfcTimeMeasure Duration;

		[ImmediateAttribute]
		public IfcTimeMeasure TotalFloat;

		[ImmediateAttribute]
		public IfcDateTimeSelect StartTime;

		[ImmediateAttribute]
		public IfcDateTimeSelect FinishTime;

		[ImmediateAttribute]
		public IfcWorkControlTypeEnum WorkControlType;

		[ImmediateAttribute]
		public IfcLabel UserDefinedControlType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationDate.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationDate.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Creators.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Duration == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Duration.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Duration.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TotalFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TotalFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TotalFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StartTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FinishTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FinishTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FinishTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WorkControlType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WorkControlType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WorkControlType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedControlType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedControlType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedControlType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcControllerType : IfcDistributionControlElementType

		public IfcControllerType(){}

		public IfcControllerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConversionBasedUnit : IfcNamedUnit

		public IfcConversionBasedUnit(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcMeasureWithUnit ConversionFactor;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConversionFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConversionFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ConversionFactor.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCooledBeamType : IfcEnergyConversionDeviceType

		public IfcCooledBeamType(){}

		public IfcCooledBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoolingTowerType : IfcEnergyConversionDeviceType

		public IfcCoolingTowerType(){}

		public IfcCoolingTowerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoordinatedUniversalTimeOffset : P21Instance

		public IfcCoordinatedUniversalTimeOffset(){}

		public IfcHourInDay HourOffset;

		[ImmediateAttribute]
		public IfcMinuteInHour MinuteOffset;

		[ImmediateAttribute]
		public IfcAheadOrBehind Sense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (HourOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HourOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HourOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinuteOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinuteOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinuteOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Sense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Sense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Sense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCraneRailAShapeProfileDef : IfcParameterizedProfileDef

		public IfcCraneRailAShapeProfileDef(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseWidth2;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Radius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadDepth2;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadDepth3;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WebThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseWidth4;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseDepth1;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseDepth2;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseDepth3;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseWidth2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseWidth2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseWidth2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadDepth2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadDepth2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadDepth2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadDepth3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadDepth3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadDepth3.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WebThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WebThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WebThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseWidth4 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseWidth4.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseWidth4.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseDepth1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseDepth1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseDepth1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseDepth2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseDepth2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseDepth2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseDepth3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseDepth3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseDepth3.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef

		public IfcCraneRailFShapeProfileDef(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Radius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadDepth2;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure HeadDepth3;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WebThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseDepth1;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BaseDepth2;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadDepth2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadDepth2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadDepth2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HeadDepth3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HeadDepth3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HeadDepth3.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WebThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WebThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WebThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseDepth1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseDepth1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseDepth1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BaseDepth2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseDepth2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BaseDepth2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRectangularPyramid : IfcCsgPrimitive3D

		public IfcRectangularPyramid(){}

		public IfcPositiveLengthMeasure XLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Height;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRightCircularCone : IfcCsgPrimitive3D

		public IfcRightCircularCone(){}

		public IfcPositiveLengthMeasure Height;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BottomRadius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRightCircularCylinder : IfcCsgPrimitive3D

		public IfcRightCircularCylinder(){}

		public IfcPositiveLengthMeasure Height;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSphere : IfcCsgPrimitive3D

		public IfcSphere(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCsgSolid : IfcSolidModel

		public IfcCsgSolid(){}

		public IfcCsgSelect TreeRootExpression;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (TreeRootExpression.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TreeRootExpression.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TreeRootExpression.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSolidModel : IfcGeometricRepresentationItem

		public IfcSolidModel(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurrencyRelationship : P21Instance

		public IfcCurrencyRelationship(){}

		public IfcMonetaryUnit RelatingMonetaryUnit;

		[ImmediateAttribute]
		public IfcMonetaryUnit RelatedMonetaryUnit;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure ExchangeRate;

		[ImmediateAttribute]
		public IfcDateAndTime RateDateTime;

		[ImmediateAttribute]
		public IfcLibraryInformation RateSource;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RelatingMonetaryUnit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingMonetaryUnit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingMonetaryUnit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatedMonetaryUnit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedMonetaryUnit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedMonetaryUnit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ExchangeRate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ExchangeRate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ExchangeRate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RateDateTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RateDateTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RateDateTime.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RateSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RateSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RateSource.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLine : IfcCurve

		public IfcLine(){}

		public IfcCartesianPoint Pnt;

		[ImmediateAttribute]
		public IfcVector Dir;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Pnt == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Pnt.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Pnt.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Dir == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dir.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dir.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOffsetCurve2D : IfcCurve

		public IfcOffsetCurve2D(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public IfcLengthMeasure Distance;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Distance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Distance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Distance.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOffsetCurve3D : IfcCurve

		public IfcOffsetCurve3D(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public IfcLengthMeasure Distance;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		[ImmediateAttribute]
		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Distance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Distance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Distance.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyle : IfcPresentationStyle

		public IfcCurveStyle(){}

		public IfcCurveFontOrScaledCurveFontSelect CurveFont;

		[ImmediateAttribute]
		public IfcSizeSelect CurveWidth;

		[ImmediateAttribute]
		public IfcColour CurveColour;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFont.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFont.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFont.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveWidth.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveWidth.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveColour.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveColour.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveColour.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPresentationStyle : P21Instance

		public IfcPresentationStyle(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFont : P21Instance

		public IfcCurveStyleFont(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public List< IfcCurveStyleFontPattern> PatternList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			PatternList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFontAndScaling : P21Instance

		public IfcCurveStyleFontAndScaling(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcCurveStyleFontSelect CurveFont;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure CurveFontScaling;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFont.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFont.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFont.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFontScaling == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFontScaling.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFontScaling.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFontPattern : P21Instance

		public IfcCurveStyleFontPattern(){}

		public IfcLengthMeasure VisibleSegmentLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure InvisibleSegmentLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (VisibleSegmentLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VisibleSegmentLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VisibleSegmentLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InvisibleSegmentLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InvisibleSegmentLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InvisibleSegmentLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDamperType : IfcFlowControllerType

		public IfcDamperType(){}

		public IfcDamperTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDateAndTime : P21Instance

		public IfcDateAndTime(){}

		public IfcCalendarDate DateComponent;

		[ImmediateAttribute]
		public IfcLocalTime TimeComponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (DateComponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DateComponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + DateComponent.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TimeComponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeComponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TimeComponent.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDefinedSymbol : IfcGeometricRepresentationItem

		public IfcDefinedSymbol(){}

		public IfcDefinedSymbolSelect Definition;

		[ImmediateAttribute]
		public IfcCartesianTransformationOperator2D Target;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Definition.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Definition.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Definition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Target == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Target.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Target.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedProfileDef : IfcProfileDef

		public IfcDerivedProfileDef(){}

		public IfcProfileDef ParentProfile;

		[ImmediateAttribute]
		public IfcCartesianTransformationOperator2D Operator;

		[ImmediateAttribute]
		public IfcLabel Label;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentProfile == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentProfile.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentProfile.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Operator.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Label == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Label.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Label.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedUnit : P21Instance

		public IfcDerivedUnit(){}

		public List< IfcDerivedUnitElement> Elements;

		[ImmediateAttribute]
		public IfcDerivedUnitEnum UnitType;

		[ImmediateAttribute]
		public IfcLabel UserDefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Elements.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedUnitElement : P21Instance

		public IfcDerivedUnitElement(){}

		public IfcNamedUnit Unit;

		[ImmediateAttribute]
		public INTEGER Exponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Unit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Unit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Unit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Exponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Exponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Exponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDiameterDimension : IfcDimensionCurveDirectedCallout

		public IfcDiameterDimension(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionCalloutRelationship : IfcDraughtingCalloutRelationship

		public IfcDimensionCalloutRelationship(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingDraughtingCallout.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatedDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedDraughtingCallout.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingCalloutRelationship : P21Instance

		public IfcDraughtingCalloutRelationship(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcDraughtingCallout RelatingDraughtingCallout;

		[ImmediateAttribute]
		public IfcDraughtingCallout RelatedDraughtingCallout;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingDraughtingCallout.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatedDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedDraughtingCallout.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLinearDimension : IfcDimensionCurveDirectedCallout

		public IfcLinearDimension(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRadiusDimension : IfcDimensionCurveDirectedCallout

		public IfcRadiusDimension(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingCallout : IfcGeometricRepresentationItem

		public IfcDraughtingCallout(){}

		public List< IfcDraughtingCalloutElement> Contents;

		[InverseAttribute]
		public List< IfcDraughtingCalloutRelationship> IsRelatedFromCallout;

		[InverseAttribute]
		public List< IfcDraughtingCalloutRelationship> IsRelatedToCallout;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionCurveTerminator : IfcTerminatorSymbol

		public IfcDimensionCurveTerminator(){}

		public IfcDimensionExtentUsage Role;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Item == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Item.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Item.EIN); }
			p21File.Write(EbConstants.Comma);
			Styles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AnnotatedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AnnotatedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + AnnotatedCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Role == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Role.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Role.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionPair : IfcDraughtingCalloutRelationship

		public IfcDimensionPair(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingDraughtingCallout.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatedDraughtingCallout == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedDraughtingCallout.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedDraughtingCallout.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionalExponents : P21Instance

		public IfcDimensionalExponents(){}

		public INTEGER LengthExponent;

		[ImmediateAttribute]
		public INTEGER MassExponent;

		[ImmediateAttribute]
		public INTEGER TimeExponent;

		[ImmediateAttribute]
		public INTEGER ElectricCurrentExponent;

		[ImmediateAttribute]
		public INTEGER ThermodynamicTemperatureExponent;

		[ImmediateAttribute]
		public INTEGER AmountOfSubstanceExponent;

		[ImmediateAttribute]
		public INTEGER LuminousIntensityExponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (LengthExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LengthExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LengthExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MassExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MassExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MassExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElectricCurrentExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElectricCurrentExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElectricCurrentExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThermodynamicTemperatureExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThermodynamicTemperatureExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThermodynamicTemperatureExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AmountOfSubstanceExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmountOfSubstanceExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmountOfSubstanceExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LuminousIntensityExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LuminousIntensityExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LuminousIntensityExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDirection : IfcGeometricRepresentationItem

		public IfcDirection(){}

		public List< REAL> DirectionRatios;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			DirectionRatios.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDiscreteAccessory : IfcElementComponent

		public IfcDiscreteAccessory(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementComponent : IfcElement

		public IfcElementComponent(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDiscreteAccessoryType : IfcElementComponentType

		public IfcDiscreteAccessoryType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcVibrationIsolatorType : IfcDiscreteAccessoryType

		public IfcVibrationIsolatorType(){}

		public IfcVibrationIsolatorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementComponentType : IfcElementType

		public IfcElementComponentType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionChamberElement : IfcDistributionFlowElement

		public IfcDistributionChamberElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionFlowElement : IfcDistributionElement

		public IfcDistributionFlowElement(){}

		public List< IfcRelFlowControlElements> HasControlElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionChamberElementType : IfcDistributionFlowElementType

		public IfcDistributionChamberElementType(){}

		public IfcDistributionChamberElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionFlowElementType : IfcDistributionElementType

		public IfcDistributionFlowElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionControlElement : IfcDistributionElement

		public IfcDistributionControlElement(){}

		public IfcIdentifier ControlElementId;

		[InverseAttribute]
		public List< IfcRelFlowControlElements> AssignedToFlowElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ControlElementId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ControlElementId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ControlElementId.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionElement : IfcElement

		public IfcDistributionElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowInstrumentType : IfcDistributionControlElementType

		public IfcFlowInstrumentType(){}

		public IfcFlowInstrumentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSensorType : IfcDistributionControlElementType

		public IfcSensorType(){}

		public IfcSensorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionElementType : IfcElementType

		public IfcDistributionElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnergyConversionDevice : IfcDistributionFlowElement

		public IfcEnergyConversionDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowController : IfcDistributionFlowElement

		public IfcFlowController(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowFitting : IfcDistributionFlowElement

		public IfcFlowFitting(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowMovingDevice : IfcDistributionFlowElement

		public IfcFlowMovingDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowSegment : IfcDistributionFlowElement

		public IfcFlowSegment(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowStorageDevice : IfcDistributionFlowElement

		public IfcFlowStorageDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTerminal : IfcDistributionFlowElement

		public IfcFlowTerminal(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTreatmentDevice : IfcDistributionFlowElement

		public IfcFlowTreatmentDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowStorageDeviceType : IfcDistributionFlowElementType

		public IfcFlowStorageDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTreatmentDeviceType : IfcDistributionFlowElementType

		public IfcFlowTreatmentDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionPort : IfcPort

		public IfcDistributionPort(){}

		public IfcFlowDirectionEnum FlowDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (FlowDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlowDirection.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPort : IfcProduct

		public IfcPort(){}

		public IfcRelConnectsPortToElement ContainedIn;

		[InverseAttribute]
		public List< IfcRelConnectsPorts> ConnectedFrom;

		[InverseAttribute]
		public List< IfcRelConnectsPorts> ConnectedTo;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentElectronicFormat : P21Instance

		public IfcDocumentElectronicFormat(){}

		public IfcLabel FileExtension;

		[ImmediateAttribute]
		public IfcLabel MimeContentType;

		[ImmediateAttribute]
		public IfcLabel MimeSubtype;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (FileExtension == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FileExtension.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FileExtension.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MimeContentType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MimeContentType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MimeContentType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MimeSubtype == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MimeSubtype.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MimeSubtype.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentInformation : P21Instance

		public IfcDocumentInformation(){}

		public IfcIdentifier DocumentId;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public List< IfcDocumentReference> DocumentReferences;

		[ImmediateAttribute]
		public IfcText Purpose;

		[ImmediateAttribute]
		public IfcText IntendedUse;

		[ImmediateAttribute]
		public IfcText Scope;

		[ImmediateAttribute]
		public IfcLabel Revision;

		[ImmediateAttribute]
		public IfcActorSelect DocumentOwner;

		[ImmediateAttribute]
		public List< IfcActorSelect> Editors;

		[ImmediateAttribute]
		public IfcDateAndTime CreationTime;

		[ImmediateAttribute]
		public IfcDateAndTime LastRevisionTime;

		[ImmediateAttribute]
		public IfcDocumentElectronicFormat ElectronicFormat;

		[ImmediateAttribute]
		public IfcCalendarDate ValidFrom;

		[ImmediateAttribute]
		public IfcCalendarDate ValidUntil;

		[ImmediateAttribute]
		public IfcDocumentConfidentialityEnum Confidentiality;

		[ImmediateAttribute]
		public IfcDocumentStatusEnum Status;

		[InverseAttribute]
		public List< IfcDocumentInformationRelationship> IsPointedTo;

		[InverseAttribute]
		public List< IfcDocumentInformationRelationship> IsPointer;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (DocumentId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DocumentId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DocumentId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			DocumentReferences.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (IntendedUse == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IntendedUse.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IntendedUse.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scope == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scope.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scope.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Revision == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Revision.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Revision.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DocumentOwner.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DocumentOwner.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DocumentOwner.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Editors.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CreationTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + CreationTime.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LastRevisionTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LastRevisionTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LastRevisionTime.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ElectronicFormat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElectronicFormat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ElectronicFormat.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ValidFrom == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValidFrom.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ValidFrom.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ValidUntil == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValidUntil.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ValidUntil.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Confidentiality == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Confidentiality.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Confidentiality.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentInformationRelationship : P21Instance

		public IfcDocumentInformationRelationship(){}

		public IfcDocumentInformation RelatingDocument;

		[ImmediateAttribute]
		public List< IfcDocumentInformation> RelatedDocuments;

		[ImmediateAttribute]
		public IfcLabel RelationshipType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RelatingDocument == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingDocument.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingDocument.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedDocuments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (RelationshipType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelationshipType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RelationshipType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentReference : IfcExternalReference

		public IfcDocumentReference(){}

		public List< IfcDocumentInformation> ReferenceToDocument;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorLiningProperties : IfcPropertySetDefinition

		public IfcDoorLiningProperties(){}

		public IfcPositiveLengthMeasure LiningDepth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure LiningThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ThresholdDepth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ThresholdThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TransomThickness;

		[ImmediateAttribute]
		public IfcLengthMeasure TransomOffset;

		[ImmediateAttribute]
		public IfcLengthMeasure LiningOffset;

		[ImmediateAttribute]
		public IfcLengthMeasure ThresholdOffset;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CasingThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CasingDepth;

		[ImmediateAttribute]
		public IfcShapeAspect ShapeAspectStyle;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TransomThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TransomThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TransomThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TransomOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TransomOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TransomOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CasingThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CasingThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CasingThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CasingDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CasingDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CasingDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeAspectStyle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeAspectStyle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ShapeAspectStyle.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPropertySetDefinition : IfcPropertyDefinition

		public IfcPropertySetDefinition(){}

		public List< IfcRelDefinesByProperties> PropertyDefinitionOf;

		[InverseAttribute]
		public List< IfcTypeObject> DefinesType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorPanelProperties : IfcPropertySetDefinition

		public IfcDoorPanelProperties(){}

		public IfcPositiveLengthMeasure PanelDepth;

		[ImmediateAttribute]
		public IfcDoorPanelOperationEnum PanelOperation;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure PanelWidth;

		[ImmediateAttribute]
		public IfcDoorPanelPositionEnum PanelPosition;

		[ImmediateAttribute]
		public IfcShapeAspect ShapeAspectStyle;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelOperation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelOperation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelOperation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelPosition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelPosition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelPosition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeAspectStyle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeAspectStyle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ShapeAspectStyle.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorStyle : IfcTypeProduct

		public IfcDoorStyle(){}

		public IfcDoorStyleOperationEnum OperationType;

		[ImmediateAttribute]
		public IfcDoorStyleConstructionEnum ConstructionType;

		[ImmediateAttribute]
		public BOOLEAN ParameterTakesPrecedence;

		[ImmediateAttribute]
		public BOOLEAN Sizeable;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstructionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstructionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstructionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParameterTakesPrecedence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParameterTakesPrecedence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ParameterTakesPrecedence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Sizeable == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Sizeable.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Sizeable.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTypeProduct : IfcTypeObject

		public IfcTypeProduct(){}

		public List< IfcRepresentationMap> RepresentationMaps;

		[ImmediateAttribute]
		public IfcLabel Tag;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStructuredDimensionCallout : IfcDraughtingCallout

		public IfcStructuredDimensionCallout(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Contents.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingPreDefinedColour : IfcPreDefinedColour

		public IfcDraughtingPreDefinedColour(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedColour : IfcPreDefinedItem

		public IfcPreDefinedColour(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont

		public IfcDraughtingPreDefinedCurveFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedCurveFont : IfcPreDefinedItem

		public IfcPreDefinedCurveFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingPreDefinedTextFont : IfcPreDefinedTextFont

		public IfcDraughtingPreDefinedTextFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedTextFont : IfcPreDefinedItem

		public IfcPreDefinedTextFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctFittingType : IfcFlowFittingType

		public IfcDuctFittingType(){}

		public IfcDuctFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSegmentType : IfcFlowSegmentType

		public IfcDuctSegmentType(){}

		public IfcDuctSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSilencerType : IfcFlowTreatmentDeviceType

		public IfcDuctSilencerType(){}

		public IfcDuctSilencerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdge : IfcTopologicalRepresentationItem

		public IfcEdge(){}

		public IfcVertex EdgeStart;

		[ImmediateAttribute]
		public IfcVertex EdgeEnd;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdgeCurve : IfcEdge

		public IfcEdgeCurve(){}

		public IfcCurve EdgeGeometry;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeGeometry == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeGeometry.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeGeometry.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOrientedEdge : IfcEdge

		public IfcOrientedEdge(){}

		public IfcEdge EdgeElement;

		[ImmediateAttribute]
		public BOOLEAN Orientation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeElement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeElement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeElement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Orientation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSubedge : IfcEdge

		public IfcSubedge(){}

		public IfcEdge ParentEdge;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ParentEdge == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentEdge.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentEdge.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRoundedEdgeFeature : IfcEdgeFeature

		public IfcRoundedEdgeFeature(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FeatureLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FeatureLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FeatureLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFeatureElementSubtraction : IfcFeatureElement

		public IfcFeatureElementSubtraction(){}

		public IfcRelVoidsElement VoidsElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdgeLoop : IfcLoop

		public IfcEdgeLoop(){}

		public List< IfcOrientedEdge> EdgeList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			EdgeList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLoop : IfcTopologicalRepresentationItem

		public IfcLoop(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricApplianceType : IfcFlowTerminalType

		public IfcElectricApplianceType(){}

		public IfcElectricApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricDistributionPoint : IfcFlowController

		public IfcElectricDistributionPoint(){}

		public IfcElectricDistributionPointFunctionEnum DistributionPointFunction;

		[ImmediateAttribute]
		public IfcLabel UserDefinedFunction;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DistributionPointFunction == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DistributionPointFunction.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DistributionPointFunction.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedFunction == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedFunction.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedFunction.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType

		public IfcElectricFlowStorageDeviceType(){}

		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricGeneratorType : IfcEnergyConversionDeviceType

		public IfcElectricGeneratorType(){}

		public IfcElectricGeneratorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricHeaterType : IfcFlowTerminalType

		public IfcElectricHeaterType(){}

		public IfcElectricHeaterTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricMotorType : IfcEnergyConversionDeviceType

		public IfcElectricMotorType(){}

		public IfcElectricMotorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricTimeControlType : IfcFlowControllerType

		public IfcElectricTimeControlType(){}

		public IfcElectricTimeControlTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricalBaseProperties : IfcEnergyProperties

		public IfcElectricalBaseProperties(){}

		public IfcElectricCurrentEnum ElectricCurrentType;

		[ImmediateAttribute]
		public IfcElectricVoltageMeasure InputVoltage;

		[ImmediateAttribute]
		public IfcFrequencyMeasure InputFrequency;

		[ImmediateAttribute]
		public IfcElectricCurrentMeasure FullLoadCurrent;

		[ImmediateAttribute]
		public IfcElectricCurrentMeasure MinimumCircuitCurrent;

		[ImmediateAttribute]
		public IfcPowerMeasure MaximumPowerInput;

		[ImmediateAttribute]
		public IfcPowerMeasure RatedPowerInput;

		[ImmediateAttribute]
		public INTEGER InputPhase;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EnergySequence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EnergySequence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EnergySequence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedEnergySequence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedEnergySequence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedEnergySequence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElectricCurrentType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElectricCurrentType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElectricCurrentType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InputVoltage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InputVoltage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InputVoltage.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InputFrequency == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InputFrequency.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InputFrequency.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FullLoadCurrent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FullLoadCurrent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FullLoadCurrent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinimumCircuitCurrent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinimumCircuitCurrent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinimumCircuitCurrent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaximumPowerInput == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaximumPowerInput.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaximumPowerInput.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RatedPowerInput == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RatedPowerInput.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RatedPowerInput.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InputPhase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InputPhase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InputPhase.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnergyProperties : IfcPropertySetDefinition

		public IfcEnergyProperties(){}

		public IfcEnergySequenceEnum EnergySequence;

		[ImmediateAttribute]
		public IfcLabel UserDefinedEnergySequence;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EnergySequence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EnergySequence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EnergySequence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedEnergySequence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedEnergySequence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedEnergySequence.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricalCircuit : IfcSystem

		public IfcElectricalCircuit(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSystem : IfcGroup

		public IfcSystem(){}

		public List< IfcRelServicesBuildings> ServicesBuildings;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricalElement : IfcElement

		public IfcElectricalElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementAssembly : IfcElement

		public IfcElementAssembly(){}

		public IfcAssemblyPlaceEnum AssemblyPlace;

		[ImmediateAttribute]
		public IfcElementAssemblyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AssemblyPlace == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AssemblyPlace.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AssemblyPlace.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEquipmentElement : IfcElement

		public IfcEquipmentElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFeatureElement : IfcElement

		public IfcFeatureElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFurnishingElement : IfcElement

		public IfcFurnishingElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTransportElement : IfcElement

		public IfcTransportElement(){}

		public IfcTransportElementTypeEnum OperationType;

		[ImmediateAttribute]
		public IfcMassMeasure CapacityByWeight;

		[ImmediateAttribute]
		public IfcCountMeasure CapacityByNumber;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CapacityByWeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CapacityByWeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CapacityByWeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CapacityByNumber == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CapacityByNumber.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CapacityByNumber.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcVirtualElement : IfcElement

		public IfcVirtualElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFastener : IfcElementComponent

		public IfcFastener(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFastenerType : IfcElementComponentType

		public IfcFastenerType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementQuantity : IfcPropertySetDefinition

		public IfcElementQuantity(){}

		public IfcLabel MethodOfMeasurement;

		[ImmediateAttribute]
		public List< IfcPhysicalQuantity> Quantities;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MethodOfMeasurement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MethodOfMeasurement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MethodOfMeasurement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Quantities.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFurnishingElementType : IfcElementType

		public IfcFurnishingElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSpatialStructureElementType : IfcElementType

		public IfcSpatialStructureElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTransportElementType : IfcElementType

		public IfcTransportElementType(){}

		public IfcTransportElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementarySurface : IfcSurface

		public IfcElementarySurface(){}

		public IfcAxis2Placement3D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlane : IfcElementarySurface

		public IfcPlane(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEllipseProfileDef : IfcParameterizedProfileDef

		public IfcEllipseProfileDef(){}

		public IfcPositiveLengthMeasure SemiAxis1;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure SemiAxis2;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis2.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEvaporativeCoolerType : IfcEnergyConversionDeviceType

		public IfcEvaporativeCoolerType(){}

		public IfcEvaporativeCoolerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEvaporatorType : IfcEnergyConversionDeviceType

		public IfcEvaporatorType(){}

		public IfcEvaporatorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcHeatExchangerType : IfcEnergyConversionDeviceType

		public IfcHeatExchangerType(){}

		public IfcHeatExchangerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcHumidifierType : IfcEnergyConversionDeviceType

		public IfcHumidifierType(){}

		public IfcHumidifierTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMotorConnectionType : IfcEnergyConversionDeviceType

		public IfcMotorConnectionType(){}

		public IfcMotorConnectionTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSpaceHeaterType : IfcEnergyConversionDeviceType

		public IfcSpaceHeaterType(){}

		public IfcSpaceHeaterTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTransformerType : IfcEnergyConversionDeviceType

		public IfcTransformerType(){}

		public IfcTransformerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTubeBundleType : IfcEnergyConversionDeviceType

		public IfcTubeBundleType(){}

		public IfcTubeBundleTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcUnitaryEquipmentType : IfcEnergyConversionDeviceType

		public IfcUnitaryEquipmentType(){}

		public IfcUnitaryEquipmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExtendedMaterialProperties : IfcMaterialProperties

		public IfcExtendedMaterialProperties(){}

		public List< IfcProperty> ExtendedProperties;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Material == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Material.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Material.EIN); }
			p21File.Write(EbConstants.Comma);
			ExtendedProperties.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMaterialProperties : P21Instance

		public IfcMaterialProperties(){}

		public IfcMaterial Material;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Material == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Material.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Material.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternallyDefinedHatchStyle : IfcExternalReference

		public IfcExternallyDefinedHatchStyle(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternallyDefinedSurfaceStyle : IfcExternalReference

		public IfcExternallyDefinedSurfaceStyle(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternallyDefinedSymbol : IfcExternalReference

		public IfcExternallyDefinedSymbol(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternallyDefinedTextFont : IfcExternalReference

		public IfcExternallyDefinedTextFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLibraryReference : IfcExternalReference

		public IfcLibraryReference(){}

		public List< IfcLibraryInformation> ReferenceIntoLibrary;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ItemReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ItemReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ItemReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExtrudedAreaSolid : IfcSweptAreaSolid

		public IfcExtrudedAreaSolid(){}

		public IfcDirection ExtrudedDirection;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Depth;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SweptArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SweptArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + SweptArea.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ExtrudedDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ExtrudedDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ExtrudedDirection.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Depth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Depth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Depth.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSweptAreaSolid : IfcSolidModel

		public IfcSweptAreaSolid(){}

		public IfcProfileDef SweptArea;

		[ImmediateAttribute]
		public IfcAxis2Placement3D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SweptArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SweptArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + SweptArea.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFace : IfcTopologicalRepresentationItem

		public IfcFace(){}

		public List< IfcFaceBound> Bounds;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Bounds.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFaceSurface : IfcFace

		public IfcFaceSurface(){}

		public IfcSurface FaceSurface;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Bounds.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (FaceSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FaceSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FaceSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem

		public IfcFaceBasedSurfaceModel(){}

		public List< IfcConnectedFaceSet> FbsmFaces;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			FbsmFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFaceBound : IfcTopologicalRepresentationItem

		public IfcFaceBound(){}

		public IfcLoop Bound;

		[ImmediateAttribute]
		public BOOLEAN Orientation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Bound == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Bound.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Bound.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Orientation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFaceOuterBound : IfcFaceBound

		public IfcFaceOuterBound(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Bound == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Bound.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Bound.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Orientation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFacetedBrep : IfcManifoldSolidBrep

		public IfcFacetedBrep(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcManifoldSolidBrep : IfcSolidModel

		public IfcManifoldSolidBrep(){}

		public IfcClosedShell Outer;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFacetedBrepWithVoids : IfcManifoldSolidBrep

		public IfcFacetedBrepWithVoids(){}

		public List< IfcClosedShell> Voids;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.Comma);
			Voids.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFailureConnectionCondition : IfcStructuralConnectionCondition

		public IfcFailureConnectionCondition(){}

		public IfcForceMeasure TensionFailureX;

		[ImmediateAttribute]
		public IfcForceMeasure TensionFailureY;

		[ImmediateAttribute]
		public IfcForceMeasure TensionFailureZ;

		[ImmediateAttribute]
		public IfcForceMeasure CompressionFailureX;

		[ImmediateAttribute]
		public IfcForceMeasure CompressionFailureY;

		[ImmediateAttribute]
		public IfcForceMeasure CompressionFailureZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TensionFailureX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TensionFailureX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TensionFailureX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TensionFailureY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TensionFailureY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TensionFailureY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TensionFailureZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TensionFailureZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TensionFailureZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompressionFailureX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompressionFailureX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompressionFailureX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompressionFailureY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompressionFailureY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompressionFailureY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompressionFailureZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompressionFailureZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompressionFailureZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStructuralConnectionCondition : P21Instance

		public IfcStructuralConnectionCondition(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFanType : IfcFlowMovingDeviceType

		public IfcFanType(){}

		public IfcFanTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMechanicalFastener : IfcFastener

		public IfcMechanicalFastener(){}

		public IfcPositiveLengthMeasure NominalDiameter;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure NominalLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NominalDiameter == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NominalDiameter.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NominalDiameter.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NominalLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NominalLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NominalLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMechanicalFastenerType : IfcFastenerType

		public IfcMechanicalFastenerType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFeatureElementAddition : IfcFeatureElement

		public IfcFeatureElementAddition(){}

		public IfcRelProjectsElement ProjectsElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectionElement : IfcFeatureElementAddition

		public IfcProjectionElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOpeningElement : IfcFeatureElementSubtraction

		public IfcOpeningElement(){}

		public List< IfcRelFillsElement> HasFillings;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFillAreaStyle : IfcPresentationStyle

		public IfcFillAreaStyle(){}

		public List< IfcFillStyleSelect> FillStyles;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			FillStyles.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFillAreaStyleHatching : IfcGeometricRepresentationItem

		public IfcFillAreaStyleHatching(){}

		public IfcCurveStyle HatchLineAppearance;

		[ImmediateAttribute]
		public IfcHatchLineDistanceSelect StartOfNextHatchLine;

		[ImmediateAttribute]
		public IfcCartesianPoint PointOfReferenceHatchLine;

		[ImmediateAttribute]
		public IfcCartesianPoint PatternStart;

		[ImmediateAttribute]
		public IfcPlaneAngleMeasure HatchLineAngle;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (HatchLineAppearance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HatchLineAppearance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + HatchLineAppearance.EIN); }
			p21File.Write(EbConstants.Comma);
			if (StartOfNextHatchLine.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartOfNextHatchLine.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartOfNextHatchLine.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PointOfReferenceHatchLine == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOfReferenceHatchLine.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PointOfReferenceHatchLine.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PatternStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PatternStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PatternStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (HatchLineAngle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HatchLineAngle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HatchLineAngle.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem

		public IfcFillAreaStyleTileSymbolWithStyle(){}

		public IfcAnnotationSymbolOccurrence Symbol;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Symbol == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Symbol.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Symbol.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem

		public IfcFillAreaStyleTiles(){}

		public IfcOneDirectionRepeatFactor TilingPattern;

		[ImmediateAttribute]
		public List< IfcFillAreaStyleTileShapeSelect> Tiles;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure TilingScale;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (TilingPattern == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TilingPattern.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TilingPattern.EIN); }
			p21File.Write(EbConstants.Comma);
			Tiles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (TilingScale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TilingScale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TilingScale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFilterType : IfcFlowTreatmentDeviceType

		public IfcFilterType(){}

		public IfcFilterTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFireSuppressionTerminalType : IfcFlowTerminalType

		public IfcFireSuppressionTerminalType(){}

		public IfcFireSuppressionTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowMeterType : IfcFlowControllerType

		public IfcFlowMeterType(){}

		public IfcFlowMeterTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProtectiveDeviceType : IfcFlowControllerType

		public IfcProtectiveDeviceType(){}

		public IfcProtectiveDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSwitchingDeviceType : IfcFlowControllerType

		public IfcSwitchingDeviceType(){}

		public IfcSwitchingDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcValveType : IfcFlowControllerType

		public IfcValveType(){}

		public IfcValveTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcJunctionBoxType : IfcFlowFittingType

		public IfcJunctionBoxType(){}

		public IfcJunctionBoxTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPipeFittingType : IfcFlowFittingType

		public IfcPipeFittingType(){}

		public IfcPipeFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPumpType : IfcFlowMovingDeviceType

		public IfcPumpType(){}

		public IfcPumpTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPipeSegmentType : IfcFlowSegmentType

		public IfcPipeSegmentType(){}

		public IfcPipeSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTankType : IfcFlowStorageDeviceType

		public IfcTankType(){}

		public IfcTankTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGasTerminalType : IfcFlowTerminalType

		public IfcGasTerminalType(){}

		public IfcGasTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLampType : IfcFlowTerminalType

		public IfcLampType(){}

		public IfcLampTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightFixtureType : IfcFlowTerminalType

		public IfcLightFixtureType(){}

		public IfcLightFixtureTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOutletType : IfcFlowTerminalType

		public IfcOutletType(){}

		public IfcOutletTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSanitaryTerminalType : IfcFlowTerminalType

		public IfcSanitaryTerminalType(){}

		public IfcSanitaryTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStackTerminalType : IfcFlowTerminalType

		public IfcStackTerminalType(){}

		public IfcStackTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWasteTerminalType : IfcFlowTerminalType

		public IfcWasteTerminalType(){}

		public IfcWasteTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFluidFlowProperties : IfcPropertySetDefinition

		public IfcFluidFlowProperties(){}

		public IfcPropertySourceEnum PropertySource;

		[ImmediateAttribute]
		public IfcTimeSeries FlowConditionTimeSeries;

		[ImmediateAttribute]
		public IfcTimeSeries VelocityTimeSeries;

		[ImmediateAttribute]
		public IfcTimeSeries FlowrateTimeSeries;

		[ImmediateAttribute]
		public IfcMaterial Fluid;

		[ImmediateAttribute]
		public IfcTimeSeries PressureTimeSeries;

		[ImmediateAttribute]
		public IfcLabel UserDefinedPropertySource;

		[ImmediateAttribute]
		public IfcThermodynamicTemperatureMeasure TemperatureSingleValue;

		[ImmediateAttribute]
		public IfcThermodynamicTemperatureMeasure WetBulbTemperatureSingleValue;

		[ImmediateAttribute]
		public IfcTimeSeries WetBulbTemperatureTimeSeries;

		[ImmediateAttribute]
		public IfcTimeSeries TemperatureTimeSeries;

		[ImmediateAttribute]
		public IfcDerivedMeasureValue FlowrateSingleValue;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure FlowConditionSingleValue;

		[ImmediateAttribute]
		public IfcLinearVelocityMeasure VelocitySingleValue;

		[ImmediateAttribute]
		public IfcPressureMeasure PressureSingleValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PropertySource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PropertySource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PropertySource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FlowConditionTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowConditionTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FlowConditionTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (VelocityTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VelocityTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + VelocityTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (FlowrateTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowrateTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FlowrateTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Fluid == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Fluid.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Fluid.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PressureTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PressureTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PressureTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPropertySource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPropertySource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPropertySource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TemperatureSingleValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TemperatureSingleValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TemperatureSingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WetBulbTemperatureSingleValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WetBulbTemperatureSingleValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WetBulbTemperatureSingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WetBulbTemperatureTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WetBulbTemperatureTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + WetBulbTemperatureTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TemperatureTimeSeries == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TemperatureTimeSeries.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TemperatureTimeSeries.EIN); }
			p21File.Write(EbConstants.Comma);
			if (FlowrateSingleValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowrateSingleValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlowrateSingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FlowConditionSingleValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowConditionSingleValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlowConditionSingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VelocitySingleValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VelocitySingleValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VelocitySingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PressureSingleValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PressureSingleValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PressureSingleValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFuelProperties : IfcMaterialProperties

		public IfcFuelProperties(){}

		public IfcThermodynamicTemperatureMeasure CombustionTemperature;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure CarbonContent;

		[ImmediateAttribute]
		public IfcHeatingValueMeasure LowerHeatingValue;

		[ImmediateAttribute]
		public IfcHeatingValueMeasure HigherHeatingValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Material == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Material.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Material.EIN); }
			p21File.Write(EbConstants.Comma);
			if (CombustionTemperature == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CombustionTemperature.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CombustionTemperature.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CarbonContent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CarbonContent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CarbonContent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LowerHeatingValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LowerHeatingValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LowerHeatingValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (HigherHeatingValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (HigherHeatingValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ HigherHeatingValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFurnitureType : IfcFurnishingElementType

		public IfcFurnitureType(){}

		public IfcAssemblyPlaceEnum AssemblyPlace;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AssemblyPlace == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AssemblyPlace.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AssemblyPlace.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSystemFurnitureElementType : IfcFurnishingElementType

		public IfcSystemFurnitureElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeneralMaterialProperties : IfcMaterialProperties

		public IfcGeneralMaterialProperties(){}

		public IfcMolecularWeightMeasure MolecularWeight;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Porosity;

		[ImmediateAttribute]
		public IfcMassDensityMeasure MassDensity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Material == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Material.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Material.EIN); }
			p21File.Write(EbConstants.Comma);
			if (MolecularWeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MolecularWeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MolecularWeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Porosity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Porosity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Porosity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MassDensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MassDensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MassDensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeneralProfileProperties : IfcProfileProperties

		public IfcGeneralProfileProperties(){}

		public IfcMassPerLengthMeasure PhysicalWeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Perimeter;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure MinimumPlateThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure MaximumPlateThickness;

		[ImmediateAttribute]
		public IfcAreaMeasure CrossSectionArea;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileDefinition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileDefinition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ProfileDefinition.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PhysicalWeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PhysicalWeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PhysicalWeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Perimeter == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Perimeter.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Perimeter.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinimumPlateThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinimumPlateThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinimumPlateThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaximumPlateThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaximumPlateThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaximumPlateThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CrossSectionArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CrossSectionArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CrossSectionArea.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStructuralProfileProperties : IfcGeneralProfileProperties

		public IfcStructuralProfileProperties(){}

		public IfcMomentOfInertiaMeasure TorsionalConstantX;

		[ImmediateAttribute]
		public IfcMomentOfInertiaMeasure MomentOfInertiaYZ;

		[ImmediateAttribute]
		public IfcMomentOfInertiaMeasure MomentOfInertiaY;

		[ImmediateAttribute]
		public IfcMomentOfInertiaMeasure MomentOfInertiaZ;

		[ImmediateAttribute]
		public IfcWarpingConstantMeasure WarpingConstant;

		[ImmediateAttribute]
		public IfcLengthMeasure ShearCentreZ;

		[ImmediateAttribute]
		public IfcLengthMeasure ShearCentreY;

		[ImmediateAttribute]
		public IfcAreaMeasure ShearDeformationAreaZ;

		[ImmediateAttribute]
		public IfcAreaMeasure ShearDeformationAreaY;

		[ImmediateAttribute]
		public IfcSectionModulusMeasure MaximumSectionModulusY;

		[ImmediateAttribute]
		public IfcSectionModulusMeasure MinimumSectionModulusY;

		[ImmediateAttribute]
		public IfcSectionModulusMeasure MaximumSectionModulusZ;

		[ImmediateAttribute]
		public IfcSectionModulusMeasure MinimumSectionModulusZ;

		[ImmediateAttribute]
		public IfcSectionModulusMeasure TorsionalSectionModulus;

		[ImmediateAttribute]
		public IfcLengthMeasure CentreOfGravityInX;

		[ImmediateAttribute]
		public IfcLengthMeasure CentreOfGravityInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileDefinition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileDefinition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ProfileDefinition.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PhysicalWeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PhysicalWeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PhysicalWeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Perimeter == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Perimeter.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Perimeter.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinimumPlateThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinimumPlateThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinimumPlateThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaximumPlateThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaximumPlateThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaximumPlateThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CrossSectionArea == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CrossSectionArea.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CrossSectionArea.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TorsionalConstantX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TorsionalConstantX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TorsionalConstantX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MomentOfInertiaYZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MomentOfInertiaYZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MomentOfInertiaYZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MomentOfInertiaY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MomentOfInertiaY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MomentOfInertiaY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MomentOfInertiaZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MomentOfInertiaZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MomentOfInertiaZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WarpingConstant == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WarpingConstant.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WarpingConstant.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShearCentreZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShearCentreZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShearCentreZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShearCentreY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShearCentreY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShearCentreY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShearDeformationAreaZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShearDeformationAreaZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShearDeformationAreaZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShearDeformationAreaY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShearDeformationAreaY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ShearDeformationAreaY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaximumSectionModulusY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaximumSectionModulusY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaximumSectionModulusY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinimumSectionModulusY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinimumSectionModulusY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinimumSectionModulusY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MaximumSectionModulusZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MaximumSectionModulusZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MaximumSectionModulusZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MinimumSectionModulusZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MinimumSectionModulusZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MinimumSectionModulusZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TorsionalSectionModulus == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TorsionalSectionModulus.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TorsionalSectionModulus.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProfileProperties : P21Instance

		public IfcProfileProperties(){}

		public IfcLabel ProfileName;

		[ImmediateAttribute]
		public IfcProfileDef ProfileDefinition;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileDefinition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileDefinition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ProfileDefinition.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricCurveSet : IfcGeometricSet

		public IfcGeometricCurveSet(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Elements.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricSet : IfcGeometricRepresentationItem

		public IfcGeometricSet(){}

		public List< IfcGeometricSetSelect> Elements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Elements.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricRepresentationContext : IfcRepresentationContext

		public IfcGeometricRepresentationContext(){}

		public IfcDimensionCount CoordinateSpaceDimension;

		[ImmediateAttribute]
		public REAL Precision;

		[ImmediateAttribute]
		public IfcAxis2Placement WorldCoordinateSystem;

		[ImmediateAttribute]
		public IfcDirection TrueNorth;

		[InverseAttribute]
		public List< IfcGeometricRepresentationSubContext> HasSubContexts;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ContextIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ContextType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CoordinateSpaceDimension == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CoordinateSpaceDimension.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CoordinateSpaceDimension.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Precision == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Precision.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Precision.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WorldCoordinateSystem.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WorldCoordinateSystem.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WorldCoordinateSystem.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TrueNorth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TrueNorth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TrueNorth.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext

		public IfcGeometricRepresentationSubContext(){}

		public IfcGeometricRepresentationContext ParentContext;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure TargetScale;

		[ImmediateAttribute]
		public IfcGeometricProjectionEnum TargetView;

		[ImmediateAttribute]
		public IfcLabel UserDefinedTargetView;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ContextIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ContextType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CoordinateSpaceDimension == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CoordinateSpaceDimension.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CoordinateSpaceDimension.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Precision == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Precision.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Precision.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WorldCoordinateSystem.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WorldCoordinateSystem.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WorldCoordinateSystem.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TrueNorth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TrueNorth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TrueNorth.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ParentContext == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentContext.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentContext.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TargetScale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TargetScale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TargetScale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TargetView == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TargetView.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TargetView.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedTargetView == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedTargetView.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedTargetView.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRepresentationContext : P21Instance

		public IfcRepresentationContext(){}

		public IfcLabel ContextIdentifier;

		[ImmediateAttribute]
		public IfcLabel ContextType;

		[InverseAttribute]
		public List< IfcRepresentation> RepresentationsInContext;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ContextIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ContextType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ContextType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ContextType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSource : IfcGeometricRepresentationItem

		public IfcLightSource(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcColourRgb LightColour;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure AmbientIntensity;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Intensity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightColour == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightColour.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LightColour.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AmbientIntensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmbientIntensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmbientIntensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Intensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Intensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Intensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem

		public IfcOneDirectionRepeatFactor(){}

		public IfcVector RepeatFactor;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RepeatFactor.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlanarExtent : IfcGeometricRepresentationItem

		public IfcPlanarExtent(){}

		public IfcLengthMeasure SizeInX;

		[ImmediateAttribute]
		public IfcLengthMeasure SizeInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SizeInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SizeInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SizeInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SizeInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SizeInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SizeInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSectionedSpine : IfcGeometricRepresentationItem

		public IfcSectionedSpine(){}

		public IfcCompositeCurve SpineCurve;

		[ImmediateAttribute]
		public List< IfcProfileDef> CrossSections;

		[ImmediateAttribute]
		public List< IfcAxis2Placement3D> CrossSectionPositions;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SpineCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SpineCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + SpineCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			CrossSections.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			CrossSectionPositions.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem

		public IfcShellBasedSurfaceModel(){}

		public List< IfcShell> SbsmBoundary;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			SbsmBoundary.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTextLiteral : IfcGeometricRepresentationItem

		public IfcTextLiteral(){}

		public IfcPresentableText Literal;

		[ImmediateAttribute]
		public IfcAxis2Placement Placement;

		[ImmediateAttribute]
		public IfcTextPath Path;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Literal == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Literal.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Literal.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Placement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Placement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Placement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Path == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Path.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Path.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcVector : IfcGeometricRepresentationItem

		public IfcVector(){}

		public IfcDirection Orientation;

		[ImmediateAttribute]
		public IfcLengthMeasure Magnitude;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Orientation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Magnitude == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Magnitude.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Magnitude.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRepresentationItem : P21Instance

		public IfcRepresentationItem(){}

		public List< IfcPresentationLayerAssignment> LayerAssignments;

		[InverseAttribute]
		public List< IfcStyledItem> StyledByItem;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGrid : IfcProduct

		public IfcGrid(){}

		public List< IfcGridAxis> UAxes;

		[ImmediateAttribute]
		public List< IfcGridAxis> VAxes;

		[ImmediateAttribute]
		public List< IfcGridAxis> WAxes;

		[InverseAttribute]
		public List< IfcRelContainedInSpatialStructure> ContainedInStructure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			UAxes.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			VAxes.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			WAxes.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGridAxis : P21Instance

		public IfcGridAxis(){}

		public IfcLabel AxisTag;

		[ImmediateAttribute]
		public IfcCurve AxisCurve;

		[ImmediateAttribute]
		public IfcBoolean SameSense;

		[InverseAttribute]
		public List< IfcGrid> PartOfW;

		[InverseAttribute]
		public List< IfcGrid> PartOfV;

		[InverseAttribute]
		public List< IfcGrid> PartOfU;

		[InverseAttribute]
		public List< IfcVirtualGridIntersection> HasIntersections;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (AxisTag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AxisTag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AxisTag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AxisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AxisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + AxisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGridPlacement : IfcObjectPlacement

		public IfcGridPlacement(){}

		public IfcVirtualGridIntersection PlacementLocation;

		[ImmediateAttribute]
		public IfcVirtualGridIntersection PlacementRefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (PlacementLocation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PlacementLocation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PlacementLocation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PlacementRefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PlacementRefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PlacementRefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObjectPlacement : P21Instance

		public IfcObjectPlacement(){}

		public List< IfcProduct> PlacesObject;

		[InverseAttribute]
		public List< IfcLocalPlacement> ReferencedByPlacements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcInventory : IfcGroup

		public IfcInventory(){}

		public IfcInventoryTypeEnum InventoryType;

		[ImmediateAttribute]
		public IfcActorSelect Jurisdiction;

		[ImmediateAttribute]
		public List< IfcPerson> ResponsiblePersons;

		[ImmediateAttribute]
		public IfcCalendarDate LastUpdateDate;

		[ImmediateAttribute]
		public IfcCostValue CurrentValue;

		[ImmediateAttribute]
		public IfcCostValue OriginalValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InventoryType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InventoryType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InventoryType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Jurisdiction.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Jurisdiction.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Jurisdiction.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ResponsiblePersons.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (LastUpdateDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LastUpdateDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LastUpdateDate.EIN); }
			p21File.Write(EbConstants.Comma);
			if (CurrentValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurrentValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + CurrentValue.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OriginalValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OriginalValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OriginalValue.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStructuralLoadGroup : IfcGroup

		public IfcStructuralLoadGroup(){}

		public IfcLoadGroupTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcActionTypeEnum ActionType;

		[ImmediateAttribute]
		public IfcActionSourceTypeEnum ActionSource;

		[ImmediateAttribute]
		public IfcRatioMeasure Coefficient;

		[ImmediateAttribute]
		public IfcLabel Purpose;

		[InverseAttribute]
		public List< IfcStructuralResultGroup> SourceOfResultGroup;

		[InverseAttribute]
		public List< IfcStructuralAnalysisModel> LoadGroupFor;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ActionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ActionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ActionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ActionSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ActionSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ActionSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Coefficient == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Coefficient.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Coefficient.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStructuralResultGroup : IfcGroup

		public IfcStructuralResultGroup(){}

		public IfcAnalysisTheoryTypeEnum TheoryType;

		[ImmediateAttribute]
		public IfcStructuralLoadGroup ResultForLoadGroup;

		[ImmediateAttribute]
		public BOOLEAN IsLinear;

		[InverseAttribute]
		public List< IfcStructuralAnalysisModel> ResultGroupFor;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TheoryType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TheoryType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TheoryType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResultForLoadGroup == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResultForLoadGroup.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ResultForLoadGroup.EIN); }
			p21File.Write(EbConstants.Comma);
			if (IsLinear == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IsLinear.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IsLinear.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcZone : IfcGroup

		public IfcZone(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid

		public IfcPolygonalBoundedHalfSpace(){}

		public IfcAxis2Placement3D Position;

		[ImmediateAttribute]
		public IfcBoundedCurve PolygonalBoundary;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BaseSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AgreementFlag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AgreementFlag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AgreementFlag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PolygonalBoundary == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PolygonalBoundary.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + PolygonalBoundary.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcHygroscopicMaterialProperties : IfcMaterialProperties

		public IfcHygroscopicMaterialProperties(){}

		public IfcPositiveRatioMeasure UpperVaporResistanceFactor;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure LowerVaporResistanceFactor;

		[ImmediateAttribute]
		public IfcIsothermalMoistureCapacityMeasure IsothermalMoistureCapacity;

		[ImmediateAttribute]
		public IfcVaporPermeabilityMeasure VaporPermeability;

		[ImmediateAttribute]
		public IfcMoistureDiffusivityMeasure MoistureDiffusivity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Material == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Material.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Material.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UpperVaporResistanceFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UpperVaporResistanceFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UpperVaporResistanceFactor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LowerVaporResistanceFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LowerVaporResistanceFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LowerVaporResistanceFactor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (IsothermalMoistureCapacity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IsothermalMoistureCapacity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IsothermalMoistureCapacity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VaporPermeability == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VaporPermeability.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VaporPermeability.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MoistureDiffusivity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MoistureDiffusivity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MoistureDiffusivity.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcImageTexture : IfcSurfaceTexture

		public IfcImageTexture(){}

		public IfcIdentifier UrlReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RepeatT == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatT.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatT.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TextureType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureTransform == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureTransform.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureTransform.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UrlReference == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UrlReference.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UrlReference.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcIrregularTimeSeries : IfcTimeSeries

		public IfcIrregularTimeSeries(){}

		public List< IfcIrregularTimeSeriesValue> Values;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StartTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EndTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EndTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EndTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeSeriesDataType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeSeriesDataType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeSeriesDataType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DataOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DataOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DataOrigin.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedDataOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedDataOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedDataOrigin.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Unit.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Unit.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Unit.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Values.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTimeSeries : P21Instance

		public IfcTimeSeries(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcDateTimeSelect StartTime;

		[ImmediateAttribute]
		public IfcDateTimeSelect EndTime;

		[ImmediateAttribute]
		public IfcTimeSeriesDataTypeEnum TimeSeriesDataType;

		[ImmediateAttribute]
		public IfcDataOriginEnum DataOrigin;

		[ImmediateAttribute]
		public IfcLabel UserDefinedDataOrigin;

		[ImmediateAttribute]
		public IfcUnit Unit;

		[InverseAttribute]
		public List< IfcTimeSeriesReferenceRelationship> DocumentedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StartTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EndTime.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EndTime.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EndTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeSeriesDataType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeSeriesDataType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeSeriesDataType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DataOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DataOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DataOrigin.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedDataOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedDataOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedDataOrigin.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Unit.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Unit.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Unit.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcIrregularTimeSeriesValue : P21Instance

		public IfcIrregularTimeSeriesValue(){}

		public IfcDateTimeSelect TimeStamp;

		[ImmediateAttribute]
		public List< IfcValue> ListValues;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (TimeStamp.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeStamp.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeStamp.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ListValues.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLShapeProfileDef : IfcParameterizedProfileDef

		public IfcLShapeProfileDef(){}

		public IfcPositiveLengthMeasure Depth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Width;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Thickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure FilletRadius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure EdgeRadius;

		[ImmediateAttribute]
		public IfcPlaneAngleMeasure LegSlope;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInX;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CentreOfGravityInY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Depth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Depth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Depth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Width == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Width.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Width.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Thickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Thickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Thickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EdgeRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EdgeRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LegSlope == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LegSlope.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LegSlope.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CentreOfGravityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CentreOfGravityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CentreOfGravityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLibraryInformation : P21Instance

		public IfcLibraryInformation(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcLabel Version;

		[ImmediateAttribute]
		public IfcOrganization Publisher;

		[ImmediateAttribute]
		public IfcCalendarDate VersionDate;

		[ImmediateAttribute]
		public List< IfcLibraryReference> LibraryReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Version == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Version.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Version.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Publisher == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Publisher.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Publisher.EIN); }
			p21File.Write(EbConstants.Comma);
			if (VersionDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VersionDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + VersionDate.EIN); }
			p21File.Write(EbConstants.Comma);
			LibraryReference.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightDistributionData : P21Instance

		public IfcLightDistributionData(){}

		public IfcPlaneAngleMeasure MainPlaneAngle;

		[ImmediateAttribute]
		public List< IfcPlaneAngleMeasure> SecondaryPlaneAngle;

		[ImmediateAttribute]
		public List< IfcLuminousIntensityDistributionMeasure> LuminousIntensity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (MainPlaneAngle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MainPlaneAngle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MainPlaneAngle.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			SecondaryPlaneAngle.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			LuminousIntensity.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightIntensityDistribution : P21Instance

		public IfcLightIntensityDistribution(){}

		public IfcLightDistributionCurveEnum LightDistributionCurve;

		[ImmediateAttribute]
		public List< IfcLightDistributionData> DistributionData;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (LightDistributionCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightDistributionCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LightDistributionCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			DistributionData.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSourceAmbient : IfcLightSource

		public IfcLightSourceAmbient(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightColour == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightColour.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LightColour.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AmbientIntensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmbientIntensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmbientIntensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Intensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Intensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Intensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSourceDirectional : IfcLightSource

		public IfcLightSourceDirectional(){}

		public IfcDirection Orientation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightColour == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightColour.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LightColour.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AmbientIntensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmbientIntensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmbientIntensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Intensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Intensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Intensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Orientation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSourceGoniometric : IfcLightSource

		public IfcLightSourceGoniometric(){}

		public IfcAxis2Placement3D Position;

		[ImmediateAttribute]
		public IfcColourRgb ColourAppearance;

		[ImmediateAttribute]
		public IfcThermodynamicTemperatureMeasure ColourTemperature;

		[ImmediateAttribute]
		public IfcLuminousFluxMeasure LuminousFlux;

		[ImmediateAttribute]
		public IfcLightEmissionSourceEnum LightEmissionSource;

		[ImmediateAttribute]
		public IfcLightDistributionDataSourceSelect LightDistributionDataSource;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightColour == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightColour.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LightColour.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AmbientIntensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmbientIntensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmbientIntensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Intensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Intensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Intensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ColourAppearance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ColourAppearance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ColourAppearance.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ColourTemperature == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ColourTemperature.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ColourTemperature.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LuminousFlux == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LuminousFlux.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LuminousFlux.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightEmissionSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightEmissionSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LightEmissionSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightDistributionDataSource.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightDistributionDataSource.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LightDistributionDataSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSourcePositional : IfcLightSource

		public IfcLightSourcePositional(){}

		public IfcCartesianPoint Position;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Radius;

		[ImmediateAttribute]
		public IfcReal ConstantAttenuation;

		[ImmediateAttribute]
		public IfcReal DistanceAttenuation;

		[ImmediateAttribute]
		public IfcReal QuadricAttenuation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LightColour == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LightColour.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LightColour.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AmbientIntensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmbientIntensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmbientIntensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Intensity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Intensity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Intensity.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstantAttenuation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstantAttenuation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstantAttenuation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DistanceAttenuation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DistanceAttenuation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DistanceAttenuation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (QuadricAttenuation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (QuadricAttenuation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ QuadricAttenuation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLightSourceSpot : IfcLightSourcePositional

		public IfcLightSourceSpot(){}

		public IfcDirection Orientation;

		[ImmediateAttribute]
		public IfcReal ConcentrationExponent;

		[ImmediateAttribute]
		public IfcPositivePlaneAngleMeasure SpreadAngle;

		[ImmediateAttribute]
		public IfcPositivePlaneAngleMeasure BeamWidthAngle;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
		}