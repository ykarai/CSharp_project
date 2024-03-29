﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapsApi;

using BE;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;

namespace BL
{
    /// <summary>
    ///implementaion of BL -logic layer whith useng Linq and lambda
    /// </summary>
    internal class MyBl : IBL
    {
        //    DAL.Idal dal;
        //   DAL.Idal dal = new DAL.Dal_imp();
        //public void Adapter()
        //{
        //    DAL.FactoryDal factory = new DAL.FactoryDal();
        //    dal = factory.getDal();
        //}
        /// <summary>
        /// get dal with use in "factory"
        /// </summary>
        DAL.Idal dal;
        public MyBl()
        {
            dal = DAL.FactoryDal.getDal();
       //     start();
        }







        //  #region initialize sample of information
        //    /// <summary>
        //    /// initialize sample of information
        //    /// </summary>
        //    private void start()
        //{

        //    Nanny Zelda = new Nanny();
        //    //Zelda.NannyAddress = "Israel,Jerusalem,Shakhal,1";
        //    Zelda.NannyAddress = "ירושלים,רמת אשכול,12";
        //    Zelda.NannyDate = new DateTime(1960, 4, 9);
        //    Zelda.NannyDaysOfWork = new bool[6];
        //    Zelda.NannyDaysOfWork[0] = true;
        //    Zelda.NannyDaysOfWork[1] = true;
        //    Zelda.NannyDaysOfWork[2] = true;
        //    Zelda.NannyDaysOfWork[3] = true;
        //    Zelda.NannyDaysOfWork[4] = true;
        //    Zelda.NannyDaysOfWork[5] = true;
        //    Zelda.NannyFirstName = "ZeldaA";
        //    Zelda.NannyFloor = 3;
        //    Zelda.NannyHaveElevator = true;
        //    Zelda.NannyHolidaysTamat = true;
        //    Zelda.NannyId = 40000000;
        //    Zelda.NannyIsHourlysalary = false;
        //    Zelda.NannyLastName = "Steinberg";
        //    Zelda.NannyMaxKidsAge = new DateTime(2005, 4, 9);
        //    Zelda.NannyMaxKidslimit = 18;//new DateTime(2001, 4, 9);
        //    Zelda.NannyMinKidsAge = new DateTime(2015, 4, 9);
        //    Zelda.NannyPhoneNumber = 0543572245;
        //    Zelda.NannyRecommendations = "non";
        //    Zelda.NannySpecialKids = true;
        //    Zelda.NannyTableOfWork = new int[2, 6];
        //    Zelda.NannyTableOfWork[0, 0] = 1;
        //    Zelda.NannyTableOfWork[1, 0] = 1;
        //    Zelda.NannyTableOfWork[0, 1] = 7;
        //    Zelda.NannyTableOfWork[1, 1] = 12;
        //    Zelda.NannyTableOfWork[0, 2] = 4;
        //    Zelda.NannyTableOfWork[1, 2] = 5;
        //    Zelda.NannyTableOfWork[0, 3] = 1;
        //    Zelda.NannyTableOfWork[1, 3] = 1;
        //    Zelda.NannyTableOfWork[0, 4] = 2;
        //    Zelda.NannyTableOfWork[1, 4] = 3;
        //    Zelda.NannyTableOfWork[0, 5] = 4;
        //    Zelda.NannyTableOfWork[1, 5] = 5;
        //    // Zelda.NannyTableOfWork[6, 6] = 6;
        //    Zelda.NannyTariffForHour = 27;
        //    Zelda.NannyTariffForMonth = 70000;
        //    Zelda.NannyYearsExperience = 3;

        //    try
        //    {
        //        this.AddNanny(Zelda);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateNanny(Zelda);
        //    }

        //    Nanny Zelda2 = new Nanny();
        //    Zelda2.NannyAddress = "ירושלים,רמת אשכול,6";
        //    Zelda2.NannyDate = new DateTime(1960, 4, 9);
        //    Zelda2.NannyDaysOfWork = new bool[6];
        //    Zelda2.NannyDaysOfWork[0] = true;
        //    Zelda2.NannyDaysOfWork[1] = true;
        //    Zelda2.NannyDaysOfWork[2] = true;
        //    Zelda2.NannyDaysOfWork[3] = true;
        //    Zelda2.NannyDaysOfWork[4] = true;
        //    Zelda2.NannyDaysOfWork[5] = false;
        //    Zelda2.NannyFirstName = "Zelda cohen";
        //    Zelda2.NannyFloor = 3;
        //    Zelda2.NannyHaveElevator = true;
        //    Zelda2.NannyHolidaysTamat = true;
        //    Zelda2.NannyId = 60000000;
        //    Zelda2.NannyIsHourlysalary = false;
        //    Zelda2.NannyLastName = "Steinberg";
        //    Zelda2.NannyMaxKidsAge = new DateTime(2005, 4, 9);
        //    Zelda2.NannyMaxKidslimit = 18;//new DateTime(2001, 4, 9);
        //    Zelda2.NannyMinKidsAge = new DateTime(2015, 4, 9);
        //    Zelda2.NannyPhoneNumber = 0543572245;
        //    Zelda2.NannyRecommendations = "non";
        //    Zelda2.NannySpecialKids = true;

        //    Zelda2.NannyTableOfWork = new int[2, 6];
        //    Zelda2.NannyTableOfWork[0, 0] = 1;
        //    Zelda2.NannyTableOfWork[1, 0] = 3;
        //    Zelda2.NannyTableOfWork[0, 1] = 6;
        //    Zelda2.NannyTableOfWork[1, 1] = 12;
        //    Zelda2.NannyTableOfWork[0, 2] = 4;
        //    Zelda2.NannyTableOfWork[1, 2] = 5;
        //    Zelda2.NannyTableOfWork[0, 3] = 1;
        //    Zelda2.NannyTableOfWork[1, 3] = 2;
        //    Zelda2.NannyTableOfWork[0, 4] = 7;
        //    Zelda2.NannyTableOfWork[1, 4] = 15;
        //    Zelda2.NannyTableOfWork[0, 5] = 4;
        //    Zelda2.NannyTableOfWork[1, 5] = 5;
        //    //  Zelda.NannyTableOfWork = new int[6][];
        //    Zelda2.NannyTariffForHour = 27;
        //    Zelda2.NannyTariffForMonth = 70000;
        //    Zelda2.NannyYearsExperience = 3;

        //    try
        //    {
        //        this.AddNanny(Zelda2);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateNanny(Zelda2);
        //    }
        //    Mother Shlomit = new Mother();
        //    Shlomit.kilometerAround = 10;
        //    Shlomit.MotherAddress = "ירושלים,רמת אשכול,18";
        //    Shlomit.MotherAroundAddress = "ירושלים,רמת אשכול,18";
        //    Shlomit.MotherDate = new DateTime(1996, 4, 9);
        //    Shlomit.MotherDaysOfWork = new bool[6];
        //    Shlomit.MotherDaysOfWork[0] = true;
        //    Shlomit.MotherDaysOfWork[1] = true;
        //    Shlomit.MotherDaysOfWork[2] = false;
        //    Shlomit.MotherDaysOfWork[3] = true;
        //    Shlomit.MotherDaysOfWork[5] = false;
        //    Shlomit.MotherDaysOfWork[4] = true;
        //    Shlomit.MotherFirstName = "Shlomit";
        //    Shlomit.MotherHaveElevator = false;
        //    Shlomit.MotherId = 20000000;
        //    Shlomit.MotherKidsAverage = 9;
        //    Shlomit.MotherLastName = "Shtetman";
        //    Shlomit.MotherPhoneNumber = 054567456;
        //    Shlomit.MotherRemarks = "";
        //    try
        //    {
        //        this.AddMother(Shlomit);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateMother(Shlomit);
        //    }

        //    Mother Shlomit2 = new Mother();
        //    Shlomit2.kilometerAround = 10;
        //    Shlomit2.MotherAddress = "ירושלים,רמת אשכול,6";
        //    Shlomit2.MotherAroundAddress = "ירושלים,רמת אשכול,6";
        //    Shlomit2.MotherDate = new DateTime(1996, 4, 9);
        //    Shlomit2.MotherDaysOfWork = new bool[6];
        //    Shlomit2.MotherDaysOfWork[0] = true;
        //    Shlomit2.MotherDaysOfWork[1] = true;
        //    Shlomit2.MotherDaysOfWork[2] = true;
        //    Shlomit2.MotherDaysOfWork[3] = true;
        //    Shlomit2.MotherDaysOfWork[5] = true;
        //    Shlomit2.MotherDaysOfWork[4] = true;
        //    Shlomit2.MotherFirstName = "Shlomit";
        //    Shlomit2.MotherHaveElevator = false;
        //    Shlomit2.MotherId = 90000000;
        //    Shlomit2.MotherKidsAverage = 9;
        //    Shlomit2.MotherLastName = "Shtetman";
        //    Shlomit2.MotherPhoneNumber = 054567456;
        //    Shlomit2.MotherRemarks = "";

        //    Shlomit2.MotherTableOfWork = new int[2, 6];

        //    Shlomit2.MotherTableOfWork[0, 0] = 1;
        //    Shlomit2.MotherTableOfWork[1, 0] = 1;
        //    Shlomit2.MotherTableOfWork[0, 1] = 8;
        //    Shlomit2.MotherTableOfWork[1, 1] = 9;
        //    Shlomit2.MotherTableOfWork[0, 2] = 4;
        //    Shlomit2.MotherTableOfWork[1, 2] = 5;
        //    Shlomit2.MotherTableOfWork[0, 3] = 1;
        //    Shlomit2.MotherTableOfWork[1, 3] = 1;
        //    Shlomit2.MotherTableOfWork[0, 4] = 9;
        //    Shlomit2.MotherTableOfWork[1, 4] = 13;
        //    Shlomit2.MotherTableOfWork[0, 5] = 4;
        //    Shlomit2.MotherTableOfWork[1, 5] = 5;

        //    try
        //    {
        //        this.AddMother(Shlomit2);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateMother(Shlomit2);
        //    }
        //    //Shlomit.MotherTableOfWork = new int[6,2];
        //    Shlomit.MotherTableOfWork = new int[2, 6];


        //    Shlomit.MotherTableOfWork[0, 0] = 1;
        //    Shlomit.MotherTableOfWork[1, 0] = 1;
        //    Shlomit.MotherTableOfWork[0, 1] = 9;
        //    Shlomit.MotherTableOfWork[1, 1] = 10;
        //    Shlomit.MotherTableOfWork[0, 2] = 4;
        //    Shlomit.MotherTableOfWork[1, 2] = 5;
        //    Shlomit.MotherTableOfWork[0, 3] = 1;
        //    Shlomit.MotherTableOfWork[1, 3] = 1;
        //    Shlomit.MotherTableOfWork[0, 4] = 9;
        //    Shlomit.MotherTableOfWork[1, 4] = 10;
        //    Shlomit.MotherTableOfWork[0, 5] = 4;
        //    Shlomit.MotherTableOfWork[1, 5] = 5;



        //    Child Yos = new Child();
        //    Yos.ChildDate = new DateTime(2008, 5, 19);
        //    Yos.ChildFirstName = "Yos";
        //    Yos.ChildId = 10000000;
        //    Yos.ChildIsSpecial = false;
        //    Yos.ChildLastName = "Shtetman";
        //    //  Yos.ChildSpical
        //    Yos.MotherId = 20000000;
        //    Child dan = new Child();
        //    dan.ChildDate = new DateTime(2004, 4, 9);
        //    dan.ChildFirstName = "Dan";
        //    dan.ChildId = 20000000;
        //    dan.ChildIsSpecial = true;
        //    dan.ChildLastName = "strauss";
        //    //  Yos.ChildSpical
        //    Yos.MotherId = 30000000;
        //    Yos.ImageSource = (@"images\start\child2.png");
        //    //  throw new NotImplementedException();
        //    try
        //    {
        //        this.AddChild(Yos);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateChild(Yos);
        //    }
        //    try
        //    {
        //        this.AddChild(dan);
        //    }
        //    catch (Exception)
        //    {
        //        this.UpdateChild(dan);
        //    }

        //    Contract con = new Contract();
        //    con.ChildId = 10000000;
        //    con.NannyId = 40000000;

        //    try
        //    {
        //        this.AddContract(con);
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    Contract con2 = new Contract();
        //    con2.ChildId = 20000000;
        //    con2.NannyId = 40000000;

        //    try
        //    {
        //        this.AddContract(con2);
        //    }
        //    catch (Exception)
        //    {

        //    }


        //}
        //#endregion

        private IEnumerable<object> a;

        #region Nanny functions

        public Nanny GetNanny(int nannyId)
        {
//           return dal.ReceiveNannys().FirstOrDefault(s => s.NannyId == nannyId);
            return dal.GetNanny(nannyId);
        }

        /// <summary>
        /// cheaking if nanny age more then 18 years
        /// </summary>
        /// <param name="nanny">Nanny</param>
        public void AddNanny(Nanny nanny)
        {
            DateTime today = DateTime.Today;
            int Age = today.Year - nanny.NannyDate.Year;
            if (Age >= 18)
            {
                dal.AddNanny(nanny);
            }
            else
            {
                throw new Exception("This nanny is too young");

            }
        }
        public bool RemoveNanny(int id)
        {
            return dal.RemoveNanny(id);
            //  throw new NotImplementedException();
        }
        /// <summary>
        /// Update Nanny
        /// </summary>
        public void UpdateNanny(Nanny nanny)
        {
            dal.UpdateNanny(nanny);
            //  throw new NotImplementedException();
        }
        public IEnumerable<Nanny> GetNannyIEnumerable(Func<Nanny, bool> predicat = null)
        {
            return dal.GetNannyIEnumerable(predicat);

        }
        #endregion


        #region Mother functions

        /// <summary>
        /// Add Mother 
        /// </summary>
        /// <param name="mother"></param>
        public void AddMother(Mother mother)
        {
            dal.AddMother(mother);
            //  throw new NotImplementedException();
        }
        /// <summary>
        /// Get Mother
        /// </summary>
        public Mother GetMother(int motherId)
        {
            //          return dal.ReceiveMothers().FirstOrDefault(s => s.MotherId == motherId);
            return dal.GetMother(motherId);
        }
        /// <summary>
        /// Remove mother
        /// </summary>
        public bool RemoveMother(int id)
        {
            return dal.RemoveMother(id);
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Updat eMother
        /// </summary>
        public void UpdateMother(Mother mother)
        {
            dal.UpdateMother(mother);
            //  throw new NotImplementedException();
        }
        public IEnumerable<Mother> GetMotherIEnumerable(Func<Mother, bool> predicat = null)
        {
            return dal.GetMotherIEnumerable(predicat);
        }
        #endregion


        #region child functions

        /// <summary>
        /// Update child
        /// </summary>
        public void AddChild(Child child)
        {
            dal.AddChild(child);
        //    throw new NotImplementedException();
        }
        /// <summary>
        /// Get child cheacking if nanny exist in data source
        /// </summary>
        /// <returns>child or null if not exist in data source</returns>
        public Child GetChild(int ChildId)
        {

//         return dal.ReceiveChild().FirstOrDefault(s => s.ChildId == ChildId);
           return dal.GetChild(ChildId);

        }
        /// <summary>
        /// Update Child
        /// </summary>
        public void UpdateChild(Child child)
        {
            dal.UpdateChild(child);
            //     throw new NotImplementedException();
        }
        /// <summary>
        /// Remove Child
        /// </summary>
        public bool RemoveChild(int id)
        {
            return dal.RemoveChild(id);
            //  throw new NotImplementedException();
        }
        public IEnumerable<Child> GetChildIEnumerable(Func<Child, bool> predicat = null)
        {
            return dal.GetChildIEnumerable(predicat);
        }
        #endregion


        #region contract functions

        /// <summary>
        /// Update Contract
        /// </summary>
        public void UpdateContract(Contract contract)
        {
            dal.UpdateContract(contract);
            //throw new NotImplementedException();
        }
        public Contract GetContract(int contractId)
        {

            //         return dal.ReceiveContract().FirstOrDefault(s => s.contractId == contractId);
            return dal.GetContract(contractId);

        }
        /// <summary>
        /// addding contract cheacking if contract is properly
        /// </summary>
        public void AddContract(Contract contract)
        {
            int ChildId = contract.ChildId;
            Child child = dal.GetChild(ChildId);
            if (child == null)
            {
                //   return false;
                throw new Exception("child with this id no exists...");
            }
            DateTime today = DateTime.Today;
            //           int Age = today.Month - child.ChildDate.Month;
            int Age = today.Year - child.ChildDate.Year;
            if (Age < 3)
            {
                throw new Exception("This child is too young");
            }
          
            bool haveTime = Isfree(contract);
            if (haveTime)
            {
                contract.ContractFinelSalary = MoneyCalculation(contract);
                dal.AddContract(contract);  
            }
            else
                throw new Exception("to nuch children");
           

            

        }
        /// <summary>
        /// Remove contract
        /// </summary>
        public bool RemoveContract(int id)
        {
            return dal.RemoveContract(id);
            //   throw new NotImplementedException();
        }
        /// <summary>
        /// checking if Nanny doesnt reach max kids limit
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>yes ifnanny have time</returns>
        public bool Isfree(Contract contract)
        {
            #region implement 1
            //   int counter = 0;
            //   Nanny ch = GetNanny(contract.NannyId);
            //   if (ch == null)
            //   {
            //       throw new Exception("no nanny ");
            //   }
            //   List<Contract> Contractlist = dal.ReceiveContracts();

            //   //   return Contractlist.FirstOrDefault(s => Child ch = GetChild(s.ChildId);int idm=ch.);
            //   foreach (Contract item in Contractlist)
            //   {
            //       Nanny nan = GetNanny(item.NannyId);
            //       if (nan.NannyId == ch.NannyId)
            //       { counter++; }
            //   }
            //   if (counter + 1 > ch.NannyMaxKidslimit)
            //       return false;
            //   return true;
               #endregion

            #region implement 2
            Nanny n = GetNanny(contract.NannyId);
            if (n == null)
            {
                //   return false;
                throw new Exception("Nanny with this id no exists...");
            }
            int counter = 0;
            var  a = from item in dal.GetContractIEnumerable(s=> s.NannyId == n.NannyId)
 //               where(item.NannyId == n.NannyId)
                  select GetContract(item.ContractId);
            foreach (var item in a)
            {
                counter++; 
            }
            if (counter + 1 > n.NannyMaxKidslimit)
                return false;
            return true;
            #endregion
        }
        // <summary>
        /// checking if A discount is required according to the number of children
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>salery of nanny after discount</returns>
        public double MoneyCalculation(Contract contract)
        {
            #region implement 1
            //int counter = 0;
            //double FinalSalery;
            //Child ch = GetChild(contract.ChildId);
            //if (ch == null)
            //{
            //    throw new Exception("no child ");
            //}
            //List<Contract> Contractlist = dal.ReceiveContracts();

            //return Contractlist.FirstOrDefault(s => Child ch = GetChild(s.ChildId); int idm = ch.);
            //foreach (Contract item in Contractlist)
            //{
            //    Child chil = GetChild(item.ChildId);

            //    if (chil.MotherId == ch.MotherId && item.NannyId == contract.NannyId && item.ChildId != contract.ChildId)
            //    {
            //        counter += 2;
            //    }

            //}
            #endregion

            #region implement 2
            int counter = 0;
            double FinalSalery;
            Child ch = GetChild(contract.ChildId);
            if (ch == null)
            {
                throw new Exception("no child ");
            }
             var a = from item in dal.GetContractIEnumerable()
                            where (item.NannyId == contract.NannyId)&&
                                  (item.MotherId== contract.MotherId)&&
                                  (item.ChildId != contract.ChildId)
                     select GetContract(item.ContractId);
            foreach (var item in a)
            {
                counter += 2;
            }
            #endregion

            if (contract.ContractIsHourlysalary)
            {
                FinalSalery = contract.ContractTariffForHour * 4;
            }
            else
            {
                FinalSalery = contract.ContractTariffForMonth;
            }

            FinalSalery -= FinalSalery * (counter / 100.0);


            return FinalSalery;
        }
        public IEnumerable<Contract> GetContractIEnumerable(Func<Contract, bool> predicat = null)
        {
            return dal.GetContractIEnumerable(predicat);
        }
        #endregion


        #region Calculate Distance function

        /// <summary>
        /// Calculate Distance batween to adresses
        /// </summary>
        /// <param name="source">source addres</param>
        /// <param name="dest">source sestnination adrees</param>
        /// <returns>Distance between places in int variable </returns>
        public static int CalculateDistance(string source, string dest)
        {
            try
            {
                var drivingDirectionRequest = new DirectionsRequest
                {
                    TravelMode = TravelMode.Walking,
                    Origin = source,
                    Destination = dest,
                };
                DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
                Route route = drivingDirections.Routes.First();
                Leg leg = route.Legs.First();
                return leg.Distance.Value;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion


        #region Fit Hours Nannys
        /// <summary>
        /// Checks whether the nannys suitable for mother hours
        /// </summary>
        /// <param name="mom">mother information </param>
        /// <returns> list of fit nannys</returns>
        public List<Nanny> FitHoursNannys(Mother mom)
        {

            List<Nanny> fitNannys = new List<Nanny>();
 //           List<Nanny> Nannytlist = dal.ReceiveNannys();
            IEnumerable<Nanny> Nannytlist = dal.GetNannyIEnumerable();
            foreach (Nanny item in Nannytlist)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (item.NannyDaysOfWork[i] && mom.MotherDaysOfWork[i])
                    {

                        int a1 = item.NannyTableOfWork[0, i];
                        int a2 = item.NannyTableOfWork[1, i];
                        int b1 = mom.MotherTableOfWork[0, i];
                        int b2 = mom.MotherTableOfWork[1, i];

                        //int a1 = item.NannyTableOfWork[0,i];
                        //int a2 = item.NannyTableOfWork[1,i];
                        //int b1 = mom.MotherTableOfWork[0,i];
                        //int b2 = mom.MotherTableOfWork[1,i];
                        if (a1 < b1 && a2 < b2)
                        {
                            fitNannys.Add(item);
                        }
                    }
                }


            }
            bool isEmpty = !(fitNannys.Any());
            if (!isEmpty)
            {
                return fitNannys;
            }
            else //no abslut mach
            {

                foreach (Nanny item in Nannytlist)
                {
                    for (int i = 0; i < 6; i++)
                    {

                        if (item.NannyDaysOfWork[i] && mom.MotherDaysOfWork[i] || Houercheck(item, mom, i))
                            if (fitNannys.Count < 5)
                            {
                                fitNannys.Add(item);
                            }
                    }

                }
                while(fitNannys.Count < 5)
                {

                    int i = 0;
                    //if (!fitNannys.Contains(Nannytlist[i]))
                    //    fitNannys.Add(Nannytlist[i]);
                    //i++;
                    foreach (Nanny item in Nannytlist)
                    {
                        fitNannys.Add(item);
                        i++;
                        if (fitNannys.Count > 4)
                            break;
                    }
                }
                return fitNannys;

            }
        }
        /// <summary>
        /// find if nannys houers close to mother houres
        /// <returns> if close return true</returns>
        public bool Houercheck(Nanny item, Mother mom, int i)
        {
            int a1 = item.NannyTableOfWork[0,i];
            int a2 = item.NannyTableOfWork[1,i];
            int b1 = mom.MotherTableOfWork[0,i];
            int b2 = mom.MotherTableOfWork[1,i];  
            if ((Math.Abs(a1 - b1) < 2) || (Math.Abs(b1 - b2) < 2))
            {
                return true;
            }
            return false;
            
        }
        #endregion


        #region Fit Distance Nannys

        /// <summary>
        /// Fit Distance Nannys
        /// </summary>
        /// <param name="mom"> mother info</param>
        /// <returns> list of nannys that there distance fit</returns>
        public List<Nanny> FitDistanceNannys(Mother mom)
        {

            List<Nanny> fitDNannys = new List<Nanny>();
            List<Nanny> Nannytlist = dal.ReceiveNannys();
            string a = mom.MotherAroundAddress;
            if (a == null)
                a = mom.MotherAddress;
            int? around = mom.kilometerAround;
            if (around==null)
                around =2;
            foreach (Nanny item in Nannytlist)
            {
                int i = (CalculateDistance(a, item.NannyAddress));
                    //if ((CalculateDistance(a,item.NannyAddress)<=around))
                    if (((i/1000) <= around)&&(i != -1))
                    {
                            fitDNannys.Add(item); 
                    }   
            }
            return fitDNannys;
        }

        #endregion


        /// <summary>
        /// find all chilren whitout nannys yet
        /// </summary>
        /// <returns> return singly kids list</returns>
        public List<Child> singlyChildren()
        {

            #region implement 1
            ////foreach (Contract item in Contractlist)
            ////{
            ////    //                Nanny nan = GetNaany(item.NannyId);
            ////    //               int ChildId = item.ChildId;
            ////    Child child = GetChild(item.ChildId);
            ////    if (child != null)
            ////    {
            ////        singlykids.Remove(child);
            ////    }
            ////}
            ////return singlykids;
            //List<Contract> Contractlist = dal.ReceiveContracts();
            //List<Child> singlykids = dal.ReceiveChild();
            //var v = from item in Contractlist
            //        where (GetChild(item.ChildId) != null)
            //        select item;
            //foreach (var item in v)
            //{
            //    Child child = GetChild(item.ChildId);
            //    singlykids.Remove(child);
            //}
            #endregion

            #region implement 2

 //         List<Child> singlykids = dal.ReceiveChild();
            List<Child> singlykids = new List<Child>();
            IEnumerable<Child> b = dal.GetChildIEnumerable();
            foreach (var item in b)
            {
                singlykids.Add(item);
            }
            var a = from item in dal.GetChildIEnumerable()
                    from i in dal.GetContractIEnumerable()
                    where (i.ChildId == item.ChildId)
                    select item;
            foreach (var item in a)
            {
                singlykids.Remove(item);
            }
            #endregion

            return singlykids;

        }
        /// <summary>
        /// checking waht nannys work under tamat method
        /// </summary>
        /// <returns>list of nannys work like tamat</returns>
        public List<Nanny> NannysWorkTmat()
        {

            #region implement 1
            //List <Nanny> nannysWorkTmat = dal.ReceiveNannys();
            //nannysWorkTmat.RemoveAll(s => s.NannyHolidaysTamat == false);

            //foreach (Nanny item in nannysWorkTmat)
            //{
            //    if ((item.NannyHolidaysTamat))
            //    {
            //        nannysWorkTmat.Remove(item);
            //    }

            //}
            #endregion
            #region implement 2
            List<Nanny> nannysWorkTmat = new List<Nanny>();
            var a = from item in dal.GetNannyIEnumerable(s => s.NannyHolidaysTamat == false)
                    select item;
            foreach (var item in a)
            {
                nannysWorkTmat.Add(item);
            }
            #endregion
            return nannysWorkTmat;

        }
        /// <summary>
        /// recieve prediact and find all contracts have match
        /// </summary>
        /// <param name="func"></param>
        /// <returns> list of contract with metch</returns>
        public List<Contract> allContract(Func<Contract, bool> func)
        {
//            List<Contract> list = dal.ReceiveContracts();
            IEnumerable<Contract> list = dal.GetContractIEnumerable();
            Func<Contract, bool> func1 = func;
            var v = list.Where(func);
            List<Contract> list1 = new List<Contract>();
            foreach (var item in v)
            {
                list1.Add(item);
            }
            return list1;
        }
        /// <summary>
        /// recieve prediact and find all contracts have match
        /// </summary>
        /// <param name="func"></param>
        /// <returns> varialble of the count of metch contracts</returns>
        public int numofContract(Func<Contract, bool> func)
        {
            int num = 0;
//            List<Contract> list = dal.ReceiveContracts();
            IEnumerable<Contract> list = dal.GetContractIEnumerable();
            Func<Contract, bool> func1 = func;
            var v = list.Where(func);
            foreach (var item in v)
            {
                num++;
            }
            return num;
        }
        ///////////////////////////////////////////////////////

        /// <summary>
        /// Mother Have Elevator
        /// </summary>
        /// <returns> list of mothers have elevator</returns>
        public List<Mother> MotherHaveElevator()
        {
          //List<Mother> motherHaveElevator = dal.ReceiveMothers();
          //motherHaveElevator.RemoveAll(s => s.MotherHaveElevator == false);
          //return motherHaveElevator;
            List <Mother> m= new List<Mother>();
            var a = from item in dal.GetMotherIEnumerable(s => s.MotherHaveElevator == true)        
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;
        }
        /// <summary>
        /// Nannys experience 1 year
        /// </summary>
        /// <returns>list of nannys have 1 year experience</returns>
        public List<Nanny> Nannysexperience1()
        {
            //List<Nanny> Nannysexperience = dal.ReceiveNannys();
            //Nannysexperience.RemoveAll(s => s.NannyYearsExperience > 1);
            //return Nannysexperience;
            List<Nanny> m = new List<Nanny>();
            var a = from item in dal.GetNannyIEnumerable(s => s.NannyYearsExperience > 1)
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;

        }
        /// <summary>
        /// Nannys experience 3 year
        /// </summary>
        /// <returns>list of nannys have 3 year experience</returns>
        public List<Nanny> Nannysexperience3()
        {
            //List<Nanny> Nannysexperience = dal.ReceiveNannys();
            //Nannysexperience.RemoveAll(s => s.NannyYearsExperience > 3);
            //return Nannysexperience;
            List<Nanny> m = new List<Nanny>();
            var a = from item in dal.GetNannyIEnumerable(s => s.NannyYearsExperience > 2)
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;

        }
        /// <summary>
        /// Spacia lKids
        /// </summary>
        /// <returns> list of spacial kids</returns>
        public List<Child> SpacialKids()
        {
            //List<Child> spacialKids = dal.ReceiveChild();
            //spacialKids.RemoveAll(s => s.ChildIsSpecial == false);
            //return spacialKids;
            List<Child> m = new List<Child>();
            var a = from item in dal.GetChildIEnumerable(s => s.ChildIsSpecial)
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;

        }
        /// <summary>
        /// Nannys Spacial Kids
        /// </summary>
        /// <returns>list of nannys whit Spacial Kids </returns>
        public List<Nanny> NannysSpacialKids()
        {
            //List<Nanny> nannysSpacialKids = dal.ReceiveNannys();
            //nannysSpacialKids.RemoveAll(s => s.NannySpecialKids == false);
            //return nannysSpacialKids;
            List<Nanny> m = new List<Nanny>();
            var a = from item in dal.GetNannyIEnumerable(s => s.NannySpecialKids)
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;

        }
        /// <summary>
        ///  Offers nannys suitable for Spacial Kids contracts
        /// </summary>
        /// <returns>contracts of Spacial Kids whith nannys</returns>
        public List<Contract> NannysuitableSpacialKids()
        {
            List<Contract> NannysuitableSpacialKids = new List<Contract>();
            List<Nanny> nannysSpacialKids = NannysSpacialKids();
            List<Child> spacialKids = SpacialKids();
            int m = 0;
            foreach (Nanny item in nannysSpacialKids)
            {
                if (m < spacialKids.Count)
                {
                    Contract a = new Contract();
                    a.NannyId = item.NannyId;
                    Child c   = spacialKids[m];
                    a.ChildId = c.ChildId;
                    NannysuitableSpacialKids.Add(a);
                }
                m++;
            }           
            return NannysuitableSpacialKids;

        }
        /// <summary>
        /// Nannys Spacial Kids Andexperience
        /// </summary>
        /// <returns> return list of nannys also have experience and spacial kids </returns>
        public List<Nanny> NannysSpacialKidsAndexperience()
        {
            //List<Nanny> nannysSpacialKidsAndexperience = dal.ReceiveNannys();
            //nannysSpacialKidsAndexperience.RemoveAll(s => s.NannySpecialKids == false);
            //nannysSpacialKidsAndexperience.RemoveAll(s => s.NannyYearsExperience>3 );
            //return nannysSpacialKidsAndexperience;

            List<Nanny> m = new List<Nanny>();
            var a = from item in dal.GetNannyIEnumerable(s => s.NannySpecialKids)
                    where(item.NannyYearsExperience>3)
                    select item;
            foreach (var item in a)
                m.Add(item);
            return m;

        }








        //      public Nanny GetSNanny(int id)
        //     {
        //        
        //        throw new NotImplementedException();
        //   }


        //public List<Contract> ReceiveContracts()
        //{
        //    dal.ReceiveContracts();
        // //   throw new NotImplementedException();
        //}





        //public List<Nanny> ReceiveNannys()
        //{
        //    return dal.ReceiveNannys();
        //    //throw new NotImplementedException();
        //}

        //public List<Mother> ReceiveMothers()
        //{
        //    return dal.ReceiveMothers();
        //   // throw new NotImplementedException();
        //}

        //public List<Child> ReceiveChild()
        //{
        //    return dal.ReceiveChild();
        //   // throw new NotImplementedException();
        //}

        //public List<Contract> ReceiveContracts()
        //{

        //    //throw new NotImplementedException();
        //}

        #region grooping implement 1 

        /// <summary>
        /// Groping Nannys according to the age of the children (max/min)
        /// </summary>
        /// <param name="list"> list of nannys</param>
        /// <param name="flag">(max /min)</param>
        /// <returns> list of nannys accordinn children age</returns>
        public List<Nanny> GroNannygood(List<Nanny> list, bool Max, bool flag = false)
        {
            List<Nanny> list1 = new List<Nanny>();
            if (!flag)
            {
                if (Max)
                {
                    var a =
                    from w in list
                        //                  group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
                    group w by w.NannyMaxKidsAge.Year into g////
                    select g;
                }
                else
                {
                    var a =
                    from w in list
                        //                group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
                    group w by w.NannyMinKidsAge into g////
                    select g;

                }
            }
            else
            {
                if (Max)
                {
                    var a =
                    from w in list
                    orderby w.NannyMaxKidsAge.Year descending
                    //                  group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
                    group w by w.NannyMaxKidsAge.Year into g////
                    select g;
                }
                else
                {
                    var a =
                    from w in list
                    orderby w.NannyMaxKidsAge.Year descending
                    //                 group w by new { month = w.NannyMaxKidsAge.Month, year = w.NannyMaxKidsAge.Year } into g////
                    group w by w.NannyMinKidsAge into g////
                    select g;

                }

            }
            foreach (var item in a)
            {
                foreach (var itemIn in a)
                {
                    list1.Add((Nanny)itemIn);
                }

            }
            return list1;
        }
        // <summary>
        /// Groping contract according distance from the mother
        /// </summary>
        /// <param name="list"> list of contract</param>
        /// <param name="flag">(max /min)</param>
        /// <returns> list of vontract accordinn distance</returns>
        public List<Contract> GropbyContract(List<Contract> list, bool flag = false)
        {
            List<Contract> list1 = new List<Contract>();
            if (!flag)
            {
                /*IEnumerable<IGrouping<int, Contract>>*/
                var a = from w in list
                            //   let a = Aaa(w)
                        group w by calculation(w) into g//new { FirstLetter = g.Key, Words = g };
                        select g;
            }
            else
            {
                var a = from w in list
                        orderby w.ContractId descending
                        group w by calculation(w) into g
                        select g;
            }
            foreach (var item in a)
            {
                foreach (var itemIn in a)
                {
                    list1.Add((Contract)itemIn);
                }
            }
            return list1;
        }

        #endregion

        #region grooping implement 2  
        public IEnumerable<IGrouping<int, Nanny>> GroNannygood(bool Max, bool sort = false)
        {
            if (!sort)
            {
                if (Max)
                {
                    return from item in dal.GetNannyIEnumerable()
                           group item by item.NannyMaxKidsAge.Year into g////
                           select g;
                }
                else
                {
                    return from item in dal.GetNannyIEnumerable()
                           group item by item.NannyMinKidsAge.Year into g////
                           select g;
                }

            }
            else
            {
                if (Max)
                {
                    return (from item in dal.GetNannyIEnumerable()
                           orderby item.NannyMaxKidsAge.Year descending
                           group item by item.NannyMaxKidsAge.Year into g////
                           select g);
                }
                else
                {
                    return (from item in dal.GetNannyIEnumerable()
                           orderby item.NannyMaxKidsAge.Year descending
                           group item by item.NannyMinKidsAge.Year into g////
                           select g);
                }
            }

        }


       public IEnumerable<IGrouping<int, Contract>> GropbyContract(bool sort = false)
        {
            if (!sort)
            {

                return from item in dal.GetContractIEnumerable()
                       group item by calculation(item) into g
                       select g;
            }
              else
            {
                return from item in dal.GetContractIEnumerable()
                       orderby item.ContractId descending
                       group item by calculation(item) into g
                       select g;
            }
        }


        #endregion




        /// <summary>
        /// calculation for grooping contracts by distance
        /// </summary>
        public int calculation(Contract w)
        {

            Child ch = GetChild(w.ChildId);
            Mother mo = GetMother(ch.MotherId);
            Nanny na = GetNanny(w.NannyId);
            int de = CalculateDistance(mo.MotherAddress, na.NannyAddress);
            return (de / 5);

            //throw new NotImplementedException();
        }
        #region Receive  list by v
        /// <summary>
        /// Receive Contracts by v
        /// </summary>
        public List<Contract> ReceiveContracts()
        {
            return dal.ReceiveContracts();
         //   throw new NotImplementedException();
        }
        /// <summary>
        /// Receive Children list from data source
        /// </summary>
        public List<Child> ReceiveChild()
        {
            return dal.ReceiveChild();
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Receive nannys list from data source
        /// </summary>
        public List<Nanny> ReceiveNannys()
        {
            return dal.ReceiveNannys();
            //   throw new NotImplementedException();
        }
        /// <summary>
        /// Receive mothers list from data source
        /// </summary>
        public List<Mother> ReceiveMothers()
        {
            return dal.ReceiveMothers();
            //  throw new NotImplementedException();
        }
        #endregion
    }

}
