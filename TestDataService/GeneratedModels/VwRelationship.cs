using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRelationship")]
	public class VwRelationship : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountAId")]
		public Guid AccountAId { get; set; }
		[CProperty(ColumnPath ="AccountBId")]
		public Guid AccountBId { get; set; }
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="ContactAId")]
		public Guid ContactAId { get; set; }
		[CProperty(ColumnPath ="ContactBId")]
		public Guid ContactBId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Our")]
		public string Our { get; set; }
		[CProperty(ColumnPath ="OutputRelationType")]
		public string OutputRelationType { get; set; }
		[CProperty(ColumnPath ="OutputReverseRelationType")]
		public string OutputReverseRelationType { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Related")]
		public string Related { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountAId")]
		public Account AccountA { get; set; }
		[CProperty(Navigation ="Account:AccountBId")]
		public Account AccountB { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactAId")]
		public Contact ContactA { get; set; }
		[CProperty(Navigation ="Contact:ContactBId")]
		public Contact ContactB { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}