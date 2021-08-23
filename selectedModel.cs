using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 客成部机器人数据管理端
{
    class selectedModel
    {
        private string code;
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
