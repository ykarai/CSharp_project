//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using GoogleMapsApi;

//using BE;
//using GoogleMapsApi.Entities.Directions.Request;
//using GoogleMapsApi.Entities.Directions.Response;

//namespace BL
//{
//    /// <summary>
//    /// implementaion of BL -logic layer whith useng Linq and lambda
//    /// </summary>
//    internal class MyBl2 : IBL
//    {
//        //    DAL.Idal dal;
//        //   DAL.Idal dal = new DAL.Dal_imp();
//        //public void Adapter()
//        //{
//        //    DAL.FactoryDal factory = new DAL.FactoryDal();
//        //    dal = factory.getDal();
//        //}
//        /// <summary>
//        /// get dal with use in "factory"
//        /// </summary>
//        DAL.Idal dal = DAL.FactoryDal.getDal();
//        public MyBl2()
//        {
//            start();
//        }
//        /// <summary>
//        /// initialize sample of information
//        /// </summary>
//        private void start()
//        {
//            Nanny Zelda = new Nanny();
//            Zelda.NannyAddress = "Israel,Jerusalem,Shakhal,1";
//            Zelda.NannyDate = new DateTime(1960, 4, 9);
//            Zelda.NannyDaysOfWork = new bool[6];
//            Zelda.NannyDaysOfWork[0] = true;
//            Zelda.NannyDaysOfWork[1] = true;
//            Zelda.NannyDaysOfWork[2] = true;
//            Zelda.NannyDaysOfWork[3] = true;
//            Zelda.NannyDaysOfWork[4] = true;
//            Zelda.NannyDaysOfWork[5] = true;
//            Zelda.NannyFirstName = "Zelda";
//            Zelda.NannyFloor = 3;
//            Zelda.NannyHaveElevator = true;
//            Zelda.NannyHolidaysTamat = true;
//            Zelda.NannyId = 40000000;
//            Zelda.NannyIsHourlysalary = false;
//            Zelda.NannyLastName = "Steinberg";
//            Zelda.NannyMaxKidsAge = new DateTime(2005, 4, 9);
//            Zelda.NannyMaxKidslimit = 18;//new DateTime(2001, 4, 9);
//            Zelda.NannyMinKidsAge = new DateTime(2015, 4, 9);
//            Zelda.NannyPhoneNumber = 0543572245;
//            Zelda.NannyRecommendations = "non";
//            Zelda.NannySpecialKids = true;
//            //  Zelda.NannyTableOfWork = new int[6][];
//            Zelda.NannyTariffForHour = 27;
//            Zelda.NannyTariffForMonth = 70000;
//            Zelda.NannyYearsExperience = 3;
//            try
//            {
//                this.AddNanny(Zelda);
//            }
//            catch (Exception)
//            {
//                this.UpdateNanny(Zelda);
//            }

//            Mother Shlomit = new Mother();
//            Shlomit.kilometerAround = 10;
//            Shlomit.MotherAddress = "Israel,Jerusalem,Shakhal,29";
//            Shlomit.MotherAroundAddress = "Israel,Jerusalem";
//            Shlomit.MotherDate = new DateTime(1996, 4, 9);
//            Shlomit.MotherDaysOfWork = new bool[6];
//            Shlomit.MotherDaysOfWork[0] = true;
//            Shlomit.MotherDaysOfWork[1] = true;
//            Shlomit.MotherDaysOfWork[2] = true;
//            Shlomit.MotherDaysOfWork[3] = true;
//            Shlomit.MotherDaysOfWork[5] = true;
//            Shlomit.MotherDaysOfWork[4] = true;
//            Shlomit.MotherFirstName = "Shlomit";
//            Shlomit.MotherHaveElevator = false;
//            Shlomit.MotherId = 20000000;
//            Shlomit.MotherKidsAverage = 9;
//            Shlomit.MotherLastName = "Shtetman";
//            Shlomit.MotherPhoneNumber = 054567456;
//            Shlomit.MotherRemarks = "";
//            try
//            {
//                this.AddMother(Shlomit);
//            }
//            catch (Exception)
//            {
//                this.UpdateMother(Shlomit);
//            }
//            //Shlomit.MotherTableOfWork = new int[6,2];
//            Child Yos = new Child();
//            Yos.ChildDate = new DateTime(2008, 5, 19);
//            Yos.ChildFirstName = "Yos";
//            Yos.ChildId = 10000000;
//            Yos.ChildIsSpecial = false;
//            Yos.ChildLastName = "Shtetman";
//            //  Yos.ChildSpical
//            Yos.MotherId = 20000000;
//            Child dan = new Child();
//            dan.ChildDate = new DateTime(2004, 4, 9);
//            dan.ChildFirstName = "Dan";
//            dan.ChildId = 20000000;
//            dan.ChildIsSpecial = false;
//            dan.ChildLastName = "strauss";
//            //  Yos.ChildSpical
//            Yos.MotherId = 30000000;
//            //  throw new NotImplementedException();
//            try
//            {
//                this.AddChild(Yos);
//            }
//            catch (Exception)
//            {
//                this.UpdateChild(Yos);
//            }
//            try
//            {
//                this.AddChild(dan);
//            }
//            catch (Exception)
//            {
//                this.UpdateChild(dan);
//            }
//        }
//        private IEnumerable<object> a;
//        /// <summary>
//        /// Update child
//        /// </summary>
//        public void AddChild(Child child)
//        {
//            dal.AddChild(child);
//            //    throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Get child cheacking if nanny exist in data source
//        /// </summary>
//        /// <returns>child or null if not exist in data source</returns>
//        public Child GetChild(int ChildId)
//        {
//            //  list <Child> ch=  dal.ReceiveChild();
//            //           return dal.ReceiveChild().FirstOrDefault(s => s.ChildId == ChildId);
//            return dal.GetChild(ChildId);
//        }
//        /// <summary>
//        /// Update Child
//        /// </summary>
//        public void UpdateChild(Child child)
//        {
//            dal.UpdateChild(child);
//            //     throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Remove Child
//        /// </summary>
//        public bool RemoveChild(int id)
//        {
//            return dal.RemoveChild(id);
//            //  throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Update Contract
//        /// </summary>
//        public void UpdateContract(Contract contract)
//        {
//            dal.UpdateContract(contract);
//            //throw new NotImplementedException();
//        }
//        /// <summary>
//        /// addding contract cheacking if contract is properly
//        /// </summary>
//        public void AddContract(Contract contract)
//        {
//            int ChildId = contract.ChildId;
//            Child child = dal.GetChild(ChildId);
//            if (child == null)
//            {
//                //   return false;
//                throw new Exception("child with this id no exists...");
//            }
//            DateTime today = DateTime.Today;
//            int Age = today.Month - child.ChildDate.Month;
//            if (Age < 3)
//            {
//                throw new Exception("This child is too young");
//            }

//            double finelsalary = Money(contract);
//            bool haveTime = free(contract);
//            if (haveTime)
//                dal.AddContract(contract);

//        }
//        /// <summary>
//        /// checking if Nanny doesnt reach max kids limit
//        /// </summary>
//        /// <param name="contract"></param>
//        /// <returns>yes ifnanny have time</returns>
//        public bool free(Contract contract)
//        {
//            int counter = 0;
//            double FinalSalery;
//            Nanny ch = GetNaany(contract.NannyId);
//            if (ch == null)
//            {
//                throw new Exception("no nanny ");
//            }
//            List<Contract> Contractlist = dal.ReceiveContracts();

//            //       return Contractlist.FirstOrDefault(s => Child ch = GetChild(s.ChildId); int idm = ch.);
//            //foreach (Contract item in Contractlist)
//            //{
//            //    Nanny nan = GetNaany(item.NannyId);
//            //    if (nan.NannyId == ch.NannyId)
//            //    { counter++; }
//            //}   
//            var v = from item in Contractlist
//                    where GetNaany(item.NannyId).NannyId == item.NannyId
//                    select item;
//            foreach (var item in v)
//                counter++;

//            if (counter + 1 > ch.NannyMaxKidslimit)
//                return false;
//            return true;
//        }
//        // <summary>
//        /// checking if A discount is required according to the number of children
//        /// </summary>
//        /// <param name="contract"></param>
//        /// <returns>salery of nanny after discount</returns>
//        public double Money(Contract contract)
//        {
//            int counter = 0;
//            double FinalSalery;
//            Child ch = GetChild(contract.ChildId);
//            if (ch == null)
//            {
//                throw new Exception("no child ");
//            }
//            List<Contract> Contractlist = dal.ReceiveContracts();

//            //   return Contractlist.FirstOrDefault(s => Child ch = GetChild(s.ChildId);int idm=ch.);
//            //foreach (Contract item in Contractlist)
//            //{
//            //    Child chil = GetChild(item.ChildId);

//            //    if (chil.MotherId == ch.MotherId && item.NannyId == contract.NannyId && item.ChildId != contract.ChildId)
//            //    {
//            //        counter += 2;
//            //    }

//            //}
//            int x = ch.ChildId;
//            var v = from item in Contractlist
//                    where ((GetChild(item.ChildId).MotherId == ch.MotherId) &&
//                    (item.NannyId == contract.NannyId) &&
//                    (item.ChildId != contract.ChildId))
//                    select item;
//            foreach (var item in v)
//                counter += 2;

//            if (contract.ContractIsHourlysalary)
//            {
//                FinalSalery = contract.ContractTariffForHour * 4;
//            }
//            else
//            {
//                FinalSalery = contract.ContractTariffForMonth;
//            }
//            FinalSalery -= FinalSalery * (counter / 100.0);


//            return FinalSalery;
//        }

//        public Nanny GetNanny(int nannyId)
//        {
//            return dal.ReceiveNannys().FirstOrDefault(s => s.NannyId == nannyId);

//        }
//        /// <summary>
//        /// Get Naany
//        /// </summary>
//        public Nanny GetNaany(int nannyId)
//        {
//            //           return dal.ReceiveNannys().FirstOrDefault(s => s.NannyId == nannyId);
//            return dal.GetNanny(nannyId);
//        }
//        /// <summary>
//        /// cheaking if nanny age more then 18 years
//        /// </summary>
//        /// <param name="nanny"></param>
//        public void AddNanny(Nanny nanny)
//        {
//            DateTime today = DateTime.Today;
//            int Age = today.Year - nanny.NannyDate.Year;
//            if (Age >= 18)
//            {
//                dal.AddNanny(nanny);
//            }
//            else
//            {
//                throw new Exception("This nanny is too young");

//            }
//        }
//        public bool RemoveNanny(int id)
//        {
//            return dal.RemoveNanny(id);
//            //  throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Update Nanny
//        /// </summary>
//        public void UpdateNanny(Nanny nanny)
//        {
//            dal.UpdateNanny(nanny);
//            //  throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Add Mother 
//        /// </summary>
//        /// <param name="mother"></param>
//        public void AddMother(Mother mother)
//        {
//            dal.AddMother(mother);
//            //  throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Get Mother
//        /// </summary>
//        private Mother GetMother(int motherId)
//        {
//            //           return dal.ReceiveMothers().FirstOrDefault(s => s.MotherId == motherId);
//            return dal.GetMother(motherId);
//        }
//        /// <summary>
//        /// Remove mother
//        /// </summary>
//        public bool RemoveMother(int id)
//        {
//            return dal.RemoveMother(id);
//            // throw new NotImplementedException();
//        }

//        /// <summary>
//        /// Updat eMother
//        /// </summary>
//        public void UpdateMother(Mother mother)
//        {
//            dal.UpdateMother(mother);
//            //  throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Calculate Distance batween to adresses
//        /// </summary>
//        /// <param name="source">source addres</param>
//        /// <param name="dest">source sestnination adrees</param>
//        /// <returns>Distance between places in int variable </returns>
//        public static int CalculateDistance(string source, string dest)
//        {
//            var drivingDirectionRequest = new DirectionsRequest
//            {
//                TravelMode = TravelMode.Walking,
//                Origin = source,
//                Destination = dest,
//            };
//            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
//            Route route = drivingDirections.Routes.First();
//            Leg leg = route.Legs.First();
//            return leg.Distance.Value;
//        }
//        /// <summary>
//        /// Checks whether the nannys suitable for mother hours
//        /// </summary>
//        /// <param name="mom">mother information </param>
//        /// <returns> list of fit nannys</returns>
//        public List<Nanny> FitHoursNannys(Mother mom)
//        {
//            List<Nanny> fitNannys = new List<Nanny>();
//            List<Nanny> Nannytlist = dal.ReceiveNannys();
//            foreach (Nanny item in Nannytlist)
//            {
//                for (int i = 0; i < 6; i++)
//                {
//                    if (item.NannyDaysOfWork[i] && mom.MotherDaysOfWork[i])
//                    {
//                        int a1 = item.NannyTableOfWork[0, i];
//                        int a2 = item.NannyTableOfWork[1, i];
//                        int b1 = mom.MotherTableOfWork[0, i];
//                        int b2 = mom.MotherTableOfWork[1, i];
//                        if (a1 < b1 && a2 < b2)
//                        {
//                            fitNannys.Add(item);
//                        }
//                    }
//                }


//            }
//            bool isEmpty = !(fitNannys.Any());
//            if (!isEmpty)
//            {
//                return fitNannys;
//            }
//            else //no abslut mach
//            {

//                foreach (Nanny item in Nannytlist)
//                {
//                    for (int i = 0; i < 7; i++)
//                    {

//                        if (item.NannyDaysOfWork[i] && mom.MotherDaysOfWork[i] || Houercheck(item, mom, i))
//                            if (fitNannys.Count < 5)
//                            {
//                                fitNannys.Add(item);
//                            }
//                    }

//                }
//                while (fitNannys.Count < 5)
//                {
//                    int i = 0;
//                    if (!fitNannys.Contains(Nannytlist[i]))
//                        fitNannys.Add(Nannytlist[i]);
//                    i++;
//                }
//                return fitNannys;

//            }
//        }
//        /// <summary>
//        /// find if nannys houers close to mother houres
//        /// <returns> if close return true</returns>
//        public bool Houercheck(Nanny item, Mother mom, int i)
//        {
//            int a1 = item.NannyTableOfWork[0, i];
//            int a2 = item.NannyTableOfWork[1, i];
//            int b1 = mom.MotherTableOfWork[0, i];
//            int b2 = mom.MotherTableOfWork[1, i];
//            if ((Math.Abs(a1 - b1) < 2) || (Math.Abs(b1 - b2) < 2))
//            {
//                return true;
//            }
//            return false;

//        }
//        /// <summary>
//        /// Fit Distance Nannys
//        /// </summary>
//        /// <param name="mom"> mother info</param>
//        /// <returns> list of nannys that there distance fit</returns>
//        public List<Nanny> FitDistanceNannys(Mother mom)
//        {

//            List<Nanny> fitDNannys = new List<Nanny>();
//            List<Nanny> Nannytlist = dal.ReceiveNannys();
//            string a = mom.MotherAroundAddress;
//            if (a == null)
//                a = mom.MotherAddress;
//            int? around = mom.kilometerAround;
//            if (a == null)
//                around = 2;
//            foreach (Nanny item in Nannytlist)
//            {

//                if ((CalculateDistance(a, item.NannyAddress) <= around))
//                {
//                    fitDNannys.Add(item);
//                }
//            }
//            return fitDNannys;
//        }
//        /// <summary>
//        /// find all chilren whitout nannys yet
//        /// </summary>
//        /// <returns> return singly kids list</returns>
//        public List<Child> singlyChildren()
//        {
//            List<Child> singlykids = dal.ReceiveChild();
//            List<Contract> Contractlist = dal.ReceiveContracts();
//            //foreach (Contract item in Contractlist)
//            //{
//            //    //                Nanny nan = GetNaany(item.NannyId);
//            //    //               int ChildId = item.ChildId;
//            //    Child child = GetChild(item.ChildId);
//            //    if (child != null)
//            //    {
//            //        singlykids.Remove(child);
//            //    }
//            //}
//            var v = from item in Contractlist
//                    where (GetChild(item.ChildId) == null)
//                    select item;
//            foreach (var item in v)
//            {
//                Child child = GetChild(item.ChildId);
//                singlykids.Remove(child);
//            }
//            return singlykids;

//        }
//        /// <summary>
//        /// checking waht nannys work under tamat method
//        /// </summary>
//        /// <returns>list of nannys work like tamat</returns>
//        public List<Nanny> NannysWorkTmat()
//        {
//            List<Nanny> nannysWorkTmat = dal.ReceiveNannys();
//            //          nannysWorkTmat.RemoveAll(s => s.NannyHolidaysTamat == false);
//            //foreach (Nanny item in nannysWorkTmat)
//            //{
//            //    if ((item.NannyHolidaysTamat))
//            //    {
//            //        nannysWorkTmat.Remove(item);
//            //    }

//            //}
//            var v = from item in nannysWorkTmat
//                    where item.NannyHolidaysTamat
//                    select item;
//            foreach (var item in v)
//            {
//                nannysWorkTmat.Remove(item);
//            }
//            return nannysWorkTmat;

//        }
//        /// <summary>
//        /// recieve prediact and find all contracts have match
//        /// </summary>
//        /// <param name="func"></param>
//        /// <returns> list of contract with metch</returns>
//        public List<Contract> allContract(Func<Contract, bool> func)
//        {
//            List<Contract> list = dal.ReceiveContracts();
//            Func<Contract, bool> func1 = func;
//            var v = list.Where(func);
//            List<Contract> list1 = new List<Contract>();
//            foreach (var item in v)
//            {
//                list1.Add(item);
//            }
//            return list1;
//        }
//        /// <summary>
//        /// recieve prediact and find all contracts have match
//        /// </summary>
//        /// <param name="func"></param>
//        /// <returns> varialble of the count of metch contracts</returns>
//        public int numofContract(Func<Contract, bool> func)
//        {
//            int num = 0;
//            List<Contract> list = dal.ReceiveContracts();
//            Func<Contract, bool> func1 = func;
//            var v = list.Where(func);
//            foreach (var item in v)
//            {
//                num++;
//            }
//            return num;
//        }
//        ///////////////////////////////////////////////////////

//        /// <summary>
//        /// Mother Have Elevator
//        /// </summary>
//        /// <returns> list of mothers have elevator</returns>
//        public List<Mother> MotherHaveElevator()
//        {
//            List<Mother> motherHaveElevator = dal.ReceiveMothers();
//            motherHaveElevator.RemoveAll(s => s.MotherHaveElevator == false);
//            return motherHaveElevator;
//        }
//        /// <summary>
//        /// Nannys experience 1 year
//        /// </summary>
//        /// <returns>list of nannys have 1 year experience</returns>
//        public List<Nanny> Nannysexperience1()
//        {
//            List<Nanny> Nannysexperience = dal.ReceiveNannys();
//            Nannysexperience.RemoveAll(s => s.NannyYearsExperience > 1);
//            return Nannysexperience;

//        }
//        /// <summary>
//        /// Nannys experience 3 year
//        /// </summary>
//        /// <returns>list of nannys have 3 year experience</returns>
//        public List<Nanny> Nannysexperience3()
//        {
//            List<Nanny> Nannysexperience = dal.ReceiveNannys();
//            Nannysexperience.RemoveAll(s => s.NannyYearsExperience > 3);
//            return Nannysexperience;

//        }
//        /// <summary>
//        /// Spacia lKids
//        /// </summary>
//        /// <returns> list of spacial kids</returns>
//        public List<Child> SpacialKids()
//        {
//            List<Child> spacialKids = dal.ReceiveChild();
//            spacialKids.RemoveAll(s => s.ChildIsSpecial == false);
//            return spacialKids;

//        }
//        /// <summary>
//        /// Nannys Spacial Kids
//        /// </summary>
//        /// <returns>list of nannys whit Spacial Kids </returns>
//        public List<Nanny> NannysSpacialKids()
//        {
//            List<Nanny> nannysSpacialKids = dal.ReceiveNannys();
//            nannysSpacialKids.RemoveAll(s => s.NannySpecialKids == false);
//            return nannysSpacialKids;

//        }
//        /// <summary>
//        ///  Offers nannys suitable for Spacial Kids contracts
//        /// </summary>
//        /// <returns>contracts of Spacial Kids whith nannys</returns>
//        public List<Contract> NannysuitableSpacialKids()
//        {
//            List<Contract> NannysuitableSpacialKids = new List<Contract>();
//            List<Nanny> nannysSpacialKids = NannysSpacialKids();
//            List<Child> spacialKids = SpacialKids();
//            int m = 0;
//            foreach (Nanny item in nannysSpacialKids)
//            {
//                if (m < spacialKids.Count)
//                {
//                    Contract a = new Contract();
//                    a.NannyId = item.NannyId;
//                    Child c = spacialKids[m];
//                    a.ChildId = c.ChildId;
//                    NannysuitableSpacialKids.Add(a);
//                }
//                m++;
//            }
//            return NannysuitableSpacialKids;

//        }
//        /// <summary>
//        /// Nannys Spacial Kids Andexperience
//        /// </summary>
//        /// <returns> return list of nannys also have experience and spacial kids </returns>
//        public List<Nanny> NannysSpacialKidsAndexperience()
//        {
//            List<Nanny> nannysSpacialKidsAndexperience = dal.ReceiveNannys();
//            nannysSpacialKidsAndexperience.RemoveAll(s => s.NannySpecialKids == false);
//            nannysSpacialKidsAndexperience.RemoveAll(s => s.NannyYearsExperience > 3);
//            return nannysSpacialKidsAndexperience;

//        }








//        //      public Nanny GetSNanny(int id)
//        //     {
//        //        
//        //        throw new NotImplementedException();
//        //   }


//        //public List<Contract> ReceiveContracts()
//        //{
//        //    dal.ReceiveContracts();
//        // //   throw new NotImplementedException();
//        //}


//        /// <summary>
//        /// Remove contract
//        /// </summary>
//        public bool RemoveContract(int id)
//        {
//            return dal.RemoveContract(id);
//            //   throw new NotImplementedException();
//        }


//        //public List<Nanny> ReceiveNannys()
//        //{
//        //    return dal.ReceiveNannys();
//        //    //throw new NotImplementedException();
//        //}

//        //public List<Mother> ReceiveMothers()
//        //{
//        //    return dal.ReceiveMothers();
//        //   // throw new NotImplementedException();
//        //}

//        //public List<Child> ReceiveChild()
//        //{
//        //    return dal.ReceiveChild();
//        //   // throw new NotImplementedException();
//        //}

//        //public List<Contract> ReceiveContracts()
//        //{

//        //    //throw new NotImplementedException();
//        //}
//        /// <summary>
//        /// Groping Nannys according to the age of the children (max/min)
//        /// </summary>
//        /// <param name="list"> list of nannys</param>
//        /// <param name="flag">(max /min)</param>
//        /// <returns> list of nannys according children age</returns>
//        public List<Nanny> GroNannygood(List<Nanny> list, bool flag = false)
//        {

//            List<Nanny> list1 = new List<Nanny>();
//            //    var wordGroups = from w in words group w by w[0] into g select new { FirstLetter = g.Key, Words = g }; foreach (var item in wordGroups) { Console.WriteLine("'{0}':", item.FirstLetter); foreach (var w in item.Words) Console.WriteLine(w); Console.WriteLine(); }
//            if (!flag)
//            {
//                var a =
//                    from w in list

//                        //      orderby w.NannyMaxKidsAge descending
//                    group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
//                    select new { FirstLetter = g.Key, Words = g };
//            }
//            else
//            {
//                var a =
//                   from w in list

//                   orderby w.NannyMaxKidsAge.Month descending
//                   group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
//                   select new { FirstLetter = g.Key, Words = g };
//            }
//            foreach (var item in a)
//            {
//                list1.Add((Nanny)item);
//            }
//            return list1;
//        }
//        // <summary>
//        /// Groping contract according distance from the mother
//        /// </summary>
//        /// <param name="list"> list of contract</param>
//        /// <param name="flag">(max /min)</param>
//        /// <returns> list of vontract accordinn distance</returns>
//        public List<Contract> GropbyContract(List<Contract> list, bool flag = false)
//        {
//            List<Contract> list1 = new List<Contract>();
//            //////   (CalculateDistance(GetMother(GetChild(w.ChildId).MotherId).MotherAddress, GetNanny(w.NannyId).NannyAddress) / 5)
//            if (!flag)
//            {
//                //     from w in list

//                //   orderby w.NannyMaxKidsAge.Month descending
//                //    group w by aaa(w) into g////
//                //   select new { FirstLetter = g.Key, Words = g };
//                /*IEnumerable<IGrouping<int, Contract>>*/
//                var v = from w in list
//                            //   let a = Aaa(w)
//                        group w by calculation(w);//new { FirstLetter = g.Key, Words = g };


//            }
//            else
//            {
//                var v = from w in list
//                        orderby w.ContractId descending
//                        group w by calculation(w);
//            }

//            return list1;

//        }
//        /// <summary>
//        /// calculation for grooping contracts by distance
//        /// </summary>
//        public int calculation(Contract w)
//        {

//            Child ch = GetChild(w.ChildId);
//            Mother mo = GetMother(ch.MotherId);
//            Nanny na = GetNanny(w.NannyId);
//            int de = CalculateDistance(mo.MotherAddress, na.NannyAddress);
//            return (de / 5);

//            //throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Receive Contracts
//        /// </summary>
//        public List<Contract> ReceiveContracts()
//        {
//            return dal.ReceiveContracts();
//            //   throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Receive Children list from data source
//        /// </summary>
//        public List<Child> ReceiveChild()
//        {
//            return dal.ReceiveChild();
//            //throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Receive nannys list from data source
//        /// </summary>
//        public List<Nanny> ReceiveNannys()
//        {
//            return dal.ReceiveNannys();
//            //   throw new NotImplementedException();
//        }
//        /// <summary>
//        /// Receive mothers list from data source
//        /// </summary>
//        public List<Mother> ReceiveMothers()
//        {
//            return dal.ReceiveMothers();
//            //  throw new NotImplementedException();
//        }

//    }

//}
