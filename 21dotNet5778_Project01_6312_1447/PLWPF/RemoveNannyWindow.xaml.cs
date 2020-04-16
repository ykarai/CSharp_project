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
    /// Interaction logic for RemoveNannyWindow.xaml
    /// </summary>
    public partial class RemoveNannyWindow : Window
    {
        Nanny contract;
        Nanny NannyTarget;
        IBL bl;
        public RemoveNannyWindow()
        {
            InitializeComponent();
            contract = new Nanny();
            // NannyTarget = null;
            grid1.DataContext = contract;
            this.comboBox.DataContext = contract;
            this.NannyDataGrid.DataContext = contract;
            bl = FactoryIBL.getIBL();

            this.comboBox.ItemsSource = bl.GetNannyIEnumerable();
            this.comboBox.DisplayMemberPath = "NannyId";
            this.comboBox.SelectedValuePath = "NannyId";

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox && ((ComboBox)sender).SelectedIndex > -1)
                this.refreshDataGrid(GetSelectedNannyId());
        }
        private int GetSelectedNannyId()
        {
            object result = this.comboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select Nanny First");
            return (int)result;
        }
        private void refreshDataGrid(int contractId)
        {
            NannyDataGrid.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == contractId);
            string str = (bl.GetNanny(contractId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                this.image.Source = b;
            }



            //this.NannyDataGrid.DataContext = contract;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.NannyDataGrid.DataContext = contract;
        //    bl.UpdateNanny(contract);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedNannyId());
        //    //bl.UpdateNanny()
        //}

        private void RemoveNanny_button(object sender, RoutedEventArgs e)
        {
            if (this.comboBox.SelectedItem is Nanny)
            {
                //child = sender as Child;
                //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                //new AddChildWindow(childTarget).ShowDialog();
                string str = "Are you sure you want to Remove?\n" + "Nanny from data:\n";

                if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    bl.RemoveNanny(((Nanny)this.comboBox.SelectedItem).NannyId);
                    this.Close();
                }
                //new RemoveChildWindow().Show();       
            }
        }

    }

}
