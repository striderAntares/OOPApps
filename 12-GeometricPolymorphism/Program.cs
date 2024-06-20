using _12_GeometricPolymorphism;

List<GeometricalShape> geoshapes = new List<GeometricalShape>();
geoshapes.Add(new Square(5,5));
geoshapes.Add(new Rectangle(5, 6));
geoshapes.Add(new RightAngledTriangle(3, 4));
geoshapes.Add(new Circle(5));
foreach (GeometricalShape item in  geoshapes)
    item.PrintInfo();


