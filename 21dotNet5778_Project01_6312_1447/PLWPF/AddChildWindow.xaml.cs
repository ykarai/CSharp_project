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
using System.Globalization;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AddChildWindow.xaml
    /// </summary>
    public partial class AddChildWindow : Window
    {
        Child child;
        IBL bl;
        bool UpdateFlag = false;
        private List<string> errorMessages;
        //private Type value;
        //private Type targetType;
        //private CultureInfo parameter;
        //private  System.Globalization. culture; culture;

        public AddChildWindow(Child chi=null)
        {       
            InitializeComponent();
            if (chi == null)
                child = new Child();
            else
            {
                this.Title = "Update child";
                child = chi;
                UpdateFlag = true;
                AddChildbutton.Content = "Update child details";
                childIdTextBox.IsReadOnly = true;
                motherIdTextBox.IsReadOnly = true;
            }
            this.grid0.DataContext = child;
            bl = FactoryIBL.getIBL();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            this.shyComboBox.ItemsSource = a;
            this.calmComboBox.ItemsSource = a;
            this.friendlyComboBox.ItemsSource = a;
            errorMessages = new List<string>();
        }



        //private void AddChildbutton_Click(object sender, RoutedEventArgs e)
        //{
        //    //  child.ChildId = int.Parse(this.childIdTextBox.Text);
        //    this.grid1.DataContext = child;
        //    bl.AddChild(child);


        //}
        private void AddChildbutton_Click(object sender, RoutedEventArgs e)
        {
           
           
            try
            {
                //  child.ChildId = int.Parse(this.childIdTextBox.Text);
                this.grid1.DataContext = child;
                string str = "Are you sure you want to add?\n" + "child with this details:\n";
                if(UpdateFlag)
                     str = "Are you sure you Update?\n" + "child with this details:\n";
                if (MessageBox.Show(str
                              + child.ToString(), " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    if (this.UpdateFlag)
                    {
                        bl.UpdateChild(child);
                    }
                    else
                    {
                        bl.AddChild(child);
                    }
                }

                //  grid1.DataContext = bl.GetChildIEnumerable();
                    this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, " message to user ", MessageBoxButton.OK, MessageBoxImage.Information);

            }


        }
        private void a(object sender, MouseEventArgs e)
        {
          
            this.ToolTip = ("1 The smallest :(\n" + "10 the most     :) ");
        }

        private void ChecksforDigits(object sender, RoutedEventArgs e)
        {
            //ValidationErrorEventArgs q;
            ValidationErrorEventArgs l = e as ValidationErrorEventArgs;
            TextBox a = sender as TextBox;
            if ((HasNumber.hasNumber(a.Text.ToString())))
            {
                ////e.Handled = false;
                //// e Name can't contain digit";
                //l = null;
                //validation_Error(a, l);
                //              errorMessages.Add(l.Error.Exception.Message);
                a.IsReadOnlyCaretVisible = true;
                this.AddChildbutton.IsEnabled = false;
            }
            else
            {
                //               errorMessages.Remove(l.Error.Exception.Message);
                this.AddChildbutton.IsEnabled = true;
                a.IsReadOnlyCaretVisible = false;
            }

        }
        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{


        //    if (errorMessages.Any()) //errorMessages.Count > 0 
        //    {
        //        string err = "Exception:";
        //        foreach (var item in errorMessages)
        //            err += "\n" + item;

        //        MessageBox.Show(err);
        //        return;
        //    }

        //}
        private void validation_Error(object sender, ValidationErrorEventArgs e)
       {
            //if ((sender is TextBox))
            //{
            //if ((sender is TextBox))
            TextBox a = sender as TextBox;
                if (e.Action == ValidationErrorEventAction.Added)
                {
                    errorMessages.Add(e.Error.Exception.Message);
                    a.IsReadOnlyCaretVisible = true;

                    //}
                    //if (IndicationImage.Visibility == Visibility.Hidden)
                    //{
                    //    IndicationImage.Visibility = Visibility.Visible;
                    //}

                }
                else
                {
                    errorMessages.Remove(e.Error.Exception.Message);
                    a.IsReadOnlyCaretVisible = false;
                    //this.IndicationImage.Source = new BitmapImage(new Uri(@"images\start\vv.png", UriKind.RelativeOrAbsolute));
                    //this.IndicationImage.Source = ImageConverter.Convert( value,  targetType,  parameter,  culture);
                    //if (IndicationImage2.Visibility == Visibility.Hidden)
                    //{
                    //    IndicationImage.Visibility = Visibility.Hidden;
                    //    IndicationImage2.Visibility = Visibility.Visible;
                    //}
                    
                    
                }

                this.AddChildbutton.IsEnabled = !errorMessages.Any();

                // image.Source = (@"images/start/empty.png");
                //this.IndicationImage.Source = new BitmapImage(new Uri(@"images\start\x.png", UriKind.RelativeOrAbsolute));
                //if (errorMessages.Any()) //errorMessages.Count > 0 
                //{
                //    string err = "Exception:";
                //    foreach (var item in errorMessages)
                //        err += "\n" + item;

                //    MessageBox.Show(err);
                //    return;
                //}
                //   image.IsEnabled = true;
                // this.addButton.IsEnabled = !errorMessages.Any();
            //}
        }

        //this.image.Source = new BitmapImage(new Uri(@"images\x.png"));

        //private void changeImageButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Microsoft.Win32.OpenFileDialog f = new Microsoft.Win32.OpenFileDialog();
        //    f.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
        //    if (f.ShowDialog() == true)
        //    {
        //        this.studentImage.Source = new BitmapImage(new Uri(f.FileName));

        //    }
        //}
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //    System.Windows.Data.CollectionViewSource childViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("childViewSource")));
        //    // Load data by setting the CollectionViewSource.Source property:
        //    // childViewSource.Source = [generic data source]
        //    //System.Windows.Data.CollectionViewSource childViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("childViewSource")));
        //    // Load data by setting the CollectionViewSource.Source property:
        //    // childViewSource.Source = [generic data source]
        //}

        //private void ImageMouseEnter_Bottun(object sender, MouseEventArgs e)
        //{
        //    Microsoft.Win32.OpenFileDialog f = new Microsoft.Win32.OpenFileDialog();
        //    f.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
        //    if (f.ShowDialog() == true)
        //    {
        //        this.image1.Source = new BitmapImage(new Uri(f.FileName));

        //    }
        //}

        //private void aaaa(object sender, DragEventArgs e)
        //{

        //}

        

        private void ImageMouseClick_Bottun(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog f = new Microsoft.Win32.OpenFileDialog();
            f.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (f.ShowDialog() == true)
            {
                this.ChildImage.Source = new BitmapImage(new Uri(f.FileName));

            }
        }

       








        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
