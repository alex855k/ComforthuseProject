using Comforthuse.Database;

namespace Comforthuse.Utility
{
    public class CaseRepository : ICaseRepository
    {

        IDbEmployee db = new DatabaseFacade();

        public CaseRepository()
        {
            db.CreateCase();

        }

        public void Load()
        {

        }

        public void Add()
        {

        }
    }
}
