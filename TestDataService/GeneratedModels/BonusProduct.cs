using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusProduct")]
	public class BonusProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BonusCategoryId")]
		public Guid BonusCategoryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceAccrueRoleId")]
		public Guid InvoiceAccrueRoleId { get; set; }
		[CProperty(ColumnPath ="InvoiceProductId")]
		public Guid InvoiceProductId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductMargin")]
		public decimal ProductMargin { get; set; }
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusCategory:BonusCategoryId")]
		public BonusCategory BonusCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="InvoiceAccrueRole:InvoiceAccrueRoleId")]
		public InvoiceAccrueRole InvoiceAccrueRole { get; set; }
		[CProperty(Navigation ="InvoiceProduct:InvoiceProductId")]
		public InvoiceProduct InvoiceProduct { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}