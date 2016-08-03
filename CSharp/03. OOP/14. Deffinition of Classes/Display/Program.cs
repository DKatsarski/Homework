using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Display
{
    private double size;
    private int numberOfColors;
    
    public Display()
    {
    }
        
    public Display(double size, int numberOfColors)
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }

    public double Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value > 0)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            if (value > 0)
            {
                this.numberOfColors = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        var displayStuff = new StringBuilder();

        displayStuff.Append("Size: ");
        displayStuff.Append(this.Size)
            .Append("/n");
        displayStuff.Append("Color: ");
        displayStuff.Append(this.NumberOfColors);

        return displayStuff.ToString();
    }




}

class Program
{


    static void Main(string[] args)
    {
    }
}

