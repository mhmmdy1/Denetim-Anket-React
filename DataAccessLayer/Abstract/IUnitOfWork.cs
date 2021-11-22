using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountDAL AccountDal { get; }
        IAccountRoleAuthorizationDAL AccountRoleAuthorizationDAL { get; }
        IAccountRoleDAL AccountRoleDAL { get; }
        IActionLogDAL ActionLogDAL { get; }
        IAnswerSetDAL AnswerSetDAL { get; }
        IAnswerSetDetailDAL AnswerSetDetailDAL { get; }
        IAuditAnswersDAL AuditAnswersDAL { get; }
        IAuditDAL AuditDAL { get; }
        IBlocksDAL BlocksDAL { get; }
        ICompaniesDAL CompaniesDAL { get; }
        IExceptionLogsDAL ExceptionLogsDAL { get; }
        IFacilityDAL FacilityDAL { get; }
        IFacilityServiceDAL FacilityServiceDAL { get; }
        IFacilityTypesDAL FacilityTypesDAL { get; }
        IFloorsDAL FloorsDAL { get; }
        IImportanceLevelsDAL ImportanceLevelsDAL { get; }
        IInspectionSetQuestionsDAL InspectionSetQuestionsDAL { get; }
        IInspectionSetsDAL InspectionSetsDAL { get; }
        IInspectionUnsuitabilitiesDAL InspectionUnsuitabilitiesDAL { get; }
        ILocationAuthorizationsDAL LocationAuthorizationsDAL { get; }
        IMembershipPackagesDAL MembershipPackagesDAL { get; }
        IPeriodsDAL PeriodsDAL { get; }
        IPreventiveActivitiesDAL PreventiveActivitiesDAL { get; }
        IRecoveryCodesDAL RecoveryCodesDAL { get; }
        IRoleAuthorizationsDAL RoleAuthorizationsDAL { get; }
        IRolesDAL RolesDAL { get; }
        IRoomsDAL RoomsDAL { get; }
        IRoomTypesDAL RoomTypesDAL { get; }
        ISISActionsDAL SISActionsDAL { get; }
        ISISControllersDAL SISControllersDAL { get; }
        ISISServicesDAL SISServicesDAL { get; }
        ISurveyDesignsDAL SurveyDesignsDAL { get; }
        ISurveyReleasesDAL SurveyReleasesDAL { get; }
        IRegisterDAL RegisterDAL { get; }
    }
}
