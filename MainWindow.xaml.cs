using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace 客成部机器人数据管理端
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            infoFlyout.IsOpen = true;
        }
        public class searchModel
        {
            public string questionNo { get; set; }
            public string Issuedate { get; set; }
            public string content { get; set; }
            public string customer { get; set; }
            public string questionLevel1 { get; set; }
            public string questionLevel2 { get; set; }
            public string status { get; set; }
            public string reason { get; set; }
            public string TAPD { get; set; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ObservableCollection<searchModel> searchModelList = new ObservableCollection<searchModel>();
            string questionLevel1Where = questionLevel1.SelectedValue == null || questionLevel1.SelectedValue.ToString() == "" ? "" : $"and questionLevel1 = '{questionLevel1.SelectedValue}'";
            string questionLevel2Where = questionLevel2.SelectedValue == null || questionLevel2.SelectedValue.ToString() == "" ? "" : $"and questionLevel2 = '{questionLevel2.SelectedValue}'";
            string EmergencyTypeWhere = EmergencyType.SelectedValue == null || EmergencyType.SelectedValue.ToString() == "" ? "" : $"and EmergencyType = '{EmergencyType.SelectedValue}'";
            string statusWhere = status.SelectedValue == null || status.SelectedValue.ToString() == "" ? "" : $"and status = '{status.SelectedValue}'";
            string ProblemlevelWhere = Problemlevel.SelectedValue == null || Problemlevel.SelectedValue.ToString() == "" ? "" : $"and Problemlevel = '{Problemlevel.SelectedValue}'";
            string searchWhere = searchKey.Text == "" ? "" : $" and content like '%{searchKey.Text}%'";
            string queryStr = $"select questionNo, Issuedate, content, customer, questionLevel1, questionLevel2, status, reason, TAPD " +
                $"from customerquestioninfo where 1 = 1 {questionLevel1Where} {questionLevel2Where}{EmergencyTypeWhere}{statusWhere}{ProblemlevelWhere}" +
                $"{searchWhere}" + "order by Issuedate";
            System.Diagnostics.Debug.WriteLine(queryStr);
            MySqlHelper mySqlHelper = new MySqlHelper();
            MySqlDataReader reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                searchModelList.Add(new searchModel()
                {
                    questionNo = reader.GetString("questionNo"),
                    Issuedate = reader.GetString("Issuedate"),
                    content = reader.GetString("content"),
                    customer = reader.GetString("customer"),
                    questionLevel1 = reader.GetString("questionLevel1"),
                    questionLevel2 = reader.GetString("questionLevel2"),
                    status = reader.GetString("status"),
                    reason = reader.GetString("reason"),
                    TAPD = reader.GetString("TAPD")
                });
            }


            searchData.ItemsSource = searchModelList;
        }
        private void searchWhere()
        {
            ObservableCollection<searchModel> searchModelList = new ObservableCollection<searchModel>();
            string questionLevel1Where = questionLevel1.SelectedValue == null || questionLevel1.SelectedValue.ToString() == "" ? "" : $"and questionLevel1 = '{questionLevel1.SelectedValue}'";
            string questionLevel2Where = questionLevel2.SelectedValue == null || questionLevel2.SelectedValue.ToString() == "" ? "" : $"and questionLevel2 = '{questionLevel2.SelectedValue}'";
            string EmergencyTypeWhere = EmergencyType.SelectedValue == null || EmergencyType.SelectedValue.ToString() == "" ? "" : $"and EmergencyType = '{EmergencyType.SelectedValue}'";
            string statusWhere = status.SelectedValue == null || status.SelectedValue.ToString() == "" ? "" : $"and status = '{status.SelectedValue}'";
            string ProblemlevelWhere = Problemlevel.SelectedValue == null || Problemlevel.SelectedValue.ToString() == "" ? "" : $"and Problemlevel = '{Problemlevel.SelectedValue}'";
            string searchWhere = searchKey.Text == "" ? "" : $" and content like '%{searchKey.Text}%'";
            string queryStr = $"select questionNo, Issuedate, content, customer, questionLevel1, questionLevel2, status, reason, TAPD " +
                $"from customerquestioninfo where 1 = 1 {questionLevel1Where} {questionLevel2Where}{EmergencyTypeWhere}{statusWhere}{ProblemlevelWhere}" +
                $"{searchWhere}  order by Issuedate";
            System.Diagnostics.Debug.WriteLine(queryStr);
            MySqlHelper mySqlHelper = new MySqlHelper();
            MySqlDataReader reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                // System.Diagnostics.Debug.WriteLine(reader.GetString("questionNo"));
                searchModelList.Add(new searchModel()
                {
                    questionNo = reader.GetString("questionNo"),
                    Issuedate = reader.GetString("Issuedate"),
                    content = reader.GetString("content"),
                    customer = reader.GetString("customer"),
                    questionLevel1 = reader.GetString("questionLevel1"),
                    questionLevel2 = reader.GetString("questionLevel2"),
                    status = reader.GetString("status"),
                    reason = reader.GetString("reason"),
                    TAPD = reader.GetString("TAPD")
                });
            }


            searchData.ItemsSource = searchModelList;
        }

        private void openInfo(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGrid grid = sender as DataGrid;
                if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                {
                    searchModel info = grid.SelectedItem as searchModel;
                    infoData.loadData(info.questionNo);
                    infoFlyout.IsOpen = true;
                }

            }


        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 问题等级1
            questionLevel1.Items.Add("");
            questionLevel1.SelectedIndex = 0;
            string queryStr = "select DISTINCT questionLevel1 from customerquestioninfo";
            MySqlHelper mySqlHelper = new MySqlHelper();
            MySqlDataReader reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                questionLevel1.Items.Add(reader.GetString("questionLevel1"));
            }
            questionLevel2.Items.Add("");
            questionLevel2.SelectedIndex = 0;
            queryStr = "select DISTINCT questionLevel2 from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                questionLevel2.Items.Add(reader.GetString("questionLevel2"));
            }
            EmergencyType.Items.Add("");
            EmergencyType.SelectedIndex = 0;
            queryStr = "select DISTINCT EmergencyType from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                EmergencyType.Items.Add(reader.GetString("EmergencyType"));
            }
            Problemlevel.Items.Add("");
            Problemlevel.SelectedItem = 0;
            queryStr = "select DISTINCT Problemlevel from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                Problemlevel.Items.Add(reader.GetString("Problemlevel"));
            }
            status.Items.Add("");
            status.SelectedIndex = 0;
            queryStr = "select DISTINCT status from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(queryStr);
            while (reader.Read())
            {
                status.Items.Add(reader.GetString("status"));
            }
        }

        private void searchData_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void infoFlyout_IsOpenChanged(object sender, RoutedEventArgs e)
        {
            if (!infoFlyout.IsOpen)
            {
                searchWhere();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Excel导入启动
        }
    }
}
