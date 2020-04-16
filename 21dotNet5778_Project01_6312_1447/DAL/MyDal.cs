
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// interface of DAL layer
    /// </summary>
    public interface Idal
    {
        void AddNanny(Nanny nanny);
        Nanny GetNanny(int nannyId);
        bool RemoveNanny(int id);
//      void RemoveNanny(int id);
        void UpdateNanny(Nanny nanny);
        IEnumerable<Nanny> GetNannyIEnumerable(Func<Nanny, bool> predicat = null);

        void AddMother(Mother mother);
        Mother GetMother(int motherId);
        bool RemoveMother(int id);
//      void RemoveMother(int id);
        void UpdateMother(Mother mother);
        IEnumerable<Mother> GetMotherIEnumerable(Func<Mother, bool> predicat = null);

        void AddChild(Child child);
        Child GetChild(int childId);
        bool RemoveChild(int id);
//      void RemoveChild(int id);
        void UpdateChild(Child child);
        IEnumerable<Child> GetChildIEnumerable(Func<Child, bool> predicat = null);


        void AddContract(Contract contract);
        Contract GetContract(int ContractId);
        bool RemoveContract(int id);
//      void RemoveContract(int id);
        void UpdateContract(Contract contract);
        IEnumerable<Contract> GetContractIEnumerable(Func<Contract, bool> predicat = null);

        /// <summary>
        /// receive from DataSource copy list of-
        /// </summary>
        List<Nanny> ReceiveNannys();             
        List<Mother> ReceiveMothers();
        List<Child> ReceiveChild();
        List<Contract> ReceiveContracts();

    }
    /// <summary>
    /// Factory Dal
    /// </summary>
    //public class FactoryDal
    //{
    //    public static Idal getDal()
    //    {
    //        return new Dal_imp();
    //    }
    //}
    /// <summary>
    /// Factory Dal whith singleton format
    /// </summary>
    static public class FactoryDal
    {
        static Idal dl = null;
        public static Idal getDal()
        {
            if (dl == null)
               dl = new Dal_XML_imp();


            //    dl = new Dal_imp();

            return dl;
        }
    }

    //public class MyDal
    //{
    //}
}
