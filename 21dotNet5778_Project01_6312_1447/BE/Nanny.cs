using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


using System.IO;

using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;



namespace BE
{


    /// <summary>
    /// class representing a mother
    /// </summary>
    [Serializable]
    public class Nanny
    {
        public int NannyId { get; set; }
        public string NannyLastName { get; set; }
        public string NannyFirstName { get; set; }
        public DateTime NannyDate { get; set; }
        public int NannyPhoneNumber { get; set; }
        public string NannyAddress { get; set; }///,,,,
        public bool NannyHaveElevator { get; set; }
        public int NannyFloor { get; set; }
        public int NannyYearsExperience { get; set; }
        public int NannyMaxKidslimit { get; set; }
        public DateTime NannyMinKidsAge { get; set; }///month
        public DateTime NannyMaxKidsAge { get; set; }///month
        public bool NannyIsHourlysalary { get; set; }
        public int NannyTariffForHour { get; set; }
        public int NannyTariffForMonth { get; set; }///month
        [XmlIgnore]
        public bool[] NannyDaysOfWork { get; set; }
        //    private int[][] n_x;
        //    public int[][] NannyTableOfWork
        //    {
        //        get { return n_x; }
        //        private set { if (value.GetLength(0) == 2 && value.GetLength(1) == 6) { n_x = value; } else { } }
        //    }
       // [XmlIgnoreAttribute]
        public string NannyDaysOfWorkstring
        {
            get
            {
                if (NannyDaysOfWork == null)
                    return null;
                string result = "";
                if (NannyDaysOfWork != null)
                {
                    int sizeA = NannyDaysOfWork.GetLength(0);
                    //  int sizeB = NannyDaysOfWork.GetLength(1);
                    result += "" + sizeA;// + "," + sizeB;
                    for (int i = 0; i < sizeA; i++)
                    {
                        //   for (int j = 0; j < sizeB; j++)
                        result += "," + NannyDaysOfWork[i];
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
                    NannyDaysOfWork = new bool[sizeA];
                    int index = 1;
                    for (int i = 0; i < sizeA; i++)
                    {
                        //   for (int j = 0; j < sizeB; j++)
                        NannyDaysOfWork[i] = bool.Parse(values[index++]);
                    }

                }
            }
        }
        [XmlIgnoreAttribute]
        public int[,] NannyTableOfWork { get; set; }

     
        public string NannyTableOfWorkstring
        {
            get
            {
                if (NannyTableOfWork == null)
                    return null;
                string result = "";
                if (NannyTableOfWork != null)
                {
                    int sizeA = NannyTableOfWork.GetLength(0);
                    int sizeB = NannyTableOfWork.GetLength(1);
                    result += "" + sizeA + "," + sizeB;
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            result += "," + NannyTableOfWork[i, j];
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = int.Parse(values[0]);
                    int sizeB = int.Parse(values[1]);
                    NannyTableOfWork = new int[sizeA, sizeB];
                    int index = 2;
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            NannyTableOfWork[i, j] = int.Parse(values[index++]);
                }
            }
        }
        public bool NannyHolidaysTamat { get; set; }
        public string NannyRecommendations { get; set; }

        public override string ToString()
        {
            return PropertyStringTool.ToStringProperty(this);
        }       
       
        public bool NannySpecialKids { get; set; }
        
       // public int divorcee{ get; set; }
        public int Nice { get; set; }

        private string imageSource;
        //[Browsable(false)]
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Nanny()
        {
            //imageSource = (@"images\start\empty.png");  //(@"vv");
            imageSource = (@"images\start\nanny.jpg");  //(@"vv");
            NannyMaxKidslimit = 3;


            //imageSource = (@"images\start\empty.png");  //(@"vv");

        }


        // public int Canhelpwithhomework{ get; set; }
        // public static explicit operator Nanny(object v)
        // {
        //     throw new NotImplementedException();
        //}
        //       public int NannyProfessionalYears { get; set; }
        //public void NannyDaysOfWorkPrint(bool[] a)
        //{
        //    Console.WriteLine("Sun-" + a[0] + " | " + "Mon-" + a[1] + " | " + "Tue-" + a[2] + " | " +
        //                      "Wed-" + a[3] + " | " + "Thu-" + a[4] + " | " + " Fry-" + a[5] + " | ");
        //}
        //public Nanny GetCopy()
        //{
        //    return (Nanny)this.MemberwiseClone();
        //}

       
    }

}
