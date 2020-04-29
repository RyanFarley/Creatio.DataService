using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysSubProcessInProcess")]
	public class SysSubProcessInProcess : BaseEntity
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
		private Guid _ParentProcessUId;
		[CProperty(ColumnPath ="ParentProcessUId")]
		public Guid ParentProcessUId
		{
			get{return _ParentProcessUId;}
			set
			{
				_ParentProcessUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentSubProcessUId;
		[CProperty(ColumnPath ="ParentSubProcessUId")]
		public Guid ParentSubProcessUId
		{
			get{return _ParentSubProcessUId;}
			set
			{
				_ParentSubProcessUId = value;
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
		private Guid _ProcessUId;
		[CProperty(ColumnPath ="ProcessUId")]
		public Guid ProcessUId
		{
			get{return _ProcessUId;}
			set
			{
				_ProcessUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubProcessUId;
		[CProperty(ColumnPath ="SubProcessUId")]
		public Guid SubProcessUId
		{
			get{return _SubProcessUId;}
			set
			{
				_SubProcessUId = value;
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
		#endregion
	}
}
