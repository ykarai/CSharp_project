using BE;
using BL;
using GoogleMapWpfApp.algo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for FitDistanceNannysWindow.xaml
    /// </summary>
    public partial class FitDistanceNannysWindow : Window
    {
        Mother contract;
        Mother MotherTarget;
        IBL bl; //= new BL.FactoryIBL();
        private List<Nanny> nannylist;
        public bool flag=true;


        // =new BL.FactoryIBL();
        //  BL.FactoryIBL();
        public FitDistanceNannysWindow()
        {
            InitializeComponent();
            contract = new Mother();
            // MotherTarget = null;
            grid1.DataContext = contract;
            this.comboBox.DataContext = contract;
            this.MotherDataGrid.DataContext = contract;
            bl = FactoryIBL.getIBL();

            this.comboBox.ItemsSource = bl.GetMotherIEnumerable();
            this.comboBox.DisplayMemberPath = "MotherId";
            this.comboBox.SelectedValuePath = "MotherId";
            //int i = GoogleMapWpfApp.algo.GoogleApiFunc.CalcDistance("ירושלים,רמת אשכול,14", "ירושלים,רמת אשכול,18", TravelType.Walking);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flag)
            {
                flag = false;
            }
            else// (!flag)
            {
                this.Close();
            }
            if (sender is ComboBox && ((ComboBox)sender).SelectedIndex > -1)
                this.refreshDataGrid(GetSelectedMotherId());
        }
        private int GetSelectedMotherId()
        {
            object result = this.comboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select Mother First");
            return (int)result;
        }
        private void refreshDataGrid(int contractId)
        {
            MotherDataGrid.ItemsSource = bl.GetMotherIEnumerable(s => s.MotherId == contractId);
            string str = (bl.GetMother(contractId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                //this.image.Source = b;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int i = GoogleMapWpfApp.algo.GoogleApiFunc.CalcDistance("ירושלים, רמת אשכול,14", "ירושלים, רמת אשכול,10", TravelType.Driving);
            //int i = GoogleMapWpfApp.algo.GoogleApiFunc.CalcDistance("ירושלים,רמת אשכול,14", "ירושלים,רמת אשכול,18", TravelType.Walking);
            //  int i = GoogleMapWpfApp.algo.GoogleApiFunc.CalcDistance("Jerusalem", "Tel-aviv", TravelType.Walking);
            if (this.comboBox.SelectedItem is Mother)
            {
                System.ComponentModel.BackgroundWorker work = new System.ComponentModel.BackgroundWorker();//new BackgroundWorker 
                work.DoWork += W_DoWork;//add Process function
                work.RunWorkerCompleted += W_RunWorkerCompleted;//do in finish
                work.RunWorkerAsync(this.comboBox.SelectedItem);//sync whith display

                //child = sender as Child;
                //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                //new AddChildWindow(childTarget).ShowDialog();
                // string str = "Are you sure you want to Remove?\n" + "Mother from data:\n";

                // if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                //  {
                //      bl.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
                //      this.Close();
                //  }

                //if (nannylist.Count() >= 5)
                //{
                //    NannyDataGrid6.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                //    string str = (bl.GetNanny(nannylist[0].NannyId)).ImageSource;
                //    if ((File.Exists(str) == false))
                //    {
                //        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                //        //this.image.Source = b;
                //    }
                //}

                //new RemoveChildWindow().Show();       
            }

        }

        private void W_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                // List<Nanny> nannylist = new List<Nanny>();
                // distance = algo.GoogleApiFunc.CalcDistance(source, dest, travelType);
                nannylist = bl.FitDistanceNannys(((Mother)e.Argument));// this.comboBox.SelectedItem));
                // duration = algo.GoogleApiFunc.CalcDuration(source, dest, travelType);

            }
            catch (Exception e1)
            {

            }
        }
        private void W_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (nannylist != null)
            {
                //List<Nanny> nannylist = new List<Nanny>();
                // nannylist = bl.FitDistanceNannys(((Mother)this.comboBox.SelectedItem));//.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
                if (nannylist.Count() > 0)
                {
                    NannyDataGrid1.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetNanny(nannylist[0].NannyId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (nannylist.Count() > 1)
                {
                    NannyDataGrid2.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[1].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetNanny(nannylist[1].NannyId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (nannylist.Count() > 2)
                {
                    NannyDataGrid3.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[2].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetNanny(nannylist[2].NannyId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (nannylist.Count() > 3)
                {
                    NannyDataGrid4.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[3].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetNanny(nannylist[3].NannyId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (nannylist.Count() > 4)
                {
                    NannyDataGrid5.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannylist[4].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetNanny(nannylist[4].NannyId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
            }
            else
            {
                MessageBox.Show("no result", " message to user ");


            }












            //public FitDistanceNannysWindow()
            //{
            //    InitializeComponent();
            //}

            //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            //{

            //}

            //private void Button_Click(object sender, RoutedEventArgs e)
            //{

            //}
        }
    }
}
