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

namespace ExampleApp
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

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
            string userString = InputTextBox.Text;
            try
            {
                OutputTextBox.Text = CodeChallenge(userString) + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
            /*
			Code Challenge:  
            Write a method that returns a three values (boolean, X, Y)

			Method has one string parameter.

			The goal is to parse the incoming string and split into two numbers.

			Return the X and Y values.

			Return true for these test cases: "30,40", "abc30,40", "30,40def", "  30,40  ", "-30,40", "30, -40", "30 40"
			Return false for these test cases: "30, 40, 50", "30", "abc";
			*/
        }

        public string CodeChallenge(string value)
		{
            RayPoint point = RayPoint.Parse(value);
            var parsed = new ParsedData
            {
                WasParsed = point.WasParsed,
                X = point.X,
                Y = point.Y
            };
            return $"Parsed: {parsed.WasParsed}, X: {parsed.X}, Y:{parsed.Y}";
        }
    }
	public struct ParsedData
	{
		public bool WasParsed { get; set; }
		public int X { get; set; }
		public int Y { get; set; }

	}
}
