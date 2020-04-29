using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountEmployeesNumber")]
	public class AccountEmployeesNumber : BaseEntity
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private int _RangeEnd;
		[CProperty(ColumnPath ="RangeEnd")]
		public int RangeEnd
		{
			get{return _RangeEnd;}
			set
			{
				_RangeEnd = value;
				OnPropertyChanged();
			}
		}
		private int _RangeStart;
		[CProperty(ColumnPath ="RangeStart")]
		public int RangeStart
		{
			get{return _RangeStart;}
			set
			{
				_RangeStart = value;
				OnPropertyChanged();
			}
		}
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
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
		[CProperty(Association ="Account:EmployeesNumberId")]
		public virtual ICollection<Account> AccountByEmployeesNumber { get; set; }
		[CProperty(Association ="AccountStageHistory:EmployeesNumberId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByEmployeesNumber { get; set; }
		[CProperty(Association ="GlbCustomer:GlbEmployeesNumberRangeId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbEmployeesNumberRange { get; set; }
		[CProperty(Association ="Lead:EmployeesNumberId")]
		public virtual ICollection<Lead> LeadByEmployeesNumber { get; set; }
		[CProperty(Association ="LeadQualification:EmployeesNumberId")]
		public virtual ICollection<LeadQualification> LeadQualificationByEmployeesNumber { get; set; }
		[CProperty(Association ="VwLead:EmployeesNumberId")]
		public virtual ICollection<VwLead> VwLeadByEmployeesNumber { get; set; }
		#endregion
	}
}
