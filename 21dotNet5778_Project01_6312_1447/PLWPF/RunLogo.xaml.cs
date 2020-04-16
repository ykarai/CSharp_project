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



using System.ComponentModel;
//using System.Windows.Forms;
using System.Drawing;
using System.Security.Principal;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class RunLogo : Window
    {
        public System.Windows.Threading.DispatcherTimer dispatcherTimer;
        int timer = 0;
        public RunLogo()
        {
            //InitializeComponent();

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer(); 
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 3);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimerEnd);
            dispatcherTimer.Start();
            InitializeComponent();

        }
        private void dispatcherTimerEnd(object sender, EventArgs e)
        {
            this.Close();

        }

        //public int timer = 0;
        //public SignIn()

        //{
        //    InitializeComponent();
        //    Height = Screen.PrimaryScreen.Bounds.Height - 5;
        //    Width = Screen.PrimaryScreen.Bounds.Width - 5;
        //    //this.Closing += OnWindowClosing;
        //}



    }
}
