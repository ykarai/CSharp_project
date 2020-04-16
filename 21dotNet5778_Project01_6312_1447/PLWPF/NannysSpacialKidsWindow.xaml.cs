using BE;
using BL;
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
    /// Interaction logic for NannysSpacialKidsWindow.xaml
    /// </summary>
    public partial class NannysSpacialKidsWindow : Window
    {
        //public NannysSpacialKidsWindow()
        //{
        //    InitializeComponent();
        //}



        //Mother contract;
        //Mother MotherTarget;
        IBL bl; //= new BL.FactoryIBL();
                // =new BL.FactoryIBL();
                //  BL.FactoryIBL();
        public NannysSpacialKidsWindow()
        {
            InitializeComponent();
            //contract = new Mother();
            // MotherTarget = null;
            //grid1.DataContext = contract;
            //  this.comboBox.DataContext = contract;
            //  this.MotherDataGrid.DataContext = contract;
            bl = FactoryIBL.getIBL();

            //            this.comboBox.ItemsSource = bl.GetMotherIEnumerable();
            //           this.comboBox.DisplayMemberPath = "MotherId";
            //          this.comboBox.SelectedValuePath = "MotherId";

        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //child = sender as Child;
            //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
            //new AddChildWindow(childTarget).ShowDialog();
            // string str = "Are you sure you want to Remove?\n" + "Mother from data:\n";

            // if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            //  {
            //      bl.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
            //      this.Close();
            //  }
            List<Nanny> Nannylist = new List<Nanny>();
            Nannylist = bl.NannysSpacialKids();//.FitHoursNannys(((Mother)this.comboBox.SelectedItem));//.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
            if (Nannylist.Count() > 0)
            {
                NannyDataGrid1.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == Nannylist[0].NannyId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                string str = (bl.GetNanny(Nannylist[0].NannyId)).ImageSource;
                if ((File.Exists(str) == false))
                {
                    BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    //this.image.Source = b;
                }
            }
            if (Nannylist.Count() > 1)
            {
                NannyDataGrid2.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == Nannylist[1].NannyId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                string str = (bl.GetNanny(Nannylist[1].NannyId)).ImageSource;
                if ((File.Exists(str) == false))
                {
                    BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    //this.image.Source = b;
                }
            }
            if (Nannylist.Count() > 2)
            {
                NannyDataGrid3.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == Nannylist[2].NannyId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                string str = (bl.GetNanny(Nannylist[2].NannyId)).ImageSource;
                if ((File.Exists(str) == false))
                {
                    BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    //this.image.Source = b;
                }
            }
            if (Nannylist.Count() > 3)
            {
                NannyDataGrid4.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == Nannylist[3].NannyId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                string str = (bl.GetNanny(Nannylist[3].NannyId)).ImageSource;
                if ((File.Exists(str) == false))
                {
                    BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    //this.image.Source = b;
                }
            }
            if (Nannylist.Count() > 4)
            {
                NannyDataGrid5.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == Nannylist[4].NannyId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                string str = (bl.GetNanny(Nannylist[4].NannyId)).ImageSource;
                if ((File.Exists(str) == false))
                {
                    BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                    //this.image.Source = b;
                }
            }

        }


        }










        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }

