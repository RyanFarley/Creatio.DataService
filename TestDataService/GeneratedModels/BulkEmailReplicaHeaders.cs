using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailReplicaHeaders")]
	public class BulkEmailReplicaHeaders : BaseEntity
	{
		#region Values
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
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
		private Guid _DCReplicaId;
		[CProperty(ColumnPath ="DCReplicaId")]
		public Guid DCReplicaId
		{
			get{return _DCReplicaId;}
			set
			{
				_DCReplicaId = value;
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
		private string _Preheader;
		[CProperty(ColumnPath ="Preheader")]
		public string Preheader
		{
			get{return _Preheader;}
			set
			{
				_Preheader = value;
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
		private string _SenderEmail;
		[CProperty(ColumnPath ="SenderEmail")]
		public string SenderEmail
		{
			get{return _SenderEmail;}
			set
			{
				_SenderEmail = value;
				OnPropertyChanged();
			}
		}
		private string _SenderName;
		[CProperty(ColumnPath ="SenderName")]
		public string SenderName
		{
			get{return _SenderName;}
			set
			{
				_SenderName = value;
				OnPropertyChanged();
			}
		}
		private string _Subject;
		[CProperty(ColumnPath ="Subject")]
		public string Subject
		{
			get{return _Subject;}
			set
			{
				_Subject = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DCReplica:DCReplicaId")]
		public DCReplica DCReplica { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
