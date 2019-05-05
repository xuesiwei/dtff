
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Log
{
    /// <summary>
    /// 继承TraceListener
    /// (1)必须要重写的方法void Write(string message);void WriteLine(string message);
    /// (2)子类方法重写必须和父类方法返回值、参数列表完全相同
    /// </summary>
    public class Log1 : TraceListener
    {
        private string m_fileName; // 文件名
        private string m_filePath; // 文件路径
        public string FileFullPath
        {
            get
            {
                if (Directory.Exists(m_filePath) == false)
                {
                    Directory.CreateDirectory(m_filePath);
                }
                return m_filePath.TrimEnd('/') + "/" + m_fileName;
            }
        }

        public Log1()
        {
            m_fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt"; // 默认文件名为 今天的日期
            m_filePath = AppDomain.CurrentDomain.BaseDirectory + "/log";  // 默认路径在当前域log文件夹下面     
        }
        public Log1(string sFileName)
        {
            m_fileName = sFileName;
            m_filePath = AppDomain.CurrentDomain.BaseDirectory + "/log";  //默认路径在当前域log文件夹下面 
        }
        public override void Write(string message)
        {
            WriteLine(message);
        }
        /// <summary>
        /// 将异常或信息写入日志
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public override void WriteLine(string message)
        {
            string sMsg = Environment.NewLine ;
            if (!string.IsNullOrEmpty(message))  //如果信息不为空，加在最前面
            {
                sMsg += message;
            }         
            File.AppendAllText(FileFullPath, sMsg);
        }

    }
}