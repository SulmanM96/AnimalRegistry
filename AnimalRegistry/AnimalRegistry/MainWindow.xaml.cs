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
using Microsoft.Win32;
using System.IO;

namespace AnimalRegistry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string empty = " ";
        AnimalType al;
        public MainWindow()
        {
            InitializeComponent();
            al = new AnimalType();
        }

        private void Imagebutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select an image from your computer";
            ofd.Filter = "all supported images |*jpeg;*.jpg;*.png";
            if (ofd.ShowDialog() == true)
            {
                imagecanvas.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            al.Animal = animalText.Text;
            al.Kingdom = Kingdom.Text;
            al.Cae = DateTime.Now.Year - caetext.SelectedDate.Value.Year;
            al.Aclass = aclass.Text;
            al.Picpath = imagecanvas.Source.ToString();
            al.Population = popbox.Text;
            if (Carni.IsChecked == true)
            {
                al.Fty[0] = "Carnivore";
            }
            if (Omni.IsChecked == true)
            {

                al.Fty[1] = "Omnivore";
            }
            if (Herbi.IsChecked == true)
            {
                al.Fty[2] = "Herbivore";

            }
            if (danger.IsChecked == true)
            {
                al.Cs = "Endangered";
            }
            if (vul.IsChecked == true)
            {
                al.Cs = "Near Extinction";
            }
            if (Near.IsChecked == true)
            {
                al.Cs = "Vulnerable";
            }
            if (least.IsChecked == true)
            {
                al.Cs = "Least Concern";
            }



            checkAlert();
            al.saveData();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string[] sr = File.ReadAllLines("AnimalData.csv");
            string[] str = sr[0].Split(',');
            animalText.Text = str[0];
            Kingdom.Text = str[1];
            caetext.Text = str[2];
            aclass.Text = str[3];
            popbox.Text = str[4];


            {

            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void Phonebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void Popbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AnimalText_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        public void checkAlert()
        {
            //MessageBoxResult mbr = MessageBox.Show("please enter your animal");
            //string animal = mbr.ToString();



            //    if (animalText == empty)
            //    {
            //        MessageBoxResult mbe = MessageBox.Show("please enter your username");
            //        string animal = mbe.ToString();
            //    }
            //     else if (Kingdom == empty)
            //    {
            //        MessageBoxResult mbk = MessageBox.Show
            //        ("please enter the animals population");
            //        string Kingdom = mbk.ToString();
            //    }
            //    else if (aclass == empty) 
            //    {
            //        MessageBoxResult mbc = MessageBox.Show
            //          ("please enter the animals class");
            //        string Aclass = mbc.ToString();
            //    }
            //    else (empty == != empty);
            //    {
            //        MessageBoxResult mbs = MessageBox.Show("you've registered Successfully!");
            //        string animal = mbs.ToString();
            //    }
            //}
        }
    }
}

