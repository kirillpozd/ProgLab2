using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.CodeDom;

namespace ProgLab2;

public class GraphObject
{
    static Random r = new Random();
    int x, y, w, h;
    SolidBrush brush;
    Color c;
    public int X { 
        get => x; 
        set {
            if (value + w > MaxSize.Width || value < 0)
                throw new ArgumentException("Выходит за границы X " + value);
            x = value;
        } 
    }
    public int Y { 
        get => y; 
        set {
            if (value + h > MaxSize.Height || value < 0)
                throw new ArgumentException("Выходит за границы Y " + value);
            y = value;
        } 
    }
    
    public GraphObject()
    {
        Color[] cols = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
        c = cols[r.Next(cols.Length)];
        x = r.Next(200);
        y = r.Next(200);
        w = 50;
        h = 50;
        brush = new SolidBrush(c);
        
    }
    public void Draw(Graphics g)
    {
        g.FillRectangle(brush, x, y, w, h);
        g.DrawRectangle(Pens.Black, x, y, w, h);

    }
    static public Size MaxSize { get; set; }
}
