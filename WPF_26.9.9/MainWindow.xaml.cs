using System.Collections.Generic;
using System.Windows;

namespace WPF_26._9._9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtName.Text;
            string userPhone = txtPhone.Text;

            List<string> infoList = new List<string> { userName, userPhone };
            string combinedInfo = "";
            foreach (string item in infoList)
            {
                combinedInfo += item + " ";
            }

            int count = 0;
            while (count < 1) { count++; }

            do { count--; } while (count > 0);

            string outputMessage = $"姓名：{userName}\n電話：{userPhone}";
            MessageBox.Show(outputMessage, "使用者資訊展示", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}