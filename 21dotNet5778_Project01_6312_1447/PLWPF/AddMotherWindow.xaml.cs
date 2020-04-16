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
    /// Interaction logic for AddNannyTargetWindow.xaml
    /// </summary>
    public partial class AddMotherWindow : Window
    {
        

            Mother mother;
            IBL bl;
            bool UpdateFlag = false;
            private List<string> errorMessages;
            //private Type value;
            //private Type targetType;
            //private CultureInfo parameter;
            //private  System.Globalization. culture; culture;

            public AddMotherWindow(Mother con = null)
            {
                InitializeComponent();
                if (con == null)
                    mother = new Mother();
                else
                {
                    this.Title = "Update mother";
                    mother = con;
                    UpdateFlag = true;
                    AddMotherbutton.Content = "Update mother details";
                    motherIdTextBox.IsReadOnly = true;
                    motherAddressTextBox.Text = mother.MotherAddress;
                    motherAroundAddressTextBox.Text = mother.MotherAroundAddress;

                this.UserControOfTheWeek.daysOfWork1 = mother.MotherDaysOfWork.DeepClone();
                this.UserControOfTheWeek.tableOfWork1 = mother.MotherTableOfWork.DeepClone();
                this.UserControOfTheWeek.Refreash(this.UserControOfTheWeek, new RoutedEventArgs());


            }
                this.grid0.DataContext = mother;
                bl = FactoryIBL.getIBL();
                //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //this.shyComboBox.ItemsSource = a;
                //this.calmComboBox.ItemsSource = a;
                //this.friendlyComboBox.ItemsSource = a;
                errorMessages = new List<string>();

            }





            private void AddMotherbutton_Click_1(object sender, RoutedEventArgs e)
            {

            this.mother.MotherDaysOfWork = UserControOfTheWeek.daysOfWork1.DeepClone();
            this.mother.MotherTableOfWork = UserControOfTheWeek.tableOfWork1.DeepClone();
            this.mother.MotherAddress = motherAddressTextBox.Text;
            this.mother.MotherAroundAddress = motherAroundAddressTextBox.Text;

            try
                {
                    //  mother.MotherId = int.Parse(this.motherIdTextBox.Text);
                    this.grid1.DataContext = mother;
                    string str = "Are you sure you want to add?\n" + "mother with this details:\n";
                    if (UpdateFlag)
                        str = "Are you sure you Update?\n" + "mother with this details:\n";
                    if (MessageBox.Show(str
                                  + mother.ToString(), " message to user ", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        if (this.UpdateFlag)
                        {
                            bl.UpdateMother(mother);
                        }
                        else
                        {
                            bl.AddMother(mother);
                        }
                    }

                    //  grid1.DataContext = bl.GetMotherIEnumerable();
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
                    this.AddMotherbutton.IsEnabled = false;
                }
                else
                {
                    //               errorMessages.Remove(l.Error.Exception.Message);
                    this.AddMotherbutton.IsEnabled = true;
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

                this.AddMotherbutton.IsEnabled = !errorMessages.Any();

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
                    this.MotherImage.Source = new BitmapImage(new Uri(f.FileName));

                }
            }

        private void motherAddressTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
