using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_06_Vector
{
    class Vector
    {
        private double _x, _y, _z;

	    //Constructors
	    public Vector() : this(0, 0, 0)
	    {

	    }

	    public Vector(double x, double y, double z)
	    {
		    _x = x;
		    _y = y;
		    _z = z;
	    }

	    //Properties

	    public double X { get{return _x;} set{_x = value;}}
        public double Y { get { return _y; } set { _y = value; } }
        public double Z { get { return _z; } set { _z = value; } }


	    public double Magnitude
	    {
		    get
		    {
			     return Math.Sqrt(_x * _x + _y * _y + _z * _z);
		    }
	    }
	

	    //Methods

	    public Vector Dot(Vector vect2)
	    {
		    return Vector.Dot(this, vect2);
	    }

	    public static Vector Dot(Vector vect1, Vector vect2)
	    {
		    return new Vector(vect1.X * vect2.X, vect1.Y * vect2.Y, vect1.Z * vect2.Z);
	    }


	    //Operator overloading 

	    public static Vector operator +(Vector v1, Vector v2)
	    {
		    return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
	    }

	    public static Vector operator -(Vector v1, Vector v2)
	    {
		    return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
	    }

	    public static Vector operator *(Vector v1, Vector v2)
	    {
		    return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
	    }

	    public static Vector operator /(Vector v1, Vector v2)
	    {
		    return new Vector(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
	    }


        //Method Overrides

        public override string ToString()
        {
            return String.Format("X: {0:0.00}, Y: {1:0.00}, Z: {2:0.00}, Megnitude: {3:0.0000}.", X, Y, Z, Magnitude);
        }

    }       
}
