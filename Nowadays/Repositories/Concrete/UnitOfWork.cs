using Microsoft.EntityFrameworkCore;
using Nowadays.EFCoreDbContext;
using Nowadays.Models;
using Nowadays.Models.ValueObject;
using Nowadays.Repositories.Abstract;
using Nowadays.Repositories.Abstract.Base;
using Nowadays.Repositories.Concrete.Base;

namespace Nowadays.Repositories.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NowadaysDbContext _dbContext;
        //private bool disposed;
        public IBaseRepository<Company> companyRepository { get; private set; }
        public IBaseRepository<Employee> employeeRepository { get; private set; }
        public IBaseRepository<Issue> issueRepository { get; private set; }
        public IBaseRepository<Project> projectRepository { get; private set; }
        public IBaseRepository<Report> reportRepository { get; private set; }
        public IBaseRepository<ProjectEmployee> projectEmployeeRepository { get; private set; }

        public UnitOfWork(NowadaysDbContext dbContext, IBaseRepository<Company> companyRepository, IBaseRepository<Employee> employeeRepository, IBaseRepository<Issue> issueRepository, IBaseRepository<Project> projectRepository, IBaseRepository<Report> reportRepository, IBaseRepository<ProjectEmployee> projectEmployeeRepository)
        {
            _dbContext = dbContext;
            this.companyRepository = new BaseRepository<Company>(_dbContext);
            this.employeeRepository = new BaseRepository<Employee>(_dbContext);
            this.issueRepository = new BaseRepository<Issue>(_dbContext);
            this.projectRepository = new BaseRepository<Project>(_dbContext);
            this.reportRepository = new BaseRepository<Report>(_dbContext);
            this.projectEmployeeRepository = new BaseRepository<ProjectEmployee>(_dbContext);
        }


        //protected virtual void Clean(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            Dispose();
        //        }
        //    }
        //    disposed = true;
        //}

        public async Task CompleteAsync()
        {
            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                }
            }
        }

        //public void Dispose()
        //{
        //    Clean(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
