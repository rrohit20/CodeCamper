using System.Collections.Generic;
using System.Linq;
using PrinceVille.Data.Contracts;
using PrinceVille.Model;

namespace PrinceVille.Web.Controllers
{
    public class FavoritesController : ApiControllerBase
    {
        public FavoritesController(IPrinceVilleUow uow)
        {
            Uow = uow;
        }

        #region OData Future: IQueryable<T>
        //[Queryable]
        // public IQueryable<Attendance> Get()
        #endregion

        // GET: api/favorites/{personId}
        public IEnumerable<Attendance> GetByPersonId(int id)
        {
            return Uow.Attendance.GetByPersonId(id)
                .OrderBy(ps => ps.Session.Title);
        }
    }
}