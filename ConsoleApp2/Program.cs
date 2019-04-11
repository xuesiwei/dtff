
using HtmlAgilityPack;
using mshtml;
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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        private static long _totalTimeCost = 0;
        private static int _endedConnenctionCount = 0;
        private static int _failedConnectionCount = 0;


        static void Main(string[] args)
        {
            //HttpHeader header = new HttpHeader();
            //header.accept = "text/html; charset=gb2312";
            //header.contentType = "application/json;charset=utf-8";
            //header.method = "POST";
            //header.userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763";
            //header.maxTry = 300;

            //string html = HTMLHelper.GetHtml("http://kaijiang.500.com/shtml/qxc/04102.shtml", HTMLHelper.GetCooKie("http://kaijiang.500.com/shtml/qxc/04102.shtml",
            //    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763", header), header);

            //Console.WriteLine(html);


            //Console.ReadLine();







            Program cc = new Program();
            int a = 0;
           // SendRequestlichul();
            //SendRequestmengceproyIP();
            SendRequest();
            // SendRequestproy();
            // SendRequestplw();
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
                ThreadPool.QueueUserWorkItem(u => SendRequest());
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
                string sql3 = "select top 400 left(number,4) as number,url from pailiewu order by Datetime desc ";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                var rowssm = d3.Rows.Cast<DataRow>().Select(x => new { a = x.Field<string>("number"),b = x.Field<string>("url")});
                List<int> mList = new List<int>();
                var exce = new List<int>();
                List<int> mList100 = new List<int>();
                for(int i=0;i<100;i++ )
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
                        Console.WriteLine("{0},{1}",item.a,item.b);                    }
                }

                foreach (var str1 in mList100)
                {
                    if (!mList.Contains(str1))
                    {
                        exce.Add(str1);
                    }
                    else
                    {
                        continue;
                    }
                }

             
            }

            catch (Exception ex)
            {
                // IncreaseFailedConnection();
            }        

        }
        private static void SendRequest()

        {
            try
            {    string ur = string.Empty;
                string sql3 = "select MAX(id) as id ,max(qishu) as qishu from qixingcai";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]);   
                int qishuj = Convert.ToInt16(d3.Rows[0]["qishu"]);
                for (int j = qishuj; j <qishuj+1; j++)
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
                            myStreamReader.Close();
                            stm.Close();





                            String str4 = "INSERT INTO qixingcai([id],[qishu],[Datetime],[number] ,[details],[dream])VALUES('" + id + "','" + qishu + "','" + datetime + "','" + numbere + "','" + datails + "','" + ' ' + "')";

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
                for (int j= qishuj; j <qishuj+1; j++)
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


