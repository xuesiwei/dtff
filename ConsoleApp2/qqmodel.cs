using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Levelname
    {
        /// <summary>
        /// 短工
        /// </summary>
        public string w { get; set; }

    }
    public class Lv
    {
        /// <summary>
        /// 
        /// </summary>
        public int point { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
    }

    public class MemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string uin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int flag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int g { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int join_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int last_speak_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lv lv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nick { get; set; }
        /// <summary>
        /// GG―丹竹头―装
        /// </summary>
        public string card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int qage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rm { get; set; }
    }

    public class Rootqq
    {
        /// <summary>
        /// 
        /// </summary>
        public int ec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string em { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int adm_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int adm_max { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int vecsize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Levelname levelname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MemsItem> mems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int svr_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int max_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int search_count { get; set; }
    }

}
