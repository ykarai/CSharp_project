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
    /// Interaction logic for AddNannyWindow.xaml
    /// </summary>
    public partial class AddNannyWindow : Window
    {
        
            Nanny nanny;
            IBL bl;
            bool UpdateFlag = false;
            private List<string> errorMessages;
            //private Type value;
            //private Type targetType;
            //private CultureInfo parameter;
            //private  System.Globalization. culture; culture;

            public AddNannyWindow(Nanny con = null)
            {
         
            InitializeComponent();
                if (con == null)
                    nanny = new Nanny();

                else
                {
                    this.Title = "Update nanny";
                    nanny = con;
                    UpdateFlag = true;
                    AddNannybutton.Content = "Update nanny details";
                   //nannyIdTextBox.IsReadOnly = true;
                    nannyAddressTextBox.Text = nanny.NannyAddress;
                    //this.UserControOfTheWeek.daysOfWork1[0] = true;

                   this.UserControOfTheWeek.daysOfWork1 =nanny.NannyDaysOfWork.DeepClone();
                   this.UserControOfTheWeek.tableOfWork1 = nanny.NannyTableOfWork.DeepClone();
                   this.UserControOfTheWeek.Refreash(this.UserControOfTheWeek, new RoutedEventArgs()) ;
            }
                this.grid0.DataContext = nanny;
                bl = FactoryIBL.getIBL();
                int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
             
            this.nannyFloorTextBox.ItemsSource = a;
            this.nannyMaxKidslimitTextBox.ItemsSource = a;
            this.nannyYearsExperienceTextBox.ItemsSource = a;
            this.niceTextBox.ItemsSource = a;

           // this.UserControOfTheWeek.DaysOfWork1[0] = true;


            errorMessages = new List<string>();
            // nanny.NannyDaysOfWork = new bool[6] {true, false, false, false, false, false };
            //bool[] DaysOfWork1 = new bool[6] { true, false, false, false, false, false };

            //this.UserControOfTheWeek.daysOfWork1 =DaysOfWork1.DeepClone();
            //this.UserControOfTheWeek.TableOfWork1 = nanny.NannyTableOfWork.DeepClone();

            //  UserControOfTheWeek week = new UserControOfTheWeek(nanny.NannyDaysOfWork );
            // UserControOfTheWeek = week;


        }





        private void AddNannybutton_Click_1(object sender, RoutedEventArgs e)
        {

            this.nanny.NannyDaysOfWork = UserControOfTheWeek.daysOfWork1.DeepClone();
            this.nanny.NannyTableOfWork = UserControOfTheWeek.tableOfWork1.DeepClone();
            this.nanny.NannyAddress = nannyAddressTextBox.Text;

            try
            {
                //  nanny.NannyId = int.Parse(this.nannyIdTextBox.Text);
                this.grid1.DataContext = nanny;
                string str = "Are you sure you want to add?\n" + "nanny with this details:\n";
                if (UpdateFlag)
                    str = "Are you sure you Update?\n" + "nanny with this details:\n";
                if (MessageBox.Show(str
                              + nanny.ToString(), " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    if (this.UpdateFlag)
                    {
                        bl.UpdateNanny(nanny);
                    }
                    else
                    {
                        bl.AddNanny(nanny);
                    }
                }

                //  grid1.DataContext = bl.GetNannyIEnumerable();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, " message to user ", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            //UserControOfTheWeek.DaysOfWork1 = null;
            //UserControOfTheWeek.TableOfWork1 = null;

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
                    this.AddNannybutton.IsEnabled = false;
                }
                else
                {
                    //               errorMessages.Remove(l.Error.Exception.Message);
                    this.AddNannybutton.IsEnabled = true;
                    a.IsReadOnlyCaretVisible = false;
                }

            }

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

                this.AddNannybutton.IsEnabled = !errorMessages.Any();

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


            private void ImageMouseClick_Bottun(object sender, MouseButtonEventArgs e)
            {
                Microsoft.Win32.OpenFileDialog f = new Microsoft.Win32.OpenFileDialog();
                f.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (f.ShowDialog() == true)
                {
                    this.NannyImage.Source = new BitmapImage(new Uri(f.FileName));

                }
            }

        private void ForUserC(object sender, RoutedEventArgs e)
        {

            ////nanny.NannyDaysOfWork = new bool[6] { true, false, false, false, false, false };
            ////bool[] DaysOfWork1 = new bool[6] { true, false, false, false, false, false };
            //  this.nanny.NannyDaysOfWork[0] = true;
            //this.nanny.NannyTableOfWork[0,0] = 6;
            //this.UserControOfTheWeek.DaysOfWork1[0] = true;// nanny.NannyDaysOfWork.DeepClone();
            //this.UserControOfTheWeek.tableOfWork1 = nanny.NannyTableOfWork.DeepClone();

        }
    }
}
