using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GameScoringLog")]
	public class GameScoringLog : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private Guid _GameId;
		[CProperty(ColumnPath ="GameId")]
		public Guid GameId
		{
			get{return _GameId;}
			set
			{
				_GameId = value;
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
		private int _Points;
		[CProperty(ColumnPath ="Points")]
		public int Points
		{
			get{return _Points;}
			set
			{
				_Points = value;
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
		private Guid _ReasonId;
		[CProperty(ColumnPath ="ReasonId")]
		public Guid ReasonId
		{
			get{return _ReasonId;}
			set
			{
				_ReasonId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RecordUId;
		[CProperty(ColumnPath ="RecordUId")]
		public Guid RecordUId
		{
			get{return _RecordUId;}
			set
			{
				_RecordUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Game:GameId")]
		public Game Game { get; set; }
		[CProperty(Navigation ="GameScoringReason:ReasonId")]
		public GameScoringReason Reason { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
