using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleInSysModuleFolder")]
	public class SysModuleInSysModuleFolder : BaseEntity
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
		private Guid _SubSysModuleFolderId;
		[CProperty(ColumnPath ="SubSysModuleFolderId")]
		public Guid SubSysModuleFolderId
		{
			get{return _SubSysModuleFolderId;}
			set
			{
				_SubSysModuleFolderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleFolderId;
		[CProperty(ColumnPath ="SysModuleFolderId")]
		public Guid SysModuleFolderId
		{
			get{return _SysModuleFolderId;}
			set
			{
				_SysModuleFolderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleId;
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId
		{
			get{return _SysModuleId;}
			set
			{
				_SysModuleId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleFolder:SubSysModuleFolderId")]
		public SysModuleFolder SubSysModuleFolder { get; set; }
		[CProperty(Navigation ="SysModuleFolder:SysModuleFolderId")]
		public SysModuleFolder SysModuleFolder { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
