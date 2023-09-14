using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace 寝室管理系统
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int days = 0;
        static int disday = 2;
        public MainWindow()
        {
            InitializeComponent();
            Data.ReadData("data.txt");
            Text_Time.Text = DateTime.Now.ToString("d");
            days = (int)(DateTime.Now - Convert.ToDateTime(MainSettings.Default.Initial_Time)).TotalDays;
            Text_Name.Text = Data.Datas[((days % (disday * Data.Datas.Length)) - 1) / disday].Name;
        }

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();     //调用系统方法实现窗口拖拽（必须为左键，否则会报错）
        }

        private void But_CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();        //关闭当前窗口
        }
    }
}
