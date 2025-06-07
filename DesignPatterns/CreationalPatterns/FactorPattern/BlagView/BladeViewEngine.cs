using System.Collections.Generic;
using DesignPatterns.CreationalPatterns.FactorPattern.BackendFramework;

namespace DesignPatterns.CreationalPatterns.FactorPattern.BlagView
{
    public class BladeViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            return "View rendered from " + fileName + " by Blade";
        }
    }
}