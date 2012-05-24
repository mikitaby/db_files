using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DB_project
{
    public partial class Form1 : Form
    {
        string pathForTestDirectory = Application.StartupPath.ToString() + @"\test_cf";
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            addFile("yoyoyo", 111);         
        }

        private void btnGetElement_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getElementById(10));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            dataGridView1.DataSource = (new DataClassesDataContext()).tblFiles;
        }

        private string getElementById(int index) 
        {
            tblFile fileInBase = (new DataClassesDataContext()).tblFiles.First(x => x.id == index);
            return fileInBase.path.Trim();            
        }

        private void addFile(string aPath, long aSize)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            tblFile newFile = new tblFile
            {
                path = aPath,
                size = aSize
            };

            dc.tblFiles.InsertOnSubmit(newFile);

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnProcessDirectory_Click(object sender, EventArgs e)
        {
            addFilesFromDirectoryToBase();
            refreshGrid();
        }

        private void addFilesFromDirectoryToBase()
        {
            DirectoryInfo di = new DirectoryInfo(pathForTestDirectory);
            foreach (FileInfo fi in di.GetFiles()) 
            {
                addFile(fi.FullName, fi.Length);                
            }             
        }
    }
}
