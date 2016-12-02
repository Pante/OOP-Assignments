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

namespace Week5Q2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private int onUpdate() {

            if(textBox.Text == "")
                return 0;

            int count = 1;

            for(int i = 1; i <= Int32.Parse(textBox.Text); i++)
                count *= i;

            label.Content = count;
            return count;
        }

        private double calBMI(double weight, double height) {
            return Math.Round((weight / (height * height)), 2);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            onUpdate();
        }
    }
}
