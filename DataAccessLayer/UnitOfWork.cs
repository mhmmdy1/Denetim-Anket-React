using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private EFAccountRepository _eFAccountRepository;
        private EFAccountRoleAuthorizationsRepository _eFAccountRoleAuthorizationsRepository;
        private EFAccountRoleRepository _eFAccountRoleRepository;
        private EFActionLogRepository _eFActionLogRepository;
        private EFAnswerSetsRepository _eFAnswerSetsRepository;
        private EFAnswerSetDetailRepository _eFAnswerSetDetailRepository;
        private EFAuditAnswersRepository _eFAuditAnswersRepository;
        private EFAuditRepository _eFAuditRepository;
        private EFBlocksRepository _eFBlocksRepository;
        private EFCompanyRepository _eFCompanyRepository;
        private EFExceptionLogsRepository _eFExceptionLogsRepository;
        private EFFacilityRepository _eFFacilityRepository;
        private EFFacilityServiceRepository _eFFacilityServiceRepository;
        private EFFacilityTypesRepository _eFFacilityTypesRepository;
        private EFFloorRepository _eFFloorRepository;
        private EFImportanceLevelRepository _eFImportanceLevelRepository;
        private EFInspectionSetQuestionRepository _eFInspectionSetQuestionRepository;
        private EFInspectionSetsRepository _eFInspectionSetsRepository;
        private EFInspectionUnsuitabilitiesRepository _EFInspectionUnsuitabilitiesRepository;
        private EFLocationAuthorizationRepository _eFLocationAuthorizationRepository;
        private EFMembershipPackagesRepository _eFMembershipPackagesRepository;
        private EFPeriodsRepository _eFPeriodsRepository;
        private EFPreventiveActivitesRepository _eFPreventiveActivitesRepository;
        private EFRecoveryCodeRepository _eFRecoveryCodeRepository;
        private EFRoleAuthorizationsRepository _eFRoleAuthorizationsRepository;
        private EFRolesRepository _eFRolesRepository;
        private EFRoomsRepository _eFRoomsRepository;
        private EFRoomTypeRepository _eFRoomTypeRepository;
        private EFSISActionsRepository _eFSISActionsRepository;
        private EFSISControllersRepository _eFSISControllersRepository;
        private EFSISServicesRepository _eFSISServicesRepository;
        private EFSurveyDesignRepository _eFSurveyDesignRepository;
        private EFSurveyReleaseRepository _eFSurveyReleaseRepository;
        private EFRegisterRepository _eFRegisterRepository;

        public UnitOfWork(Context context)
        {
            this._context = context;
        }

        public IAccountDAL AccountDal => _eFAccountRepository = _eFAccountRepository ?? new EFAccountRepository(_context);
        public IAccountRoleAuthorizationDAL AccountRoleAuthorizationDAL => _eFAccountRoleAuthorizationsRepository = _eFAccountRoleAuthorizationsRepository ?? new EFAccountRoleAuthorizationsRepository(_context);

        public IAccountRoleDAL AccountRoleDAL => _eFAccountRoleRepository = _eFAccountRoleRepository  ?? new EFAccountRoleRepository(_context);

        public IActionLogDAL ActionLogDAL => _eFActionLogRepository = _eFActionLogRepository ?? new EFActionLogRepository(_context);

        public IAnswerSetDAL AnswerSetDAL => _eFAnswerSetsRepository = _eFAnswerSetsRepository ?? new EFAnswerSetsRepository(_context);

        public IAnswerSetDetailDAL AnswerSetDetailDAL => _eFAnswerSetDetailRepository = _eFAnswerSetDetailRepository ?? new EFAnswerSetDetailRepository(_context);

        public IAuditAnswersDAL AuditAnswersDAL => _eFAuditAnswersRepository = _eFAuditAnswersRepository ?? new EFAuditAnswersRepository(_context);

        public IAuditDAL AuditDAL => _eFAuditRepository = _eFAuditRepository ?? new EFAuditRepository(_context);

        public IBlocksDAL BlocksDAL => _eFBlocksRepository = _eFBlocksRepository ?? new EFBlocksRepository(_context);

        public ICompaniesDAL CompaniesDAL => _eFCompanyRepository = _eFCompanyRepository ?? new EFCompanyRepository(_context);

        public IExceptionLogsDAL ExceptionLogsDAL => _eFExceptionLogsRepository = _eFExceptionLogsRepository ?? new EFExceptionLogsRepository(_context);

        public IFacilityDAL FacilityDAL => _eFFacilityRepository = _eFFacilityRepository ?? new EFFacilityRepository(_context);

        public IFacilityServiceDAL FacilityServiceDAL => _eFFacilityServiceRepository = _eFFacilityServiceRepository ?? new EFFacilityServiceRepository(_context)
;
        public IFacilityTypesDAL FacilityTypesDAL => _eFFacilityTypesRepository = _eFFacilityTypesRepository ?? new EFFacilityTypesRepository(_context);

        public IFloorsDAL FloorsDAL => _eFFloorRepository = _eFFloorRepository ?? new EFFloorRepository(_context);

        public IImportanceLevelsDAL ImportanceLevelsDAL => _eFImportanceLevelRepository = _eFImportanceLevelRepository ?? new EFImportanceLevelRepository(_context);

        public IInspectionSetQuestionsDAL InspectionSetQuestionsDAL => _eFInspectionSetQuestionRepository = _eFInspectionSetQuestionRepository ?? new EFInspectionSetQuestionRepository(_context);

        public IInspectionSetsDAL InspectionSetsDAL => _eFInspectionSetsRepository = _eFInspectionSetsRepository ?? new EFInspectionSetsRepository(_context);

        public IInspectionUnsuitabilitiesDAL InspectionUnsuitabilitiesDAL => _EFInspectionUnsuitabilitiesRepository = _EFInspectionUnsuitabilitiesRepository ?? new EFInspectionUnsuitabilitiesRepository(_context);
        public ILocationAuthorizationsDAL LocationAuthorizationsDAL => _eFLocationAuthorizationRepository = _eFLocationAuthorizationRepository ?? new EFLocationAuthorizationRepository(_context);

        public IMembershipPackagesDAL MembershipPackagesDAL => _eFMembershipPackagesRepository = _eFMembershipPackagesRepository ?? new EFMembershipPackagesRepository(_context);

        public IPeriodsDAL PeriodsDAL => _eFPeriodsRepository = _eFPeriodsRepository ?? new EFPeriodsRepository(_context);

        public IPreventiveActivitiesDAL PreventiveActivitiesDAL => _eFPreventiveActivitesRepository = _eFPreventiveActivitesRepository ?? new EFPreventiveActivitesRepository(_context);

        public IRecoveryCodesDAL RecoveryCodesDAL => _eFRecoveryCodeRepository = _eFRecoveryCodeRepository ?? new EFRecoveryCodeRepository(_context);

        public IRoleAuthorizationsDAL RoleAuthorizationsDAL => _eFRoleAuthorizationsRepository = _eFRoleAuthorizationsRepository ?? new EFRoleAuthorizationsRepository(_context);

        public IRolesDAL RolesDAL => _eFRolesRepository = _eFRolesRepository ?? new EFRolesRepository(_context);

        public IRoomsDAL RoomsDAL => _eFRoomsRepository = _eFRoomsRepository ?? new EFRoomsRepository(_context);

        public IRoomTypesDAL RoomTypesDAL => _eFRoomTypeRepository = _eFRoomTypeRepository ?? new EFRoomTypeRepository(_context);

        public ISISActionsDAL SISActionsDAL => _eFSISActionsRepository = _eFSISActionsRepository ?? new EFSISActionsRepository(_context);

        public ISISControllersDAL SISControllersDAL => _eFSISControllersRepository = _eFSISControllersRepository ?? new EFSISControllersRepository(_context);

        public ISISServicesDAL SISServicesDAL => _eFSISServicesRepository = _eFSISServicesRepository ?? new EFSISServicesRepository(_context);

        public ISurveyDesignsDAL SurveyDesignsDAL => _eFSurveyDesignRepository = _eFSurveyDesignRepository ?? new EFSurveyDesignRepository(_context);

        public ISurveyReleasesDAL SurveyReleasesDAL => _eFSurveyReleaseRepository = _eFSurveyReleaseRepository ?? new EFSurveyReleaseRepository(_context);

        public IRegisterDAL RegisterDAL=> _eFRegisterRepository = _eFRegisterRepository ?? new EFRegisterRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
