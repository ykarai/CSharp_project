using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    /// <summary>
    /// class representing a contract between a nanny and a child
    /// </summary>
    [Serializable]
    public class Contract
    {
        public  int ContractId { get; set; }//8
        public  int NannyId { get; set; }
        public int ChildId { get; set; }
        public bool Meet { get; set; }
        public bool ContractSigned { get; set; }
        public int ContractTariffForHour { get; set; }
        public int ContractTariffForMonth { get; set; }///month
        public bool ContractIsHourlysalary { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public Double ContractFinelSalary{ get; set; }


       public int MotherId { get; set; }
       //public int Thecontractisclosedandcannotbechanged { get; set; }

        public override string ToString()
        {
            return PropertyStringTool.ToStringProperty(this);

        }


        private string imageSource;
        [Browsable(false)]
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Contract()
        {
            //imageSource = (@"images\start\empty.png");  //(@"vv");
            imageSource = (@"images\start\contract.jpg");  //(@"vv");
            

            //imageSource = (@"images\start\empty.png");  //(@"vv");

        }
        //int NannyPhoneNumber { get; set; }
        //string NannyAddress { get; set; }///,,,,
        //bool NannyHaveElevator { get; set; }
        //int NannyFloor { get; set; }
        //int NannyYearsExperience { get; set; }
        //int NannyMaxKidslimit { get; set; }
        //int NannyMinKidsAge { get; set; }///month
        //int NannyMaxKidsAge { get; set; }///month
        //bool NannyIsHourlysalary { get; set; }
        //int NannyTariffForHour { get; set; }
        //int NannyTariffForMonth { get; set; }///month
        //bool[] NannyDaysOfWork { get; set; }
        //int[][] NannyTableOfWork { get; set; }
        //bool NannyHolidaysTamat { get; set; }
        //string NannyRecommendations { get; set; }
    }
}
