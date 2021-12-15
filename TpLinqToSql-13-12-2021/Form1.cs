using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Linq;

namespace TpLinqToSql_13_12_2021
{
    public partial class LinqToSql : Form
    {
        public LinqToSql()
        {
            InitializeComponent();
        }
        CompanyDBDataContext db = new CompanyDBDataContext();
        
        //Table<Employee> emp;
        e

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            //emp=db.GetTable<Employee>();



            var reqSelect = (from jobs in db.Employees select jobs.Job).Distinct();

          

            //comboBox1.DataSource = db.Employees.ToList();
            //comboBox1.DisplayMember = "Job";
            //comboBox1.ValueMember = "Job";


            //Method 1 and the best one 


            comboBox1.DataSource=reqSelect;
            



            
        }

        private void btnOrderSalire_Click(object sender, EventArgs e)
        {
            var reqOrder = from emp in db.Employees
                           orderby emp.Salary ascending
                           select emp;
            
            dataGridView1.DataSource=reqOrder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reqOrderbyName = from emp in db.Employees
                           orderby emp.EmpName descending
                           select emp;
            dataGridView1.DataSource = reqOrderbyName;
        }
        List<string> liststr;
        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = string.Empty ;
            foreach (string strcheck in checkedListBox1.CheckedItems)
            {
                liststr.Add(strcheck);
            }
            for(int i = 0; i < liststr.Count - 2; i++)
            {
                str1 += "emp." + liststr[i] + ",";
            }
            str1+="emp."+liststr[liststr.Count - 1];
            Object obj=new Object();
            obj = str1.Replace("\"",""); 

            var reqSelectedColumns = from emp in db.Employees
                                     select obj;
                                    
            dataGridView1.DataSource = reqSelectedColumns;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var reqGroupjob = from job in db.Employees
                     group job by job.Job into grpJob
                     select new { Job = grpJob.Key, NbrEmployess = grpJob.Count() };

            dataGridView1.DataSource= reqGroupjob;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void button5_Click(object sender, EventArgs e)
        {

            var pl = from empDep in db.Employees
                     group empDep by empDep.DeptNO into grpdep
                     select new { deptno = grpdep.Key, Nbrdep = grpdep.Count() };

            dataGridView1.DataSource = pl;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var reqGroupjob = from job in db.Employees
                              group job by job.DeptNO into grpJob
                              where grpJob.Count() >=5
                              
                              select new { dep = grpJob.Key, NbrEmployess = grpJob.Count() };

            dataGridView1.DataSource = reqGroupjob;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            var selectbyJob = from emp in db.Employees
                              where emp.Job == comboBox1.SelectedValue.ToString()
                              select emp;



            dataGridView1.DataSource = selectbyJob;
        }
         
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reqGroupjob = from job in db.Employees
                              group job by job.Job into grpJob
                              where grpJob.Count() < 5
                              select new { Job = grpJob.Key, NbrEmployess = grpJob.Count() };

            dataGridView1.DataSource = reqGroupjob;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
