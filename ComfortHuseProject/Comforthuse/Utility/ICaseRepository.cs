using Comforthuse.Models;
using System.Collections.Generic;

namespace Comforthuse.Utility
{
    public interface ICaseRepository
    {
        void Load();
        bool Create();
        void AddCase(Case caseObject);
        List<Case> GetListOfCases();
    }
}