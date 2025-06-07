using DesignPatterns.CreationalPatterns.FactorPattern.BlagView;
using DesignPatterns.CreationalPatterns.FactorPattern.TwigView;

namespace DesignPatterns.CreationalPatterns.FactorPattern.BackendFramework
{
    public class BladeController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new BladeViewEngine();
        }
    }
}