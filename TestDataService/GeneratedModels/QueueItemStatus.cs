using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QueueItemStatus")]
	public class QueueItemStatus : BaseEntity
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private bool _IsFinal;
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal
		{
			get{return _IsFinal;}
			set
			{
				_IsFinal = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="QueueItem:StatusId")]
		public virtual ICollection<QueueItem> QueueItemByStatus { get; set; }
		[CProperty(Association ="VwLeadInQueue:ElementStatusId")]
		public virtual ICollection<VwLeadInQueue> VwLeadInQueueByElementStatus { get; set; }
		[CProperty(Association ="VwQueueItem:StatusId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByStatus { get; set; }
		[CProperty(Association ="VwQueueItemDashboard:QueueItemStatusId")]
		public virtual ICollection<VwQueueItemDashboard> VwQueueItemDashboardByQueueItemStatus { get; set; }
		[CProperty(Association ="VwQueueItemDashboardC:QueueItemStatusId")]
		public virtual ICollection<VwQueueItemDashboardC> VwQueueItemDashboardCByQueueItemStatus { get; set; }
		[CProperty(Association ="VwQueueItemSuper:StatusId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByStatus { get; set; }
		#endregion
	}
}
