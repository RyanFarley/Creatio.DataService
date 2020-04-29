using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalUserRoleInRegion")]
	public class PortalUserRoleInRegion : BaseEntity
	{
		#region Values
		private Guid _AccountRoleId;
		[CProperty(ColumnPath ="AccountRoleId")]
		public Guid AccountRoleId
		{
			get{return _AccountRoleId;}
			set
			{
				_AccountRoleId = value;
				OnPropertyChanged();
			}
		}
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
		private bool _End;
		[CProperty(ColumnPath ="End")]
		public bool End
		{
			get{return _End;}
			set
			{
				_End = value;
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
		private int _Number;
		[CProperty(ColumnPath ="Number")]
		public int Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerRoleId;
		[CProperty(ColumnPath ="PartnerRoleId")]
		public Guid PartnerRoleId
		{
			get{return _PartnerRoleId;}
			set
			{
				_PartnerRoleId = value;
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
		private Guid _RegionId;
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId
		{
			get{return _RegionId;}
			set
			{
				_RegionId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:RegionId")]
		public OpportunityTerritory Region { get; set; }
		[CProperty(Navigation ="SysAdminUnit:PartnerRoleId")]
		public SysAdminUnit PartnerRole { get; set; }
		[CProperty(Navigation ="SysAdminUnit:AccountRoleId")]
		public SysAdminUnit AccountRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
