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
    /// Interaction logic for RemoveContractWindow.xaml
    /// </summary>
    public partial class RemoveContractWindow : Window
    {
        Contract contract;
        Contract contractTarget;
        IBL bl;
        public RemoveContractWindow()
        {
            InitializeComponent();
            contract = new Contract();
            // contractTarget = null;
            grid1.DataContext = contract;
            this.comboBox.DataContext = contract;
            this.ContractDataGrid.DataContext = contract;
            bl = FactoryIBL.getIBL();

            this.comboBox.ItemsSource = bl.GetContractIEnumerable();
            this.comboBox.DisplayMemberPath = "ContractId";
            this.comboBox.SelectedValuePath = "ContractId";

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox && ((ComboBox)sender).SelectedIndex > -1)
                this.refreshDataGrid(GetSelectedContractId());
        }
        private int GetSelectedContractId()
        {
            object result = this.comboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select Contract First");
            return (int)result;
        }
        private void refreshDataGrid(int contractId)
        {
            ContractDataGrid.ItemsSource = bl.GetContractIEnumerable(s => s.ContractId == contractId);
            string str = (bl.GetContract(contractId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                this.image.Source = b;
            }



            //this.ContractDataGrid.DataContext = contract;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.ContractDataGrid.DataContext = contract;
        //    bl.UpdateContract(contract);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedContractId());
        //    //bl.UpdateContract()
        //}

        private void RemoveContract_button(object sender, RoutedEventArgs e)
        {
            if (this.comboBox.SelectedItem is Contract)
            {
                //child = sender as Child;
                //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                //new AddChildWindow(childTarget).ShowDialog();
                string str = "Are you sure you want to Remove?\n" + "Contract from data:\n";

                if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    bl.RemoveContract(((Contract)this.comboBox.SelectedItem).ContractId);
                    this.Close();
                }
                //new RemoveChildWindow().Show();       
            }
        }

    }

}
