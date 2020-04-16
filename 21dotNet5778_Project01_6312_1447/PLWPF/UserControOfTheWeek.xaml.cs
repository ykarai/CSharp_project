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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for UserControOfTheWeek.xaml
    /// </summary>
     [Serializable]
    public partial class UserControOfTheWeek : UserControl
    {
        private bool[] DaysOfWork1 = new bool[6];// { false, false, false, false, false, false };
        private int[,] TableOfWork1 = new int[2, 6];//{
              //{ 00, 00 ,00,00,00, 00},
              //{ 00, 00,00,00,00, 00 },
              
        //};
        //public bool[] DaysOfWork1 = new bool[6];
        //public int[,] TableOfWork1 = new int[6, 2];

        public bool[] daysOfWork1
        {
            get { return DaysOfWork1; }
            set { DaysOfWork1 = value; }
        }

        public int[,] tableOfWork1
        {
            get { return TableOfWork1; }
            set { TableOfWork1 = value; }
        }
      
      // public static readonly DependencyProperty TTableOfWork1 = DependencyProperty.Register("daysOfWork1", typeof(bool[]), typeof(UserControOfTheWeek), new PropertyMetadata());

        //public UserControOfTheWeek(bool[] DaysOfWork0=null,  int[,] TableOfWork0=null)
        public UserControOfTheWeek()
        {

           
            InitializeComponent();
            // DaysOfWork1[0] = true;
            // this.grid00.DataContext = DaysOfWork1;
            //for (int i = 0; i < DaysOfWork1.Length; i++)
            //{ DaysOfWork1[i] = false; }

            //for (int i = 0; i < (TableOfWork1.Length) / 6; i++)
            //{
            //    for (int j = 0; j < (TableOfWork1.Length) / 2; j++)
            //    {
            //        TableOfWork1[i, j] = 00;
            //    }
            //}
            //if (DaysOfWork0 != null)
            //{
            //    DaysOfWork1 = DaysOfWork0;
            //}
            //this.grid00.DataContext = DaysOfWork1;

            //if (TableOfWork0 != null)
            //{
            //    grid00.DataContext = TableOfWork0;
            //}

            // this.daysOfWork1[0] = true;

            //TableOfWork1[0, 0] = int.Parse(this.textBoxSundayFrom.Text);
            //TableOfWork1[1, 0] = int.Parse(this.textBoxSundayTo.Text);
            //TableOfWork1[0, 1] = int.Parse(this.textBoxMondayFrom.Text);
            //TableOfWork1[1, 1] = int.Parse(this.textBoxMondayTo.Text);
            //TableOfWork1[0, 2] = int.Parse(this.textBoxTuesdayFrom.Text);
            //TableOfWork1[1, 2] = int.Parse(this.textBoxTuesdayTo.Text);
            //TableOfWork1[0, 3] = int.Parse(this.textBoxWednesdayFrom.Text);
            //TableOfWork1[1, 3] = int.Parse(this.textBoxWednesdayTo.Text);
            //TableOfWork1[0, 4] = int.Parse(this.textBoxTuesdayFrom.Text);
            //TableOfWork1[1, 4] = int.Parse(this.textBoxTuesdayTo.Text);
            //TableOfWork1[0, 5] = int.Parse(this.textBoxFridayFrom.Text);
            //TableOfWork1[1, 5] = int.Parse(this.textBoxFridayTo.Text);
            this.MouseMove += button_Click;
        }

       
       
        public void Refreash(object sender, RoutedEventArgs e)
        {
           // this.daysOfWork1[0] = true;
            int i = 0;
            this.Sunday.IsChecked = DaysOfWork1[i++];
            this.Monday.IsChecked = DaysOfWork1[i++];
            this.Tuesday.IsChecked = DaysOfWork1[i++];
            this.wednesday.IsChecked = DaysOfWork1[i++];
            this.Thursday.IsChecked = DaysOfWork1[i++];
            this.Friday.IsChecked = DaysOfWork1[i++];
            // this.Saturday.IsChecked = DaysOfWork1[i++];

            ///TableOfWork1[0, 0] = 6;
            this.textBoxSundayFrom.Text =   TableOfWork1[0, 0].ToString();
            this.textBoxSundayTo.Text =   TableOfWork1[1, 0].ToString();
            this.textBoxMondayFrom.Text =   TableOfWork1[0, 1].ToString();
            this.textBoxMondayTo.Text =     TableOfWork1[1, 1].ToString();
            this.textBoxTuesdayFrom.Text =  TableOfWork1[0, 2].ToString();
            this.textBoxTuesdayTo.Text =    TableOfWork1[1, 2].ToString();
            this.textBoxWednesdayFrom.Text =TableOfWork1[0, 3].ToString();
            this.textBoxWednesdayTo.Text =  TableOfWork1[1, 3].ToString();
            this.textBoxThursdayFrom.Text = TableOfWork1[0, 4].ToString();
            this.textBoxThursdayTo.Text =   TableOfWork1[1, 4].ToString();
            this.textBoxFridayFrom.Text =   TableOfWork1[0, 5].ToString();
            this.textBoxFridayTo.Text =     TableOfWork1[1, 5].ToString();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            DaysOfWork1[i++] = (bool)Sunday.IsChecked;
            DaysOfWork1[i++] = (bool)Monday.IsChecked;
            DaysOfWork1[i++] = (bool)Tuesday.IsChecked;
            DaysOfWork1[i++] = (bool)wednesday.IsChecked;
            DaysOfWork1[i++] = (bool)Thursday.IsChecked;
            DaysOfWork1[i++] = (bool)Friday.IsChecked;
            // DaysOfWork1[i] = (bool)Saturday.IsChecked;

            TableOfWork1[0, 0] = int.Parse(this.textBoxSundayFrom.Text);
            TableOfWork1[1, 0] = int.Parse(this.textBoxSundayTo.Text);
            TableOfWork1[0, 1] = int.Parse(this.textBoxMondayFrom.Text);
            TableOfWork1[1, 1] = int.Parse(this.textBoxMondayTo.Text);
            TableOfWork1[0, 2] = int.Parse(this.textBoxTuesdayFrom.Text);
            TableOfWork1[1, 2] = int.Parse(this.textBoxTuesdayTo.Text);
            TableOfWork1[0, 3] = int.Parse(this.textBoxWednesdayFrom.Text);
            TableOfWork1[1, 3] = int.Parse(this.textBoxWednesdayTo.Text);
            TableOfWork1[0, 4] = int.Parse(this.textBoxTuesdayFrom.Text);
            TableOfWork1[1, 4] = int.Parse(this.textBoxTuesdayTo.Text);
            TableOfWork1[0, 5] = int.Parse(this.textBoxFridayFrom.Text);
            TableOfWork1[1, 5] = int.Parse(this.textBoxFridayTo.Text);
            //TableOfWork1[0, 6] = int.Parse(this.textBoxSaturdayFrom.Text);
            //TableOfWork1[1, 6] = int.Parse(this.textBoxSaturdayTo.Text);
        }
    } 
    
}
