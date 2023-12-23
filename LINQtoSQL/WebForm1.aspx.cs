using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQtoSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
         /*private void GetData()
         {
            SampleDataContext sdc = new SampleDataContext();
            //sdc.Log = Response.Output;
            //sdc.Log = Console.Out;
            var linqQuery = from employee in sdc.Employees
                            select employee;
            *//*string sqlQuery= linqQuery.ToString();
            Response.Write(sqlQuery);*//*
            Response.Write(sdc.GetCommand(linqQuery).CommandText);
            GridView1.DataSource = linqQuery;
            GridView1.DataBind();
         }*/
        private void GetData()
        {
            SampleDataContext sdc=new SampleDataContext();
            GridView1.DataSource=sdc.GetEmployees();
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using(SampleDataContext sdc= new SampleDataContext())
            {
                Employee emp = new Employee
                {
                    EmpName = "Mahesh",
                    Gender="Male",
                    Salary=3000,
                    DeptId=2
                };
                sdc.Employees.InsertOnSubmit(emp);
                sdc.SubmitChanges();
            }
            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using(var sdc=new  SampleDataContext())
            {
                Employee emp=sdc.Employees.FirstOrDefault(x=>x.EmpId==1);
                emp.Salary = 30000;
                sdc.SubmitChanges();
            }
            GetData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using(var sdc=new SampleDataContext())
            {
                Employee emp=sdc.Employees.FirstOrDefault(x=>x.EmpId == 7);
                sdc.Employees.DeleteOnSubmit(emp);
                sdc.SubmitChanges();
            }
            GetData();
        }

        protected void btnGetEmployeeByDept_Click(object sender, EventArgs e)
        {
            using(SampleDataContext sdc=new SampleDataContext())
            {
                string deptName=string.Empty;
                GridView1.DataSource = sdc.GetEmployeesByDept(3, ref deptName);
                GridView1.DataBind();

                lblDept.Text="Department Name = " + deptName;
            }
        }
    }
}