using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1 != null)
            {
                label4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                checkBox8.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1 != null)
            {
                label3.Visible  = true;
                checkBox1.Visible  = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1 != null)
            {
                label3.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            label5.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            MessageBox.Show("请认真填写！");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1 != null)
            {
                label4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                checkBox8.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1 != null)
            {
                label4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                checkBox8.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1 != null)
            {
                MessageBox.Show("请你们不想将你们肮脏的思想 玷污了我们的学院！");
                this.Visible = false;
                
                
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5 !=null)
            {
                MessageBox.Show("“你也许属于格兰芬多，那里有埋藏在心底的勇敢，他们的胆识、气魄和豪爽，使格兰芬多出类拔萃 ”","格兰芬多");
            }
            button1.Visible = true;
            button2.Visible = true;

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7 != null)
            {
                MessageBox.Show("“你也许属于赫奇帕奇，那里的人正直忠诚，赫奇帕奇的学子们坚忍诚实，不畏惧艰辛的劳动 ”","赫奇帕奇");
            }
            button1.Visible = true;
            button2.Visible = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6 != null)
            { 
                MessageBox.Show("“如果你头脑精明，或许会进智慧的老拉文劳克，那些睿智博学的人，总会在那里遇见他们的同道 ”", "拉文劳克");
            }
            button1.Visible = true;
            button2.Visible = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8 != null)
            {
                MessageBox.Show("“也许你会进斯莱特林，也许你在这里交上真诚的朋友，但那些狡诈阴险之辈却会不惜一切手段，去达到他们的目的 ”", "斯莱特林");
            }
            button1.Visible = true;
            button2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox .Show ("我们愉快的通知您，您已获准在霍格沃茨魔法学校就读。随信附上所需书籍及装备一览表。学期定于九月一日开始。我们将于七月三十一日前静后您的猫头鹰带来您的回信。校长：阿不思·邓不利多");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我很抱歉我的孩子！但是我们尊重你的选择。");
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                label6.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }
    }
}
