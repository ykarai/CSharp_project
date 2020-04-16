using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   
    /// <summary>
    /// A class representing a child
    /// </summary>
    [Serializable]
    public class Child
    {

        public int childId;
        public int ChildId
        {
            get { return childId; }
            set
            {
                // if (value > 0 && Convert.ToString(value).Length>5)
                if (value > 0)
                    this.childId = value; ;
            }
        }
       
        public int MotherId { get; set; }
        public string childLastName;

        public string ChildLastName
        { 
        get { return childLastName; }
        set
            {
                //if (!(HasNumber.hasNumber(value.ToString())))
                //    this.childLastName = value; ;
                //if (!(HasNumber.hasNumber(value.ToString())))
                    this.childLastName = value; ;
            }
        }
        public string ChildFirstName { get; set; }
        public DateTime ChildDate { get; set; }
        public bool ChildIsSpecial { get; set; }
        public string ChildSpical { get; set; }

        public int friendly{ get; set; }
        public int shy { get; set; }
        public int Calm { get; set; }

        public override string ToString()
        {
              return PropertyStringTool.ToStringProperty(this); 
        }


        public string imageSource;
        //[Browsable(false)]
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Child()
        {
           // ChildSpical = "a";
            //imageSource = (@"images\start\empty.png");  //(@"vv");
            imageSource = (@"images\start\child.jpg");  //(@"vv");
            friendly = 10;
            shy = 9;
            Calm = 8;

            //imageSource = (@"images\start\empty.png");  //(@"vv");

        }






        //      int MotherPhoneNumber { get; set; }
        //      string MotherAddress { get; set; }///,,,,
        //      string MotherAroundAddress { get; set; }///,,,,
        //      bool MotherHaveElevator { get; set; }
        //      int MotherFloor { get; set; }
        //      int MotherYearsExperience { get; set; }
        //      int MotherMaxKidslimit { get; set; }
        //      int MotherMinKidsAge { get; set; }///month
        //      int MotherMaxKidsAge { get; set; }///month
        //      bool MotherIsHourlysalary { get; set; }
        //      int MotherTariffForHour { get; set; }
        //      int MotherTariffForMonth { get; set; }///month
        //      bool[] MotherDaysOfWork { get; set; }
        //      int[][] MotherTableOfWork { get; set; }
        //      bool MotherHolidaysTamat { get; set; }
        //      string MotherRemarks { get; set; }
    }
}
