using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        public int Real { get; private set; }
        public int Imaginary { get; private set; }

        public Complex(int re,int im){
            Real = re;
            Imaginary = im;
        }

        public int Modulus => (int)Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Phase => Math.Atan2(Imaginary, Real);

        public Complex Complement() => new Complex(this.Real, -(this.Imaginary));

        public Complex Plus(Complex arg) => new Complex(this.Real + arg.Real, this.Imaginary + arg.Imaginary);

        public Complex Minus(Complex arg) => new Complex(this.Real - arg.Real, this.Imaginary - arg.Imaginary);

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            return this.Equals((Complex)obj);
        }

        public bool Equals(Complex num)
        {
            return (Int32.Equals(num.Real, this.Real) && Int32.Equals(num.Imaginary, this.Imaginary));
        }

        public override string ToString()
        {
            return "" + this.Real + "+i" + this.Imaginary;
        }



    }
}