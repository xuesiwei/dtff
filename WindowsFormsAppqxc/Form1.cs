using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppqxc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxyuan.Text = "1:8900";
            textBoxMember.Text = "wz1688";
            textBoxCode.Text = "4181";
            textBoxqishu.Text = "19054";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> mListqb = new List<string>();
            List<string> mListqbs = new List<string>();
            List<string> mListqbsg = new List<string>();
            List<string> mexList = new List<string>();
            foreach (var itqian in textBoxhousand.Text)
            {

                foreach (var itbai in textBoxhundred.Text)
                {

                    string qb = itqian.ToString() + itbai;


                    mListqb.Add(qb);
                }
            }
            foreach (var itshi in textBoxten.Text)
            {

                foreach (var itqbs in mListqb)
                {
                    string qbs = itqbs + itshi;
                    mListqbs.Add(qbs);
                }
            }
            foreach (var itge in textBoxge.Text)
            {

                foreach (var itgege in mListqbs)
                {
                    string qbsg = itgege + itge;
                    mListqbsg.Add(qbsg);
                }

            }
            foreach(var item in mListqbsg)
            {

            }
            string strArraynumber = string.Join("\n", mListqbsg);
            richTextBox1.Text = strArraynumber;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                string sql3 = "select MAX(id) as id from qixingcai_dj";
                sqlconection r3 = new sqlconection();
                DataTable d3 = new DataTable();
                d3 = r3.ExecuteQuery(sql3);
                int id = Convert.ToInt16(d3.Rows[0]["id"]) + 1;
                DateTime dateTime = DateTime.Now;
                string Member = textBoxMember.Text;
                string Code = textBoxCode.Text;
                Random random = new Random();
                int n1 = random.Next(1000, 9999);
                int n2 = random.Next(1000, 9999);
                int n3 = random.Next(1000, 9999);
                int n6 = random.Next(10, 20);
                string code = Code + n1 + n2 + n3 + n6;
                string Odds = textBoxyuan.Text;
                int Money = Convert.ToInt32(textBoxmoney.Text.ToString());
                string number = richTextBox1.Text;
                string qishu = textBoxqishu.Text;
                string[] strnumber = number.Split('\n');
                foreach (var item in strnumber)
                {

                    String str4 = "INSERT INTO qixingcai_dj([id],[Datetime],[Member] ,[Code],[Odds],[Money],[number],[qishu])VALUES('" + id + "','" + dateTime + "','" + Member + "','" + code + "','" + Odds + "','" + Money + "','" + item + "','" + qishu + "')";
                    int d2 = r3.ExecuteUpdate(str4);//执行后会有返回值，是int类型，如果执行失败会返回0；
                    id++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void buttonbaoma_Click(object sender, EventArgs e)
        {
            string number = richTextBox2.Text;
            string[] strnumber = number.Split('\n');
            char[] str1 = strnumber[0].ToCharArray();
            var listr = str1.Select(d => d.ToString()).ToList();     
            string[] strnumber2;         
            strnumber2 = listr.ToArray();
            List<string> list = Route(str1.Length, ref strnumber2);
            List<string> exist = new List<string>();
            foreach(var item in list)
            {    if (!exist.Contains(item))
                {
                    exist.Add(item);
                }
                else
                {
                    continue;
                }
            }
            string strArraynumber = string.Join("\n", exist);

            richTextBox3.Text= strArraynumber;
        }
        public static List<string> Route(int count, ref string[] str)
        {
            if (count > 1)
            {
                List<string> list = Route(count - 1, ref str);
                List<string> newList = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        newList.Add(list[j].Insert(i, str[count - 1]));
                    }
                }
                return newList;
            }
            else
            {
                return new List<string>() { str[0] };
            }
        }
    }
}


