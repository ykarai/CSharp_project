//בס"ד
using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5778_Project01_6312_1447
{
    /// <summary>
    /// temporary project whit console aplication
    /// </summary>
    class PL
    {
        static void Main(string[] args)
        {
            try
            {
                //               MyBl s = new MyBl();
                BL.IBL bl = BL.FactoryIBL.getIBL();           //FactoryIBL
                                                              //List<Mother> mam = bl.ReceiveMothers();
                                                              //List<Nanny> nan = bl.FitDistanceNannys(mam[0]);

                
                for (int i = 0; i < 10; i++)
                {
                    Child s = new Child { ChildId = i, ChildFirstName = "first" + i, ChildLastName = "last" + i };
                    bl.AddChild(s);
                }
                int a=7;
                bl.RemoveChild(5);
                bl.UpdateChild(new Child { ChildId = 2, ChildFirstName = "oshri", ChildLastName = "cohen" });
                bl.GetChildIEnumerable();
                IEnumerable<Child> aa = bl.GetChildIEnumerable();
                List<Child> list = bl.ReceiveChild();

                foreach (var item in list)
                {
                    Console.WriteLine("id:{0,-5} name:{1} {2}", item.ChildId, item.ChildFirstName, item.ChildLastName);
                }

                foreach (var item in aa)
                {
                    Console.WriteLine("id:{0,-5} name:{1} {2}", item.ChildId, item.ChildFirstName, item.ChildLastName);
                }


                Console.ReadKey();

                //Contract co = new Contract();
                //co.ChildId = 20000000;
                //co.NannyId = 40000000;

                ////               co.MotherId = 20000000;
                //try
                //{
                //   bl.AddContract(co);
                //}
                //catch (Exception)
                //{
                //    bl.AddContract(co);
                //}


                //                Child a = new Child();                     //tests
                //                a.ChildId = 12345678;
                //                a.MotherId = 23456789;
                ////               Console.WriteLine( a.ToString());
                //                bl.AddChild(a);
                ////              bl.AddChild(a);
                List<Child> q = bl.ReceiveChild();
                foreach (var item in q)
                {
                    Console.WriteLine(item.ToString());
                }
                //                a.ChildId = 888;
                //                a.MotherId = 888;
                //                bl.UpdateChild(a);
                ////                bl.RemoveChild(a.ChildId);
                //                List<Child> p = bl.ReceiveChild();
                //                foreach (var item in p)
                //                {
                //                    Console.WriteLine(item.ToString());
                //                }
                //List<Mother> l = bl.ReceiveMothers();
                //foreach (var item in l)
                //{
                //    Console.WriteLine(item.ToString());
                //}
                //                //List<Contract> m = bl.ReceiveContracts();
                //                //foreach (var item in m)
                //                //{
                //                //    Console.WriteLine(item.ToString());
                //                //}
                //                //List<Nanny> n = bl.ReceiveNannys();
                //                //foreach (var item in n)
                //                //{
                //                //    Console.WriteLine(item.ToString());
                //                //}
                //                bl.AddChild(a);
                //                a.ChildFirstName = "dadada";
                //                bl.UpdateChild(a);
                //                //List<Child> q = bl.ReceiveChild();


                //Console.WriteLine("child 1, Contract 2, Mother 3,Nanny 4");
                //int v = int.Parse(Console.ReadLine());
                //if (v == 1)
                //{

                //    Child a1 = new Child();
                //    Console.WriteLine("ChildId");
                //    a1.ChildId = int.Parse(Console.ReadLine());
                //    Console.WriteLine("MotherId");
                //    a1.MotherId = int.Parse(Console.ReadLine());
                //    Console.WriteLine("ChildFirstName");
                //    a1.ChildFirstName = Console.ReadLine();
                //    Console.WriteLine("ChildLastName");
                //    a1.ChildLastName = Console.ReadLine();
                //    Console.WriteLine("ChildDate");
                //    a1.ChildDate = DateTime.Parse(Console.ReadLine());
                //    bl.AddChild(a1);
                //}

                List<Child> m = bl.ReceiveChild();
                foreach (var item in q)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception e)
            {
                string str = e.Message;
                Console.WriteLine(str);
            }

        }


    }
}