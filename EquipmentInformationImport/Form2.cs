using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EquipmentInformationImport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowser = new FolderBrowserDialog();

            if(folderbrowser.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderbrowser.SelectedPath;
                DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text);
                FileSystemInfo[] finfo = dinfo.GetFileSystemInfos();
                listBox1.Items.AddRange(finfo);
                label3.Text="文件夹中文件列表(" + listBox1.Items.Count+"项)";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "您选择的是：";
            for(int i=0 ;i<listBox1.SelectedItems.Count ;i++)
            {
                label4.Text += listBox1.SelectedItems[i] + "·";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
