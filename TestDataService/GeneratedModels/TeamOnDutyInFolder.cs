using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TeamOnDutyInFolder")]
	public class TeamOnDutyInFolder : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FolderId")]
		public Guid FolderId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TeamOnDutyId")]
		public Guid TeamOnDutyId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TeamOnDuty:TeamOnDutyId")]
		public TeamOnDuty TeamOnDuty { get; set; }
		[CProperty(Navigation ="TeamOnDutyFolder:FolderId")]
		public TeamOnDutyFolder Folder { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}