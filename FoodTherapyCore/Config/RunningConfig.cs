using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTherapyCore.Config
{
    public class RunningConfig
    {
        private static readonly RunningConfig instance = new RunningConfig();
        public static RunningConfig Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// 调试模式
        /// </summary>
        public bool DebugMode { get; set; }

        public string DBServiceIP { get; set; } = "121.4.29.105";
        public string DBName { get; set; } = "food";
        public string DBUserID { get; set; } = "root";
        public string DBPwd { get; set; } = "sa!123456";
        public int DBPort { get; set; } = 3306;

        //Server=121.4.29.105;Database=stock;User Id=root;Password=sa!123456;Pooling=true;Max Pool Size={100};Connect Timeout=20;
        public string DBConnectionString
        {
            get
            {
                return $"Server={DBServiceIP};Database={DBName};User Id={DBUserID};Password={DBPwd};Connect Timeout=20;";
            }
        }
    }
}
