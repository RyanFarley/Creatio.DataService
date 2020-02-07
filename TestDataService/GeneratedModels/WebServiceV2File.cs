using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WebServiceV2File")]
	public class WebServiceV2File : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Data")]
		public byte[] Data { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LockedById")]
		public Guid LockedById { get; set; }
		[CProperty(ColumnPath ="LockedOn")]
		public DateTime LockedOn { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Size")]
		public int Size { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Version")]
		public int Version { get; set; }
		[CProperty(ColumnPath ="WebServiceV2Id")]
		public Guid WebServiceV2Id { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:LockedById")]
		public Contact LockedBy { get; set; }
		[CProperty(Navigation ="FileType:TypeId")]
		public FileType Type { get; set; }
		[CProperty(Navigation ="VwWebServiceV2:WebServiceV2Id")]
		public VwWebServiceV2 WebServiceV2 { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}