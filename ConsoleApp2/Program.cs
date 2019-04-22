
using HtmlAgilityPack;
using mshtml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApp2
{
    public class Program
    {
        private static long _totalTimeCost = 0;
        private static int _endedConnenctionCount = 0;
        private static int _failedConnectionCount = 0;

   
        static void Main(string[] args)
        {
           

             Program cc = new Program();
             int a = 0;
            string path = "E:\\微信对账单.txt";
            //cc.ReadTxtContent(path);
            //SendRequestHwUserinfo();
            // string url11 = "https://www.bilibili.com/video/av49401880";
            // cc.SaveAsWebImg(url11);
            //SendRequestplwduoxianc();
            //Thread thread25yi = new Thread(new ThreadStart(obj.SendRequestqxc));
            //thread25yi.Start();
            //void MethodTimer1()
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(DateTime.Now.ToString() + "_" + thread25yi.CurrentThread.ManagedThreadId.ToString());
            //        thread25yi.CurrentThread.Join(100);//阻止设定时间 
            //    }
            //}
            // SendRequestwms();

            int temp = 0;
            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };
            Console.WriteLine("排序前的数组：");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("排序后的数组：");
            foreach (int item in arr)
            {
                Console.WriteLine(item + "");
            }
            Console.WriteLine();
            Console.ReadKey();


            // SendRequestlichul();
            //SendRequestmengceproyIP();
            // SendRequestqxc();
            // SendRequestproy();
            //SendRequestplw();
            // SendRequestmengce();
            Console.Read();

            //while (true)
            //{
            //    a++;
            //    var connectionCount = 1000;
            //    var requestThread = new Thread(() => StartRequest(connectionCount)) { IsBackground = true };
            //    requestThread.Start();
              

                //Parallel.Invoke(() =>
                //{
                //    a++;
                //    var connectionCount = 1000;
                //    var requestThread = new Thread(() => StartRequest(connectionCount)) { IsBackground = true };
                //    requestThread.Start();
                //    Console.WriteLine(a);
                //});


                // Console.WriteLine("恭喜，成功完成！");
                // Console.ReadLine();


                //  GC.Collect();
                //  }
                // }

          //  }
        }
        //冒泡排序方法，从小到大排，虽然很多冒泡排序都是从大到小，
        //可是我就想这么排，你能怎么着我。
        public void PopSort(int[] list)
        {
            int i, j, temp;  //先定义一下要用的变量
            for (i = 0; i < list.Length - 1; i++)
            {
                for (j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j]) //如果第二个小于第一个数
                    {
                        //交换两个数的位置，在这里你也可以单独写一个交换方法，在此调用就行了
                        temp = list[i]; //把大的数放在一个临时存储位置
                        list[i] = list[j]; //然后把小的数赋给前一个，保证每趟排序前面的最小
                        list[j] = temp; //然后把临时位置的那个大数赋给后一个
                    }
                }
            }
        }
            private static void IncreaseFailedConnection()
        {
            Interlocked.Increment(ref _failedConnectionCount);
            Console.WriteLine("失败个数：" + _failedConnectionCount);
        }
        private static void IncreaseSuccessConnection()
        {
            Interlocked.Increment(ref _endedConnenctionCount);
            Console.WriteLine("成功个数：" + _endedConnenctionCount);
        }
        private static void StartRequest(int connectionCount)
        {
            Reset();
            for (var i = 0; i < connectionCount; i++)
            {
                ThreadPool.QueueUserWorkItem(u => SendRequestqxc());
            }
        }


        private static void Reset()
        {
            _failedConnectionCount = 0;
            _endedConnenctionCount = 0;
            _totalTimeCost = 0;
        }
       private static void see( )
            {
                try
                {
                    HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    Encoding encoder = Encoding.GetEncoding("gb2312");
                    htmlDoc.Load("http://kaijiang.500.com/shtml/qxc/04102.shtml", encoder);
                    HtmlWeb webClient = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = webClient.Load("http://kaijiang.500.com/shtml/qxc/04102.shtml");

                    HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");

                    if (hrefList != null)
                    {
                        foreach (HtmlNode href in hrefList)
                        {
                            HtmlAttribute att = href.Attributes["href"];
                            Console.WriteLine(att.Value);

                        }

                    }
                }
                catch (Exception ex)
                {

                }
            }
        public static List<string> GetHtmls(string start, string end, string html)
        {
            List<string> list = new List<string>();
            try
            {
                string pattern = string.Format("{0}(?<g>(.|[\r\n])+?){1}", start, end);//匹配URL的模式,并分组 
                MatchCollection mc = Regex.Matches(html, pattern);//满足pattern的匹配集合    
                if (mc.Count != 0)
                {
                    foreach (Match match in mc)
                    {
                        GroupCollection gc = match.Groups;
                        list.Add(gc["g"].Value);
                    }
                }
            }
            catch { }
            return list;
        }
        public static string ReplaceHtmlTag(string html, int length = 0)
        {
            string strText = System.Text.RegularExpressions.Regex.Replace(html, "<[^>]+>", "");
            strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");

            if (length > 0 && strText.Length > length)
                return strText.Substring(0, length);

            return strText;
        }
        private static void SendRequest3()
        {
            int Result=0;
            for (int i = 0; i < 10000; i++)
            {
                System.Random Random = new System.Random();
                 Result = Random.Next(0, 9999);
                Console.WriteLine(Result);
            }
         
        }
        private static void SendRequestproy()

        {
            try
            {
                string ur = string.Empty;

               string Url = "http://kaijiang.500.com/shtml/plw/04010.shtml";

                //string Url = "http://192.168.0.242/admin/";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);


              
                request.Method = "GET";
                request.ContentType = "application/json;charset=utf-8";


                //设置代理
                WebProxy proxy = new WebProxy();
                proxy.Address = new Uri("http://180.113.105.79:4332");
                request.UseDefaultCredentials = true;
                request.Proxy = proxy;

               

                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Stream myResponseStream = response.GetResponseStream();


                    StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);

                    string retString = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return;
                }

             
            }

            

            // IncreaseSuccessConnection();



            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
        private static void SendRequestmengceproyIP()

        {
            try
            {
                string ur = string.Empty;
                int id = 1;
              
                
                    id++;
                    string Url = "https://raw.githubusercontent.com/fate0/proxylist/master/proxy.list?tdsourcetag=s_pcqq_aiomsg";
                 
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                    request.Method = "GET";
                    request.ContentType = "application/json;charset=gb2312";
                    // Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));          
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        Stream myResponseStream = response.GetResponseStream();
                        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gb2312"));

                        string retString = myStreamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(retString))
                        {
                            DateTime datetime;
                            string html = retString.Replace("null(", "").Replace(")", "");
                            List<string> info = GetHtmls("export_address", "host", html);
                            if (info != null)
                            {
                                string datails = ReplaceHtmlTag(info[0]).Replace("\t", "").Replace("\r", "").Replace(" ", "").Trim();



                                String str4 = "INSERT INTO mengce([id],[number],[dream],[url])VALUES('" + id + "','" +  datails + "')";

                                sqlconection r2 = new sqlconection();
                                int d2 = r2.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                                int d = 0;
                                d++;
                                int e = 0;
                                e++;
                                Console.WriteLine(id);
                            }
                            myStreamReader.Close();
                        }
                    }
                    catch (Exception ex) { }
                


                // IncreaseSuccessConnection();

            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
        private static void SendRequestlichul()

        {
            try
            {
                string ur = string.Empty;
                string sql3 = "select top 130 left(number,4) as number from qixingcai order by Datetime desc ";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);

               // var rowssm = d3.Rows.Cast<DataRow>().Select(x => new { a = x.Field<string>("number"),b = x.Field<string>("url")});
                var rowssm = d3.Rows.Cast<DataRow>().Select(x => new { a = x.Field<string>("number")});
                List<int> mList = new List<int>();
                var exce = new List<int>();
                List<int> mList100 = new List<int>();
                List<int> mListthesame= new List<int>();
                int thesame = 0;
                for (int i=0;i<100;i++ )
                {
                    mList100.Add(i);
                }
                foreach (var item in rowssm)
                {
                    try
                    {
                        string a1 = item.a.Substring(0, 1);
                        string a2 = item.a.Substring(item.a.Length - 1, 1);
                        string um = a1 + a2;
                        int num = Convert.ToInt32(um);
                        mList.Add(num);
                    }
                    catch(Exception ex)
                    {
                        //Console.WriteLine("{0},{1}",item.a,item.b);
                        Console.WriteLine("{0}", item.a);
                    }
                }

                foreach (var str1 in mList100)
                {
                    if (!mList.Contains(str1))
                    {
                        exce.Add(str1);
                       
                    }
                    else
                    {
                        mListthesame.Add(str1);
                        if (mListthesame.Contains(str1))
                        {
                            thesame++;
                        }
                        Console.WriteLine("{0},{1}", str1, thesame);
                        continue;
                    }
                }

                for (int i = 0; i <exce.Count; i++)
                {
                    Console.WriteLine("未开:{0}",exce[i]);
                }

            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }        

        }
        private static void SendRequestqxc()

        {
            try
            {    string ur = string.Empty;
                string sql3 = "select MAX(id) as id ,max(qishu) as qishu from qixingcai";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]);   
                int qishuj = Convert.ToInt16(d3.Rows[0]["qishu"]);
                for (int j = qishuj; j <qishuj+3; j++)
                {
                    if (j >= 8000 & j < 10000)
                    {
                        ur = "0" + j + ".shtml";

                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) > 200)
                        {
                            continue;
                        }

                    }
                    else
                    {
                        ur = j + ".shtml";
                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) > 200)
                        {
                            continue;
                        }
                    }

                    id++;
                    string Url = "http://kaijiang.500.com/shtml/qxc/";
                    string URL = Url + ur;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json;charset=gb2312";
                    // Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));          
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                        Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                        StreamReader myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));

                        string retString = myStreamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(retString))
                        {
                            string html = retString.Replace("null(", "").Replace(")", "");
                            List<string> info = GetHtmls("<tr>", "</tr>", html);
                           
                            string datails = ReplaceHtmlTag(info[4]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Trim();
                            string strtempa = "第";
                            string strtempb = "期开";
                            int IndexofA = datails.IndexOf(strtempa);
                            int IndexofB = datails.IndexOf(strtempb);
                            string qishu = datails.Substring(IndexofA + 1, IndexofB - IndexofA - 1).Trim();
                            string strtempc = "：";
                            string strtempd = "兑奖";
                            int IndexofC = datails.IndexOf(strtempc);
                            int IndexofD = datails.IndexOf(strtempd);
                            string datatime = datails.Substring(IndexofC + 1, IndexofD - IndexofC - 1).Trim();
                            string[] tmp = datatime.Split('年');
                            string Year = tmp[0];
                            string stryear = "年";
                            string strmouth = "月";
                            int Indexofyear = datatime.IndexOf(stryear);
                            int Indexofmouth = datatime.IndexOf(strmouth);
                            string mouth = datatime.Substring(Indexofyear + 1, Indexofmouth - Indexofyear - 1).Trim();



                            string strmouthe = "月";
                            string strday = "日";
                            int Indexofmouthe = datatime.IndexOf(strmouthe);
                            int Indexofday = datatime.IndexOf(strday);
                            string day = datatime.Substring(Indexofmouthe + 1, Indexofday - Indexofmouthe - 1).Trim();

                            string numberDatetime = Year + "-" + mouth + "-" + day;
                            DateTime datetime = Convert.ToDateTime(numberDatetime);
                            string number = ReplaceHtmlTag(info[5]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Replace("\r0", "").Replace("r2", "").Replace("r3", "").Replace("r8", "").Replace("r9", "").Trim();
                            string[] sArray = number.Split('：');
                            string numbere = sArray[1];
                          

                            string sql6 = "SELECT dream FROM mengce where number=left("+numbere+",4)";
                            sqlconection r6 = new sqlconection();
                            DataTable d6 = new DataTable();
                            d6= r6.ExecuteQuery(sql6);                         
                            string dream= d6.Rows[0]["dream"].ToString();

                            myStreamReader.Close();
                            stm.Close();
                            String str4 = "INSERT INTO qixingcai([id],[qishu],[Datetime],[number] ,[details],[dream])VALUES('" + id + "','" + qishu + "','" + datetime + "','" + numbere + "','" + datails + "','" + dream + "')";

                            sqlconection r2 = new sqlconection();
                            int d2 = r2.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                            int d = 0;
                            d++;
                            int e = 0;
                            e++;
                            Console.WriteLine(id);
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(j); Console.WriteLine(URL); }
                }
                

                // IncreaseSuccessConnection();

            }
            
            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
        /// <summary>
        /// 将json数据转换成实体类  
        /// </summary>
        /// <returns></returns>
        private static List<Root> getObjectByJson(string jsonString)
        {
            // 实例化DataContractJsonSerializer对象，需要待序列化的对象类型
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Root>));
            //把Json传入内存流中保存
            jsonString = "[" + jsonString + "]";
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            // 使用ReadObject方法反序列化成对象
            object ob = serializer.ReadObject(stream);
            List<Root> ls = (List<Root>)ob;
            return ls;
        }

        /// <summary>
        /// 将json数据转换成实体类  
        /// </summary>
        /// <returns></returns>
        private static List<HwUserInfo> getObjectByJsonHwUserInfo(string jsonString)
        {
            // 实例化DataContractJsonSerializer对象，需要待序列化的对象类型
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<HwUserInfo>));
            //把Json传入内存流中保存
            jsonString = "[" + jsonString + "]";
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            // 使用ReadObject方法反序列化成对象
            object ob = serializer.ReadObject(stream);
            List<HwUserInfo> ls = (List<HwUserInfo>)ob;
            return ls;
        }
        /// <summary>
        /// 读取txt文件内容
        /// </summary>
        /// <param name="Path">文件地址</param>
        ///
        string path = "E:\\微信对账单.txt";
        public void ReadTxtContent(string Path)
        {
          
            string []content=File.ReadAllLines(Path,Encoding.Default);

            foreach(var item in content)
            {
                string 表头 = content[0];
            }
          
          // string tradeMsg = content.su(content.IndexOf("`"));
            
        }
        private static void SendRequestHwUserinfo()

        {
            try
            {

                string ur = string.Empty;
                for (int i = 1; i < 1559; i++)
                {
                    string Url = "http://zmtyf.360jlb.cn/admin/rest/user/list?&mid=-1990&page="+i+"&beginTime=0";
                   
                    try
                    {
                        string cookieStr = "S_ID=7NYW1553849630857WI7FIA443CJUXQAJRM77P8VYX7JF; route=3d6b021b81f47d01488401546cf24ed6; U_ID=37cd1cb8c21e397ba6f2a131e2bbe3a9; U_CRTDATE=1555573367074; U_SIG=a830f5498172afbb8243c176b5434a39";
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                        request.Method = "POST";
                        request.ContentType = "application/x-www-form-urlencoded";
                        request.Headers.Add("Cookie", cookieStr);
                        try
                        {
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();                                                 
                            Stream myResponseStream = response.GetResponseStream();
                            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                            string retString = myStreamReader.ReadToEnd().ToString();
                            if (!string.IsNullOrEmpty(retString))
                            {
                                var ss = getObjectByJsonHwUserInfo(retString);
                                 foreach( var item in ss[0].result.list)
                                {
                                    int userid = item.user.id;
                                    string email = item.user.email;
                                    string phone = item.user.phone;
                                    string nickname = item.user.nickname;
                                    string trueName = item.userExt.trueName;
                                    string identityCode = item.userExt.identityCode;
                                    string sex = item.userExt.sex;
                                    switch (sex)
                                    {
                                        case "M":
                                            sex = "男";
                                            break;
                                        case "F":
                                            sex = "女";
                                            break;
                                         case "U":
                                            sex = "未知";
                                            break;                                       
                                    }
                                    string emergencyContactPerson = item.userExt.emergencyContactPerson;
                                    string emergencyContactPhone = item.userExt.emergencyContactPhone;
                                    int birthdayTime = item.userExt.birthdayTime;
                                    string resultjson= Newtonsoft.Json.JsonConvert.SerializeObject(item);
                                    String str4 = "INSERT INTO HwUserInfo([userid],[email],[phone],[nickname] ,[trueName] ,[identityCode]," +
                                       "[sex],[emergencyContactPerson] ,[emergencyContactPhone],[birthdayTime],[resultjson],[url])VALUES" +
                                       "('" + userid + "','" + email + "','" + phone + "','" + nickname + "','" +
                                       trueName + "','" + identityCode + "','" + sex + "','" + emergencyContactPerson + "','" +
                                       emergencyContactPhone + "','" + birthdayTime + "','" + resultjson + "','" + Url + "')";
                                    sqlconection r2 = new sqlconection();
                                     int d2 = r2.ExecuteUpdate(str4);
                                    Console.WriteLine(i);
                                    myStreamReader.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                    catch (Exception ex) { }
                }

            }
            catch (Exception ex)
            {

            }
        }
        private static void SendRequestwms()

        {
            try
            {
                    
                  string ur = string.Empty;
                for (int i = 1347; i < 1351; i++)
                {
                    string Url = "https://wapi.ai-cross.com/order/";
                    string URL = Url + i;
                    try { 
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "GET";
                    request.ContentType = "application/json;charset=utf-8";
                        try
                        {
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            Stream myResponseStream = response.GetResponseStream();
                            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                            string retString = myStreamReader.ReadToEnd().ToString();
                            if (!string.IsNullOrEmpty(retString))
                            {

                                var ss = getObjectByJson(retString);
                                int id = ss[0].datas.id;
                                string order_buyer_regno = ss[0].datas.order_buyer_regno;
                                string order_buyer_name = ss[0].datas.order_buyer_name;
                                string order_buyer_idcard = ss[0].datas.order_buyer_idcard;
                                string order_consignee = ss[0].datas.order_consignee;
                                string order_consignee_tel = ss[0].datas.order_consignee_tel;
                                string order_consignee_addr = ss[0].datas.order_consignee_addr;
                                string order_actural_paid = ss[0].datas.order_actural_paid;
                                string order_currency = ss[0].datas.order_currency;
                                string order_express_no = ss[0].datas.order_express_no;
                                string order_express = ss[0].datas.order_express;
                                DateTime? create_time =Convert.ToDateTime(ss[0].datas.create_time);
                                String str4 = "INSERT INTO orderInfo([id],[order_buyer_regno],[order_buyer_name],[order_buyer_idcard] ,[order_consignee] ,[order_consignee_tel]," +
                                   "[order_consignee_addr],[order_actural_paid] ,[order_currency],[order_express_no],[order_express],[details],[url],[create_time])VALUES" +
                                   "('" + id + "','" + order_buyer_regno + "','" + order_buyer_name + "','" + order_buyer_idcard + "','" +
                                   order_consignee + "','" + order_consignee_tel + "','" + order_consignee_addr + "','" + order_actural_paid + "','" +
                                   order_currency + "','" + order_express_no + "','" + order_express + "','"+retString+ "','" + URL+ "','"+ create_time + "')";
                                sqlconection r2 = new sqlconection();
                                int d2 = r2.ExecuteUpdate(str4);
                                Console.WriteLine(i);
                                myStreamReader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                     
                     
                    }
                    catch (Exception ex) {  }
                }
         
            }
            catch (Exception ex)
            {
                
            }     
        }
        private static void SendRequestplwduoxianc()

        {
            try
            {
                string ur = string.Empty;
                string sql3 = "select MAX(id) as id ,max(qishu) as qishu from pailiewunak";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);            
                int id = Convert.ToInt16(d3.Rows[0]["id"]);
                int qishuj = Convert.ToInt16(d3.Rows[0]["qishu"]);
                for (int j = qishuj; j < 19094; j++)
                {
                    if (j >= 4000 & j < 10000)
                    {
                        ur = "0" + j + ".shtml";

                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) > 367)
                        {
                            continue;
                        }

                    }
                    else
                    {
                        ur = j + ".shtml";
                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) > 367)
                        {
                            continue;
                        }
                    }

                    id++;
                    string Url = "http://kaijiang.500.com/shtml/plw/";
                    string URL = Url + ur;
                    ServicePointManager.DefaultConnectionLimit = 512;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json;charset=gb2312";
                    // Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));          
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                        Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                        StreamReader myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));

                        string retString = myStreamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(retString))
                        {
                            DateTime datetime;
                            string html = retString.Replace("null(", "").Replace(")", "");
                            List<string> info = GetHtmls("<tr>", "</tr>", html);

                            string datails = ReplaceHtmlTag(info[4]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Trim();
                            string strtempa = "第";
                            string strtempb = "期开";
                            int IndexofA = datails.IndexOf(strtempa);
                            int IndexofB = datails.IndexOf(strtempb);
                            string qishu = datails.Substring(IndexofA + 1, IndexofB - IndexofA - 1).Trim();
                            string strtempc = "：";
                            string strtempd = "兑奖";
                            int IndexofC = datails.IndexOf(strtempc);
                            int IndexofD = datails.IndexOf(strtempd);
                            string datatime = datails.Substring(IndexofC + 1, IndexofD - IndexofC - 1).Trim();
                            if (datatime.Contains("年"))
                            {
                                string[] tmp = datatime.Split('年');
                                string Year = tmp[0];
                                string stryear = "年";
                                string strmouth = "月";
                                int Indexofyear = datatime.IndexOf(stryear);
                                int Indexofmouth = datatime.IndexOf(strmouth);
                                string mouth = datatime.Substring(Indexofyear + 1, Indexofmouth - Indexofyear - 1).Trim();



                                string strmouthe = "月";
                                string strday = "日";
                                int Indexofmouthe = datatime.IndexOf(strmouthe);
                                int Indexofday = datatime.IndexOf(strday);
                                string day = datatime.Substring(Indexofmouthe + 1, Indexofday - Indexofmouthe - 1).Trim();

                                string numberDatetime = Year + "-" + mouth + "-" + day;
                                datetime = Convert.ToDateTime(numberDatetime);
                            }
                            else
                            {
                                datetime = Convert.ToDateTime(datatime);
                            }
                            string number = ReplaceHtmlTag(info[5]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Replace("\r0", "").Replace("r2", "").Replace("r3", "").Replace("r8", "").Replace("r9", "").Trim();
                            string[] sArray = number.Split('：');
                            string numbere = sArray[1];
                            myStreamReader.Close();
                            stm.Close();





                            String str4 = "INSERT INTO pailiewunak([id],[qishu],[Datetime],[number] ,[details],[dream],[url])VALUES('" + id + "','" + qishu + "','" + datetime + "','" + numbere + "','" + datails + "','" + ' ' + "','" + URL + "')";

                            sqlconection r2 = new sqlconection();
                            int d2 = r2.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                            int d = 0;
                            d++;
                            int e = 0;
                            e++;
                            Console.WriteLine(id);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


                // IncreaseSuccessConnection();

            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
      
    
    public string SaveAsWebImg(string picUrl)
        {
            string result = "";
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"File";  //目录 
            try
            {
                if (!String.IsNullOrEmpty(picUrl))
                {
                    Random rd = new Random();
                    DateTime nowTime = DateTime.Now;
                    string fileName = nowTime.Month.ToString() + nowTime.Day.ToString() + nowTime.Hour.ToString() + nowTime.Minute.ToString() + nowTime.Second.ToString() + rd.Next(1000, 1000000) + ".mp4";
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(picUrl, path + fileName);
                    result = fileName;
                    Console.WriteLine(result);
                }
            }
            catch(Exception ex) { }
            return result;
        }
        private static void SendRequestplw()

        {
            try
            {
                string ur = string.Empty;
                string sql3 = "select MAX(id) as id ,max(qishu) as qishu from pailiewu";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]);
                int qishuj=Convert.ToInt16(d3.Rows[0]["qishu"]);
                for (int j= qishuj; j <qishuj+10; j++)
                {
                    if (j >= 8200 & j < 10000)
                    {
                        ur = "0" + j + ".shtml";

                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) > 367)
                        {
                            continue;
                        }

                    }
                    else
                    {
                        ur = j + ".shtml";
                        string uu = Convert.ToString(j).Substring(Convert.ToString(j).Length - 3, 3);
                        if (Convert.ToInt32(uu) >367)
                        {
                            continue;
                        }
                    }

                    id++;
                    string Url = "http://kaijiang.500.com/shtml/plw/";
                    string URL = Url + ur;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json;charset=gb2312";
                    // Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));          
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                        Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                        StreamReader myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));

                        string retString = myStreamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(retString))
                        {
                            DateTime datetime;
                            string html = retString.Replace("null(", "").Replace(")", "");
                            List<string> info = GetHtmls("<tr>", "</tr>", html);

                            string datails = ReplaceHtmlTag(info[4]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Trim();
                            string strtempa = "第";
                            string strtempb = "期开";
                            int IndexofA = datails.IndexOf(strtempa);
                            int IndexofB = datails.IndexOf(strtempb);
                            string qishu = datails.Substring(IndexofA + 1, IndexofB - IndexofA - 1).Trim();
                            string strtempc = "：";
                            string strtempd = "兑奖";
                            int IndexofC = datails.IndexOf(strtempc);
                            int IndexofD = datails.IndexOf(strtempd);
                            string datatime = datails.Substring(IndexofC + 1, IndexofD - IndexofC - 1).Trim();
                            if (datatime.Contains("年"))
                            {
                                string[] tmp = datatime.Split('年');
                                string Year = tmp[0];
                                string stryear = "年";
                                string strmouth = "月";
                                int Indexofyear = datatime.IndexOf(stryear);
                                int Indexofmouth = datatime.IndexOf(strmouth);
                                string mouth = datatime.Substring(Indexofyear + 1, Indexofmouth - Indexofyear - 1).Trim();



                                string strmouthe = "月";
                                string strday = "日";
                                int Indexofmouthe = datatime.IndexOf(strmouthe);
                                int Indexofday = datatime.IndexOf(strday);
                                string day = datatime.Substring(Indexofmouthe + 1, Indexofday - Indexofmouthe - 1).Trim();

                                string numberDatetime = Year + "-" + mouth + "-" + day;
                                datetime = Convert.ToDateTime(numberDatetime);
                            }
                            else
                            {
                                datetime = Convert.ToDateTime(datatime);
                            }
                            string number = ReplaceHtmlTag(info[5]).Replace("\t", "").Replace("\n", "").Replace("\r", "").Replace("\r0", "").Replace("r2", "").Replace("r3", "").Replace("r8", "").Replace("r9", "").Trim();
                            string[] sArray = number.Split('：');
                            string numbere = sArray[1];
                            myStreamReader.Close();
                            stm.Close();





                            String str4 = "INSERT INTO pailiewu([id],[qishu],[Datetime],[number] ,[details],[dream],[url])VALUES('" + id + "','" + qishu + "','" + datetime + "','" + numbere + "','" + datails + "','" + ' ' + "','" + URL + "')";

                            sqlconection r2 = new sqlconection();
                            int d2 = r2.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                            int d = 0;
                            d++;
                            int e = 0;
                            e++;
                            Console.WriteLine(id);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


                // IncreaseSuccessConnection();

            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
        private static void SendRequestmengce()

        {
            try
            {
                string ur = string.Empty;
                int id = 1;
                string sql = "SELECT number,dream FROM mengce";
                sqlconection r1 = new sqlconection();  
                DataTable d1 = new DataTable();   
                d1 = r1.ExecuteQuery(sql);
                var rowssnumber = d1.Rows.Cast<DataRow>().Select(e => e.Field<string>("number"));
                var rowssdream = d1.Rows.Cast<DataRow>().Select(e => e.Field<string>("dream"));
                string sqlm = "SELECT left(number,4) as number FROM [DTcmsdb5].[dbo].[qixingcai]";
                sqlconection r1m = new sqlconection();
                DataTable d1m = new DataTable();
                d1m = r1.ExecuteQuery(sqlm);
               
                var rowssm = d1m.Rows.Cast<DataRow>().Select(e => e.Field<string>("number"));


                foreach (var  item in rowssnumber)
                {
                   
                    id++;
                    string Url = "https://www.ccmeng.com/do/search.php?keyword=";
                    string URL = Url + item;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json;charset=gb2312";
                    // Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));          
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        Stream myResponseStream = response.GetResponseStream();
                       StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gb2312"));

                        string retString = myStreamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(retString))
                        {
                            DateTime datetime;
                            string html = retString.Replace("null(", "").Replace(")", "");
                            List<string> info = GetHtmls("div class=\"bleft\">", "</td>", html);
                            if (info != null)
                            {
                                string datails = ReplaceHtmlTag(info[0]).Replace("\t", "").Replace("\r", "").Replace(" ", "").Trim();

                              

                                String str4 = "INSERT INTO mengce([id],[number],[dream],[url])VALUES('" + id + "','" + item + "','" + datails + "','" + URL + "')";

                                sqlconection r2 = new sqlconection();
                                int d2 = r2.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                                int d = 0;
                                d++;
                                int e = 0;
                                e++;
                                Console.WriteLine(id);
                            }
                            myStreamReader.Close();
                        }
                    }
                    catch (Exception ex) { }
                }


                // IncreaseSuccessConnection();

            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }
            //return content;

        }
        public static List<T> ToDataList<T>(DataTable dt)
        {
            var list = new List<T>();
            var plist = new List<PropertyInfo>(typeof(T).GetProperties());
            foreach (DataRow item in dt.Rows)
            {
                T s = Activator.CreateInstance<T>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    PropertyInfo info = plist.Find(p => p.Name == dt.Columns[i].ColumnName);
                    if (info != null)
                    {
                        try
                        {
                            if (!Convert.IsDBNull(item[i]))
                            {
                                object v = null;
                                if (info.PropertyType.ToString().Contains("System.Nullable"))
                                {
                                    v = Convert.ChangeType(item[i], Nullable.GetUnderlyingType(info.PropertyType));
                                }
                                else
                                {
                                    v = Convert.ChangeType(item[i], info.PropertyType);
                                }
                                info.SetValue(s, v, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("字段[" + info.Name + "]转换出错," + ex.Message);
                        }
                    }
                }
                list.Add(s);
            }
            return list;
        }
    }


    }


