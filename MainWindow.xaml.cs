/*
 * Peter McEwen
 * March 02, 2018
 * Careers project
 * displays info about Western university
 */
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

namespace U1CareersPeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            lblInfo.Content = "Western - Engineering (Software Engineering" + "\n" + "EE" + "\n" +
                "580 registrants in engineering, 35 000 students, 306 000 alumni" + "\n" + 
                "An average in the high 80’s is required, fairly competitive"+ "\n" + 
                "London, Ontario - 366 000 people live there, 11th largest city in Canada" + "\n" +
                "Total Tuition->$14,600.58" + "\n" + 
                "Traditional room-> single room: $7,890, double room: $7,090";
            BitmapImage A = new BitmapImage(new Uri("https://www.edu.uwo.ca/CSW/images/Western_University_Map_Frame.jpg"));
            imgInfo.Source = A;
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            lblInfo.Content = "English, ENG4U - Advanced Functions, MHF4U - Calculus and Vectors, MCV4U - " + "\n" +
                "Chemistry, SCH4U - Physics, SPH4U"
                + "\n" + "NA" 
                + "\n" + "High 80’s";
            BitmapImage B = new BitmapImage(new Uri("http://storage.lfpress.com/v1/dynamic_resize/sws_path/suns-prod-images/1297634394439_ORIGINAL.jpg?quality=80&size=650x&stmp=1416935593432"));
            imgInfo.Source = B;

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            lblInfo.Content = "Full year courses: Applied Mathematics for engineers, Introductory engineering design " + "\n" + 
                "and innovative studio, Business for engineers, Engineering statistics."
                + "\n" + "4 years, 28 mandatory courses, 1 non-technical elective and one technical elective.";
            BitmapImage C = new BitmapImage(new Uri("https://ir.lib.uwo.ca/assets/md5images/04669f5fa20678f5bc0ae0fc99655d98.png"));
            imgInfo.Source = C;
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            lblInfo.Content = "Junior software developer for FDM group - writing, developing, testing, " 
               + "\n" + "and reviewing code, supporting existing applications, liaising with end  "
               + "\n" + "to fix defects, find solutions, and test them."
               + "\n" + "Web developer for London Public Library - develop, implement and support "
               + "\n" + "London Public Library’s corporate website, intranet, and digital " + "\n" + 
               "communications and media initiatives.";
            BitmapImage D = new BitmapImage(new Uri("https://ajonit-reviewofweb.netdna-ssl.com/wp-content/uploads/2014/08/wordpress-1600x800.jpg"));
            imgInfo.Source = D;
        }
    }
}
