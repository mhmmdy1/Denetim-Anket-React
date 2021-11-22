using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options)

        { }
     
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<AccountRoleAuthorization> AccountRoleAuthorizations { get; set; }
        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<AnswerSet> AnswerSets { get; set; }
        public DbSet<AnswerSetDetail> AnswerSetDetails { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<AuditAnswers> AuditAnswers { get; set; }
        public DbSet<SISController> SISControllers { get; set; }
        public DbSet<SISAction> SISActions { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityType> FacilityTypes { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<ImportanceLevel> ImportanceLevels { get; set; }
        public DbSet<InspectionSet> InspectionSets { get; set; }
        public DbSet<InspectionSetQuestion> InspectionSetQuestions { get; set; }
        public DbSet<InspectionUnsuitability> InspectionUnsuitabilities { get; set; }
        public DbSet<LocationAuthorization> LocationAuthorizations { get; set; }
        public DbSet<MembershipPackages> MembershipPackages { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<PreventiveActivity> PreventiveActivities { get; set; }
        public DbSet<RecoveryCode> RecoveryCodes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAuthorization> RoleAuthorizations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<SISService> SISServices { get; set; }
        public DbSet<SurveyDesign> SurveyDesigns { get; set; }
        public DbSet<SurveyRelease> SurveyReleases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Company>()
            //.HasOne(p => p.Accounts)
            //.WithMany()
            //.HasForeignKey(p => p.CompanyId);

            //DbContext.Entry<Account>.State = EntityState.Modified;

           // modelBuilder.Entity<Company>().HasKey(c => new { c.CompanyId, c.Accounts });
  
        }

     
    }
}
