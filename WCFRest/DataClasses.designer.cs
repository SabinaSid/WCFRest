﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFRest
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
    using System.Runtime.Serialization;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BlogDB")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    partial void InsertPostType(PostType instance);
    partial void UpdatePostType(PostType instance);
    partial void DeletePostType(PostType instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Post> Post
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		public System.Data.Linq.Table<PostType> PostType
		{
			get
			{
				return this.GetTable<PostType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Post")]
	
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private int _PostID;

		private string _PostHeader;

		private string _PostText;

		private short _PostTypeID;
		
		private EntityRef<PostType> _PostType;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnPostHeaderChanging(string value);
    partial void OnPostHeaderChanged();
    partial void OnPostTextChanging(string value);
    partial void OnPostTextChanged();
    partial void OnPostTypeIDChanging(short value);
    partial void OnPostTypeIDChanged();
    #endregion
		
		public Post()
		{
			this._PostType = default(EntityRef<PostType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostHeader", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string PostHeader
		{
			get
			{
				return this._PostHeader;
			}
			set
			{
				if ((this._PostHeader != value))
				{
					this.OnPostHeaderChanging(value);
					this.SendPropertyChanging();
					this._PostHeader = value;
					this.SendPropertyChanged("PostHeader");
					this.OnPostHeaderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostText", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PostText
		{
			get
			{
				return this._PostText;
			}
			set
			{
				if ((this._PostText != value))
				{
					this.OnPostTextChanging(value);
					this.SendPropertyChanging();
					this._PostText = value;
					this.SendPropertyChanged("PostText");
					this.OnPostTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeID", DbType="SmallInt NOT NULL")]
		public short PostTypeID
		{
			get
			{
				return this._PostTypeID;
			}
			set
			{
				if ((this._PostTypeID != value))
				{
					if (this._PostType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PostTypeID = value;
					this.SendPropertyChanged("PostTypeID");
					this.OnPostTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PostType_Post", Storage="_PostType", ThisKey="PostTypeID", OtherKey="PostTypeID", IsForeignKey=true)]
		public PostType PostType
		{
			get
			{
				return this._PostType.Entity;
			}
			set
			{
				PostType previousValue = this._PostType.Entity;
				if (((previousValue != value) 
							|| (this._PostType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PostType.Entity = null;
						previousValue.Post.Remove(this);
					}
					this._PostType.Entity = value;
					if ((value != null))
					{
						value.Post.Add(this);
						this._PostTypeID = value.PostTypeID;
					}
					else
					{
						this._PostTypeID = default(short);
					}
					this.SendPropertyChanged("PostType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PostType")]
	public partial class PostType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

		private short _PostTypeID;

		private string _PostTypeName;
		
		private EntitySet<Post> _Post;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostTypeIDChanging(short value);
    partial void OnPostTypeIDChanged();
    partial void OnPostTypeNameChanging(string value);
    partial void OnPostTypeNameChanged();
    #endregion
		
		public PostType()
		{
			this._Post = new EntitySet<Post>(new Action<Post>(this.attach_Post), new Action<Post>(this.detach_Post));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeID", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short PostTypeID
		{
			get
			{
				return this._PostTypeID;
			}
			set
			{
				if ((this._PostTypeID != value))
				{
					this.OnPostTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PostTypeID = value;
					this.SendPropertyChanged("PostTypeID");
					this.OnPostTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PostTypeName
		{
			get
			{
				return this._PostTypeName;
			}
			set
			{
				if ((this._PostTypeName != value))
				{
					this.OnPostTypeNameChanging(value);
					this.SendPropertyChanging();
					this._PostTypeName = value;
					this.SendPropertyChanged("PostTypeName");
					this.OnPostTypeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PostType_Post", Storage="_Post", ThisKey="PostTypeID", OtherKey="PostTypeID")]
		public EntitySet<Post> Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				this._Post.Assign(value);
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
		
		private void attach_Post(Post entity)
		{
			this.SendPropertyChanging();
			entity.PostType = this;
		}
		
		private void detach_Post(Post entity)
		{
			this.SendPropertyChanging();
			entity.PostType = null;
		}
	}
}
#pragma warning restore 1591
