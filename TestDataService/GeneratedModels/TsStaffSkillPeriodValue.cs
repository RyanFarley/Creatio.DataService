using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffSkillPeriodValue")]
	public class TsStaffSkillPeriodValue : BaseEntity
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
		[CProperty(ColumnPath ="InProgress")]
		public bool InProgress { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PointValue")]
		public decimal PointValue { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SkillId")]
		public Guid SkillId { get; set; }
		[CProperty(ColumnPath ="StaffSkillPeriodId")]
		public Guid StaffSkillPeriodId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public decimal Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSkill:SkillId")]
		public TsSkill Skill { get; set; }
		[CProperty(Navigation ="TsStaffSkillPeriod:StaffSkillPeriodId")]
		public TsStaffSkillPeriod StaffSkillPeriod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TsStaffSkillPeriodValueVisa:StaffSkillPeriodValueId")]
		public virtual ICollection<TsStaffSkillPeriodValueVisa> TsStaffSkillPeriodValueVisaByStaffSkillPeriodValue { get; set; }
		#endregion
	}
}