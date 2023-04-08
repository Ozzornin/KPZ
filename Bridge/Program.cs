using Bridge.Renderers;
using Bridge.Shapes;

IRenderer vector = new VectorRenderer();
IRenderer raster = new RasterRenderer();

Circle circle = new Circle(vector);
circle.Draw();

Square square = new Square(raster);
square.Draw();

Triangle triangle = new Triangle(vector);
triangle.Draw();