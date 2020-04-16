using BE;
using DS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DAL
{
    class Dal_XML_imp :Idal
    {
        static int contractnumber = 1000; //for contract ID
       // XElement childRoot;

        public static string childPath = @"ChildXml.xml";
        public static string PathNanny = @"NannyXml.xml";
        public static string PathMother = @"MotherXml.xml";
        public static string PathContract = @"ContractXml.xml";

        static XElement NannyRoot;
        static XElement MotherRoot;
        static XElement ContractRoot;


        #region Nanny functions

        /// <summary>
        /// Add Nanny to Data Source 
        /// </summary>
        public void AddNanny(Nanny nanny_)
        {
            Nanny nanny = GetNanny(nanny_.NannyId);
            if (nanny != null)
                throw new Exception("Nanny with the same id already exists...");
           
            List<Nanny> a = ReceiveNannys();
            a.Add(nanny_);
            SetNannyList(a);
    
            //SaveToXML(nanny, "userXmlBySerilalizer.xml");

            //List<Nanny> list = LoadFromXML<List<Nanny>>(PathNanny);
            //return list.FirstOrDefault(s => s.NannyId == nannyId);

            //DataSource.ListOfNannys.Add(nanny_);
        }
        /// <summary>
        /// Get Nanny cheacking if nanny exist in data source
        /// </summary>
        /// <returns>Nanny or null if not exist in data source</returns>
        public Nanny GetNanny(int nannyId)
        {
            return ReceiveNannys().FirstOrDefault(s => s.NannyId == nannyId);

            //List<Nanny> list= LoadFromXML<List<Nanny>>(PathNanny);
            //return list.FirstOrDefault(s => s.NannyId == nannyId);

            #region implement 2
            //            Nanny b = null;
            ////          IEnumerable<Nanny> a = DataSource.ListOfNannys.AsEnumerable();
            //            List<Nanny> a;
            //            a = DataSource.ListOfNannyByV();
            //            int x = nannyId;
            //            var v = from item in a
            //                    where item.NannyId == x
            //                    select item;
            //            foreach (var item in v)
            //            {
            //                b = item;
            //            }
            //            return b;
            #endregion
        }


        /// <summary>
        /// Remove Nanny from data source
        /// </summary>
        /// <param name="id"></param>
        public bool RemoveNanny(int id)
        {
            Nanny nanny = GetNanny(id);
            if (nanny == null)
            {
                throw new Exception("Nanny with this id no exists...");
            }
            bool flag = false;
            List<Nanny> a = ReceiveNannys();
            if (a!=null)
            {
                int i = 0;
                foreach (var item in a)
                {
                    if (item.NannyId==nanny.NannyId)
                    {
                        flag = true;
                        a.RemoveAt(i);
                        

                    }
                    i++;
                    if (flag)
                    {
                        break;
                    }
                }
            }
           // bool flag = a.Remove(nanny);
            SetNannyList(a);
            return flag;
            //Dal_XML_imp.ListOfNannys.Remove(nanny);         
            //return DataSource.ListOfNannys.Remove(nanny);
        }
        /// <summary>
        /// Update Nanny in data source
        /// </summary>
        public void UpdateNanny(Nanny nanny)
        {
            List<Nanny> a1 =ReceiveNannys();
            int i = a1.FindIndex(s => s.NannyId == nanny.NannyId);
            if (i == -1)
                throw new Exception("Nanny with the same id not found...");
            List<Nanny> a = ReceiveNannys();
            a[i] = nanny;
            SetNannyList(a);

            //    DataSource.ListOfNannys[DataSource.ListOfNannys.FindIndex(s => s.NannyId == nanny.NannyId)] = nanny;
            //int i = DataSource.ListOfNannys.FindIndex(s => s.NannyId == nanny.NannyId);
            //if (i == -1)
            //    throw new Exception("Nanny with the same id not found...");
            //DataSource.ListOfNannys[i] = nanny;
        }
        public IEnumerable<Nanny> GetNannyIEnumerable(Func<Nanny, bool> predicat = null)
        {
            FileStream file = new FileStream(PathNanny, FileMode.Open);
            try
            {
                // FileStream file = new FileStream(PathNanny, FileMode.Open);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Nanny>));
                List<Nanny> nanny = new List<Nanny>();
                if (file.Length == 0)
                {

                    file.Close();
                    return new List<Nanny>();
                }
                nanny = (List<Nanny>)xmlSerializer.Deserialize(file);
                file.Close();
                if (predicat == null)
                    return nanny.AsEnumerable();
                return nanny.Where(predicat);

            }
            catch (Exception a)
            {
                file.Close();
                throw new Exception("xml");
            }




            //if (predicat == null)
            //    return DataSource.ListOfNannys.AsEnumerable();

            //return DataSource.ListOfNannys.Where(predicat);
        }

        public void SetNannyList(List<Nanny> list)
        {
            FileStream file = new FileStream(PathNanny, FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(list.GetType());
            xmlSerializer.Serialize(file, list);
            file.Close();
        }

        #endregion


        #region Mother functions

        /// <summary>
        /// Add Mother to Data Source 
        /// </summary>
        /// <param name="nanny_"></param>
        public void AddMother(Mother mother_)
        {

            Mother mother = GetMother(mother_.MotherId);
            if (mother != null)
                throw new Exception("mother with the same id already exists...");
            // Dal_XML_imp.ListOfMothers.Add(mother_);
            List<Mother> a = ReceiveMothers();
            a.Add(mother_);
            SetMotherList(a);


            //Mother mother = GetMother(mother_.MotherId);
            //if (mother != null)
            //    throw new Exception("mother with the same id already exists...");
            //DataSource.ListOfMothers.Add(mother_);
        }

        /// <summary>
        /// Get mother cheacking if mother exist in data source
        /// </summary>
        /// <param name="MotherId">Mother</param>
        /// <returns>mother or null if not exist in data source</returns>
        public Mother GetMother(int MotherId)
        {

            return ReceiveMothers().FirstOrDefault(s => s.MotherId == MotherId);
            
            //  return DataSource.ListOfMothers.FirstOrDefault(s => s.MotherId == MotherId);
            #region implment 2
            //Mother b = null; 
            //List<Mother> a 
            ////IEnumerable<Mother> a = DataSource.ListOfMothers.AsEnumerable();
            //a = DataSource.ListOfMotherByV();
            //int x = MotherId;
            //var v = from item in a
            //        where item.MotherId == x
            //        select item;
            //foreach (var item in v)
            //{
            //    b = item;
            //}
            //return b;
            #endregion
        }

        /// <summary>
        /// Remove Mother from data source
        /// </summary>
        /// <param name="id"></param>
        public bool RemoveMother(int id)
        {
            Mother mother = GetMother(id);
            if (mother == null)
            {
                //   return false;
                throw new Exception("mother with this id no exists...");
            }


            bool flag = false;
            List<Mother> a = ReceiveMothers();
            if (a != null)
            {
                int i = 0;
                foreach (var item in a)
                {
                    if (item.MotherId == mother.MotherId)
                    {
                        flag = true;
                        a.RemoveAt(i);


                    }
                    i++;
                    if (flag)
                    {
                        break;
                    }
                }
            }
            // bool flag = a.Remove(nanny);
            SetMotherList(a);
            return flag;






            //List<Mother> a = ReceiveMothers();
            //bool flag = a.Remove(mother);
            //SetMotherList(a);
            //return flag;

            //Mother mother = GetMother(id);
            //if (mother == null)
            //{
            //    //   return false;
            //    throw new Exception("mother with this id no exists...");
            //}
            //return DataSource.ListOfMothers.Remove(mother);
        }
        /// <summary>
        /// Update Mother in data source
        /// </summary>
        public void UpdateMother(Mother mother)
        {
            int i = ReceiveMothers().FindIndex(s => s.MotherId == mother.MotherId);
            if (i == -1)
                throw new Exception("mother with the same id not found...");
            List<Mother> a = ReceiveMothers();
            a[i] = mother;
            SetMotherList(a);


            //    DataSource.ListOfMothers[DataSource.ListOfMothers.FindIndex(s => s.MotherId == mother.MotherId)] = mother;
            //int i = DataSource.ListOfMothers.FindIndex(s => s.MotherId == mother.MotherId);
            //if (i == -1)
            //    throw new Exception("mother with the same id not found...");
            //DataSource.ListOfMothers[i] = mother;
        }
        public IEnumerable<Mother> GetMotherIEnumerable(Func<Mother, bool> predicat = null)
        {
            FileStream file = new FileStream(PathMother, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Mother>));
            if (file.Length == 0)
            {

                file.Close();
                return new List<Mother>();
            }
            List<Mother> mother = (List<Mother>)xmlSerializer.Deserialize(file);
            file.Close();
            if (predicat == null)
              return mother.AsEnumerable();

            return mother.Where(predicat);


            //if (predicat == null)
            //    return DataSource.ListOfMothers.AsEnumerable();

            //return DataSource.ListOfMothers.Where(predicat);
        }

        public void SetMotherList(List<Mother> list)
        {
            FileStream file = new FileStream(PathMother, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(list.GetType());
            xmlSerializer.Serialize(file, list);
            file.Close();
        }

        #endregion


        #region Child functions

        static XElement childRoot;
       // static String childPath = @"ChildXml.xml";

        public void start()
        {
            if (!File.Exists(childPath))
                CreateFiles();
            else
                LoadData();
        }

        private void CreateFiles()
        {
            childRoot = new XElement("children");
            childRoot.Save(childPath);
        }

        private void LoadData()
        {
            try
            {
                childRoot = XElement.Load(childPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }


        /// <summary>
        /// Update child in data source
        /// </summary>
        public void AddChild(Child child)
        { 
            start();
            Child child_ = GetChild(child.ChildId);
            if (child_ != null)
                throw new Exception("child with the same id already exists...");

            XElement id = new XElement("id", child.ChildId);
            XElement MotherId = new XElement("MotherId", child.MotherId);
            XElement ChildLastName = new XElement("ChildLastName", child.ChildLastName);
            XElement ChildFirstName = new XElement("ChildFirstName", child.ChildFirstName);
        //    XElement Name = new XElement("Name", ChildFirstName,ChildLastName);
            XElement ChildDate = new XElement("ChildDate", child.ChildDate);
            XElement ChildIsSpecial = new XElement("ChildIsSpecial", child.ChildIsSpecial);
            XElement ChildSpical = new XElement("ChildSpical", child.ChildSpical);
            XElement friendly = new XElement("friendly", child.friendly);
            XElement shy = new XElement("shy", child.shy);
            XElement Calm = new XElement("Calm", child.Calm);
            XElement ImageSource = new XElement("ImageSource", child.ImageSource);
            childRoot.Add(new XElement("Child", id, MotherId, ChildLastName, ChildFirstName, ChildDate, ChildIsSpecial, ChildSpical, friendly, shy, Calm));

       //     childRoot.Add(new XElement("Child", id, MotherId ,ChildDate, ChildIsSpecial, ChildSpical, friendly, shy, Calm, ImageSource));
            childRoot.Save(childPath);

            //Child child = GetChild(child_.ChildId);
            //if (child != null)
            //    throw new Exception("child with the same id already exists...");
            //DataSource.ListOfChild.Add(child_);
        }





        /// <summary>
        /// Get child cheacking if child exist in data source
        /// </summary>
        /// <param name="MotherId"></param>
        /// <returns>child or null if not exist in data source</returns>
        public Child GetChild(int ChildId)
        {

            //new Child { ChildId = i, ChildFirstName = "first" + i, ChildLastName = "last" + i };
            start();
            //LoadData();
            List<Child> a=GetChildList();
            foreach (Child item in a)
            {
                if (item.ChildId== ChildId)
                {
                    return item;
                }
            }
            return null;

            Child child=new Child();
             try
            {
                child = (from stu in childRoot.Elements()
                         where int.Parse(stu.Element("id").Value) == ChildId
                         select new Child
                         {
                             ChildId = int.Parse(stu.Element("id").Value),
                             MotherId = int.Parse(stu.Element("MotherId").Value),
                             ChildLastName = stu.Element("Name").Element("ChildLastName").Value,
                             ChildFirstName = stu.Element("Name").Element("ChildFirstName").Value,
                             ChildDate = DateTime.Parse(stu.Element("ChildDate").Value),
                             ChildIsSpecial = bool.Parse(stu.Element("ChildIsSpecial").Value),
                             ChildSpical = (stu.Element("ChildSpical").Value),
                             shy = int.Parse(stu.Element("shy").Value),
                             friendly = int.Parse(stu.Element("friendly").Value),
                             Calm = int.Parse(stu.Element("Calm").Value),
                             ImageSource = (stu.Element("ImageSource").Value),

            }).FirstOrDefault();
            }


            catch
            {
                child = null;
            } 
            
           return child; 

          //  return DataSource.ListOfChild.FirstOrDefault(s => s.ChildId == ChildId);
            #region implement 2
            //Child b = null; 
            //List<Child> a; 
            ////IEnumerable<Child> a = DataSource.ListOfChild.AsEnumerable();
            //a = DataSource.ListOfChildByV();
            //int x = ChildId;
            //var v = from item in a
            //        where item.ChildId == x
            //        select item;
            //foreach (var item in v)
            //{
            //    b = item;
            //}
            //return b;
            #endregion
        }
        /// <summary>
        /// Update child in data source
        /// </summary>
        public void UpdateChild(Child child)
        {
            start();
           // ChildElement = new XElement("c",0);
            XElement ChildElement = (from stu in childRoot.Elements()
                                       where int.Parse(stu.Element("id").Value) == child.ChildId
                                       select stu).FirstOrDefault();

            if (ChildElement == null)
                throw new Exception("child with the same id not found...");

            //studentElement.Element("name").Element("firstName").Value = student.FirstName;
            //ChildElement.Element("Name").Element("ChildFirstName").Value = child.ChildFirstName;
            //ChildElement.Element("Name").Element("ChildLastName").Value = child.ChildLastName;
            //ChildElement.Element("MotherId").Value = Convert.ToString(child.MotherId);

            ChildElement.Element("id").Value =Convert.ToString(child.ChildId);
            ChildElement.Element("ChildFirstName").Value = child.ChildFirstName;
            ChildElement.Element("ChildLastName").Value = child.ChildLastName;
            ChildElement.Element("MotherId").Value = Convert.ToString(child.MotherId);
            ChildElement.Element("ChildDate").Value = Convert.ToString(child.ChildDate);
            ChildElement.Element("ChildIsSpecial").Value = Convert.ToString(child.ChildIsSpecial);
            ChildElement.Element("ChildSpical").SetValue(child.ChildSpical);
            ChildElement.Element("friendly").Value = Convert.ToString(child.friendly);
            ChildElement.Element("shy").Value = Convert.ToString(child.shy);
            ChildElement.Element("Calm").Value = Convert.ToString(child.Calm);
     //       ChildElement.Element("ImageSource").SetValue(child.ImageSource);
            childRoot.Save(childPath);
            
            //      DataSource.ListOfChild[DataSource.ListOfChild.FindIndex(s => s.ChildId == child.ChildId)] = child;
            //int m = DataSource.ListOfMothers.FindIndex(s => s.MotherId == child.MotherId);
            //if (m == -1)
            //    throw new Exception("mother with the same id not found...");
            //int i = DataSource.ListOfChild.FindIndex(s => s.ChildId == child.ChildId);
            //if (i == -1)
            //    throw new Exception("child with the same id not found...");
            //DataSource.ListOfChild[i] = child;

        }
        /// <summary>
        /// Remove Child from data source
        /// </summary>
        public bool RemoveChild(int id)
        {


            start();
            Child child = GetChild(id);
            if (child == null)
            {
                throw new Exception("child with this id no exists...");
            }

            XElement childElement;
            try
            {
                childElement = (from stu in childRoot.Elements()
                                  where int.Parse(stu.Element("id").Value) == id
                                  select stu).FirstOrDefault();
                childElement.Remove();
                childRoot.Save(childPath);
                return true;
            }
            catch
            {
                return false;
            }

            //Child child = GetChild(id);
            //if (child == null)
            //{
            //    //   return false;
            //    throw new Exception("child with this id no exists...");
            //}
            //return DataSource.ListOfChild.Remove(child);
        }
        public List<Child> GetChildList()
        {
            start();
            FileStream file = new FileStream(childPath, FileMode.Open);

            if (file.Length == 0)
            {

                file.Close();
                return new List<Child>();
            }

            file.Close();
            XElement ChildRoot;
            try
            {

                ChildRoot = XElement.Load(childPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
            List<Child> Childs;
            try
            {
                Childs = (from p in ChildRoot.Elements()
                          select new Child()
                          {
                              ChildId = Convert.ToInt32(p.Element("id").Value),
                              MotherId = Convert.ToInt32(p.Element("MotherId").Value),
                              ChildLastName = p.Element("ChildLastName").Value,

                              ChildFirstName = p.Element("ChildFirstName").Value,
                              ChildDate = Convert.ToDateTime(p.Element("ChildDate").Value),
                              ChildIsSpecial = Convert.ToBoolean(p.Element("ChildIsSpecial").Value),
                              ChildSpical = p.Element("ChildSpical").Value,
                              friendly = Convert.ToInt32(p.Element("friendly").Value),
                              shy = Convert.ToInt32(p.Element("shy").Value),
                              Calm = Convert.ToInt32(p.Element("Calm").Value)


                          }).ToList();
            }
            catch
            {
                Childs = null;
            }
            return Childs;
        }




        public IEnumerable<Child> GetChildIEnumerable(Func<Child, bool> predicat = null)
        {
            if (predicat == null)
                return GetChildList().AsEnumerable();

            return GetChildList().Where(predicat);
        
        ////   LoadData();
        //start();
        //List<Child> children;
        //try
        //{
        //    children = (from stu in childRoot.Elements()
        //                select new Child
        //                {

        //                    ChildId = int.Parse(stu.Element("id").Value),
        //                    ChildFirstName = stu.Element("Name").Element("ChildFirstName").Value,
        //                    ChildLastName = stu.Element("Name").Element("ChildLastName").Value,
        //                    ChildDate = DateTime.Parse(stu.Element("ChildDate").Value),
        //                    MotherId = int.Parse(stu.Element("MotherId").Value),
        //                    ChildIsSpecial = bool.Parse(stu.Element("ChildIsSpecial").Value),
        //                    ChildSpical = (stu.Element("ChildSpical").Value),
        //                    shy = int.Parse(stu.Element("shy").Value),
        //                    friendly = int.Parse(stu.Element("friendly").Value),
        //                    Calm = int.Parse(stu.Element("Calm").Value),
        //                    ImageSource = (stu.Element("ImageSource").Value),

        //                }).ToList();
        //}
        //catch
        //{
        //    children = null;
        //}
        //if (predicat == null)
        //    return children.AsEnumerable();

        //return children.Where(predicat);

        //if (predicat == null)
        //    return DataSource.ListOfChild.AsEnumerable();

        //return DataSource.ListOfChild.Where(predicat);
    }

        public void SaveChildListToXML1(List<Child> CList)
        {
            childRoot = new XElement("children");

            foreach (Child item in CList)
            {
                AddChild(item);
            }

            childRoot.Save(childPath);

        }
        public void SaveChildListToXML2(List<Child> CList)
        {
            var v = from p in CList
                    select new XElement("child",
                            new XElement("id", p.ChildId),
                             new XElement("MotherId", p.MotherId),
                         //    new XElement("Name", 
                              new XElement("ChildLastName", p.ChildLastName),
                               new XElement("ChildFirstName", p.ChildFirstName),                             
                                 new XElement("ChildDate", p.ChildDate),
                                  new XElement("ChildIsSpecial", p.ChildIsSpecial),
                                   new XElement("ChildSpical", p.ChildSpical),
                                    new XElement("friendly", p.friendly,
                                     new XElement("shy", p.shy),
                                      new XElement("Calm", p.Calm),
                                       new XElement("ImageSource", p.ImageSource)//  )                        
                            )

                        );
            childRoot = new XElement("children", v);
            childRoot.Save(childPath);

        }

        



        #endregion


        #region Contract functions

        /// <summary>
        /// Add contract to Data Source 
        /// </summary>
        public void AddContract(Contract contract_)
        {
            Child ch = GetChild(contract_.ChildId);
            if (ch == null)
                throw new Exception("child not exists...");
            //           if (GetNanny(contract_.NannyId) == null || GetMother(ch.MotherId) == null)
            //              throw new Exception("Nanny or Mother not exists...");
            if (GetNanny(contract_.NannyId) == null)//|| GetMother(ch.MotherId) == null )
                throw new Exception("Nanny or Mother or Child not exist...");

         //   bool flag = true;
            while (true)
            {
                if (GetContract(contractnumber)!=null)
                {
                    contractnumber++;
                }
                else
                {
                    break;
                }
            }
            contract_.ContractId = contractnumber;
            contractnumber = contractnumber + 1;
            Contract contract = GetContract(contract_.ContractId);
            if (contract == null)
            {
                List<Contract> a = ReceiveContracts();
                a.Add(contract_);
                SetContractList(a);
                //Dal_XML_imp.ListOfContracts.Add(contract_);
                contract_.ContractSigned = true;

            }
            else
                throw new Exception("Contract with this id already exists...");


            //Child ch = GetChild(contract_.ChildId);
            //if (ch == null)
            //    throw new Exception("child not exists...");
            ////           if (GetNanny(contract_.NannyId) == null || GetMother(ch.MotherId) == null)
            ////              throw new Exception("Nanny or Mother not exists...");
            //if (GetNanny(contract_.NannyId) == null)//|| GetMother(ch.MotherId) == null )
            //    throw new Exception("Nanny or Mother or Child not exist...");
            //contract_.ContractId = contractnumber;
            //contractnumber = contractnumber + 1;
            //Contract contract = GetContract(contract_.ContractId);
            //if (contract == null)
            //{
            //    DataSource.ListOfContracts.Add(contract_);
            //    contract_.ContractSigned = true;

            //}
            //else
            //    throw new Exception("Contract with this id already exists...");
        }
        /// <summary>
        /// Get contract cheacking if contract exist in data source
        /// </summary>
        /// <param name="nannyId"></param>
        /// <returns>contract or null if not exist in data source</returns>
        public Contract GetContract(int contractId)
        {
            return ReceiveContracts().FirstOrDefault(s => s.ContractId == contractId);


            //  return DataSource.ListOfContracts.FirstOrDefault(s => s.ContractId == contractId);
            // #region imlement 2
            //Contract b = null; 
            //List<Contract> a 
            //// IEnumerable<Contract> a = DataSource.ListOfContracts.AsEnumerable();
            //a = DataSource.ListOfContractByV();
            //int x = contractId;
            //var v = from item in a
            //        where item.ContractId == x
            //        select item;
            //foreach (var item in v)
            //{
            //    b = item;
            //}
            //return b;
            // #endregion
        }
        /// <summary>
        /// remove contract from data source
        /// </summary>
        public bool RemoveContract(int id)
        {
            Contract contract = GetContract(id);
            if (contract == null)
            {
                throw new Exception("Contract with this id no exists...");
            }


            bool flag = false;
            List<Contract> a = ReceiveContracts();
            if (a != null)
            {
                int i = 0;
                foreach (var item in a)
                {
                    if (item.ContractId == contract.ContractId)
                    {
                        flag = true;
                        a.RemoveAt(i);


                    }
                    i++;
                    if (flag)
                    {
                        break;
                    }
                }
            }
            // bool flag = a.Remove(nanny);
            SetContractList(a);
            return flag;




            //List<Contract> a = ReceiveContracts();
            //bool flag = a.Remove(contract);
            //SetContractList(a);
            //return flag;

            //Contract contract = GetContract(id);
            //if (contract == null)
            //{
            //    throw new Exception("Contract with this id no exists...");
            //}
            //return DataSource.ListOfContracts.Remove(contract);

        }
        /// <summary>
        /// Update contract in data source
        /// </summary>
        public void UpdateContract(Contract contract)
        {
            int m =ReceiveContracts().FindIndex(s => s.NannyId == contract.NannyId);
            if (m == -1)
                throw new Exception("Nanny with the same id not found...");
            int n = ReceiveContracts().FindIndex(s => s.ChildId == contract.ChildId);
            if (n == -1)
                throw new Exception("child with the same id not found...");
            int o = ReceiveContracts().FindIndex(s => s.ContractId == contract.ContractId);
            if (o == -1)
                throw new Exception("contract with the same id not found...");
            List<Contract> a = ReceiveContracts();
            a[ReceiveContracts().FindIndex(s => s.ContractId == contract.ContractId)] = contract;
            SetContractList(a);


            //if (GetContract(contract.ContractId) == null)
            //{
            //    throw new Exception("Contract with this id no exists...");
            //}
            //int m = DataSource.ListOfNannys.FindIndex(s => s.NannyId == contract.NannyId);
            //if (m == -1)
            //    throw new Exception("Nanny with the same id not found...");
            //int n = DataSource.ListOfChild.FindIndex(s => s.ChildId == contract.ChildId);
            //if (n == -1)
            //    throw new Exception("child with the same id not found...");
            //int o = DataSource.ListOfContracts.FindIndex(s => s.ContractId == contract.ContractId);
            //if (o == -1)
            //    throw new Exception("contract with the same id not found...");
            //DataSource.ListOfContracts[DataSource.ListOfContracts.FindIndex(s => s.ContractId == contract.ContractId)] = contract;

        }
        public IEnumerable<Contract> GetContractIEnumerable(Func<Contract, bool> predicat = null)
        {
            FileStream file = new FileStream(PathContract, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contract>));
            if (file.Length == 0)
            {

                file.Close();
                return new List<Contract>();
            }
            List<Contract> contract = (List<Contract>)xmlSerializer.Deserialize(file);
            file.Close();
            if (predicat == null)
                return contract.AsEnumerable();
            return contract.Where(predicat);
           


            //if (predicat == null)
            //    return DataSource.ListOfContracts.AsEnumerable();

            //return DataSource.ListOfContracts.Where(predicat);
        }
        public void SetContractList(List<Contract> list)
        {
            FileStream file = new FileStream(PathContract, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(list.GetType());
            xmlSerializer.Serialize(file, list);
            file.Close();
        }
        #endregion


        #region Receive data function (by value)
        /// <summary>
        /// Receive all Nannys from data source
        /// </summary>
        /// <returns>list of the nannys from data source</returns>
        public List<Nanny> ReceiveNannys()
        {





          
            List<Nanny> user2 = LoadFromXML<List<Nanny>>(PathNanny);
            return user2;
            //FileStream file = new FileStream(PathNanny, FileMode.Open);
            //try
            //{
            //    // FileStream file = new FileStream(PathNanny, FileMode.Open);

            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Nanny>));
            //    List<Nanny> nanny = new List<Nanny>();
            //    if (file.Length == 0)
            //    {

            //        file.Close();
            //        return new List<Nanny>();
            //    }
            //    Nanny a;
            //    a = (Nanny)xmlSerializer.Deserialize(file);
            //    file.Close();
            //    return nanny;
            //}
            //catch (Exception a)
            //{
            //    file.Close();
            //    throw new Exception("xml");
            //}


            //    return DataSource.ListOfNannyByV();
            // throw new NotImplementedException();
        }
        public List<Nanny> ReceiveNannys2()
        {


            List<Nanny> user2 = LoadFromXML<List<Nanny>>(PathNanny);
            return user2;
            //FileStream file = new FileStream(PathNanny, FileMode.Open);
            //try
            //{
            //    // FileStream file = new FileStream(PathNanny, FileMode.Open);

            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Nanny>));
            //    List<Nanny> nanny = new List<Nanny>();
            //    if (file.Length == 0)
            //    {

            //        file.Close();
            //        return new List<Nanny>();
            //    }
            //    Nanny a;
            //    a = (Nanny)xmlSerializer.Deserialize(file);
            //    file.Close();
            //    return nanny;
            //}
            //catch (Exception a)
            //{
            //    file.Close();
            //    throw new Exception("xml");
            //}


            //    return DataSource.ListOfNannyByV();
            // throw new NotImplementedException();
        }



        /// <summary>
        /// Receive all contracts from data source
        /// </summary>
        /// <returns> list of the contracts from data source</returns>
        public List<Contract> ReceiveContracts()
        {
            FileStream file = new FileStream(PathContract, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contract>));
            if (file.Length == 0)
            {

                file.Close();
                return new List<Contract>();
            }
            List<Contract> contract = (List<Contract>)xmlSerializer.Deserialize(file);
            file.Close();
            return contract;


            // return DataSource.ListOfContractByV();
        }
        /// <summary>
        /// Receive all Cildren from data source
        /// </summary>
        /// <returns>list of the nannys from data source</returns>
        public List<Child> ReceiveChild()
        {
            //   LoadData();Child s = new Child { ChildId = i, ChildFirstName = "first" + i, ChildLastName = "last" + i };
            start();
            List<Child> children;
            try
            {
                children = (from stu in childRoot.Elements()
                            select new Child
                            {

                                ChildId = int.Parse(stu.Element("id").Value),
                                ChildFirstName = stu.Element("Name").Element("ChildFirstName").Value,
                                ChildLastName = stu.Element("Name").Element("ChildLastName").Value,
                                ChildDate = DateTime.Parse(stu.Element("ChildDate").Value),///Convert.ToDateTime
                                MotherId = int.Parse(stu.Element("MotherId").Value),
                                ChildIsSpecial = bool.Parse(stu.Element("ChildIsSpecial").Value),
                                ChildSpical = (stu.Element("ChildSpical").Value),
                                shy = int.Parse(stu.Element("shy").Value),
                                friendly = int.Parse(stu.Element("friendly").Value),
                                Calm = int.Parse(stu.Element("Calm").Value),
                                ImageSource = (stu.Element("ImageSource").Value),

                            }).ToList();
            }
            catch
            {
                children = null;
            }

            return children;



            //return DataSource.ListOfChildByV();
        }
        /// <summary>
        /// Receive all Mothers from data source
        /// </summary>
        /// <returns> list of the mothers from data source</returns>
        public List<Mother> ReceiveMothers()
        {
            FileStream file = new FileStream(PathMother, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Mother>));
            if (file.Length == 0)
            {

                file.Close();
                return new List<Mother>();
            }
            List<Mother> mother = (List<Mother>)xmlSerializer.Deserialize(file);
            file.Close();
            return mother;
            //    return DataSource.ListOfMotherByV();
        }
        #endregion


        

        public static void SaveToXML<T>(T source, string path)
        {

            if (!File.Exists(path))
            {
                NannyRoot = new XElement("nannies");
                NannyRoot.Save(path);
            }
            else
            { 
                try
                {
                    childRoot = XElement.Load(path);
                }
                catch
                {
                    throw new Exception("File upload problem");
                }

            }



            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source); file.Close();
        }
        public static T LoadFromXML<T>(string path) where T : class, new()
        {
            if (!File.Exists(path))
            {
                NannyRoot = new XElement("nannies");
                NannyRoot.Save(path);
            }
            else
            {
                try
                {
                    NannyRoot = XElement.Load(path);
                }
                catch
                {
                    throw new Exception("File upload problem");
                }

            }

            //XmlSerializer deserializer = new XmlSerializer(typeof(T));
            //using (TextReader reader = new StreamReader(path))
            //{
            //    object a = deserializer.Deserialize(reader) as T;
            //    return (T)a;
            //}



            FileStream file = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T result = (T)xmlSerializer.Deserialize(file);
            file.Close();
            return result;
        }



    }
}

