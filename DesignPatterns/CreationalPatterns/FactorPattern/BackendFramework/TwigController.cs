using DesignPatterns.CreationalPatterns.FactorPattern.TwigView;

namespace DesignPatterns.CreationalPatterns.FactorPattern.BackendFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}