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
            // 資料型態 (string) 與 取得資料
            string userName = txtName.Text;
            string userPhone = txtPhone.Text;

            // 重複結構展現：foreach 處理資料清單
            List<string> infoList = new List<string> { userName, userPhone };
            string combinedInfo = "";
            foreach (string item in infoList)
            {
                combinedInfo += item + " ";
            }

            // 重複結構展現：while 範例 (計數)
            int count = 0;
            while (count < 1) { count++; }

            // 重複結構展現：do-while 範例
            do { count--; } while (count > 0);

            // 插補字串 ($"...") 與 MessageBox 呈現
            string outputMessage = $"姓名：{userName}\n電話：{userPhone}";
            MessageBox.Show(outputMessage, "使用者資訊展示", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}