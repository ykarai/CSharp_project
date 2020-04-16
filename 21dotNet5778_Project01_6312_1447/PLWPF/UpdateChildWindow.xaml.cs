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
    /// Interaction logic for UpdateChildWindow.xaml
    /// </summary>
    public partial class UpdateChildWindow : Window
    {
        Child child;
        Child childTarget;
        IBL bl;
        public UpdateChildWindow()
        {
            InitializeComponent();
             child = new Child();
            // childTarget = null;
            grid1.DataContext = child;
            this.comboBox.DataContext = child;
            this.ChildDataGrid.DataContext = child;
            bl = FactoryIBL.getIBL();
            
            this.comboBox.ItemsSource = bl.GetChildIEnumerable();
            //    this.comboBox.DisplayMemberPath = "ChildFirstName";
            this.comboBox.DisplayMemberPath = "ChildId";
            this.comboBox.SelectedValuePath = "ChildId";

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox && ((ComboBox)sender).SelectedIndex > -1)
                this.refreshDataGrid(GetSelectedChildId());
        }
        private int GetSelectedChildId()
        {
            object result = this.comboBox.SelectedValue;
            if (result == null)
                throw new Exception("must select Child First");
            return (int)result;
        }
        private void refreshDataGrid(int childId)
        {
            ChildDataGrid.ItemsSource = bl.GetChildIEnumerable(s => s.ChildId == childId);
            string str = (bl.GetChild(childId)).ImageSource;
            if ((File.Exists(str) == false))
            {
                BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                this.image.Source = b;
            }
               
        
            
            //this.ChildDataGrid.DataContext = child;
        }

        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    this.ChildDataGrid.DataContext = child;
        //    bl.UpdateChild(child);

        //    //if (sender is DataGrid)
        //    //{
        //    //   ( (DataGrid)sender).Se
        //    //}

        //    //    this.refreshDataGrid(GetSelectedChildId());
        //    //bl.UpdateChild()
        //}

        private void ChangeDetails_button(object sender, RoutedEventArgs e)
        {
            //int childId = GetSelectedChildId();
            //child = bl.GetChild(childId);
            //childTarget = (this.child).DeepClone();
            //new AddChildWindow(childTarget).ShowDialog();    
            if (this.comboBox.SelectedItem is Child)
            {
                this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                new AddChildWindow(childTarget).ShowDialog();
                this.refreshDataGrid(GetSelectedChildId());
                this.refreshCoBobox(GetSelectedChildId());
            }
        }

        public void refreshCoBobox(int childId)
        {
            comboBox.ItemsSource = bl.GetChildIEnumerable(s => s.childId == childId);
            comboBox.ItemsSource = bl.GetChildIEnumerable();

        }

    }

}
