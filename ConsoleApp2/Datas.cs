using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Datas
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 订购人
        /// </summary>
        public string order_buyer_regno { get; set; }
        /// <summary>
        /// 订购人姓名
        /// </summary>
        public string order_buyer_name { get; set; }
        /// <summary>
        /// 订购人身份证
        /// </summary>
        public string order_buyer_idcard { get; set; }//订购人身份证
        /// <summary>
        /// 收货人
        /// </summary>
        public string order_consignee { get; set; }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string order_consignee_tel { get; set; }
        /// <summary>
        /// 
        /// 收货人地址
        /// </summary>
        public string order_consignee_addr { get; set; }
        /// <summary>
        /// 成交总价
        /// </summary>
        public string order_actural_paid { get; set; }
        /// <summary>
        /// 成交币种
        /// </summary>
        public string order_currency { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string order_express_no { get; set; }
        /// <summary>
        /// 快递类型
        /// </summary>
        public string order_express { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public string create_time { get; set; }


    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Datas datas { get; set; }
    }
}