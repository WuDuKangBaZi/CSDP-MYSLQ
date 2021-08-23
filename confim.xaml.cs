using MahApps.Metro.Controls;

namespace 客成部机器人数据管理端
{
    /// <summary>
    /// confim.xaml 的交互逻辑
    /// </summary>
    public partial class confim : MetroWindow
    {
        dataInfo info;
        public confim(dataInfo info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //确定
            info.confim = true;
            this.Close();
            info.configCallBack();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            //取消
            info.confim = false;
            this.Close();
            info.configCallBack();
        }
    }
}
