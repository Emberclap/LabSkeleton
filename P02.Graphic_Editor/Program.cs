namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape circle = new Circle();
            IShape square = new Square();

            var editor = new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(square);
        }
    }
}
