
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
using Log;
using System.Timers;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    public class Program
    {
        private static long _totalTimeCost = 0;
        private static int _endedConnenctionCount = 0;
        private static int _failedConnectionCount = 0;

        [STAThread]
        static void Main(string[] args)
        {
            //System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);

            //aTimer.Interval = 1000;

            //aTimer.Enabled = true;

            //Console.WriteLine("按回车键结束程序");

            //Console.WriteLine(" 等待程序的执行．．．．．．");

            //Console.ReadLine();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Program cc = new Program();

            string path = "E:\\微信对账单.txt";



            //cc.ReadTxtContent(path);
            // SendRequestHwUserinfo();
            //SendRequestqqmember();
            // string url11 = "https://www.bilibili.com/video/av49401880";
            // cc.SaveAsWebImg(url11);
            //SendRequestplwduoxianc();

            // SendRequestBLZinfo();
            //zhuchehao();
            //SendRequestBLZzhYanzheng();
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
            //  SendRequestwine();

            string str = "160万";
            //Regex r = new Regex(".*(?=万)");
            //bool ismatch = r.IsMatch(str);
            //MatchCollection mc = r.Matches(str);
            //string result = string.Empty;
            //for (int i = 0; i < mc.Count; i++)
            //{
            //    result += mc[i];//匹配结果是完整的数字，此处可以不做拼接的
            //}
            // SendRequestlichul();
            //SendRequestmengceproyIP();

            //SendRequestqxc();
            // SendRequestproy();

            //while (true)
            //{
            //    withdrow();
            //}
            //SendRequestplw();
            // SendRequestPHPapi();
            PostJson();
            // SendRequestmengce();
            Console.Read();
            return;
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

        public static void withdrow()
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(@"F:\weixin\WeChat Files\x54073416\FileStorage\Image\2019-11\");
                FileInfo[] files = info.GetFiles();
                DateTime time = new DateTime(1900, 1, 1);
                FileInfo newestFile = null;
                foreach (FileInfo f1 in files)
                {
                    if (f1.LastWriteTime > time)
                    {
                        time = f1.LastWriteTime;
                        newestFile = f1;

                    }
                }
                string pathold = newestFile.FullName;
                string newpath = @"F:\weixin\WeChat Files\x54073416\FileStorage\Image\2019-11withdraw\" + newestFile;
                FileInfo fi = new FileInfo(pathold);
                if (fi.Exists)
                {
                    fi.CopyTo(newpath);
                }
            }
            catch (Exception ex)
            {

            }


        }
        private static void TimeEvent(object source, ElapsedEventArgs e)



        {
            int intHour = DateTime.Now.Hour;

            int intMinute = DateTime.Now.Minute;

            int intSecond = DateTime.Now.Second;
            int iHour = 10;

            int iMinute = 08;

            int iSecond = 00;

            if (intSecond == iSecond)

            {
                SendRequestqxc();
                SendRequestplw();
                Console.WriteLine("七星彩！");

            }
            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)

            {
                SendRequestplw();
                Console.WriteLine("排列五！");

            }

        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.ReadKey();
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
        private static void see()
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
            int Result = 0;
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
                            String str4 = "INSERT INTO mengce([id],[number],[dream],[url])VALUES('" + id + "','" + datails + "')";
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
                // string sql3 = "select top 130 left(number,4) as number from qixingcai order by Datetime desc ";
                string sql3 = "select top 200 left(number,4) as number from pailiewu order by Datetime desc ";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                // var rowssm = d3.Rows.Cast<DataRow>().Select(x => new { a = x.Field<string>("number"),b = x.Field<string>("url")});
                var rowssm = d3.Rows.Cast<DataRow>().Select(x => new { a = x.Field<string>("number") });
                List<int> mList = new List<int>();
                var exce = new List<int>();
                List<int> mList100 = new List<int>();
                List<int> mListthesame = new List<int>();
                int thesame = 0;
                for (int i = 0; i < 100; i++)
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
                    catch (Exception ex)
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
                for (int i = 0; i < exce.Count; i++)
                {

                    Console.WriteLine("未开:{0}", exce[i]);
                    Log1 gg = new Log1();
                    gg.WriteLine(Convert.ToString(exce[i]));
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
            { string ur = string.Empty;
                string sql3 = "select MAX(id) as id ,max(qishu) as qishu from qixingcai";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]);
                int qishuj = Convert.ToInt16(d3.Rows[0]["qishu"]);
                for (int j = qishuj; j < qishuj + 5; j++)
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
                    Stream myRequestStream = request.GetRequestStream();
                    StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
                    myStreamWriter.Close();
                    Stream stm;
                    StreamReader myStreamReader;
                    string retString = string.Empty;
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        //Stream myStreamReader = response.GetResponseStream();
                        //StreamReader stm = new StreamReader(myStreamReader, Encoding.GetEncoding("gb2312"));
                        try
                        {
                            stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                            myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));

                            retString = myStreamReader.ReadToEnd();
                        }

                        catch
                        {

                            stm = response.GetResponseStream();
                            myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));
                            retString = myStreamReader.ReadToEnd();

                        }
                        //Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                        //StreamReader myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));
                        //string retString = myStreamReader.ReadToEnd();
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
                            if (Convert.ToDateTime(numberDatetime) >= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")))
                            {
                                return;
                            }

                            string sql6 = "SELECT dream FROM mengce where number=left('" + numbere + "',4)";
                            sqlconection r6 = new sqlconection();
                            DataTable d6 = new DataTable();
                            d6 = r6.ExecuteQuery(sql6);
                            string dream = d6.Rows[0]["dream"].ToString();

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
        /// 



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
        private static List<Rootqq> getObjectByJsonqqmodel(string jsonString)
        {
            // 实例化DataContractJsonSerializer对象，需要待序列化的对象类型
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Rootqq>));
            //把Json传入内存流中保存
            jsonString = "[" + jsonString + "]";
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            // 使用ReadObject方法反序列化成对象
            object ob = serializer.ReadObject(stream);
            List<Rootqq> ls = (List<Rootqq>)ob;
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

            string[] content = File.ReadAllLines(Path, Encoding.Default);

            foreach (var item in content)
            {
                string 表头 = content[0];
            }

            // string tradeMsg = content.su(content.IndexOf("`"));

        }
        public static string CreatePostData(Dictionary<string, string> PostParameters)
        {
            var query = from s in PostParameters select s.Key + "=" + s.Value;
            string[] parameters = query.ToArray<string>();
            return string.Join("&", parameters);
        }

        private static void SendRequestBLZzhYanzheng()

        {
            try
            {
                sqlconection r2 = new sqlconection();
                string ur = string.Empty;
                List<string> mList = new List<string>();
                string sql6 = "select userid  from BLZitStudentInfo";
                DataTable d6 = new DataTable();
                d6 = r2.ExecuteQuery(sql6);
                var rowssm = d6.Rows.Cast<DataRow>().Select(e => e.Field<int>("userid"));
                foreach (var item in rowssm)
                {
                    string ex = item.ToString();

                    mList.Add(ex);

                }
                for (int i = 74373; i < 80000; i++)
                {
                    if (!mList.Contains(i.ToString()))
                    {
                        Dictionary<string, string> parameters = new Dictionary<string, string>();
                        parameters.Add("IPT_LOGINUSERNAME", "101002133035");
                        parameters.Add("IPT_LOGINPASSWORD", "000000");

                        string postdata = CreatePostData(parameters);


                        string Url = "http://eol.zhbit.com/homepage/common/login.jsp?" + postdata;

                        int id = 1;

                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);


                        request.Method = "GET";


                        try
                        {
                            //request.AllowAutoRedirect = false;
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                            Stream myResponseStream1 = response.GetResponseStream();
                            StreamReader myStreamReader1 = new StreamReader(myResponseStream1, Encoding.GetEncoding("gbk"));
                            string retString1 = myStreamReader1.ReadToEnd().ToString();
                            string cookie = response.Headers.Get("Set-Cookie");
                            //string cookie = "JSESSIONID=8F32DAADE4BB5CD825ABF514181CD069";
                            string[] cookies = cookie.Split(';');
                            string Cookie = cookies[0];
                            string Url2 = "http://eol.zhbit.com/popups/viewstudent_info.jsp?SID=" + 29805 + "";
                            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(Url2);

                            request2.Method = "GET";
                            request2.ContentType = "text/html;charset=gbk";
                            request2.Headers.Add("Cookie", Cookie);

                            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
                            string cookie2 = response2.Headers.Get("Set-Cookie");
                            Stream myResponseStream = response2.GetResponseStream();
                            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gbk"));
                            string retString = myStreamReader.ReadToEnd().ToString();
                            if (!string.IsNullOrEmpty(retString))
                            {
                                string html = retString.Replace("null(", "").Replace(")", "");
                                List<string> info = GetHtmls("<th align=", "</td>", html);
                                if (info.Count != 0)
                                {
                                    string xuehao = ReplaceHtmlTag(info[0]).Replace("\"right\" width=\"20%\">", "").Replace("\n", "").Replace(" ", "").Trim();
                                    string[] xueHao = xuehao.Split('：');
                                    string xuehaor = xueHao[1].ToString();
                                    string username = ReplaceHtmlTag(info[1]).Replace("\"right\" width=\"20%\">", "").Replace("\n", "").Replace(" ", "").Trim();
                                    string[] userName = username.Split('：');
                                    string usernamer = userName[1].ToString();


                                    String str4 = "INSERT INTO BLZitStudentInfo([id],[xuehao],[userName],[userid] ,[url])VALUES" +
                                       "('" + id + "','" + xuehaor + "','" + usernamer + "','" + i + "','" + Url + "')";

                                    int d2 = r2.ExecuteUpdate(str4);
                                    Console.WriteLine(i);
                                }
                                else
                                {
                                    Console.WriteLine("未有该用户{0}", i);
                                    continue;

                                }

                            }
                            myStreamReader.Close();
                        }

                        catch (Exception ex)
                        {
                            try
                            {
                                int iid = 1;
                                Console.WriteLine(ex.Message);
                                String str6 = "INSERT INTO BLZitStudentnotUserId([id],[userid],[url])VALUES" +
                                     "('" + iid + "','" + i + "','" + Url + "')";

                                int d2 = r2.ExecuteUpdate(str6);
                                iid++;
                            }
                            catch (Exception ex1)
                            {
                                Console.WriteLine(ex1.Message);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("已存在改{0}useerid", i);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
        private static void SendRequestBLZinfo()

        {
            try
            {
                sqlconection r2 = new sqlconection();
                string ur = string.Empty;
                List<string> mList = new List<string>();
                string sql6 = "select userid  from BLZitStudentInfo";
                DataTable d6 = new DataTable();
                d6 = r2.ExecuteQuery(sql6);
                var rowssm = d6.Rows.Cast<DataRow>().Select(e => e.Field<int>("userid"));
                foreach (var item in rowssm)
                {
                    string ex = item.ToString();

                    mList.Add(ex);

                }
                for (int i = 57318; i < 100000; i++)
                {
                    if (!mList.Contains(i.ToString()))
                    {



                        string Url = "http://eol.zhbit.com/popups/viewstudent_info.jsp?SID=" + i + "";
                        int id = 1;
                        string cookieStr = "JSESSIONID=1A86FB3616CC3F5C16EC4F78B30F766C";
                        Thread.Sleep(5000);
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                        request.Timeout = 5000;
                        request.Method = "GET";
                        request.ContentType = "atext/html;charset=gbk";
                        request.Headers.Add("Cookie", cookieStr);
                        try
                        {

                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();



                            Stream myResponseStream = response.GetResponseStream();
                            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gbk"));
                            string retString = myStreamReader.ReadToEnd().ToString();
                            if (!string.IsNullOrEmpty(retString))
                            {
                                string html = retString.Replace("null(", "").Replace(")", "");
                                List<string> info = GetHtmls("<th align=", "</td>", html);
                                if (info.Count != 0)
                                {
                                    string xuehao = ReplaceHtmlTag(info[0]).Replace("\"right\" width=\"20%\">", "").Replace("\n", "").Replace(" ", "").Trim();
                                    string[] xueHao = xuehao.Split('：');
                                    string xuehaor = xueHao[1].ToString();
                                    string username = ReplaceHtmlTag(info[1]).Replace("\"right\" width=\"20%\">", "").Replace("\n", "").Replace(" ", "").Trim();
                                    string[] userName = username.Split('：');
                                    string usernamer = userName[1].ToString();


                                    String str4 = "INSERT INTO BLZitStudentInfo([id],[xuehao],[userName],[userid] ,[url])VALUES" +
                                       "('" + id + "','" + xuehaor + "','" + usernamer + "','" + i + "','" + Url + "')";

                                    int d2 = r2.ExecuteUpdate(str4);
                                    Console.WriteLine(i);
                                }
                                else
                                {
                                    Console.WriteLine("未有该用户{0}", i);
                                    continue;

                                }

                            }
                            myStreamReader.Close();
                        }

                        catch (Exception ex)
                        {
                            try
                            {
                                int iid = 1;
                                Console.WriteLine(ex.Message);
                                String str6 = "INSERT INTO BLZitStudentnotUserId([id],[userid],[url])VALUES" +
                                     "('" + iid + "','" + i + "','" + Url + "')";

                                int d2 = r2.ExecuteUpdate(str6);
                                iid++;
                            }
                            catch (Exception ex1)
                            {
                                Console.WriteLine(ex1.Message);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("已存在改{0}useerid", i);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///
        /// 去除字符串中的中文
        ///
        ///
        ///
        public static string DeleteChineseWord(string str)
        {
            string retValue = str;
            if (System.Text.RegularExpressions.Regex.IsMatch(str, @"[\u4e00-\u9fa5]"))
            {
                retValue = string.Empty;
                var strsStrings = str.ToCharArray();
                for (int index = 0; index < strsStrings.Length; index++)
                {
                    if (strsStrings[index] >= 0x4e00 && strsStrings[index] <= 0x9fa5)
                    {
                        continue;
                    }
                    retValue += strsStrings[index];
                }
            }
            return retValue;
        }

        /// <summary>
        /// 保留中文字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string KeepChinese(string str)
        {
            //声明存储结果的字符串
            string chineseString = "";


            //将传入参数中的中文字符添加到结果字符串中
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 0x4E00 && str[i] <= 0x9FA5) //汉字
                {
                    chineseString += str[i];
                }
            }


            //返回保留中文的处理结果
            return chineseString;
        }
        private static void zhuchehao()

        {
            try
            {
                
                sqlconection r2 = new sqlconection();
                string ur = string.Empty;
                List<string> mList = new List<string>();
                string sql6 = "select *  from zhucehao";
                DataTable d6 = new DataTable();
                d6 = r2.ExecuteQuery(sql6);
                //  var rowppz = d6.Rows.Cast<DataRow>().Select(e => e.Field<string>("pinpai"));
                 

                int id = 0;
               // var rowpplx = d6.Rows.Cast<DataRow>().Select(e => e.Field<string>("pinpaileixing"));
                foreach(DataRow row in d6.Rows)
                {
                    string pp = row[2].ToString();
                   // string pplx = row[1].ToString();
                    string guojia = row[2].ToString();               
                    id++;

                    string str = string.Empty;
                    int ID = id;
                    string pingpai = row[2].ToString();
                    string pinpaiy = row[3].ToString();
                    string guojia2 =string.Empty;
                    string SBZHUEHAO = string.Empty;
                    string guojia4 = string.Empty;
                    string shuzi = string.Empty;
                    string PINGPAIY = string.Empty;
                    string sql8 = "select *  from guojia where pinpai like" + "'" + pp + "%'";
                    DataTable d8 = new DataTable();
                    d8 = r2.ExecuteQuery(sql8);
                    if (d8 != null && d8.Rows.Count > 0)
                    {
                         string guojia3 = d8.Rows[0]["原产国"].ToString();
                         shuzi = System.Text.RegularExpressions.Regex.Replace(guojia3, @"[^0-9]+", "");

                        SBZHUEHAO = shuzi + row[0].ToString() + row[5].ToString();
                        guojia4 = KeepChinese(guojia3);
                    }
                    else
                    {
                        SBZHUEHAO = "";
                    }

                    string PINGPAIZ = pingpai;
                    PyHash szm = new PyHash();
                    string PINGPAIZS ;
                    PINGPAIY = pinpaiy;
                    string Guojia = guojia4;
                    string SBLEIXING = "39";
                    string PPLX = "境外品牌（其它）";
                    string ZZLX = "商品注册证";
                    string bTIME = "2015/5/25";
                    string gTIME = "2025/5/26";
                    string SBZCR = pingpai;



                    PINGPAIZS = PINGPAIZ.Substring(0, 1);
                    char[] c = PINGPAIZS.ToCharArray();
                    string PBSZMs = szm.GetPinYin(c[0]); ;
                    string PBSZM = PBSZMs.Substring(0, 1).ToUpper();
                    string SBQD = "无";
                    int result = 0;

                    try
                    {
                           string MySqlCon = "Data Source=PV-11;Initial Catalog=DTcmsdb5;User ID=sa;Password=qq123456";
                           SqlConnection conn = new SqlConnection(MySqlCon);
                           conn.Open();

        string sqlStr = "insert into DSSJUB(PINGPAIZ,PINGPAIY,Guojia,SBZHUEHAO,SBLEIXING,PPLX,ZZLX,bTIME,gTIME,SBZCR,PBSZM,SBQD) values(@PINGPAIZ,@PINGPAIY,@Guojia,@SBZHUEHAO,@SBLEIXING,@PPLX,@ZZLX,@bTIME,@gTIME,@SBZCR,@PBSZM,@SBQD)";
                                     SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        SqlParameter[] parames = {

         new SqlParameter("@PINGPAIZ",PINGPAIZ),
         new SqlParameter("@PINGPAIY",PINGPAIY),
         new SqlParameter("@Guojia",Guojia),
         new SqlParameter("@SBZHUEHAO",SBZHUEHAO),
         new SqlParameter("@SBLEIXING",SBLEIXING),
         new SqlParameter("@PPLX",PPLX),
         new SqlParameter("@ZZLX",ZZLX),
         new SqlParameter("@bTIME",bTIME),
         new SqlParameter("@gTIME",gTIME),
         new SqlParameter("@SBZCR",SBZCR),
         new SqlParameter("@PBSZM",PBSZM),
         new SqlParameter("@SBQD",SBQD)
                                  };
                        
             cmd.Parameters.AddRange(parames);
                        
             result = cmd.ExecuteNonQuery();


                        //String str4 = "INSERT INTO DSSJUB([PINGPAIZ],[PINGPAIY],[GUOJIA],[SBZHUEHAO],[SBLEIXING],[PPLX],[ZZLX],[bTIME] ,[gTIME],[SBZCR],[PBSZM],[SBQD])VALUES" +
                        //   "('" + PINGPAIZ + "','" + PINGPAIY + "','" + Guojia + "','" + SBZHUEHAO + "','" + SBLEIXING + "','" + PPLX + "','" + ZZLX + "','" + bTIME + "','" + gTIME + "','" + SBZCR + "','" + PBSZM + "','" + SBQD + "')";

                        //int d2 = r2.ExecuteUpdate(str4);
                        Console.WriteLine(id);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine(pingpai);
                    }
                    

                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }




        }
        private static void SendRequestHwUserinfo()

        {
            try
            {

                string ur = string.Empty;
                for (int i = 1; i < 1559; i++)
                {
                    string Url = "http://zmtyf.360jlb.cn/admin/rest/user/list?&mid=-1990&page=" + i + "&beginTime=0";

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
                                foreach (var item in ss[0].result.list)
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
                                    string resultjson = Newtonsoft.Json.JsonConvert.SerializeObject(item);
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

        private static void SendRequestqqmemberssss()

        {
            try
            {

                int id = 0;
                string sql3 = "select MAX(id) as id from qqnumber";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);


                string Url = "http://tmsearch.uspto.gov/bin/showfield?";
                string State = "4810%3A6tw2w0.1.1";
                // string name = "A B S BY ALLEN SCHWARTZc";
                string name1 = "A Christmas Story";
                string name = name1.Replace(" ", "+");
                string url = "f=toc&state=" + State + "&p_search=searchss&p_L=50&BackReference=&p_plural=yes&p_s_PARA1=&p_tagrepl%7E%3A=PARA1%24LD&expr=PARA1+AND+PARA2&p_s_PARA2="+ name+"&p_tagrepl%7E%3A=PARA2%24COMB&p_op_ALL=AND&a_default=search&a_search=Submit+Query&a_search=Submit+Query";
                string URL = Url + url;
                try
                {
                    string cookieStr = "_ga=GA1.2.2050352112.1556612920; _4c_=lVPNbts8EHyVgGf%2FkJREkb65PygMFEWAtF%2FRk0BRq5iwLAokbdUJ8u5ZyrFa9FD080Hi7M7uiLvjZzLuoScbVhRCMMGVVEouyAEugWyeibdNep3JhmjTMgmc1ZJBIWmrCiEbQ1lWUC1Y25IF%2BZn6iDyTUvGCZvJlQczwVv9MjGsA%2BzC1EiuB7PiEKJcUj9AnhRAf8dxiBaF53Srd0IwL0IpqxCBaUZeiLCkYhbxP22r3AamcolTBGeOr6yW44qnnyXeY3cc4hM16PY7j6hSG6FaP7ryOXjdw1P4QlnoYOmt0tK5fDt4ZCGEdQHuzX86sZaOjrnUAbIuc5mRiFS9Dus0I9V1oDpi41xH6iFMjXxB9nRUw8AMDu%2Fvqsx6re4dql2rXt%2B6N%2BR%2F0jfO%2FR7ZnbbvqYwcmetdbU72zT9VDWsiU3vWxq7Ym2rONFmZBCNEeXX%2BpHgYAs58TtXdjAI%2Fo%2Fd67I9yVaToupb9blB4DQg8teD%2BxEAUb093meb2F0BS36PIaHdLaMjx0zugu1aCXptV8%2B8tu0BaTUwpRUi5UXuYFuiHiuqTIafohY0A4GYfNbMHLjBc8u7FZ%2Fos9OQwf2b%2F0vo7k%2F9W0dX37J6SB3T5JqYxLJcs%2FC15eXgE%3D; TMSearchsession=705753098.20480.0000; ROUTEID=.1";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                   // request.Method = "GET";

                    //request.ContentType = "text/html";
                    request.Headers.Add("Cookie", cookieStr);
                  //   request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                    //request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml; q = 0.9,image/webp,image/apng,*/*;q=0.8");
                   // request.Headers.Add("Accept-Encoding", "gzip, deflate");
                  //  request.Referer="http://tmsearch.uspto.gov/bin/gate.exe?f=searchss&state=4804:t0x26i.1.1";
                  //  request.UserAgent = "Mozilla/5.0(Windows NT 10.0;WOW64)AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.67 Safari/537.36";
                  //  request.Headers.Add("Accept-Encoding", "gzip,deflate");
                 //   string ur = string.Empty;
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream myResponseStream = response.GetResponseStream();
                        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("iso8859-1"));
                        string retString = myStreamReader.ReadToEnd().ToString();
                        if (!string.IsNullOrEmpty(retString))
                        {
                            var ss = getObjectByJsonqqmodel(retString);
                            string card = string.Empty;
                            string qq;
                            int role;
                            int point;
                            int level;
                            string nick = string.Empty;
                            foreach (var item in ss[0].mems)
                            {
                                id++;
                                card = item.card;
                                qq = item.uin;
                                role = item.role;
                                point = item.lv.point;
                                level = item.lv.level;
                                nick = item.nick;
                                String str4 = "INSERT INTO qqnumber([id],[card],[qq],[role] ,[point] ,[level]," +
                                   "[nick],[url],[groupqq])VALUES" +
                                   "('" + id + "','" + card + "','" + qq + "','" + role + "','" +
                                   point + "','" + level + "','" + nick + "','" + Url + "','" + 84479667 + "')";
                                sqlconection r2 = new sqlconection();
                                int d2 = r2.ExecuteUpdate(str4);
                                Console.WriteLine(id);
                            }
                            myStreamReader.Close();
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(Url);
                      
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }


            catch (Exception ex)
            {

            }
}
        private static void SendRequestqqmember()

        {
            try
            {

                int id = 0;
                string sql3 = "select MAX(id) as id from qqnumber";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                if (d3.DataSet!=null)
                {
                    id = Convert.ToInt16(d3.Rows[0]["id"]);
                }
                else
                {
                    id = Convert.ToInt16(d3.Rows[0]["id"]);
                }
              //
                for (int i =1; i < 2000; i++)
                {
                    Thread.Sleep(1000);
                    if (i % 20 == 0)
                    {
                        int st1 = i-20;
                        int end1 = i;
                        string qqgropunumber= "121547051";
                        string Url = "https://qun.qq.com/cgi-bin/qun_mgr/search_group_members?&gc="+ qqgropunumber + "&st=" + st1 + "&end=" + end1 + "&sort=0&bkn=939018797";
                        try
                        {
                            string cookieStr = "pgv_pvi=586314752; RK=mJI4uh6JSZ; ptcz=53d7c290c34862af168da5a2dd3ab3371994226e562008b71a7337592c06bf6c; pgv_pvid=8303468981; tvfe_boss_uuid=50a22e41292cd555; o_cookie=540734160; pac_uid=1_540734160; _gcl_au=1.1.231089453.1561362132; _ga=GA1.2.469681840.1561362132; pt_235db4a7=uid=X0tFcEviEqv0V9v6cuF9YQ&nid=1&vid=CgqVN9EKS7F-MSsOG5AwoQ&vn=1&pvn=1&sact=1561362158655&to_flag=0&pl=0KzaISwJA-wYoyVB1nkjpQ*pt*1561362132322; pgv_si=s7114341376; pgv_info=ssid=s8169310290; ts_uid=888827844; _qpsvr_localtk=0.8413444478296574; uin=o0540734160; skey=@mku0yxK6Y; ptisp=ctc; p_uin=o0540734160; pt4_token=QD5loV-pObpH80wEetSolqUwBdJVtw55jJOFkx1odEg_; p_skey=c0SxsJWnrjTxo-pj1anL77S86ZlkhZ4hFrb8kiqxKnQ_; ts_refer=xui.ptlogin2.qq.com/cgi-bin/xlogin; traceid=9f700deb27; enc_uin=AUif_lticvSvjZCOiO6N1g; ts_last=qun.qq.com/member.html";
                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                            request.Headers.Add("Cookie", cookieStr);
                            string ur = string.Empty;
                            try
                            {
                                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                Stream myResponseStream = response.GetResponseStream();
                                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                                string retString = myStreamReader.ReadToEnd().ToString();
                                if (!string.IsNullOrEmpty(retString))
                                {
                                    var ss = getObjectByJsonqqmodel(retString);
                                    string card = string.Empty;
                                    string qq;
                                    int role;
                                    int point;
                                    int level;
                                    string nick = string.Empty;
                                    foreach (var item in ss[0].mems)
                                    {
                                        id++;
                                        card = item.card;
                                        qq = item.uin;
                                        role = item.role;
                                        point = item.lv.point;
                                        level = item.lv.level;
                                        nick = item.nick;
                                        String str4 = "INSERT INTO qqnumber([id],[card],[qq],[role] ,[point] ,[level]," +
                                           "[nick],[url],[groupqq])VALUES" +
                                           "('" + id + "','" + card + "','" + qq + "','" + role + "','" +
                                           point + "','" + level + "','" + nick + "','" + Url + "','"+ qqgropunumber + "')";
                                        sqlconection r2 = new sqlconection();
                                        int d2 = r2.ExecuteUpdate(str4);
                                     
                                        Console.WriteLine(id);
                                    }
                                    myStreamReader.Close();
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(Url);
                                Console.WriteLine(i);
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        protected int m_timestamp;

    
        private static void SendRequestPHPapi()

        {

            try
            {

                TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                 Convert.ToInt64(ts.TotalSeconds).ToString();
                Dictionary<string, string> sign_data = new Dictionary<string, string> {
                 {"method","get.goods.stock"},{"format","JSON"},{"timestamp", Convert.ToInt64(ts.TotalSeconds).ToString() },
                    { "vendorCode","44"}
                  };
                string key = "ce73caefc4d594010675e1b843bf7eac";
               string signData=SignTopRequest(sign_data, key,true);

                string url = "http://39.108.11.201/tripartite/v1/rest";
                Dictionary<string, string> UseApi = new Dictionary<string, string> {
                 {"method","get.goods.stock"},{"format","JSON"},{"timestamp", Convert.ToInt64(ts.TotalSeconds).ToString() },
                    { "vendorCode","44"},{"sign_data",signData},{"goods_sku","2A909C5142411"},
                    { "goods_type","2"},{"is_combination","0"}
                  };
                string jsonpara= JsonConvert.SerializeObject(UseApi);
                Post(url, UseApi);
            }
            catch (Exception ex)
            {

            }
        }
        //MD5排序加密
        public static string SignTopRequest(IDictionary<string, string> parameters, string secret, bool qhs)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            string dd=string.Empty;
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }
            if (qhs)
            {
               dd= query.Append(secret).ToString();
            }

            // 第三步：使用MD5加密

            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(dd));
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();

        }

      

        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string PostJson()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string timestamp=Convert.ToInt64(ts.TotalSeconds).ToString();
            Dictionary<string, string> sign_data = new Dictionary<string, string> {
                 {"method","get.goods.stock"},{"format","JSON"},{"timestamp", timestamp },
                    { "vendorCode","45"}
                  };
          //  string key = "ce73caefc4d594010675e1b843bf7eac";
            string key = "87p02e2n09dl1kzuegk834zbboltu800";
            string signData = SignTopRequest(sign_data, key, true);

          
            Dictionary<string, string> UseApi = new Dictionary<string, string> {
                 {"method","get.goods.stock"},{"format","JSON"},{"timestamp",timestamp},
                    { "vendorCode","45"},{"sign_data",signData},{"goods_sku","2A909C5142411"},
                    { "goods_type","2"},{"is_combination","0"}
                  };
            string jsonpara = JsonConvert.SerializeObject(UseApi);
            string result = "";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://39.108.11.201/tripartite/v1/rest");
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = jsonpara;

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                 result = streamReader.ReadToEnd();
            }
            return result;
        }
        private static void SendRequestwine()

        {
            try
            {

                string ur = string.Empty;
                string sql3 = "select max(id) as id from dbo.orderInfo";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]);
                for (int i = id+1; i < id+20; i++)
                {
                    string Url = "https://wapi.ai-cross.com/order/";
                    string URL = Url + i;
                    try
                    {
                         HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                        string access_token = "WyivnJ0hC6wCqcVBEFTiSWPLx2sV55KW1r4vGLdf3gOLULsDm21vNzojidb6TEu4IItIgk4L1xCSQxuOHogc+osAzPh9m9bJD0LRxaFm9KRwytS6sa19ZWRKkYwF/FDb";                  
                        string origin = "https://wine.ai-cross.com";
                        string nbenterpriseguid = "49fd9414-666c-11e9-95e2-00163e0a2622";

                        request.Method = "GET";
                        request.ContentType = "application/json;charset=utf-8";
                        request.Headers.Add("access_token", access_token);
                        request.Referer = "https://wine.ai-cross.com/home/index.html";             
                        request.Headers.Add("origin", origin);
                        request.Headers.Add("nb-enterprise-guid", nbenterpriseguid);
                        try
                        {
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            Stream myResponseStream = response.GetResponseStream();
                            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                            string retString = myStreamReader.ReadToEnd().ToString();                                                                       
                            if (!string.IsNullOrEmpty(retString))
                            {

                                var ss = getObjectByJson(retString);
                                id = ss[0].datas.id;
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
                                DateTime? create_time = Convert.ToDateTime(ss[0].datas.create_time);
                                String str4 = "INSERT INTO orderInfo([id],[order_buyer_regno],[order_buyer_name],[order_buyer_idcard] ,[order_consignee] ,[order_consignee_tel]," +
                                   "[order_consignee_addr],[order_actural_paid] ,[order_currency],[order_express_no],[order_express],[details],[url],[create_time])VALUES" +
                                   "('" + id + "','" + order_buyer_regno + "','" + order_buyer_name + "','" + order_buyer_idcard + "','" +
                                   order_consignee + "','" + order_consignee_tel + "','" + order_consignee_addr + "','" + order_actural_paid + "','" +
                                   order_currency + "','" + order_express_no + "','" + order_express + "','" + retString + "','" + URL + "','" + create_time + "')";
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
                for (int i = 1628; i < 1638; i++)
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
                for (int j= qishuj; j < qishuj + 10; j++)
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
                    request.ContentLength = 0;
                    request.Method = "POST";
                    request.ContentType = "application/json;charset=gb2312";
                    string retString=string.Empty;
                    StreamReader myStreamReader;
                    Stream stm;
                    //Stream myRequestStream = request.GetRequestStream();
                    //StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
                    // myStreamWriter.Close();
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();             
                        try
                        {
                            stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                            myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));
                            retString = myStreamReader.ReadToEnd();
                          
                        }
                        catch
                        {
                            stm = response.GetResponseStream();
                            myStreamReader = new StreamReader(stm, Encoding.GetEncoding("gb2312"));
                            retString = myStreamReader.ReadToEnd();
                          

                        }

                       

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
                            if (datetime>= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")))
                            {
                                return;
                            }

                            string sql6 = "SELECT dream FROM mengce where number=left('" + numbere + "',4)";
                            sqlconection r6 = new sqlconection();
                            DataTable d6 = new DataTable();
                            d6 = r6.ExecuteQuery(sql6);
                            string dream = d6.Rows[0]["dream"].ToString();




                            String str4 = "INSERT INTO pailiewu([id],[qishu],[Datetime],[number] ,[details],[dream],[url])VALUES('" + id + "','" + qishu + "','" + datetime + "','" + numbere + "','" + datails + "','" + dream + "','" + URL + "')";

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


