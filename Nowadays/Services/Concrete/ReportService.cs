using AutoMapper;
using Nowadays.Models;
using Nowadays.Models.DTOs;
using Nowadays.Models.ResponseModels;
using Nowadays.Repositories.Abstract;
using Nowadays.Repositories.Abstract.Base;
using Nowadays.Repositories.Concrete;
using Nowadays.Services.Abstract;
using Nowadays.Services.Concrete.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Nowadays.Services.Concrete
{
    public class ReportService : BaseService<Report>, IReportService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectEmployeeRepository _projectEmployeeRepository;
        private readonly IMapper _mapper;
        public ReportService(IUnitOfWork unitOfWork, IBaseRepository<Report> baseRepository, ICompanyRepository companyRepository, IMapper mapper, IProjectRepository projectRepository, IProjectEmployeeRepository projectEmployeeRepository) : base(unitOfWork, baseRepository)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _projectRepository = projectRepository;
            _projectEmployeeRepository = projectEmployeeRepository;
        }
        public async Task<ResponseModel<Report>> GetReportByCompanyId(string id)
        {
            var companies = await _companyRepository.GetById(id);
            var companyReportModel = _mapper.Map<ReportCompanyDTO>(companies.Model);
            var projects = await _projectRepository.GetProjectByCompanyId(id);

            foreach (var project in projects.Model)
            {
                var projectEmployees = await _projectEmployeeRepository.GetByProjectId(project.Id);
                foreach (var employee in projectEmployees.Model)
                {
                    project.ProjectEmployees.Add(employee);
                }
            }


            if (projects.Model != null)
            {
                var projectReportModel = _mapper.Map<List<ReportProjectDTO>>(projects.Model);
                companyReportModel.Project = new List<ReportProjectDTO>(projectReportModel);
                
            }

            
            
            
            var report = new Report
            {
                Company = companyReportModel
            };
            return new ResponseModel<Report>(200,report);
        }
    }
}
