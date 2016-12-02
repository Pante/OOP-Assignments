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

namespace Week5Q4 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        int number;

        public MainWindow() {
            InitializeComponent();

            Random rnd = new Random();
            number = rnd.Next(1, 101);
        }

        private int onUpdate() {
            if(textBox.Text == "" || textBox.Text == "-")
                return 0;

            if(Int32.Parse(textBox.Text) == -1) {
                Application.Current.Shutdown();
            } else if(Int32.Parse(textBox.Text) > number) {
                label.Content = "Your guess is too high!";
            } else if(Int32.Parse(textBox.Text) < number) {
                label.Content = "Your guess is too low!";
            } else {
                label.Content = "Bingo, the correct answer is " + number;
            }
            return 1;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            onUpdate();
        }
    }
}
