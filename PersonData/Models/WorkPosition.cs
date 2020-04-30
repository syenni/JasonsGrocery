using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class WorkPosition
    {
        public int WorkPositionID { get; }
        public double HourlyPay { get; }
        public string PositionName { get; }
        public WorkPositionType WorkPositionType { get; }

        public WorkPosition(int workpositionID, double hourlypay, string positionName, WorkPositionType workPositionType)
        {
            WorkPositionID = workpositionID;
            HourlyPay = hourlypay;
            PositionName = positionName;
            WorkPositionType = workPositionType;
        }

        public WorkPosition(string positionName, double avghourlypay)
        {
            PositionName = positionName;
            HourlyPay = avghourlypay;
        }
    }
}
