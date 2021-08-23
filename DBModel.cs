using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 客成部机器人数据管理端
{
    class DBModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string questionNos;
        public string questionNo
        {
            get { return questionNos; }
            set { if (questionNos != value) { questionNos = value; if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("questionNos")); } } }
        }
        private string issuedate;
        public string Issuedate
        {
            get { return issuedate; }
            set
            {
                if (issuedate != value)
                {
                    issuedate = value;
                    System.Diagnostics.Debug.WriteLine(issuedate);
                    if (PropertyChanged != null)
                    {
                        System.Diagnostics.Debug.WriteLine("loding.........change");
                        PropertyChanged(this, new PropertyChangedEventArgs("issuedate"));
                    }
                }
            }
        }
        private string ProblemSource;
        public string Problemsource
        {
            get { return ProblemSource; }
            set
            {
                if(ProblemSource != value)
                {
                    ProblemSource = value;
                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Problemsource"));
                    }
                }
            }
        }
        private string Regional1;
        public string Regional
        {
            get { return Regional1; }
            set
            {
                if (Regional1 != value)
                {
                    Regional1 = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Regional"));
                    }
                }
            }
        }
        private string Customer;
        public string customer
        {
            get { return Customer; }
            set
            {
                if (Customer != value)
                {
                    Customer = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("customer"));
                    }
                }
            }
        }
        private string scenes;
        public string Scenes
        {
            get { return scenes; }
            set
            {
                if (scenes != value)
                {
                    scenes = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Scenes"));
                    }
                }
            }
        }
        private string business;
        public string Business
        {
            get { return business; }
            set
            {
                if (business != value)
                {
                    business = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Business"));
                    }
                }
            }
        }
        private string Content;
        public string content
        {
            get { return Content; }
            set
            {
                if (Content != value)
                {
                    Content = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("content"));
                    }
                }
            }
        }
        private string tapd;
        public string TAPD
        {
            get { return tapd; }
            set
            {
                if (tapd != value)
                {
                    tapd = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TAPD"));
                    }
                }
            }
        }
        private string facVersion;
        public string FactoryVersion
        {
            get { return facVersion; }
            set
            {
                if (facVersion != value)
                {
                    facVersion = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("FactoryVersion"));
                    }
                }
            }
        }
        private string botVersion;
        public string BotVersion
        {
            get { return botVersion; }
            set
            {
                if (botVersion != value)
                {
                    botVersion = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BotVersion"));
                    }
                }
            }
        }
        private string commanderversion;
        public string commanderVersion
        {
            get { return commanderversion; }
            set
            {
                if (commanderversion != value)
                {
                    commanderversion = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("commanderVersion"));
                    }
                }
            }
        }
        private string baseocr;
        public string BaseOCR
        {
            get { return baseocr; }
            set
            {
                if (baseocr != value)
                {
                    baseocr = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BaseOCR"));
                    }
                }
            }
        }
        private string pathfile;
        public string Patchfile
        {
            get { return pathfile; }
            set
            {
                if (pathfile != value)
                {
                    pathfile = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Patchfile"));
                    }
                }
            }
        }
        private string level1;
        public string questionLevel1
        {
            get { return level1; }
            set
            {
                if (level1 != value)
                {
                    level1 = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("questionLevel1"));
                    }
                }
            }
        }
        private string level2;
        public string questionLevel2
        {
            get { return level2; }
            set
            {
                if (level2 != value)
                {
                    level2 = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("questionLevel2"));
                    }
                }
            }
        }
        private string level3;
        public string questionLevel3
        {
            get { return level3; }
            set
            {
                if (level3 != value)
                {
                    level3 = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("questionLevel3"));
                    }
                }
            }
        }
        private string emeType;
        public string EmergencyType
        {
            get { return emeType; }
            set
            {
                if (emeType != value)
                {
                    emeType = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("EmergencyType"));
                    }
                }
            }
        }
        private string prolevel;
        public string Problemlevel
        {
            get { return prolevel; }
            set
            {
                if (prolevel != value)
                {
                    prolevel = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Problemlevel"));
                    }
                }
            }
        }
        private string Stage;
        public string stage
        {
            get { return Stage; }
            set
            {
                if (Stage != value)
                {
                    Stage = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("stage"));
                    }
                }
            }
        }
        private string Status;
        public string status
        {
            get { return Status; }
            set
            {
                if (Status != value)
                {
                    Status = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("status"));
                    }
                }
            }
        }
        private string Reason;
        public string reason
        {
            get { return Reason; }
            set
            {
                if (Reason != value)
                {
                    Reason = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("reason"));
                    }
                }
            }
        }
        private string Solution;
        public string solution
        {
            get { return Solution; }
            set
            {
                if (Solution != value)
                {
                    Solution = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("solution"));
                    }
                }
            }
        }
        private string Action;
        public string action
        {
            get { return Action; }
            set
            {
                if (Action != value)
                {
                    Action = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("action"));
                    }
                }
            }
        }
        private string Manager;
        public string manager
        {
            get { return Manager; }
            set
            {
                if (Manager != value)
                {
                    Manager = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("manager"));
                    }
                }
            }
        }
        private string Deliver;
        public string deliver
        {
            get { return Deliver; }
            set
            {
                if (Deliver != value)
                {
                    Deliver = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("deliver"));
                    }
                }
            }
        }
        private string technology;
        public string Technology
        {
            get { return technology; }
            set
            {
                if (technology != value)
                {
                    technology = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Technology"));
                    }
                }
            }
        }
        private string designator;
        public string Designator
        {
            get { return designator; }
            set
            {
                if (designator != value)
                {
                    designator = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Designator"));
                    }
                }
            }
        }
        private string PlanTime;
        public string planTime
        {
            get { return PlanTime; }
            set
            {
                if (PlanTime != value)
                {
                    PlanTime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("planTime"));
                    }
                }
            }
        }
        private string completetime;
        public string Completetime
        {
            get { return completetime; }
            set
            {
                if (completetime != value)
                {
                    completetime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Completetime"));
                    }
                }
            }
        }
        private string input;
        public string Input
        {
            get { return input; }
            set
            {
                if (input != value)
                {
                    input = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Input"));
                    }
                }
            }
        }
        private string remark;
        public string Remark
        {
            get { return remark; }
            set
            {
                if (remark != value)
                {
                    remark = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
                    }
                }
            }
        }
        private string investin;
        public string Investin
        {
            get { return investin; }
            set
            {
                if (investin != value)
                {
                    investin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Investin"));
                }
            }
        }
        private string similarity;
        public string Similarity
        {
            get { return similarity; }
            set
            {
                if (similarity != value)
                {
                    similarity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Similarity"));
                }
            }
        }
        private string infllevel;
        public string influencelevel
        {
            get { return infllevel; }
            set
            {
                if (infllevel != value)
                {
                    infllevel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("influencelevel"));
                }
            }
        }

    }
}
