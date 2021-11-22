using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company 
    {
        [StringLength (150)]
        public virtual string Name { get; set; }
        public virtual string RegisterNo { get; set; }
        public virtual string Email { get; set; }
        public virtual string Town { get; set; }
        public virtual string City { get; set; }
        [StringLength(10)]
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string AdminUser { get; set; }
        [Key]
        public virtual int CompanyId { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int CreateUser { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual int UpdateUser { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual DateTime? ExpirationDate { get; set; }
       // public ICollection<Account> Accounts { get; set; }
        public ICollection<AccountRole> AccountRoles { get; set; }
        public ICollection<AnswerSet> answerSets { get; set; }
        public ICollection<AnswerSetDetail> answerSetDetails { get; set; }
        public ICollection<Audit> Audits { get; set; }
        public ICollection<AuditAnswers> auditAnswers { get; set; }
        public ICollection<Block> blocks { get; set; }
        public ICollection<Facility> facilities { get; set; }
        public ICollection<FacilityService> facilityServices { get; set; }
        public ICollection<FacilityType> facilityTypes { get; set; }
        public ICollection<Floor> floors { get; set; }
        public ICollection<ImportanceLevel> ımportanceLevels { get; set; }
        public ICollection<InspectionSet> ınspectionSets { get; set; }
        public ICollection<InspectionSetQuestion> ınspectionSetQuestions { get; set; }
        public ICollection<InspectionUnsuitability> ınspectionUnsuitabilities { get; set; }
        public ICollection<LocationAuthorization> locationAuthorizations { get; set; }
        public ICollection<MembershipPackages> membershipPackages { get; set; }
        public ICollection<Period> periods { get; set; }
        public ICollection<PreventiveActivity> preventiveActivities { get; set; }
        public ICollection<Role> roles { get; set; }
        public ICollection<RoleAuthorization> roleAuthorizations { get; set; }
        public ICollection<Room> rooms { get; set; }
        public ICollection<RoomType> roomTypes { get; set; }
        public ICollection<SISService> SISServices { get; set; }
        public ICollection<SurveyDesign> surveyDesigns { get; set; }
        public ICollection<SurveyRelease> surveyReleases { get; set; }


    }
}
