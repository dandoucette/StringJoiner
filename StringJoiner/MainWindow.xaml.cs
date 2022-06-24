using System;
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

            DestinationTextBox.Text = $"{bookend}{string.Join(join, SourceTextBox.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))}{bookend}";
        }

        private void SourceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringLengthTextBlock.Text = $"Source text lenght is {SourceTextBox.Text.Length} characters"; 
        }
    }
}
