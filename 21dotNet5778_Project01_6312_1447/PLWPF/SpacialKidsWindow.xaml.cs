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
    /// Interaction logic for SpacialKidsWindow.xaml
    /// </summary>
    public partial class SpacialKidsWindow : Window
    {

        //Mother contract;
        //Mother MotherTarget;
        IBL bl; //= new BL.FactoryIBL();
                // =new BL.FactoryIBL();
                //  BL.FactoryIBL();
        public SpacialKidsWindow()
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

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (sender is ComboBox && ((ComboBox)sender).SelectedIndex > -1)
        //        this.refreshDataGrid(GetSelectedMotherId());
        //}
        //private int GetSelectedMotherId()
        //{
        //    object result = this.comboBox.SelectedValue;
        //    if (result == null)
        //        throw new Exception("must select Mother First");
        //    return (int)result;
        //}
        //private void refreshDataGrid(int contractId)
        //{
        //    MotherDataGrid.ItemsSource = bl.GetMotherIEnumerable(s => s.MotherId == contractId);
        //    string str = (bl.GetMother(contractId)).ImageSource;
        //    if ((File.Exists(str) == false))
        //    {
        //        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
        //        //this.image.Source = b;
        //    }
        //}

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
                List<Child> Childlist = new List<Child>();
                Childlist = bl.SpacialKids();//.FitHoursNannys(((Mother)this.comboBox.SelectedItem));//.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
                if (Childlist.Count() > 0)
                {
                NannyDataGrid1.ItemsSource =  bl.GetChildIEnumerable(s => s.ChildId == Childlist[0].ChildId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetChild(Childlist[0].ChildId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (Childlist.Count() > 1)
                {
                    NannyDataGrid2.ItemsSource = bl.GetChildIEnumerable(s => s.ChildId == Childlist[1].ChildId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetChild(Childlist[1].ChildId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (Childlist.Count() > 2)
                {
                    NannyDataGrid3.ItemsSource = bl.GetChildIEnumerable(s => s.ChildId == Childlist[2].ChildId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetChild(Childlist[2].ChildId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (Childlist.Count() > 3)
                {
                    NannyDataGrid4.ItemsSource = bl.GetChildIEnumerable(s => s.ChildId == Childlist[3].ChildId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetChild(Childlist[3].ChildId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }
                if (Childlist.Count() > 4)
                {
                    NannyDataGrid5.ItemsSource = bl.GetChildIEnumerable(s => s.ChildId == Childlist[4].ChildId);//.GetNannyIEnumerable(s => s..NannyId == nannylist[0].NannyId); //.GetMotherIEnumerable(s => s.MotherId == contractId);
                    string str = (bl.GetChild(Childlist[4].ChildId)).ImageSource;
                    if ((File.Exists(str) == false))
                    {
                        BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                        //this.image.Source = b;
                    }
                }

            
        }




























        //public SpacialKidsWindow()
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
