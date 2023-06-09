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

namespace DoAnCoSo.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PhongKhamDatabase")]
	public partial class LinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBACSI(BACSI instance);
    partial void UpdateBACSI(BACSI instance);
    partial void DeleteBACSI(BACSI instance);
    partial void InsertPHIEUHEN(PHIEUHEN instance);
    partial void UpdatePHIEUHEN(PHIEUHEN instance);
    partial void DeletePHIEUHEN(PHIEUHEN instance);
    partial void InsertKHOA(KHOA instance);
    partial void UpdateKHOA(KHOA instance);
    partial void DeleteKHOA(KHOA instance);
    #endregion
		
		public LinQDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PhongKhamDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BACSI> BACSIs
		{
			get
			{
				return this.GetTable<BACSI>();
			}
		}
		
		public System.Data.Linq.Table<PHIEUHEN> PHIEUHENs
		{
			get
			{
				return this.GetTable<PHIEUHEN>();
			}
		}
		
		public System.Data.Linq.Table<KHOA> KHOAs
		{
			get
			{
				return this.GetTable<KHOA>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BACSI")]
	public partial class BACSI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MABS;
		
		private string _HOTEN;
		
		private System.Nullable<System.DateTime> _NAMSINH;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private System.Nullable<int> _MAKHOA;
		
		private EntitySet<PHIEUHEN> _PHIEUHENs;
		
		private EntityRef<KHOA> _KHOA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMABSChanging(int value);
    partial void OnMABSChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNAMSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNAMSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnMAKHOAChanging(System.Nullable<int> value);
    partial void OnMAKHOAChanged();
    #endregion
		
		public BACSI()
		{
			this._PHIEUHENs = new EntitySet<PHIEUHEN>(new Action<PHIEUHEN>(this.attach_PHIEUHENs), new Action<PHIEUHEN>(this.detach_PHIEUHENs));
			this._KHOA = default(EntityRef<KHOA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MABS", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MABS
		{
			get
			{
				return this._MABS;
			}
			set
			{
				if ((this._MABS != value))
				{
					this.OnMABSChanging(value);
					this.SendPropertyChanging();
					this._MABS = value;
					this.SendPropertyChanged("MABS");
					this.OnMABSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(50)")]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMSINH", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> NAMSINH
		{
			get
			{
				return this._NAMSINH;
			}
			set
			{
				if ((this._NAMSINH != value))
				{
					this.OnNAMSINHChanging(value);
					this.SendPropertyChanging();
					this._NAMSINH = value;
					this.SendPropertyChanged("NAMSINH");
					this.OnNAMSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(200)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(20)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHOA", DbType="Int")]
		public System.Nullable<int> MAKHOA
		{
			get
			{
				return this._MAKHOA;
			}
			set
			{
				if ((this._MAKHOA != value))
				{
					if (this._KHOA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKHOAChanging(value);
					this.SendPropertyChanging();
					this._MAKHOA = value;
					this.SendPropertyChanged("MAKHOA");
					this.OnMAKHOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BACSI_PHIEUHEN", Storage="_PHIEUHENs", ThisKey="MABS", OtherKey="MABS")]
		public EntitySet<PHIEUHEN> PHIEUHENs
		{
			get
			{
				return this._PHIEUHENs;
			}
			set
			{
				this._PHIEUHENs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHOA_BACSI", Storage="_KHOA", ThisKey="MAKHOA", OtherKey="MAKHOA", IsForeignKey=true)]
		public KHOA KHOA
		{
			get
			{
				return this._KHOA.Entity;
			}
			set
			{
				KHOA previousValue = this._KHOA.Entity;
				if (((previousValue != value) 
							|| (this._KHOA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHOA.Entity = null;
						previousValue.BACSIs.Remove(this);
					}
					this._KHOA.Entity = value;
					if ((value != null))
					{
						value.BACSIs.Add(this);
						this._MAKHOA = value.MAKHOA;
					}
					else
					{
						this._MAKHOA = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHOA");
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
		
		private void attach_PHIEUHENs(PHIEUHEN entity)
		{
			this.SendPropertyChanging();
			entity.BACSI = this;
		}
		
		private void detach_PHIEUHENs(PHIEUHEN entity)
		{
			this.SendPropertyChanging();
			entity.BACSI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHIEUHEN")]
	public partial class PHIEUHEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAPHIEUHEN;
		
		private string _HOTEN;
		
		private System.Nullable<System.DateTime> _NAMSINH;
		
		private string _DIACHI;
		
		private string _NGHENGHIEP;
		
		private string _SDT;
		
		private System.Nullable<System.DateTime> _NGAYHEN;
		
		private System.Nullable<int> _MABS;
		
		private EntityRef<BACSI> _BACSI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHIEUHENChanging(int value);
    partial void OnMAPHIEUHENChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNAMSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNAMSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnNGHENGHIEPChanging(string value);
    partial void OnNGHENGHIEPChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnNGAYHENChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYHENChanged();
    partial void OnMABSChanging(System.Nullable<int> value);
    partial void OnMABSChanged();
    #endregion
		
		public PHIEUHEN()
		{
			this._BACSI = default(EntityRef<BACSI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHIEUHEN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAPHIEUHEN
		{
			get
			{
				return this._MAPHIEUHEN;
			}
			set
			{
				if ((this._MAPHIEUHEN != value))
				{
					this.OnMAPHIEUHENChanging(value);
					this.SendPropertyChanging();
					this._MAPHIEUHEN = value;
					this.SendPropertyChanged("MAPHIEUHEN");
					this.OnMAPHIEUHENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(50)")]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMSINH", DbType="DateTime")]
		public System.Nullable<System.DateTime> NAMSINH
		{
			get
			{
				return this._NAMSINH;
			}
			set
			{
				if ((this._NAMSINH != value))
				{
					this.OnNAMSINHChanging(value);
					this.SendPropertyChanging();
					this._NAMSINH = value;
					this.SendPropertyChanged("NAMSINH");
					this.OnNAMSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(200)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGHENGHIEP", DbType="NVarChar(50)")]
		public string NGHENGHIEP
		{
			get
			{
				return this._NGHENGHIEP;
			}
			set
			{
				if ((this._NGHENGHIEP != value))
				{
					this.OnNGHENGHIEPChanging(value);
					this.SendPropertyChanging();
					this._NGHENGHIEP = value;
					this.SendPropertyChanged("NGHENGHIEP");
					this.OnNGHENGHIEPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(20)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYHEN", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYHEN
		{
			get
			{
				return this._NGAYHEN;
			}
			set
			{
				if ((this._NGAYHEN != value))
				{
					this.OnNGAYHENChanging(value);
					this.SendPropertyChanging();
					this._NGAYHEN = value;
					this.SendPropertyChanged("NGAYHEN");
					this.OnNGAYHENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MABS", DbType="Int")]
		public System.Nullable<int> MABS
		{
			get
			{
				return this._MABS;
			}
			set
			{
				if ((this._MABS != value))
				{
					if (this._BACSI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMABSChanging(value);
					this.SendPropertyChanging();
					this._MABS = value;
					this.SendPropertyChanged("MABS");
					this.OnMABSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BACSI_PHIEUHEN", Storage="_BACSI", ThisKey="MABS", OtherKey="MABS", IsForeignKey=true)]
		public BACSI BACSI
		{
			get
			{
				return this._BACSI.Entity;
			}
			set
			{
				BACSI previousValue = this._BACSI.Entity;
				if (((previousValue != value) 
							|| (this._BACSI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BACSI.Entity = null;
						previousValue.PHIEUHENs.Remove(this);
					}
					this._BACSI.Entity = value;
					if ((value != null))
					{
						value.PHIEUHENs.Add(this);
						this._MABS = value.MABS;
					}
					else
					{
						this._MABS = default(Nullable<int>);
					}
					this.SendPropertyChanged("BACSI");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHOA")]
	public partial class KHOA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAKHOA;
		
		private string _TENKHOA;
		
		private EntitySet<BACSI> _BACSIs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHOAChanging(int value);
    partial void OnMAKHOAChanged();
    partial void OnTENKHOAChanging(string value);
    partial void OnTENKHOAChanged();
    #endregion
		
		public KHOA()
		{
			this._BACSIs = new EntitySet<BACSI>(new Action<BACSI>(this.attach_BACSIs), new Action<BACSI>(this.detach_BACSIs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHOA", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAKHOA
		{
			get
			{
				return this._MAKHOA;
			}
			set
			{
				if ((this._MAKHOA != value))
				{
					this.OnMAKHOAChanging(value);
					this.SendPropertyChanging();
					this._MAKHOA = value;
					this.SendPropertyChanged("MAKHOA");
					this.OnMAKHOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKHOA", DbType="NVarChar(50)")]
		public string TENKHOA
		{
			get
			{
				return this._TENKHOA;
			}
			set
			{
				if ((this._TENKHOA != value))
				{
					this.OnTENKHOAChanging(value);
					this.SendPropertyChanging();
					this._TENKHOA = value;
					this.SendPropertyChanged("TENKHOA");
					this.OnTENKHOAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHOA_BACSI", Storage="_BACSIs", ThisKey="MAKHOA", OtherKey="MAKHOA")]
		public EntitySet<BACSI> BACSIs
		{
			get
			{
				return this._BACSIs;
			}
			set
			{
				this._BACSIs.Assign(value);
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
		
		private void attach_BACSIs(BACSI entity)
		{
			this.SendPropertyChanging();
			entity.KHOA = this;
		}
		
		private void detach_BACSIs(BACSI entity)
		{
			this.SendPropertyChanging();
			entity.KHOA = null;
		}
	}
}
#pragma warning restore 1591
