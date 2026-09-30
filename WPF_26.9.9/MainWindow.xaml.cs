using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPF_26._9._9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            // 1. 取得各滑桿 (Slider) 的數量
            int qty1 = (int)slider1.Value; // 紅茶大杯 (60)
            int qty2 = (int)slider2.Value; // 紅茶小杯 (40)
            int qty3 = (int)slider3.Value; // 奶茶大杯 (60)
            int qty4 = (int)slider4.Value; // 奶茶小杯 (40)
            int qty5 = (int)slider5.Value; // 綠茶大杯 (60)
            int qty6 = (int)slider6.Value; // 綠茶小杯 (40)

            // 2. 計算原始總金額
            float costFloat = (qty1 * 60) + (qty2 * 40) + (qty3 * 60) + (qty4 * 40) + (qty5 * 60) + (qty6 * 40);

            if (costFloat == 0)
            {
                txtResult.Text = "請調整滑桿選擇飲料數量！";
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("【 訂購明細 】");

            if (qty1 > 0) sb.AppendLine($"紅茶大杯 × {qty1} = {qty1 * 60} 元");
            if (qty2 > 0) sb.AppendLine($"紅茶小杯 × {qty2} = {qty2 * 40} 元");
            if (qty3 > 0) sb.AppendLine($"奶茶大杯 × {qty3} = {qty3 * 60} 元");
            if (qty4 > 0) sb.AppendLine($"奶茶小杯 × {qty4} = {qty4 * 40} 元");
            if (qty5 > 0) sb.AppendLine($"綠茶大杯 × {qty5} = {qty5 * 60} 元");
            if (qty6 > 0) sb.AppendLine($"綠茶小杯 × {qty6} = {qty6 * 40} 元");

            sb.AppendLine("--------------------------------");
            sb.AppendLine($"原價總額：{costFloat} 元");

            // 3. 融入折扣計算邏輯 (已修正 = 為 *=)
            string discountMsg = "無折扣";

            if (costFloat >= 500)
            {
                costFloat *= 0.8f;
                discountMsg = "滿 500 元享 8 折優惠";
            }
            else if (costFloat >= 300)
            {
                costFloat *= 0.85f;
                discountMsg = "滿 300 元享 8.5 折優惠";
            }
            else if (costFloat >= 200)
            {
                costFloat *= 0.9f;
                discountMsg = "滿 200 元享 9 折優惠";
            }

            // 4. 顯示折扣與最終金額
            if (discountMsg != "無折扣")
            {
                sb.AppendLine($"優惠活動：{discountMsg}");
            }

            // 使用 Math.Round 四捨五入取整數
            sb.AppendLine($"實付金額：{Math.Round(costFloat)} 元");

            txtResult.Text = sb.ToString();
        }
    }
}