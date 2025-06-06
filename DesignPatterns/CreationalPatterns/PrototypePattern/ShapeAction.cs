namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    public class ShapeActions
    {
        public IShape Duplicate(IShape shape)
        {
            System.Console.WriteLine("Duplicating shape");
            return shape.Duplicate();
        }
    }
}