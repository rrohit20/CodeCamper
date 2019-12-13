using System.Collections.Generic;
using System.Linq;
using PrinceVille.Data.Contracts;
using PrinceVille.Model;

namespace PrinceVille.Web.Controllers
{
    public class SessionBriefsController : ApiControllerBase
    {
        public SessionBriefsController(IPrinceVilleUow uow)
        {
            Uow = uow;
        }

        #region OData Future: IQueryable<T>
        //[Queryable]
        // public IQueryable<SessionBrief> Get()
        #endregion

        // GET /api/sessionbriefs
        public IEnumerable<SessionBrief> Get()
        {
            return Uow.Sessions.GetSessionBriefs()
                .OrderBy(sb => sb.TimeSlotId);
        }
    }
}