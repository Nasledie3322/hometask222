




using System;

namespace Task1;

public class Rectangle
{
    int Width;
    int Height;
    string Color;
    public Rectangle(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }
    
    public int GetArea()
    {
        return Width * Height;
    }
    public int GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}