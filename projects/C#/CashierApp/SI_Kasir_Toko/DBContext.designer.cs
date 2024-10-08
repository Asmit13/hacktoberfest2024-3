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

namespace SI_Kasir_Toko
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SI_KASIR_PBO")]
	public partial class DBContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBarang(Barang instance);
    partial void UpdateBarang(Barang instance);
    partial void DeleteBarang(Barang instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    partial void InsertSupplier(Supplier instance);
    partial void UpdateSupplier(Supplier instance);
    partial void DeleteSupplier(Supplier instance);
    partial void InsertBarcode2(Barcode2 instance);
    partial void UpdateBarcode2(Barcode2 instance);
    partial void DeleteBarcode2(Barcode2 instance);
    #endregion
		
		public DBContextDataContext() : 
				base(global::SI_Kasir_Toko.Properties.Settings.Default.SI_KASIR_PBOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Barang> Barangs
		{
			get
			{
				return this.GetTable<Barang>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
		
		public System.Data.Linq.Table<Supplier> Suppliers
		{
			get
			{
				return this.GetTable<Supplier>();
			}
		}
		
		public System.Data.Linq.Table<Barcode2> Barcode2s
		{
			get
			{
				return this.GetTable<Barcode2>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Barang")]
	public partial class Barang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NamaBarang;
		
		private int _HargaBarang;
		
		private int _StokBarang;
		
		private System.DateTime _DataMasuk;
		
		private EntitySet<Transaction> _Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNamaBarangChanging(string value);
    partial void OnNamaBarangChanged();
    partial void OnHargaBarangChanging(int value);
    partial void OnHargaBarangChanged();
    partial void OnStokBarangChanging(int value);
    partial void OnStokBarangChanged();
    partial void OnDataMasukChanging(System.DateTime value);
    partial void OnDataMasukChanged();
    #endregion
		
		public Barang()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamaBarang", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string NamaBarang
		{
			get
			{
				return this._NamaBarang;
			}
			set
			{
				if ((this._NamaBarang != value))
				{
					this.OnNamaBarangChanging(value);
					this.SendPropertyChanging();
					this._NamaBarang = value;
					this.SendPropertyChanged("NamaBarang");
					this.OnNamaBarangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HargaBarang", DbType="Int NOT NULL")]
		public int HargaBarang
		{
			get
			{
				return this._HargaBarang;
			}
			set
			{
				if ((this._HargaBarang != value))
				{
					this.OnHargaBarangChanging(value);
					this.SendPropertyChanging();
					this._HargaBarang = value;
					this.SendPropertyChanged("HargaBarang");
					this.OnHargaBarangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StokBarang", DbType="Int NOT NULL")]
		public int StokBarang
		{
			get
			{
				return this._StokBarang;
			}
			set
			{
				if ((this._StokBarang != value))
				{
					this.OnStokBarangChanging(value);
					this.SendPropertyChanging();
					this._StokBarang = value;
					this.SendPropertyChanged("StokBarang");
					this.OnStokBarangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataMasuk", DbType="DateTime NOT NULL")]
		public System.DateTime DataMasuk
		{
			get
			{
				return this._DataMasuk;
			}
			set
			{
				if ((this._DataMasuk != value))
				{
					this.OnDataMasukChanging(value);
					this.SendPropertyChanging();
					this._DataMasuk = value;
					this.SendPropertyChanged("DataMasuk");
					this.OnDataMasukChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Barang_Transaction", Storage="_Transactions", ThisKey="ID", OtherKey="IDBarang")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Barang = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Barang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Password;
		
		private bool _Role;
		
		private string _Fullname;
		
		private string _Email;
		
		private string _Alamat;
		
		private System.DateTime _MasukAt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(bool value);
    partial void OnRoleChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAlamatChanging(string value);
    partial void OnAlamatChanged();
    partial void OnMasukAtChanging(System.DateTime value);
    partial void OnMasukAtChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="Bit NOT NULL")]
		public bool Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alamat", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Alamat
		{
			get
			{
				return this._Alamat;
			}
			set
			{
				if ((this._Alamat != value))
				{
					this.OnAlamatChanging(value);
					this.SendPropertyChanging();
					this._Alamat = value;
					this.SendPropertyChanged("Alamat");
					this.OnAlamatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MasukAt", DbType="DateTime NOT NULL")]
		public System.DateTime MasukAt
		{
			get
			{
				return this._MasukAt;
			}
			set
			{
				if ((this._MasukAt != value))
				{
					this.OnMasukAtChanging(value);
					this.SendPropertyChanging();
					this._MasukAt = value;
					this.SendPropertyChanged("MasukAt");
					this.OnMasukAtChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _IDBarang;
		
		private int _JumlahTransaksi;
		
		private int _TotalHarga;
		
		private System.DateTime _TransaksiAt;
		
		private EntityRef<Barang> _Barang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIDBarangChanging(int value);
    partial void OnIDBarangChanged();
    partial void OnJumlahTransaksiChanging(int value);
    partial void OnJumlahTransaksiChanged();
    partial void OnTotalHargaChanging(int value);
    partial void OnTotalHargaChanged();
    partial void OnTransaksiAtChanging(System.DateTime value);
    partial void OnTransaksiAtChanged();
    #endregion
		
		public Transaction()
		{
			this._Barang = default(EntityRef<Barang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBarang", DbType="Int NOT NULL")]
		public int IDBarang
		{
			get
			{
				return this._IDBarang;
			}
			set
			{
				if ((this._IDBarang != value))
				{
					if (this._Barang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBarangChanging(value);
					this.SendPropertyChanging();
					this._IDBarang = value;
					this.SendPropertyChanged("IDBarang");
					this.OnIDBarangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JumlahTransaksi", DbType="Int NOT NULL")]
		public int JumlahTransaksi
		{
			get
			{
				return this._JumlahTransaksi;
			}
			set
			{
				if ((this._JumlahTransaksi != value))
				{
					this.OnJumlahTransaksiChanging(value);
					this.SendPropertyChanging();
					this._JumlahTransaksi = value;
					this.SendPropertyChanged("JumlahTransaksi");
					this.OnJumlahTransaksiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalHarga", DbType="Int NOT NULL")]
		public int TotalHarga
		{
			get
			{
				return this._TotalHarga;
			}
			set
			{
				if ((this._TotalHarga != value))
				{
					this.OnTotalHargaChanging(value);
					this.SendPropertyChanging();
					this._TotalHarga = value;
					this.SendPropertyChanged("TotalHarga");
					this.OnTotalHargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransaksiAt", DbType="DateTime NOT NULL")]
		public System.DateTime TransaksiAt
		{
			get
			{
				return this._TransaksiAt;
			}
			set
			{
				if ((this._TransaksiAt != value))
				{
					this.OnTransaksiAtChanging(value);
					this.SendPropertyChanging();
					this._TransaksiAt = value;
					this.SendPropertyChanged("TransaksiAt");
					this.OnTransaksiAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Barang_Transaction", Storage="_Barang", ThisKey="IDBarang", OtherKey="ID", IsForeignKey=true)]
		public Barang Barang
		{
			get
			{
				return this._Barang.Entity;
			}
			set
			{
				Barang previousValue = this._Barang.Entity;
				if (((previousValue != value) 
							|| (this._Barang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Barang.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Barang.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._IDBarang = value.ID;
					}
					else
					{
						this._IDBarang = default(int);
					}
					this.SendPropertyChanged("Barang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Supplier")]
	public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeSupplier;
		
		private string _NamaSupplier;
		
		private int _Telephone;
		
		private string _Alamat;
		
		private int _NoRekening;
		
		private string _NPWP;
		
		private string _Kota;
		
		private string _Negara;
		
		private string _Provinsi;
		
		private int _KodePos;
		
		private int _Fax;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeSupplierChanging(int value);
    partial void OnCodeSupplierChanged();
    partial void OnNamaSupplierChanging(string value);
    partial void OnNamaSupplierChanged();
    partial void OnTelephoneChanging(int value);
    partial void OnTelephoneChanged();
    partial void OnAlamatChanging(string value);
    partial void OnAlamatChanged();
    partial void OnNoRekeningChanging(int value);
    partial void OnNoRekeningChanged();
    partial void OnNPWPChanging(string value);
    partial void OnNPWPChanged();
    partial void OnKotaChanging(string value);
    partial void OnKotaChanged();
    partial void OnNegaraChanging(string value);
    partial void OnNegaraChanged();
    partial void OnProvinsiChanging(string value);
    partial void OnProvinsiChanged();
    partial void OnKodePosChanging(int value);
    partial void OnKodePosChanged();
    partial void OnFaxChanging(int value);
    partial void OnFaxChanged();
    #endregion
		
		public Supplier()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeSupplier", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeSupplier
		{
			get
			{
				return this._CodeSupplier;
			}
			set
			{
				if ((this._CodeSupplier != value))
				{
					this.OnCodeSupplierChanging(value);
					this.SendPropertyChanging();
					this._CodeSupplier = value;
					this.SendPropertyChanged("CodeSupplier");
					this.OnCodeSupplierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamaSupplier", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string NamaSupplier
		{
			get
			{
				return this._NamaSupplier;
			}
			set
			{
				if ((this._NamaSupplier != value))
				{
					this.OnNamaSupplierChanging(value);
					this.SendPropertyChanging();
					this._NamaSupplier = value;
					this.SendPropertyChanged("NamaSupplier");
					this.OnNamaSupplierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="Int NOT NULL")]
		public int Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alamat", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Alamat
		{
			get
			{
				return this._Alamat;
			}
			set
			{
				if ((this._Alamat != value))
				{
					this.OnAlamatChanging(value);
					this.SendPropertyChanging();
					this._Alamat = value;
					this.SendPropertyChanged("Alamat");
					this.OnAlamatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoRekening", DbType="Int NOT NULL")]
		public int NoRekening
		{
			get
			{
				return this._NoRekening;
			}
			set
			{
				if ((this._NoRekening != value))
				{
					this.OnNoRekeningChanging(value);
					this.SendPropertyChanging();
					this._NoRekening = value;
					this.SendPropertyChanged("NoRekening");
					this.OnNoRekeningChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NPWP", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string NPWP
		{
			get
			{
				return this._NPWP;
			}
			set
			{
				if ((this._NPWP != value))
				{
					this.OnNPWPChanging(value);
					this.SendPropertyChanging();
					this._NPWP = value;
					this.SendPropertyChanged("NPWP");
					this.OnNPWPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kota", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Kota
		{
			get
			{
				return this._Kota;
			}
			set
			{
				if ((this._Kota != value))
				{
					this.OnKotaChanging(value);
					this.SendPropertyChanging();
					this._Kota = value;
					this.SendPropertyChanged("Kota");
					this.OnKotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Negara", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Negara
		{
			get
			{
				return this._Negara;
			}
			set
			{
				if ((this._Negara != value))
				{
					this.OnNegaraChanging(value);
					this.SendPropertyChanging();
					this._Negara = value;
					this.SendPropertyChanged("Negara");
					this.OnNegaraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provinsi", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Provinsi
		{
			get
			{
				return this._Provinsi;
			}
			set
			{
				if ((this._Provinsi != value))
				{
					this.OnProvinsiChanging(value);
					this.SendPropertyChanging();
					this._Provinsi = value;
					this.SendPropertyChanged("Provinsi");
					this.OnProvinsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KodePos", DbType="Int NOT NULL")]
		public int KodePos
		{
			get
			{
				return this._KodePos;
			}
			set
			{
				if ((this._KodePos != value))
				{
					this.OnKodePosChanging(value);
					this.SendPropertyChanging();
					this._KodePos = value;
					this.SendPropertyChanged("KodePos");
					this.OnKodePosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="Int NOT NULL")]
		public int Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Barcode2")]
	public partial class Barcode2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _BarcodeID;
		
		private string _Nama;
		
		private System.Nullable<int> _Stok;
		
		private System.Nullable<int> _Harga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBarcodeIDChanging(long value);
    partial void OnBarcodeIDChanged();
    partial void OnNamaChanging(string value);
    partial void OnNamaChanged();
    partial void OnStokChanging(System.Nullable<int> value);
    partial void OnStokChanged();
    partial void OnHargaChanging(System.Nullable<int> value);
    partial void OnHargaChanged();
    #endregion
		
		public Barcode2()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BarcodeID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long BarcodeID
		{
			get
			{
				return this._BarcodeID;
			}
			set
			{
				if ((this._BarcodeID != value))
				{
					this.OnBarcodeIDChanging(value);
					this.SendPropertyChanging();
					this._BarcodeID = value;
					this.SendPropertyChanged("BarcodeID");
					this.OnBarcodeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nama", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nama
		{
			get
			{
				return this._Nama;
			}
			set
			{
				if ((this._Nama != value))
				{
					this.OnNamaChanging(value);
					this.SendPropertyChanging();
					this._Nama = value;
					this.SendPropertyChanged("Nama");
					this.OnNamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stok", DbType="Int")]
		public System.Nullable<int> Stok
		{
			get
			{
				return this._Stok;
			}
			set
			{
				if ((this._Stok != value))
				{
					this.OnStokChanging(value);
					this.SendPropertyChanging();
					this._Stok = value;
					this.SendPropertyChanged("Stok");
					this.OnStokChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Harga", DbType="Int")]
		public System.Nullable<int> Harga
		{
			get
			{
				return this._Harga;
			}
			set
			{
				if ((this._Harga != value))
				{
					this.OnHargaChanging(value);
					this.SendPropertyChanging();
					this._Harga = value;
					this.SendPropertyChanged("Harga");
					this.OnHargaChanged();
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
}
#pragma warning restore 1591