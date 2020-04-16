using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCRegisterObject")]
	public class OneCRegisterObject : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="IsPeriodic")]
		public bool IsPeriodic { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegisterClassId")]
		public Guid RegisterClassId { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:RegisterClassId")]
		public OneCRegisterClass RegisterClass { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OneCRegisterFunction:OneCRegisterId")]
		public virtual ICollection<OneCRegisterFunction> OneCRegisterFunctionByOneCRegister { get; set; }
		[CProperty(Association ="OneCRegisterObjColumn:OneCRegisterObjectId")]
		public virtual ICollection<OneCRegisterObjColumn> OneCRegisterObjColumnByOneCRegisterObject { get; set; }
		[CProperty(Association ="SyncObject:OneCRegisterId")]
		public virtual ICollection<SyncObject> SyncObjectByOneCRegister { get; set; }
		#endregion
	}
}