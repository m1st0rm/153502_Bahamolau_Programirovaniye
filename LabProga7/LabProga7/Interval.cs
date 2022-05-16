using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProga7
{
    public class Interval
    {
        private double beginning;

        public double Beginning
        {
            get { return beginning; }
            set
            {
                if (value <= this.end)
                {
                    this.beginning = value;
                }
            }
        }

        private double end;

        public double End
        {
            get { return end; }
            set { if (value >= this.beginning) 
                {
                    this.end = value;
                }
            }
        }

        public Interval()
        {
            this.beginning = 0;
            this.end = 0;
        }

        public Interval(double BeginPoint, double EndPoint)
        {
            if (EndPoint >= BeginPoint)
            {
                this.beginning = BeginPoint;
                this.end = EndPoint;
            }
            else
            {
                this.beginning = 0;
                this.end = 0;
            }
        }

        public double GetLength()
        {
            return Math.Abs(this.beginning - this.end);
        }

        public static Interval operator +(Interval First,Interval Second)
        {
            Interval Result = new Interval();
            Result.beginning = First.beginning + Second.beginning;
            Result.end = First.end + Second.end;
            return Result;
        }

        public static Interval operator -(Interval First, Interval Second)
        {
            Interval Result = new Interval();
            Result.beginning = First.beginning - Second.beginning;
            Result.end = First.end - Second.end;
            return Result;
        }

        public static Interval operator *(Interval First, Interval Second)
        {
            Interval Result = new Interval();
            if(First.end<Second.beginning|| First.beginning > Second.end)
            {
                return Result;
            }
            else if (Second.end < First.beginning || Second.beginning > First.end)
            {
                return Result;
            }
            else if((Second.beginning>=First.beginning) && (Second.end <= First.end))
            {
                return Second;
            }
            else if ((First.beginning >= Second.beginning) && (First.end <= Second.end))
            {
                return First;
            }
            else if((Second.end<First.end)&& (Second.beginning < First.beginning))
            {
                Result.beginning = First.beginning;
                Result.end = Second.end;
                return Result;
            }
            else if ((First.end < Second.end) && (First.beginning < Second.beginning))
            {
                Result.beginning = Second.beginning;
                Result.end = First.end;
                return Result;
            }
            else
            {
                return Result;
            }
        }

        public static Interval operator ++(Interval Object)
        {
            Object.beginning --;
            Object.end ++;
            return Object;
        }

        public static Interval operator --(Interval Object)
        {
            Object.beginning++;
            Object.end--;
            return Object;
        }

        public static bool operator < (Interval First, Interval Second) 
        {
            return First.GetLength() < Second.GetLength();
        }

        public static bool operator >(Interval First, Interval Second)
        {
            return First.GetLength() > Second.GetLength();
        }

        public static bool operator <=(Interval First, Interval Second)
        {
            return First.GetLength() <= Second.GetLength();
        }

        public static bool operator >=(Interval First, Interval Second)
        {
            return First.GetLength() >= Second.GetLength();
        }

        public static bool operator ==(Interval First, Interval Second)
        {
            return (First.GetLength() == Second.GetLength());
        }

        public static bool operator !=(Interval First, Interval Second)
        {
            return First.GetLength() != Second.GetLength();
        }

        public double this[int Index]
        {
            get
            {
                if (Index == 0)
                {
                    return beginning;
                }
                else
                {
                    return end;
                }
            }
            set
            {
                if (Index == 0)
                {
                    beginning = value;
                }
                else
                {
                    end = value;
                }
            }
        }

        public static bool operator true(Interval Object)
        {
            return Object.GetLength() > 0;
        }

        public static bool operator false(Interval Object)
        {
            return Object.GetLength() == 0;
        }

        public static explicit operator double(Interval Object)
        {
            return Object.GetLength();
        }


        public static explicit operator Interval (double Number)
        {
            return new Interval(0, Number);
        }

        public override string ToString()
        {
            return "Beginning = " + this.beginning.ToString() + ", End = " + this.end.ToString() + ", Length = " + this.GetLength().ToString();
        }
    }
}