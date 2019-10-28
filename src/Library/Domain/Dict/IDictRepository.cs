using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Module.Common.Domain.Dict.Models;

namespace NetModular.Module.Common.Domain.Dict
{
    /// <summary>
    /// 字典仓储
    /// </summary>
    public interface IDictRepository : IRepository<DictEntity>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<DictEntity>> Query(DictQueryModel model);
    }
}