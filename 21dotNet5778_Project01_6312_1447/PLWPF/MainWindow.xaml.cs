using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char t1 = 'n';
        char t2 = 'a';
        char t3 = 'y';
        char t4 = 'f';
        char t5 = 'o';
        char t6 = 'r';
        char t7 = 'u';
        String str1 = "";
        String str2 = "בסד ";
        
        public MainWindow()
        {

            new RunLogo().Show();

            Thread.Sleep(2000);
            InitializeComponent();

            Thread thread = new Thread(A);
            thread.Start();

            this.Closing += MainWindow_Closed;

            textBlock1.Text =str2;
        }

        void ChangeOutput1()
        {
            str1 = ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t2);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t3);
            this.textBlock.Text = str1;
            this.textBlock_Copy.Text = str1;
        }


        void ChangeOutput2()
        {
            str1 = ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t2);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t3);
            str1 += "\n\n\n";
            str1 += ABCasterisks.p(t4);
            str1 += "\n";
            str1 += ABCasterisks.p(t5);
            str1 += "\n";
            str1 += ABCasterisks.p(t6);
            this.textBlock.Text = str1;
            this.textBlock_Copy.Text = str1;
        }

        void ChangeOutput3()
        {
            str1 = ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t2);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t1);
            str1 += "\n";
            str1 += ABCasterisks.p(t3);
            str1 += "\n\n\n";
            str1 += ABCasterisks.p(t4);
            str1 += "\n";
            str1 += ABCasterisks.p(t5);
            str1 += "\n";
            str1 += ABCasterisks.p(t6);
            str1 += "\n\n\n";
            str1 += ABCasterisks.p(t3);
            str1 += "\n";
            str1 += ABCasterisks.p(t5);
            str1 += "\n";
            str1 += ABCasterisks.p(t7);
            str1 += "\n";
            str1 += @" 

    *   *     
    *   *  
    *   *
    *   *


    *   *  ";
            this.textBlock.Text = str1;
            this.textBlock_Copy.Text = str1;
        }
        public void A()
        {
            while (true)
            {
                Action action = () => this.textBlock.Text = " ";
                Action action2 = () => this.textBlock_Copy.Text = " ";
                Dispatcher.BeginInvoke(action);
                Dispatcher.BeginInvoke(action2);
                Thread.Sleep(1000);

                action = ChangeOutput1;
                Dispatcher.BeginInvoke(action);
                Thread.Sleep(1000);

                action = ChangeOutput2;
                Dispatcher.BeginInvoke(action);
                Thread.Sleep(1000);

                action = ChangeOutput3;
                Dispatcher.BeginInvoke(action);
                Thread.Sleep(1000);

            }
        }

        private void AddNanny_Click(object sender, RoutedEventArgs e)
        {
             //new RunLogo().Show();
             new AddNannyWindow().Show();
            //  Window NannyWindow = new NannyWindow();
            //  NannyWindow.Show();
        }
        private void RemoveNanny_Click(object sender, RoutedEventArgs e)
        {
            new RemoveNannyWindow().Show();
        }
        private void UpdateNanny_Click(object sender, RoutedEventArgs e)
        {
            new UpdateNannyWindow().Show();
        }



        private void AddChild_Click(object sender, RoutedEventArgs e)
        {
            new AddChildWindow().Show();
        }
        private void RemoveChild_Click(object sender, RoutedEventArgs e)
        {
            new RemoveChildWindow().Show();
        }
        private void UpdateChild_Click(object sender, RoutedEventArgs e)
        {
            new UpdateChildWindow().Show();
        }




        private void AddMother_Click(object sender, RoutedEventArgs e)
        {
            new AddMotherWindow().Show();
        }
        private void RemoveMother_Click(object sender, RoutedEventArgs e)
        {
            new RemoveMotherWindow().Show();
        }
        private void UpdateMother_Click(object sender, RoutedEventArgs e)
        {
            new UpdateMotherWindow().Show();
        }


        private void AddContract_Click(object sender, RoutedEventArgs e)
        {
            new AddContractWindow().Show();
        }

        private void RemoveContract_Click(object sender, RoutedEventArgs e)
        {
            new RemoveContractWindow().Show();
        }

        private void UpdateContract_Click(object sender, RoutedEventArgs e)
        {
            new UpdateContractWindow().Show();
        }

        //private void Q1_Click(object sender, RoutedEventArgs e)
        //{
        //    //new Q1Window().Show();
        //}

        private void Q2_Click(object sender, RoutedEventArgs e)
        {
            //new Q2NannyWindow().Show();
        }

        private void Q3_Click(object sender, RoutedEventArgs e)
        {
            //new Q3NannyWindow().Show();
        }

        private void FitNannysByTime_Click(object sender, RoutedEventArgs e)
        {
            new FitNannysWindow().Show();
        }

        private void FitDistanceNannys_Click(object sender, RoutedEventArgs e)
        {


            new FitDistanceNannysWindow().Show();
        }

        private void SpacialKids_Click(object sender, RoutedEventArgs e)
        {
            new SpacialKidsWindow().Show();

        }

        private void NannysSpacialKids_Click(object sender, RoutedEventArgs e)
        {

            new NannysSpacialKidsWindow().Show();

        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

      
    }
}
