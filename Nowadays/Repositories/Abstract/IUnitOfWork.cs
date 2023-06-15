using Nowadays.Models;
using Nowadays.Repositories.Abstract.Base;

namespace Nowadays.Repositories.Abstract
{
    public interface IUnitOfWork /*: IDisposable*/
    {
        Task CompleteAsync();
        public IBaseRepository<Company> companyRepository { get; }
        public IBaseRepository<Employee> employeeRepository { get; }
        public IBaseRepository<Issue> issueRepository { get; }
        public IBaseRepository<Project> projectRepository { get; }
        public IBaseRepository<Report> reportRepository { get; }


    }
}
