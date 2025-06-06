namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    public interface IShape
    {
        void Draw();

        IShape Duplicate();
    }
}