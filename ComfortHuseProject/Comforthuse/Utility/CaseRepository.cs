using Comforthuse.Database;
using Comforthuse.Models;
using System;
using System.Collections.Generic;

namespace Comforthuse.Utility
{
    public class CaseRepository : ICaseRepository
    {
        private new List<Case> listOfCases = new List<Case>();
        IDbEmployee db = new DatabaseFacade();

        public CaseRepository()
        {
            db.CreateCase();

        }

        public void Load()
        {

        }

        public void AddCase(Case caseObj)
        {
            listOfCases.Add(caseObj);
        }

        public bool Create()
        {
            throw new System.NotImplementedException();
        }

        public List<Case> GetListOfCases()
        {
            if (listOfCases.Count > 0)
            { return listOfCases; }
            else
            {
                throw new Exception("The list is empty");
            }
        }

        public void AddCase()
        {
            throw new NotImplementedException();
        }
    }
}
