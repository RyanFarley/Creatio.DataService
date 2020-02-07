using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CommunicationType")]
	public class CommunicationType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="HyperlinkTemplate")]
		public string HyperlinkTemplate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Image")]
		public byte[] Image { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UseforAccounts")]
		public bool UseforAccounts { get; set; }
		[CProperty(ColumnPath ="UseforContacts")]
		public bool UseforContacts { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountCommunication:CommunicationTypeId")]
		public virtual ICollection<AccountCommunication> AccountCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="ComTypebyCommunication:CommunicationTypeId")]
		public virtual ICollection<ComTypebyCommunication> ComTypebyCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="ContactCommunication:CommunicationTypeId")]
		public virtual ICollection<ContactCommunication> ContactCommunicationByCommunicationType { get; set; }
		[CProperty(Association ="ContactCorrespondence:SourceId")]
		public virtual ICollection<ContactCorrespondence> ContactCorrespondenceBySource { get; set; }
		[CProperty(Association ="CTISearchResult:CommunicationTypeId")]
		public virtual ICollection<CTISearchResult> CTISearchResultByCommunicationType { get; set; }
		[CProperty(Association ="EmailTemplateMacros:AccountCommunicationTypeId")]
		public virtual ICollection<EmailTemplateMacros> EmailTemplateMacrosByAccountCommunicationType { get; set; }
		[CProperty(Association ="EnrchTypeMapping:CommunicationTypeId")]
		public virtual ICollection<EnrchTypeMapping> EnrchTypeMappingByCommunicationType { get; set; }
		[CProperty(Association ="SocialAccount:TypeId")]
		public virtual ICollection<SocialAccount> SocialAccountByType { get; set; }
		#endregion
	}
}