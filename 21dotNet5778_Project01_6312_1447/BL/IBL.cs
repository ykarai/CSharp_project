using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BL
{
    /// <summary>
    /// interface IBL - in the the logic layer
    /// </summary>
    public interface IBL
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
        Contract GetContract(int contractId);
 //     void RemoveContract(int id);
        bool RemoveContract(int id);
        void UpdateContract(Contract contract);
        IEnumerable<Contract> GetContractIEnumerable(Func<Contract, bool> predicat = null);


        List<Nanny> ReceiveNannys();       
        List<Mother> ReceiveMothers();
        List<Child> ReceiveChild();
        List<Contract> ReceiveContracts();


        List<Nanny> FitHoursNannys(Mother mom);
        List<Nanny> FitDistanceNannys(Mother mom);
        List<Child> SpacialKids();
        List<Nanny> NannysSpacialKids();


    }
    ///// <summary>
    // /// Factory IBL
    // /// </summary>
    //public class FactoryIBL
    //{
    //    public static IBL getIBL()
    //    {
    //        return new MyBl();
    //    }
    //}
    /// <summary>
    /// Factory BL whith singleton format
    /// </summary>
    static public class FactoryIBL
    {
        static IBL bl = null;
        public static IBL getIBL()
        {
            if (bl == null)
                bl = new MyBl();

            return bl;
        }
    }

}
