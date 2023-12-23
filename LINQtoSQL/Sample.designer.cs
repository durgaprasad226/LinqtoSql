﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQtoSQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinqtoSQL")]
	public partial class SampleDataContext : System.Data.Linq.DataContext
	{
        public SampleDataContext() : base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LinqtoSQLConnectionString"].ConnectionString)
        {
            OnCreated();
        }

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    #endregion
		
		public SampleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		private void InsertEmployee(Employee obj)
		{
			this.InsertEmployees(obj.EmpName, obj.Gender, ((System.Nullable<int>)(obj.Salary)), ((System.Nullable<int>)(obj.DeptId)));
		}
		
		private void UpdateEmployee(Employee obj)
		{
			this.UpdateEmployee(((System.Nullable<int>)(obj.EmpId)), obj.EmpName, obj.Gender, ((System.Nullable<int>)(obj.Salary)), ((System.Nullable<int>)(obj.DeptId)));
		}
		
		private void DeleteEmployee(Employee obj)
		{
			this.DeleteEmployee(((System.Nullable<int>)(obj.EmpId)));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployees")]
		public ISingleResult<Employee> GetEmployees()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Employee>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteEmployee")]
		public int DeleteEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpId", DbType="Int")] System.Nullable<int> empId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmployees")]
		public int InsertEmployees([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpName", DbType="NVarChar(50)")] string empName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeptId", DbType="Int")] System.Nullable<int> deptId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empName, gender, salary, deptId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateEmployee")]
		public int UpdateEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpId", DbType="Int")] System.Nullable<int> empId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpName", DbType="NVarChar(50)")] string empName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeptId", DbType="Int")] System.Nullable<int> deptId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empId, empName, gender, salary, deptId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployeesByDept")]
		public ISingleResult<GetEmployeesByDeptResult> GetEmployeesByDept([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeptId", DbType="Int")] System.Nullable<int> deptId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(50)")] ref string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), deptId, name);
			name = ((string)(result.GetParameterValue(1)));
			return ((ISingleResult<GetEmployeesByDeptResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptId;
		
		private string _Name;
		
		private string _Location;
		
		private EntityRef<Department> _Department2;
		
		private EntitySet<Employee> _Employees;
		
		private EntityRef<Department> _Department1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
		
		public Department()
		{
			this._Department2 = default(EntityRef<Department>);
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			this._Department1 = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					if (this._Department1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Department", Storage="_Department2", ThisKey="DeptId", OtherKey="DeptId", IsUnique=true, IsForeignKey=false)]
		public Department Department2
		{
			get
			{
				return this._Department2.Entity;
			}
			set
			{
				Department previousValue = this._Department2.Entity;
				if (((previousValue != value) 
							|| (this._Department2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department2.Entity = null;
						previousValue.Department1 = null;
					}
					this._Department2.Entity = value;
					if ((value != null))
					{
						value.Department1 = this;
					}
					this.SendPropertyChanged("Department2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="DeptId", OtherKey="DeptId")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Department", Storage="_Department1", ThisKey="DeptId", OtherKey="DeptId", IsForeignKey=true)]
		public Department Department1
		{
			get
			{
				return this._Department1.Entity;
			}
			set
			{
				Department previousValue = this._Department1.Entity;
				if (((previousValue != value) 
							|| (this._Department1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department1.Entity = null;
						previousValue.Department2 = null;
					}
					this._Department1.Entity = value;
					if ((value != null))
					{
						value.Department2 = this;
						this._DeptId = value.DeptId;
					}
					else
					{
						this._DeptId = default(int);
					}
					this.SendPropertyChanged("Department1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private string _EmpName;
		
		private string _Gender;
		
		private int _Salary;
		
		private int _DeptId;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnSalaryChanging(int value);
    partial void OnSalaryChanged();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    #endregion
		
		public Employee()
		{
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL")]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="DeptId", OtherKey="DeptId", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DeptId = value.DeptId;
					}
					else
					{
						this._DeptId = default(int);
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class GetEmployeesByDeptResult
	{
		
		private int _EmpId;
		
		private string _EmpName;
		
		private string _Gender;
		
		private int _Salary;
		
		private int _DeptId;
		
		public GetEmployeesByDeptResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this._EmpName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL")]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this._DeptId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
