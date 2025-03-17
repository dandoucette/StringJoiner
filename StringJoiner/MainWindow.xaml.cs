using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StringJoiner
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

        private void JoinTextButton_Click(object sender, RoutedEventArgs e)
        {
            string join = ((Button)sender).Tag.ToString();
            var bookend = "";
            if(join.Contains("'"))
            {
                bookend = "'";
            }
            
            var source = SourceTextBox.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            source = source.Distinct().ToArray();

            DestinationTextBox.Text = $"{bookend}{string.Join(join, source)}{bookend}";
        }

        private void SourceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringLengthTextBlock.Text = $"Source text length is {SourceTextBox.Text.Length} characters"; 
        }

        private void StackButton_Click(object sender, RoutedEventArgs e)
        {
            SourceTextBox.Text = string.Join("\n", DestinationTextBox.Text.Split(','));
        }
    }
}
