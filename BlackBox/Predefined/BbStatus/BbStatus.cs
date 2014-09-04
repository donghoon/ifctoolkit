using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BlackBox.Service;
using EbInstanceModel;
using IFC2X3;
using System.Linq;

namespace BlackBox.Predefined
{
    public partial class BbStatus : BbBase
    {
        
        static readonly List<string> StatusStrings = new List<string>
        {
            "Default",
            "ReadyForProcurement",
            "ReadyForMill",
            "IssuedForFabrication"
        };


        static readonly List<string> ChangeStatusStrings = new List<string>
        {
           "Default", "Changed", "Deleted"
        };




        public string Status { get; private set; }

        public string ChangeStatus { get; private set; }

        public bool Approved { get; private set; }




        public BbPropertySet BbPropertySet { get; private set; }


        protected BbStatus(
            BbPropertySet bbPropertySet,
            string status,
            string changeStatus,
            bool? approved
            )
        {
            BbPropertySet = bbPropertySet;
            if (!string.IsNullOrWhiteSpace(status))
            {
                Status = status;
                bbPropertySet.AddProperty(BbPropertyEnumerated.Create("Status", Status, true));
            }

            if (!string.IsNullOrWhiteSpace(changeStatus))
            {
                ChangeStatus = changeStatus;
            bbPropertySet.AddProperty(BbPropertyEnumerated.Create("ChangeStatus", ChangeStatus, true));
            }
            if (approved != null)
            {
                Approved = approved.Value;
                bbPropertySet.AddProperty(BbSingleProperty.Create("Approved", Approved));
            }
            
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bbPropertySet"></param>
        /// <param name="status">One of "Default", "ReadyForProcurement", "ReadyForMill", "IssuedForFabrication"</param>
        /// <param name="changeStatus">One of "Default", "Changed", "Deleted"</param>
        /// <param name="approved"></param>
        /// <returns></returns>
        public static BbStatus Create(
           BbPropertySet bbPropertySet,
            string status,
            string changeStatus,
            bool? approved)
        {
            var ai = new BbStatus(
				bbPropertySet,
             status,
             changeStatus,
             approved);
            return ai;
        }

        public void AssignTo(BbElement element)
        {
            //element.IfcElement.Name = Name;
            BbPropertySet.AssignTo(element);
        }

    }
    
}
