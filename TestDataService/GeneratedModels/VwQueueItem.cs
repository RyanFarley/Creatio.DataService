using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwQueueItem")]
	public class VwQueueItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityRecordId")]
		public Guid EntityRecordId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LastActivityId")]
		public Guid LastActivityId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NextProcessingDate")]
		public DateTime NextProcessingDate { get; set; }
		[CProperty(ColumnPath ="NextProcessingDateOrder")]
		public int NextProcessingDateOrder { get; set; }
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="PostponesCount")]
		public int PostponesCount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SysProcessDataId")]
		public Guid SysProcessDataId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:LastActivityId")]
		public Activity LastActivity { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorId")]
		public Contact Operator { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		[CProperty(Navigation ="QueueItemStatus:StatusId")]
		public QueueItemStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:QueueItemId")]
		public virtual ICollection<Activity> ActivityByQueueItem { get; set; }
		[CProperty(Association ="QueueItemFolder:ParentId")]
		public virtual ICollection<QueueItemFolder> QueueItemFolderByParent { get; set; }
		#endregion
	}
}