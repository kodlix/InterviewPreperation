using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.FactorPattern.BackendFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}