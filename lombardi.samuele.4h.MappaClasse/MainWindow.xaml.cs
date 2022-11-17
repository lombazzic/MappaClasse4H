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

namespace lombardi.samuele._4h.MappaClasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }




        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Pompa");
            btn1.Content = "Pompa";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Salvi");
            btn2.Content = "Salvi";
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Lombardi");
            btn3.Content = "Lombardi";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Cau");
            btn4.Content = "Cau";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Capanna");
            btn5.Content = "Capanna";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Islamowski");
            btn6.Content = "Islamowski";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Zhang");
            btn7.Content = "Zhang";

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Morelli");
            btn8.Content = "Morelli";

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Casadei");
            btn9.Content = "Casadei";
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Ghinelli");
            btn10.Content = "Ghinelli";
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Capicchioni");
            btn11.Content = "Capicchioni";
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Burioli");
            btn12.Content = "Burioli";
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Basilico");
            btn13.Content = "Basilico";
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Cancellieri-Tumidei");
            btn14.Content = "Cancellieri-Tumidei";

        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Rossini");
            btn15.Content = "Rossini";

        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Ricci");
            btn16.Content = "Ricci";
        }

        private void btn17_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Dyrmishi");
            btn17.Content = "Dyrmishi";
        }

        private void btn18_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Chietti-Dervishi");
            btn18.Content = "Chietti-Dervishi";
        }
        private void btn19_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("qui c'è: Conti-Sartini");
            btn19.Content = "Conti-Sartini";
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show("ciao" + b.Tag);
        }
    }
}
