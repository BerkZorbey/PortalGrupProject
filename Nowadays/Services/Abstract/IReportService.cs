using Nowadays.Models;
using Nowadays.Models.ResponseModels;
using Nowadays.Services.Abstract.Base;

namespace Nowadays.Services.Abstract
{
    public interface IReportService : IBaseService<Report>
    {
        public Task<ResponseModel<Report>> GetReportByCompanyId(string id);
    }
}
