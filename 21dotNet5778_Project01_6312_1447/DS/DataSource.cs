using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DS
{
    /// <summary>
    /// Data Source of all program data (saved in static lists)
    /// </summary>
    public class DataSource
    {
        

        public static List<Nanny> ListOfNannys = new List<Nanny>();
        public static List<Mother> ListOfMothers = new List<Mother>();
        public static List<Child> ListOfChild = new List<Child>();
        public static List<Contract> ListOfContracts = new List<Contract>();

        public void SaveStudentList()
        {
            XElement studentRoot = new XElement("students");
            foreach (Child item in ListOfChild)
            {
                XElement id = new XElement("id", item.ChildId);
                XElement MotherId = new XElement("MotherId", item.MotherId);
                XElement ChildLastName = new XElement("ChildLastName", item.ChildLastName);
                XElement ChildFirstName = new XElement("ChildFirstName", item.ChildFirstName);
                XElement ChildDate = new XElement("ChildDate", item.ChildDate);
                XElement ChildIsSpecial = new XElement("ChildIsSpecial", item.ChildIsSpecial);
                XElement ChildSpical = new XElement("ChildSpical", item.ChildSpical);
                XElement friendly = new XElement("friendly", item.friendly);
                XElement shy = new XElement("shy", item.shy);
                XElement Calm = new XElement("Calm", item.Calm);
               
                XElement student = new XElement("student", id, MotherId, ChildLastName, ChildFirstName, ChildDate, ChildIsSpecial, ChildSpical, friendly, shy, Calm);
                studentRoot.Add(student);
            }
            studentRoot.Save("ListOfChild.xml");
        }
        DataSource()
        {

        }
        ~DataSource()
        {
            SaveStudentList();
        }
        #region copy Data Source function by v
        /// <summary>
        /// Returns a copy from DataSource of the list-
        /// </summary>
        /// <returns></returns>
        public static List<Nanny> ListOfNannyByV()
        {
            List<Nanny> a = new List<Nanny>();
            foreach (Nanny item in ListOfNannys)
            {
                a.Add(item);
            }
            return a;
        }
        public static List<Mother> ListOfMotherByV()
        {
            List<Mother> a = new List<Mother>();
            foreach (Mother item in ListOfMothers)
            {
                a.Add(item);
            }
            return a;
        }
        public static List<Child> ListOfChildByV()
        {
            List<Child> a = new List<Child>();
            foreach (Child item in ListOfChild)
            {
                a.Add(item);
            }
            return a;
        }
        public static List<Contract> ListOfContractByV()
        {
            List<Contract> a = new List<Contract>();
            foreach (Contract item in ListOfContracts)
            {
                a.Add(item);
            }
            return a;
        }
        #endregion




    }

}
