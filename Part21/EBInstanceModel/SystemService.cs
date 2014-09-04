using System;
using System.Diagnostics;
using System.Reflection;

namespace EbInstanceModel
{
    public class SystemService
    {
        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>Get executing assembly product attribute</summary>
        public static string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        ///// <summary>Dictionary of IFCSPATIALSTRUCTUREELEMENT and relating IfcDefinition(s)</summary>
        //internal static IfcRelationDictionary<IfcSpatialStructureElement> SpatialStructureElementTable { get; set; }

        /// <summary>Name of current user detected from the environment</summary>
        internal static string SystemUser { get { return Environment.UserName; } }

        /// <summary>Name of current application or executable</summary>
        internal static string ExecutableName { get { return Process.GetCurrentProcess().ProcessName; } }
    }
}