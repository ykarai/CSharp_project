using BE;
using BL;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for RemoveChildWindow.xaml
    /// </summary>
    public partial class RemoveChildWindow : Window
    {
        
            Child child;
 //         Child childTarget;
            IBL bl;
             public RemoveChildWindow()
            { 
            InitializeComponent();
            child = new Child();
            // childTarget = null;
            this.comboBox.DataContext = child;
            this.ChildDataGrid.DataContext = child;
            bl = FactoryIBL.getIBL();

            this.comboBox.ItemsSource = bl.GetChildIEnumerable();
            this.comboBox.DisplayMemberPath = "ChildId";
            this.comboBox.SelectedValuePath = "ChildId";
            InitializeComponent();
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
            BitmapImage b = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
            this.image.Source = b;
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

        private void RemoveChild_button(object sender, RoutedEventArgs e)
        {
            //int childId = GetSelectedChildId();
            //child = bl.GetChild(childId);
            //childTarget = (this.child).DeepClone();
            //new AddChildWindow(childTarget).ShowDialog();    
            if (this.comboBox.SelectedItem is Child)
            {
                //child = sender as Child;
                //this.childTarget = ((Child)this.comboBox.SelectedItem).DeepClone();
                //new AddChildWindow(childTarget).ShowDialog();
                string str = "Are you sure you want to Remove?\n" + "child from data:\n";

                if (MessageBox.Show(str, " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    bl.RemoveChild(((Child)this.comboBox.SelectedItem).ChildId);
                    this.Close();
                }         
                //new RemoveChildWindow().Show();       
            }
        }




    }
}
