using Nowadays.Models;
using Nowadays.Models.ResponseModels;
using Nowadays.Repositories.Abstract;
using Nowadays.Repositories.Abstract.Base;
using Nowadays.Repositories.Concrete.Base;
using Nowadays.Repositories.Concrete;
using Nowadays.Services.Abstract;
using Nowadays.Services.Concrete.Base;
using static Nowadays.Models.Enum.BaseEnum;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models.DTOs;

namespace Nowadays.Services.Concrete
{
    public class IssueService : BaseService<Issue>, IIssueService
    {
        private readonly IIssueRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public IssueService(IUnitOfWork unitOfWork, IBaseRepository<Issue> baseRepository, IIssueRepository repository) : base(unitOfWork, baseRepository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ResponseModel> ChangeIssueSetting(string id, [FromBody] IssueSettingDTO ıssueSetting)
        {
            try
            {
                var issue = await _repository.GetById(id);
                if (issue is null)
                {
                    throw new Exception("Data is not found");
                }
                issue.Model.Title = ıssueSetting.Title != default ? ıssueSetting.Title : issue.Model.Title;
                issue.Model.ProjectId = ıssueSetting.ProjectId != default ? ıssueSetting.ProjectId.ToString() : issue.Model.ProjectId;
                var result = _repository.Update(issue.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex.Message);
            }
        }
        public async Task<ResponseModel> UpdateDescription(string id, string Description)
        {
            try
            {
                var issue = await _repository.GetById(id);
                if (issue is null)
                {
                    throw new Exception("Data is not found");
                }
                issue.Model.Description = Description != default ? Description : issue.Model.Description;
                var result = _repository.Update(issue.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex.Message);
            }
        }
        public async Task<ResponseModel> ChangeStatus(string id,StatusType statusType)
        {
            try
            {
                var issue = await _repository.GetById(id);
                if (issue is null)
                {
                    throw new Exception("Data is not found");
                }
                issue.Model.Status = statusType != default ? statusType : issue.Model.Status;
                var result = _repository.Update(issue.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex.Message);
            }
        }
        public async Task<ResponseModel> UpdateIssueAssignEmployee(string id, string emloyeeId)
        {
            try
            {
                var issue = await _repository.GetById(id);
                if (issue is null)
                {
                    throw new Exception("Data is not found");
                }
                issue.Model.EmployeeId = emloyeeId != default ? emloyeeId : issue.Model.EmployeeId;
                var result = _repository.Update(issue.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex.Message);
            }
        }
        public async Task<ResponseModel> UpdateIssueReportingEmployee(string id, string reportingEmployeeId)
        {
            try
            {
                var issue = await _repository.GetById(id);
                if (issue is null)
                {
                    throw new Exception("Data is not found");
                }
                issue.Model.ReportingEmployeeId = reportingEmployeeId != default ? reportingEmployeeId : issue.Model.ReportingEmployeeId;
                var result = _repository.Update(issue.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex.Message);
            }
        }
    }
}
