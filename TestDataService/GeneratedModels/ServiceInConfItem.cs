using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceInConfItem")]
	public class ServiceInConfItem : BaseEntity
	{
		#region Values
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _DependencyCategoryId;
		[CProperty(ColumnPath ="DependencyCategoryId")]
		public Guid DependencyCategoryId
		{
			get{return _DependencyCategoryId;}
			set
			{
				_DependencyCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DependencyTypeId;
		[CProperty(ColumnPath ="DependencyTypeId")]
		public Guid DependencyTypeId
		{
			get{return _DependencyTypeId;}
			set
			{
				_DependencyTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceItemId;
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId
		{
			get{return _ServiceItemId;}
			set
			{
				_ServiceItemId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DependencyCategory:DependencyCategoryId")]
		public DependencyCategory DependencyCategory { get; set; }
		[CProperty(Navigation ="DependencyType:DependencyTypeId")]
		public DependencyType DependencyType { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
