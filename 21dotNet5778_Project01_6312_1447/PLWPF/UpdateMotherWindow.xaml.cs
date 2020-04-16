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
    /// Interaction logic for UpdateMotherWindow.xaml
    /// </summary>
    public partial class UpdateMotherWindow : Window
    {
        Mother mother;
        Mother motherTarget;
        IBL bl;
        public UpdateMotherWindow()
        {
            InitializeComponent();
            mother = new Mother();
            // motherTarget = null;
            grid1.DataContext = mother;
            this.comboBox.DataContext = mother;
            this.MotherDataGrid.DataContext = mother;
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
        private void refreshDataGrid(int motherId)
        {
            MotherDataGrid.ItemsSource = bl.GetMotherIEnumerable(s => s.MotherId == motherId);
            string str = (bl.GetMother(motherId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                this.image.Source = b;
            }



            //this.MotherDataGrid.DataContext = mother;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.MotherDataGrid.DataContext = mother;
        //    bl.UpdateMother(mother);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedMotherId());
        //    //bl.UpdateMother()
        //}

        private void ChangeDetails_button(object sender, RoutedEventArgs e)
        {
            //int motherId = GetSelectedMotherId();
            //mother = bl.GetMother(motherId);
            //motherTarget = (this.mother).DeepClone();
            //new AddMotherWindow(motherTarget).ShowDialog();    
            if (this.comboBox.SelectedItem is Mother)
            {
                this.motherTarget = ((Mother)this.comboBox.SelectedItem).DeepClone();
                new AddMotherWindow(motherTarget).ShowDialog();
                this.refreshDataGrid(GetSelectedMotherId());
                this.refreshCoBobox(GetSelectedMotherId());
            }
        }

        public void refreshCoBobox(int motherId)
        {
            comboBox.ItemsSource = bl.GetMotherIEnumerable(s => s.MotherId == motherId);
            comboBox.ItemsSource = bl.GetMotherIEnumerable();

        }

    }

}
