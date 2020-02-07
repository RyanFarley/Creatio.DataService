using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TagType")]
	public class TagType : BaseEntity
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
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountTag:TypeId")]
		public virtual ICollection<AccountTag> AccountTagByType { get; set; }
		[CProperty(Association ="ActivityTag:TypeId")]
		public virtual ICollection<ActivityTag> ActivityTagByType { get; set; }
		[CProperty(Association ="BulkEmailTag:TypeId")]
		public virtual ICollection<BulkEmailTag> BulkEmailTagByType { get; set; }
		[CProperty(Association ="CallTag:TypeId")]
		public virtual ICollection<CallTag> CallTagByType { get; set; }
		[CProperty(Association ="CampaignPlannerTag:TypeId")]
		public virtual ICollection<CampaignPlannerTag> CampaignPlannerTagByType { get; set; }
		[CProperty(Association ="CampaignTag:TypeId")]
		public virtual ICollection<CampaignTag> CampaignTagByType { get; set; }
		[CProperty(Association ="CaseTag:TypeId")]
		public virtual ICollection<CaseTag> CaseTagByType { get; set; }
		[CProperty(Association ="CertificationTag:TypeId")]
		public virtual ICollection<CertificationTag> CertificationTagByType { get; set; }
		[CProperty(Association ="ChangeTag:TypeId")]
		public virtual ICollection<ChangeTag> ChangeTagByType { get; set; }
		[CProperty(Association ="ConfItemTag:TypeId")]
		public virtual ICollection<ConfItemTag> ConfItemTagByType { get; set; }
		[CProperty(Association ="ContactTag:TypeId")]
		public virtual ICollection<ContactTag> ContactTagByType { get; set; }
		[CProperty(Association ="ContentBlockTag:TypeId")]
		public virtual ICollection<ContentBlockTag> ContentBlockTagByType { get; set; }
		[CProperty(Association ="ContractTag:TypeId")]
		public virtual ICollection<ContractTag> ContractTagByType { get; set; }
		[CProperty(Association ="DocumentTag:TypeId")]
		public virtual ICollection<DocumentTag> DocumentTagByType { get; set; }
		[CProperty(Association ="DuplicatesRuleTag:TypeId")]
		public virtual ICollection<DuplicatesRuleTag> DuplicatesRuleTagByType { get; set; }
		[CProperty(Association ="EmployeeTag:TypeId")]
		public virtual ICollection<EmployeeTag> EmployeeTagByType { get; set; }
		[CProperty(Association ="EventTag:TypeId")]
		public virtual ICollection<EventTag> EventTagByType { get; set; }
		[CProperty(Association ="ExternalAccessTag:TypeId")]
		public virtual ICollection<ExternalAccessTag> ExternalAccessTagByType { get; set; }
		[CProperty(Association ="GeneratedWebFormTag:TypeId")]
		public virtual ICollection<GeneratedWebFormTag> GeneratedWebFormTagByType { get; set; }
		[CProperty(Association ="GuidedLearningTag:TypeId")]
		public virtual ICollection<GuidedLearningTag> GuidedLearningTagByType { get; set; }
		[CProperty(Association ="InvoiceTag:TypeId")]
		public virtual ICollection<InvoiceTag> InvoiceTagByType { get; set; }
		[CProperty(Association ="KnowledgeBaseTagV2:TypeId")]
		public virtual ICollection<KnowledgeBaseTagV2> KnowledgeBaseTagV2ByType { get; set; }
		[CProperty(Association ="LeadTag:TypeId")]
		public virtual ICollection<LeadTag> LeadTagByType { get; set; }
		[CProperty(Association ="LookupTag:TypeId")]
		public virtual ICollection<LookupTag> LookupTagByType { get; set; }
		[CProperty(Association ="MktgActivityTag:TypeId")]
		public virtual ICollection<MktgActivityTag> MktgActivityTagByType { get; set; }
		[CProperty(Association ="MLModelTag:TypeId")]
		public virtual ICollection<MLModelTag> MLModelTagByType { get; set; }
		[CProperty(Association ="OAuth20AppTag:TypeId")]
		public virtual ICollection<OAuth20AppTag> OAuth20AppTagByType { get; set; }
		[CProperty(Association ="OpportunityTag:TypeId")]
		public virtual ICollection<OpportunityTag> OpportunityTagByType { get; set; }
		[CProperty(Association ="OrderTag:TypeId")]
		public virtual ICollection<OrderTag> OrderTagByType { get; set; }
		[CProperty(Association ="PartnershipTag:TypeId")]
		public virtual ICollection<PartnershipTag> PartnershipTagByType { get; set; }
		[CProperty(Association ="ProblemTag:TypeId")]
		public virtual ICollection<ProblemTag> ProblemTagByType { get; set; }
		[CProperty(Association ="ProductTag:TypeId")]
		public virtual ICollection<ProductTag> ProductTagByType { get; set; }
		[CProperty(Association ="ProjectTag:TypeId")]
		public virtual ICollection<ProjectTag> ProjectTagByType { get; set; }
		[CProperty(Association ="QandATag:TypeId")]
		public virtual ICollection<QandATag> QandATagByType { get; set; }
		[CProperty(Association ="QueueTag:TypeId")]
		public virtual ICollection<QueueTag> QueueTagByType { get; set; }
		[CProperty(Association ="ReleaseTag:TypeId")]
		public virtual ICollection<ReleaseTag> ReleaseTagByType { get; set; }
		[CProperty(Association ="ServiceItemTag:TypeId")]
		public virtual ICollection<ServiceItemTag> ServiceItemTagByType { get; set; }
		[CProperty(Association ="ServicePactTag:TypeId")]
		public virtual ICollection<ServicePactTag> ServicePactTagByType { get; set; }
		[CProperty(Association ="SiteEventTypeTag:TypeId")]
		public virtual ICollection<SiteEventTypeTag> SiteEventTypeTagByType { get; set; }
		[CProperty(Association ="SocialChannelTag:TypeId")]
		public virtual ICollection<SocialChannelTag> SocialChannelTagByType { get; set; }
		[CProperty(Association ="SysTranslationTag:TypeId")]
		public virtual ICollection<SysTranslationTag> SysTranslationTagByType { get; set; }
		[CProperty(Association ="tsaTermTag:TypeId")]
		public virtual ICollection<tsaTermTag> tsaTermTagByType { get; set; }
		[CProperty(Association ="tsaTermTranslationTag:TypeId")]
		public virtual ICollection<tsaTermTranslationTag> tsaTermTranslationTagByType { get; set; }
		[CProperty(Association ="WebServiceV2Tag:TypeId")]
		public virtual ICollection<WebServiceV2Tag> WebServiceV2TagByType { get; set; }
		[CProperty(Association ="WSysAccountTag:TypeId")]
		public virtual ICollection<WSysAccountTag> WSysAccountTagByType { get; set; }
		#endregion
	}
}