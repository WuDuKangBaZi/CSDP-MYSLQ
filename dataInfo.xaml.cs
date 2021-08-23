using MySql.Data.MySqlClient;
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

namespace 客成部机器人数据管理端
{
    /// <summary>
    /// dataInfo.xaml 的交互逻辑
    /// </summary>
    public partial class dataInfo : UserControl
    {
        public bool confim;
        DBModel dBModel;
        public dataInfo()
        {
            InitializeComponent();
            dBModel = new DBModel();
        }
        /// <summary>
        /// 数据传递 打开panel的时候就load出来
        /// </summary>
        /// <param name="uuid"></param>
        public void loadData(string uuid)
        {
            allClear();
            string querySql = $"select * from  customerquestioninfo where questionNo ='{uuid}'";
            
            MySqlHelper mySqlHelper = new MySqlHelper();
            MySqlDataReader reader = mySqlHelper.getMySqlReader(querySql);
            reader.Read();
            dBModel.questionNo = reader.GetString("questionNo");
            dBModel.Issuedate = reader.GetString("Issuedate");
            dBModel.Problemsource = reader.GetString("Problemsource");
            dBModel.Regional = reader.GetString("Regional");
            dBModel.customer = reader.GetString("customer");
            dBModel.Scenes = reader.GetString("Scenes");
            dBModel.Business = reader.GetString("Business");
            dBModel.content = reader.GetString("content");
            dBModel.TAPD = reader.GetString("TAPD");
            dBModel.FactoryVersion = reader.GetString("FactoryVersion");
            dBModel.BotVersion = reader.GetString("BotVersion");
            dBModel.commanderVersion = reader.GetString("commanderVersion");
            dBModel.BaseOCR = reader.GetString("BaseOCR");
            dBModel.Patchfile = reader.GetString("Patchfile");
            dBModel.questionLevel1 = reader.GetString("questionLevel1");
            dBModel.questionLevel2 = reader.GetString("questionLevel2");
            dBModel.questionLevel3 = reader.GetString("questionLevel3");
            dBModel.EmergencyType = reader.GetString("EmergencyType");
            dBModel.Problemlevel = reader.GetString("Problemlevel");
            dBModel.stage = reader.GetString("stage");
            dBModel.status = reader.GetString("status");
            dBModel.reason = reader.GetString("reason");
            dBModel.solution = reader.GetString("solution");
            dBModel.action = reader.GetString("action");
            dBModel.manager = reader.GetString("manager");
            dBModel.deliver = reader.GetString("deliver");
            dBModel.Technology = reader.GetString("Technology");
            dBModel.Designator = reader.GetString("Designator");
            dBModel.planTime = reader.GetString("planTime");
            dBModel.Completetime = reader.GetString("Completetime");
            dBModel.Input = reader.GetString("Input");
            dBModel.Remark = reader.GetString("Remark");
            dBModel.Investin = reader.GetString("Investin");
            dBModel.Similarity = reader.GetString("Similarity");
            dBModel.influencelevel = reader.GetString("influencelevel");
            grid_dataInfo.DataContext = dBModel;

        }
        private void allClear()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            confim c = new confim(this);
            c.Title = "保存确认";
            c.PromptText.Content = "确认更改保存？";
            c.Show();
        }
        public void configCallBack()
        {
            if (confim)
            {
                DeleteData(questionno.Text);
                insertNow();
                loadData(questionno.Text);
            }
            if (!confim)
            {
                System.Diagnostics.Debug.WriteLine("传递参数返回false");
            }
        }
        private void insertNow()
        {
            string insertSql = $"insert into customerquestioninfo values('{questionno.Text}','{Issuedate.Text}','{Problemsource.SelectedValue}'," +
                $"'{Regional.Text}','{customer.Text}','{Scenes.Text}','{Business.Text}','{content.Text}','{TAPD.Text}','{FactoryVersion.Text}'," +
                $"'{BotVersion.Text}','{commanderVersion.Text}','{BaseOCR.Text}','{Patchfile.Text}','{questionLevel1.SelectedValue}','{questionLevel2.SelectedValue}'," +
                $"'{questionLevel3.Text}','{EmergencyType.SelectedValue}','{Problemlevel.SelectedValue}','{stage.Text}','{status.SelectedValue}','{reason.Text}','{solution.Text}'," +
                $"'{action.Text}','{manager.Text}','{deliver.Text}','{Technology.Text}','{Designator.Text}','{planTime.Text}','{Completetime.Text}','{Input.Text}','{Remark.Text}'," +
                $"'{Investin.Text}','{Similarity.Text}','{influencelevel.Text}')";
            System.Diagnostics.Debug.WriteLine(insertSql);
            MySqlHelper mySqlHelper = new MySqlHelper();
            mySqlHelper.getmysqlcom(insertSql);
        }
        private static void DeleteData(string uuid)
        {
            string deleteSql = $"delete from customerquestioninfo where questionNo = '{uuid}'";
            System.Diagnostics.Debug.WriteLine(deleteSql);
            MySqlHelper mySqlHelper = new MySqlHelper();
            mySqlHelper.getmysqlcom(deleteSql);
        }
        /// <summary>
        /// 各种下拉框的可选值更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //dataLoad 
            string querySql = "select DISTINCT `status` as code,`status` as name from customerquestioninfo";
            MySqlHelper mySqlHelper = new MySqlHelper();
            MySqlDataReader reader = mySqlHelper.getMySqlReader(querySql);
            status.ItemsSource = getDesc(reader);

            querySql = "select DISTINCT `Problemsource` as code,`Problemsource` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            Problemsource.ItemsSource = getDesc(reader);

            querySql = "select DISTINCT `questionLevel1` as code,`questionLevel1` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            questionLevel1.ItemsSource = getDesc(reader);

            querySql = "select DISTINCT `questionLevel2` as code,`questionLevel2` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            questionLevel2.ItemsSource = getDesc(reader);

           
            querySql = "select DISTINCT `EmergencyType` as code,`EmergencyType` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            EmergencyType.ItemsSource = getDesc(reader);

            querySql = "select DISTINCT `Problemlevel` as code,`Problemlevel` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            Problemlevel.ItemsSource = getDesc(reader);

            querySql = "select DISTINCT `Problemlevel` as code,`Problemlevel` as name from customerquestioninfo";
            reader = mySqlHelper.getMySqlReader(querySql);
            Problemlevel.ItemsSource = getDesc(reader);


        }
        private List<selectedModel> getDesc(MySqlDataReader reader)
        {
            List<selectedModel> models = new List<selectedModel>();
            while (reader.Read())
            {
                selectedModel statusMode = new selectedModel();
                statusMode.Code = reader.GetString("code");
                statusMode.Name = reader.GetString("name");
                models.Add(statusMode);
            }
            return models;
        }
    }
}
