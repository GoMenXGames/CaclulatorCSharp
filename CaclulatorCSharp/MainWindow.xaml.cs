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

namespace CaclulatorCSharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private String _NumFieldText = "0";
        public string NumFieldText
        {
            get
            {
                return _NumFieldText;
            }
            set
            {
                _NumFieldText = value;
                NumField.Text = value;
            }
        }
        


        public MainWindow()
        {
            InitializeComponent();
            NumFieldText = "0";
        }


        private void OnLoadWindow(object sender, RoutedEventArgs e)
        {
            NumField.Text.ToUpper();
        }


        private void MaximazeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
        }

        private void HideBtn_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void NameHold(object sender, MouseEventArgs e)
        {
            DragMove();
        }

        private void NameBtn(object sender, MouseButtonEventArgs e)
        {
            if (sender is Label) {
                char senderBtn = char.Parse((sender as Label).Content.ToString());
                if (senderBtn != '=')
                {
                    NumFieldText += senderBtn;
                }
                else {
                    getResult();
                }
            }
        }

        private void getResult()
        {
            NumFieldText.Split('+');
        }

        private void btnZeroClick()
        {
            
        }

        private void EraseBtn(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (NumFieldText != null)
                {
                    if (NumFieldText.Length > 0)
                    {
                        NumFieldText = NumFieldText.Remove(NumFieldText.Length - 1);
                    }
                }
            }
            catch (ArgumentException x)
            {
                MessageBox.Show(x.ToString());
            }

        }

    }
}

