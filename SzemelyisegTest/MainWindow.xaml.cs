using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzemelyisegTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult gomb = MessageBox.Show("Ügyes vagy!:3", "ablak", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            foreach (CheckBox checkbox in stc1.Children)
            {
                if (checkbox.IsChecked == true)
                {
                    lbl1.Items.Add(checkbox.Content);
                }
            }


            foreach (CheckBox checkbox in stc2.Children)
            {
                if (checkbox.IsChecked == true)
                {
                    lbl2.Items.Add(checkbox.Content);
                }

            }
            lbl3.Content= ((ComboBoxItem)combo1.SelectedItem).Content;

            foreach (RadioButton radioButton in stc3.Children)
            {
                if (radioButton.IsChecked == true)
                {
                    lbl4.Content = radioButton.Content;
                }
            }
            lbl5.Content = ((ListBoxItem)list1.SelectedItem).Content;
        }
    }
}