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

namespace Week5Q1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void onUpdate() {
            if(textBoxHeight.Text != "" && textBoxWeight.Text != "") {
                double height = Math.Round(Double.Parse(textBoxHeight.Text), 2);
                double weight = Math.Round(Double.Parse(textBoxWeight.Text), 2);

                double bmi = calBMI(weight, height);

                labelBMI.Content = bmi;

                if(bmi < 18.5) {
                    labelBMICat.Content = "Underweight";
                } else if(bmi < 25) {
                    labelBMICat.Content = "Normal weight";
                } else if(bmi < 30) {
                    labelBMICat.Content = "Overweight";
                } else {
                    labelBMICat.Content = "Obesity";
                }
            } else {
                labelBMI.Content = 0;
                labelBMICat.Content = "Underweight";
            }
            
        }

        private double calBMI(double weight, double height) {
            return Math.Round((weight / (height * height)), 2);
        }

        private void textBoxHeight_TextChanged(object sender, TextChangedEventArgs e) {
            onUpdate();
        }

        private void textBoxWeight_TextChanged(object sender, TextChangedEventArgs e) {
            onUpdate();
        }
    }
}
