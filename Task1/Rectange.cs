

Rectange rec =new Rectange(){

Width=4,
Height=5

};

rec.GetArea();

rec.Width=Convert.ToInt32(Console.ReadLine());
rec.Height=Convert.ToInt32(Console.ReadLine()
);
rec.GetArea();






public class Rectange
{
public int Width;
public int Height;

public void GetArea(){
    System.Console.WriteLine(Width*Height);
 }
 
}