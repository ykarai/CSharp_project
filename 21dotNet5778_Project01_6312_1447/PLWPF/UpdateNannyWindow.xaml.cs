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
    /// Interaction logic for UpdatenannyWindow.xaml
    /// </summary>
    public partial class UpdateNannyWindow : Window
    {
        Nanny nanny;
        Nanny nannyTarget;
        IBL bl;
        public UpdateNannyWindow()
        {
            InitializeComponent();
            nanny = new Nanny();
            // nannyTarget = null;
            grid1.DataContext = nanny;
            this.comboBox.DataContext = nanny;
            this.NannyDataGrid.DataContext = nanny;
            bl = FactoryIBL.getIBL();

            this.comboBox.ItemsSource = bl.GetNannyIEnumerable();
            this.comboBox.DisplayMemberPath = "NannyId";
            this.comboBox.SelectedValuePath = "NannyId";

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //this.comboBox.ItemsSource = bl.GetNannyIEnumerable();
            //this.comboBox.DataContext = bl.GetNannyIEnumerable();
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
        private void refreshDataGrid(int nannyId)
        {
            NannyDataGrid.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannyId);
            string str = (bl.GetNanny(nannyId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                this.image.Source = b;
            }



            //this.NannyDataGrid.DataContext = nanny;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.NannyDataGrid.DataContext = nanny;
        //    bl.UpdateNanny(nanny);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedNannyId());
        //    //bl.UpdateNanny()
        //}

        private void ChangeDetails_button(object sender, RoutedEventArgs e)
        {
            //int nannyId = GetSelectedNannyId();
            //nanny = bl.GetNanny(nannyId);
            //nannyTarget = (this.nanny).DeepClone();
            //new AddNannyWindow(nannyTarget).ShowDialog(); 

            

            if (this.comboBox.SelectedItem is Nanny)
            {
                this.nannyTarget = ((Nanny)this.comboBox.SelectedItem).DeepClone();
                new AddNannyWindow(nannyTarget).ShowDialog();
                this.refreshDataGrid(GetSelectedNannyId());
                this.refreshCoBobox(GetSelectedNannyId());
               
                //this.comboBox.ItemsSource = bl.GetNannyIEnumerable();
                //this.comboBox.DisplayMemberPath = "NannyId";
                //this.comboBox.SelectedValuePath = "NannyId";
                // this.comboBox.ItemsSource = bl.GetNannyIEnumerable();
            }

          



        }

        public void refreshCoBobox(int nannyId)
        {
            comboBox.ItemsSource = bl.GetNannyIEnumerable(s => s.NannyId == nannyId);
            comboBox.ItemsSource = bl.GetNannyIEnumerable();
           
        }


    }

}
