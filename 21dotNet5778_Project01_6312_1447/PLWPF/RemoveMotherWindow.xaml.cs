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
    /// Interaction logic for RemoveMotherWindow.xaml
    /// </summary>
    public partial class RemoveMotherWindow : Window
    {
        Mother contract;
        Mother MotherTarget;
        IBL bl;
        public RemoveMotherWindow()
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

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
                this.image.Source = b;
            }



            //this.MotherDataGrid.DataContext = contract;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.MotherDataGrid.DataContext = contract;
        //    bl.UpdateMother(contract);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedMotherId());
        //    //bl.UpdateMother()
        //}

        private void RemoveMother_button(object sender, RoutedEventArgs e)
        {
            if (this.comboBox.SelectedItem is Mother)
            {
                //child = sender as Child;
                //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                //new AddChildWindow(childTarget).ShowDialog();
                string str = "Are you sure you want to Remove?\n" + "Mother from data:\n";

                if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    bl.RemoveMother(((Mother)this.comboBox.SelectedItem).MotherId);
                    this.Close();
                }
                //new RemoveChildWindow().Show();       
            }
        }

    }

}
