using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //6

    internal abstract class abs
    {
        public abstract void print();



    }
    internal class Eabs : abs
    {


        public override void print()
        {
            Console.WriteLine("hello");
        }
    }
    internal class Eabs1 : abs
    {


        public override void print()
        {
            Console.WriteLine("hello hello");
        }
    }
    //7
    public interface IsAttach
    {
        void attach(IsAttach isAttach);
        void anattach();

    }
    public class Ball : IsAttach
    {


        public void anattach()
        {
        }

        public void attach(IsAttach isAttach)
        {
        }
    }
    //8
    public class what
    {
        public what()
        {

        }
        public what(int I)
        {

        }
        public what(string S)
        {

        }
    }
    //9

    public interface shape
    {
         int size();
    }
    public class circle : shape
    {
        public int size()
        {
            throw new NotImplementedException();
        }
    }
    public class Square : shape
    {
        public int size()
        {
            throw new NotImplementedException();
        }
    }
    public class triangular : shape
    {
        public int size()
        {
            throw new NotImplementedException();
        }
    }
public class building
    {
        public shape shape;
        public building()
        {
            shape s = Factory.BuildShape("");
        }
        public int BuildABuilding(shape shape)
        {
           return shape.size();
        }
    }
    //10
    public class Factory
    {
        public static shape BuildShape(string WhatShape)
        {
            if (WhatShape == "circle")
                return new circle();
            else if (WhatShape == "Square")
                return new Square();
            else if (WhatShape == "triangular")
                return new triangular();
            return null;
        }
    }
}
