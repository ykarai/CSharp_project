using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    /// <summary>
    /// implementaion of Idal -data layer
    /// </summary>
   internal class Dal_imp : Idal
   {
        static int contractnumber = 1000; //for contract ID


        #region Nanny functions

        /// <summary>
        /// Add Nanny to Data Source 
        /// </summary>
        public void AddNanny(Nanny nanny_)
        {
            Nanny nanny = GetNanny(nanny_.NannyId);
            if (nanny != null)
                throw new Exception("Nanny with the same id already exists...");
            DataSource.ListOfNannys.Add(nanny_);
        }
        /// <summary>
        /// Get Nanny cheacking if nanny exist in data source
        /// </summary>
        /// <returns>Nanny or null if not exist in data source</returns>
        public Nanny GetNanny(int nannyId)
        {
             return DataSource.ListOfNannys.FirstOrDefault(s => s.NannyId == nannyId);
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
            return DataSource.ListOfNannys.Remove(nanny);
        }
        /// <summary>
        /// Update Nanny in data source
        /// </summary>
        public void UpdateNanny(Nanny nanny)
        {
            //    DataSource.ListOfNannys[DataSource.ListOfNannys.FindIndex(s => s.NannyId == nanny.NannyId)] = nanny;
            int i = DataSource.ListOfNannys.FindIndex(s => s.NannyId == nanny.NannyId);
            if (i == -1)
                throw new Exception("Nanny with the same id not found...");
            DataSource.ListOfNannys[i] = nanny;
        }
        public IEnumerable<Nanny> GetNannyIEnumerable(Func<Nanny, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.ListOfNannys.AsEnumerable();

            return DataSource.ListOfNannys.Where(predicat);
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
            DataSource.ListOfMothers.Add(mother_);
        }

        /// <summary>
        /// Get mother cheacking if mother exist in data source
        /// </summary>
        /// <param name="MotherId">Mother</param>
        /// <returns>mother or null if not exist in data source</returns>
        public Mother GetMother(int MotherId)
        {
            return DataSource.ListOfMothers.FirstOrDefault(s => s.MotherId == MotherId);
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
            return DataSource.ListOfMothers.Remove(mother);
        }
        /// <summary>
        /// Update Mother in data source
        /// </summary>
        public void UpdateMother(Mother mother)
        {
            //    DataSource.ListOfMothers[DataSource.ListOfMothers.FindIndex(s => s.MotherId == mother.MotherId)] = mother;
            int i = DataSource.ListOfMothers.FindIndex(s => s.MotherId == mother.MotherId);
            if (i == -1)
                throw new Exception("mother with the same id not found...");
            DataSource.ListOfMothers[i] = mother;
        }
        public IEnumerable<Mother> GetMotherIEnumerable(Func<Mother, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.ListOfMothers.AsEnumerable();

            return DataSource.ListOfMothers.Where(predicat);
        }
        #endregion


        #region Child functions

        /// <summary>
        /// Update child in data source
        /// </summary>
        public void AddChild(Child child_)
        {
            Child child = GetChild(child_.ChildId);
            if (child != null)
                throw new Exception("child with the same id already exists...");
            DataSource.ListOfChild.Add(child_);
        }       
        /// <summary>
        /// Get child cheacking if child exist in data source
        /// </summary>
        /// <param name="MotherId"></param>
        /// <returns>child or null if not exist in data source</returns>
        public Child GetChild(int ChildId)
        {
             return DataSource.ListOfChild.FirstOrDefault(s => s.ChildId == ChildId);
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

            //      DataSource.ListOfChild[DataSource.ListOfChild.FindIndex(s => s.ChildId == child.ChildId)] = child;
            //int m = DataSource.ListOfMothers.FindIndex(s => s.MotherId == child.MotherId);
            //if (m == -1)
            //    throw new Exception("mother with the same id not found...");
            int i = DataSource.ListOfChild.FindIndex(s => s.ChildId == child.ChildId);
            if (i == -1)
                throw new Exception("child with the same id not found...");
            DataSource.ListOfChild[i] = child;

        }
        /// <summary>
        /// Remove Child from data source
        /// </summary>
        public bool RemoveChild(int id)
        {
            Child child = GetChild(id);
            if (child == null)
            {
                //   return false;
                throw new Exception("child with this id no exists...");
            }
            return DataSource.ListOfChild.Remove(child);
        }
        public IEnumerable<Child> GetChildIEnumerable(Func<Child, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.ListOfChild.AsEnumerable();

            return DataSource.ListOfChild.Where(predicat);
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
            if (GetNanny(contract_.NannyId) == null )//|| GetMother(ch.MotherId) == null )
                throw new Exception("Nanny or Mother or Child not exist...");
            contract_.ContractId = contractnumber;
            contractnumber = contractnumber + 1;
            Contract contract = GetContract(contract_.ContractId);
            if (contract == null)
            {
                DataSource.ListOfContracts.Add(contract_);
                contract_.ContractSigned = true;
                
            }
            else
            throw new Exception("Contract with this id already exists...");
        }
        /// <summary>
        /// Get contract cheacking if contract exist in data source
        /// </summary>
        /// <param name="nannyId"></param>
        /// <returns>contract or null if not exist in data source</returns>
        public Contract GetContract(int contractId)
        {
         return DataSource.ListOfContracts.FirstOrDefault(s => s.ContractId == contractId);
            #region imlement 2
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
            #endregion
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
            return DataSource.ListOfContracts.Remove(contract);

        }
        /// <summary>
        /// Update contract in data source
        /// </summary>
        public void UpdateContract(Contract contract)
        {
            //if (GetContract(contract.ContractId) == null)
            //{
            //    throw new Exception("Contract with this id no exists...");
            //}
            int m = DataSource.ListOfNannys.FindIndex(s => s.NannyId == contract.NannyId);
            if (m == -1)
                throw new Exception("Nanny with the same id not found...");
            int n = DataSource.ListOfChild.FindIndex(s => s.ChildId == contract.ChildId);
            if (n == -1)
                throw new Exception("child with the same id not found...");
            int o = DataSource.ListOfContracts.FindIndex(s => s.ContractId == contract.ContractId);
            if (o == -1)
                throw new Exception("contract with the same id not found...");
            DataSource.ListOfContracts[DataSource.ListOfContracts.FindIndex(s => s.ContractId == contract.ContractId)] = contract;
            
        }
        public IEnumerable<Contract> GetContractIEnumerable(Func<Contract, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.ListOfContracts.AsEnumerable();

            return DataSource.ListOfContracts.Where(predicat);
        }
        #endregion


        #region Receive data function (by value)
        /// <summary>
        /// Receive all Nannys from data source
        /// </summary>
        /// <returns>list of the nannys from data source</returns>
        public List<Nanny> ReceiveNannys()
        {
            return DataSource.ListOfNannyByV();
            // throw new NotImplementedException();
        }
        /// <summary>
        /// Receive all contracts from data source
        /// </summary>
        /// <returns> list of the contracts from data source</returns>
        public List<Contract> ReceiveContracts()
        {
            return DataSource.ListOfContractByV();
        }
        /// <summary>
        /// Receive all Cildren from data source
        /// </summary>
        /// <returns>list of the nannys from data source</returns>
        public List<Child> ReceiveChild()
        {
            return DataSource.ListOfChildByV();
        }
        /// <summary>
        /// Receive all Mothers from data source
        /// </summary>
        /// <returns> list of the mothers from data source</returns>
        public List<Mother> ReceiveMothers()
        {
            return DataSource.ListOfMotherByV();
        }
        #endregion


    }
}
