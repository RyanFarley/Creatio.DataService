using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCObjectDetailColumn")]
	public class OneCObjectDetailColumn : BaseEntity
	{
		#region Values
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
		private bool _IsCheck;
		[CProperty(ColumnPath ="IsCheck")]
		public bool IsCheck
		{
			get{return _IsCheck;}
			set
			{
				_IsCheck = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCObjectDetailId;
		[CProperty(ColumnPath ="OneCObjectDetailId")]
		public Guid OneCObjectDetailId
		{
			get{return _OneCObjectDetailId;}
			set
			{
				_OneCObjectDetailId = value;
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
		private string _Type;
		[CProperty(ColumnPath ="Type")]
		public string Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObjectDetail:OneCObjectDetailId")]
		public OneCObjectDetail OneCObjectDetail { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SyncColumn:IdentityColumnId")]
		public virtual ICollection<SyncColumn> SyncColumnByIdentityColumn { get; set; }
		[CProperty(Association ="TableIntegrationFilter:OneCObjectColumnId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByOneCObjectColumn { get; set; }
		[CProperty(Association ="TableIntegrationFilter:OneCObjectCompareColumnId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByOneCObjectCompareColumn { get; set; }
		[CProperty(Association ="TableSyncColumn:OneCDetailColumnId")]
		public virtual ICollection<TableSyncColumn> TableSyncColumnByOneCDetailColumn { get; set; }
		#endregion
	}
}
