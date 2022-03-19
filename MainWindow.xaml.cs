using System;
using System.Diagnostics;
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

namespace Calculator
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

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            string[] items = evaluationField.Text.Split(' ');
            EvaluationAlgorithm.evaluate(items);

            // debug stuff
            Trace.WriteLine("Calculator output: ");
            //MessageBox.Show("Height: " + ActualHeight + "Width: " + ActualWidth);
            foreach (string item in items)
            {
                Trace.Write(item);
            }
            // end of debug
        }

        private void addToField(Button button)
        {
            evaluationField.AppendText(Convert.ToString(button.Content));
           //MessageBox.Show("Button clicked: " + button.Content);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            addToField((Button) sender);
            
        }

    }
}
