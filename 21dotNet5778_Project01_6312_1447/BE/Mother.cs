using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    enum Days { Sat ,Sun , Mon ,Tue ,Wed ,Thu ,Fry}

    /// <summary>
    /// class representing a mother
    /// </summary>
    [Serializable]
    public class Mother
    {
        public int MotherId { get; set; }
        public string MotherLastName { get; set; }
        public string MotherFirstName { get; set; }
        public int MotherPhoneNumber { get; set; }
        public string MotherAddress { get; set; }///,,,,
        public string MotherAroundAddress { get; set; }///,,,,
        [XmlIgnoreAttribute]
        public bool[] MotherDaysOfWork { get; set; }
        public string MotherDaysOfWorkstring
        {
            get
            {
                if (MotherDaysOfWork == null)
                    return null;
                string result = "";
                if (MotherDaysOfWork != null)
                {
                    int sizeA = MotherDaysOfWork.GetLength(0);
                    //  int sizeB = NannyDaysOfWork.GetLength(1);
                    result += "" + sizeA;// + "," + sizeB;
                    for (int i = 0; i < sizeA; i++)
                    {
                        //   for (int j = 0; j < sizeB; j++)
                        result += "," + MotherDaysOfWork[i];
                    }
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = int.Parse(values[0]);
                    //   int sizeB = int.Parse(values[1]);
                    MotherDaysOfWork = new bool[sizeA];
                    int index = 1;
                    for (int i = 0; i < sizeA; i++)
                    {
                        //   for (int j = 0; j < sizeB; j++)
                        MotherDaysOfWork[i] = bool.Parse(values[index++]);
                    }

                }
            }
        }




        //     public int[,] MotherTableOfWork { get; set; }

        [XmlIgnoreAttribute]
        public int[,] MotherTableOfWork { get; set; }


        public string MotherTableOfWorkstring
        {
            get
            {
                if (MotherTableOfWork == null)
                    return null;
                string result = "";
                if (MotherTableOfWork != null)
                {
                    int sizeA = MotherTableOfWork.GetLength(0);
                    int sizeB = MotherTableOfWork.GetLength(1);
                    result += "" + sizeA + "," + sizeB;
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            result += "," + MotherTableOfWork[i, j];
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = 2;//int.Parse(values[0]);
                    int sizeB = 6;// int.Parse(values[1]);
                    MotherTableOfWork = new int[sizeA, sizeB];
                    int index = 2;
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            MotherTableOfWork[i, j] = int.Parse(values[index++]);
                }
            }
        }
        public string MotherRemarks { get; set; }
        //
        public int? kilometerAround { get; set; }
        public  DateTime MotherDate { get; set; }
        public bool MotherHaveElevator { get; set; }
        public   int MotherKidsAverage { get; set; }



        //public int MotherYearsExperience { get; set; }//daniel
       // public int MotherMaxKidslimit { get; set; }
        public int MotherMinKidsAge { get; set; }///month
        public int MotherMaxKidsAge { get; set; }///month
        public bool MotherIsHourlysalary { get; set; }
        public int MotherTariffForHour { get; set; }
        public int MotherTariffForMonth { get; set; }///month
        public bool MotherHolidaysTamat { get; set; }
        public override string ToString()
        {
            return PropertyStringTool.ToStringProperty(this);
        }

        private string imageSource;
        //[Browsable(false)]
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Mother()
        {
            //imageSource = (@"images\start\empty.png");  //(@"vv");
            imageSource = (@"images\start\mother.jpg");  //(@"vv");
           

            //imageSource = (@"images\start\empty.png");  //(@"vv");

        }
    }
}
