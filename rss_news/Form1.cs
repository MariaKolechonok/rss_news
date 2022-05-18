using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace rss_news
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void read_button_Click(object sender, EventArgs e)
        {
            string url = link_textBox.Text;
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                String subject = item.Title.Text;
                String summary = item.Summary.Text;
                //Console.WriteLine(subject + " " + summary);
                textout_richTextBox.AppendText(subject + ". " + summary + Environment.NewLine + Environment.NewLine);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
