namespace DesignPatterns.CreationalPatterns.PrototypePattern
{
    public class Circle: IShape
    {
        public int Radius { get; set; } = 5; // give a default radius of 5 for newly-created circles

        public void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }

        public IShape Duplicate()
        {
            var newCircle = new Circle
            {
                Radius = Radius
            };
            return newCircle;
        }
    }
}