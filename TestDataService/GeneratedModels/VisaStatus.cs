using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VisaStatus")]
	public class VisaStatus : BaseEntity
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
		[CProperty(Association ="ActivityVisa:StatusId")]
		public virtual ICollection<ActivityVisa> ActivityVisaByStatus { get; set; }
		[CProperty(Association ="ApplicantVisa:StatusId")]
		public virtual ICollection<ApplicantVisa> ApplicantVisaByStatus { get; set; }
		[CProperty(Association ="BonusVisa:StatusId")]
		public virtual ICollection<BonusVisa> BonusVisaByStatus { get; set; }
		[CProperty(Association ="ChangeVisa:StatusId")]
		public virtual ICollection<ChangeVisa> ChangeVisaByStatus { get; set; }
		[CProperty(Association ="CIVisa:StatusId")]
		public virtual ICollection<CIVisa> CIVisaByStatus { get; set; }
		[CProperty(Association ="ContractVisa:StatusId")]
		public virtual ICollection<ContractVisa> ContractVisaByStatus { get; set; }
		[CProperty(Association ="DocumentVisa:StatusId")]
		public virtual ICollection<DocumentVisa> DocumentVisaByStatus { get; set; }
		[CProperty(Association ="InternalRequestVisa:StatusId")]
		public virtual ICollection<InternalRequestVisa> InternalRequestVisaByStatus { get; set; }
		[CProperty(Association ="InvoiceVisa:StatusId")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaByStatus { get; set; }
		[CProperty(Association ="OpportunityForecastVisa:StatusId")]
		public virtual ICollection<OpportunityForecastVisa> OpportunityForecastVisaByStatus { get; set; }
		[CProperty(Association ="OpportunityVisa:StatusId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByStatus { get; set; }
		[CProperty(Association ="OrderVisa:StatusId")]
		public virtual ICollection<OrderVisa> OrderVisaByStatus { get; set; }
		[CProperty(Association ="PartnershipVisa:StatusId")]
		public virtual ICollection<PartnershipVisa> PartnershipVisaByStatus { get; set; }
		[CProperty(Association ="PDECaseVisa:StatusId")]
		public virtual ICollection<PDECaseVisa> PDECaseVisaByStatus { get; set; }
		[CProperty(Association ="PDEKnowledgeBaseVisa:StatusId")]
		public virtual ICollection<PDEKnowledgeBaseVisa> PDEKnowledgeBaseVisaByStatus { get; set; }
		[CProperty(Association ="PsDeliveryVisa:StatusId")]
		public virtual ICollection<PsDeliveryVisa> PsDeliveryVisaByStatus { get; set; }
		[CProperty(Association ="ScreenResultVisa:StatusId")]
		public virtual ICollection<ScreenResultVisa> ScreenResultVisaByStatus { get; set; }
		[CProperty(Association ="TsOrderExpenseVisa:StatusId")]
		public virtual ICollection<TsOrderExpenseVisa> TsOrderExpenseVisaByStatus { get; set; }
		[CProperty(Association ="TsStaffGoalVisa:StatusId")]
		public virtual ICollection<TsStaffGoalVisa> TsStaffGoalVisaByStatus { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValueVisa:StatusId")]
		public virtual ICollection<TsStaffSkillPeriodValueVisa> TsStaffSkillPeriodValueVisaByStatus { get; set; }
		[CProperty(Association ="VwVisa:StatusId")]
		public virtual ICollection<VwVisa> VwVisaByStatus { get; set; }
		#endregion
	}
}
