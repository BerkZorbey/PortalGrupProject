using Nowadays.Models;
using Nowadays.Models.ResponseModels;
using Nowadays.Repositories.Abstract;
using Nowadays.Repositories.Abstract.Base;
using Nowadays.Repositories.Concrete.Base;
using Nowadays.Services.Abstract;
using Nowadays.Services.Concrete.Base;

namespace Nowadays.Services.Concrete
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        private readonly IBaseRepository<Project> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IUnitOfWork unitOfWork, IBaseRepository<Project> baseRepository) : base(unitOfWork, baseRepository)
        {
            _repository = baseRepository;
            _unitOfWork = unitOfWork;
        }
        public override async Task<ResponseModel> UpdateAsync(string id, Project updatedProject)
        {
            try
            {
                var project = await _repository.GetById(id);
                if (project.Model is null)
                {
                    throw new Exception("Data is not found");
                }
                project.Model.ProjectLeader = updatedProject.ProjectLeader != default ? updatedProject.ProjectLeader : project.Model.ProjectLeader;
                project.Model.ProjectKey = updatedProject.ProjectKey != default ? updatedProject.ProjectKey : project.Model.ProjectKey;
                project.Model.Name = updatedProject.Name != default ? updatedProject.Name : project.Model.Name;
                var result = _repository.Update(project.Model);
                await _unitOfWork.CompleteAsync();
                return result;
            }
            catch (Exception ex)
            {
                return new ResponseModel(404, ex);
            }
        }
    }
}
