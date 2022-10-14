//FOr 2x2 Matrix
namespace Operator_Overloading
{
    public class Matrix
    {
        int a, b, c, d;
        public Matrix(int a,int b, int c,int d)
        {
            this.a = a; 
            this.b = b;   
            this.c = c; 
            this.d = d;
        }
        public static Matrix operator + (Matrix obj1,Matrix obj2) //overloaded +
        {
            Matrix objMatAdd = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return objMatAdd;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2) //overloaded -
        {
            Matrix objMatSub = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return objMatSub;
        }

        public override string ToString() //overrides because its defination in Object is virtual
        {
            return a+ " "+ b +"\n" +c +" "+d;
        }

        public static void Main()
        {
            int a;
            List<int> list = new(); // null derefrencing

        start:
            try
            {
                Console.WriteLine("Enter Matrix 1: (2x2) 4 elements");
                for (var i = 0; i < 4; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    list.Add(a);
                }

                Matrix matrix1 = new Matrix(list[0], list[1], list[2], list[3]);
                Console.WriteLine("Enter Matrix 2: (2x2) 4 elements");
                for (var i = 4; i < 8; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    list.Add(a);
                }
                Matrix matrix2 = new Matrix(list[4], list[5], list[6], list[7]);
                Matrix matrixResultAddition = matrix1 + matrix2;
                Matrix matrixResultSubtraction = matrix1 - matrix2;

                Console.WriteLine("Addition Matrix: (2x2) 4 elements:\n" + matrixResultSubtraction.ToString());
                Console.WriteLine();
                Console.WriteLine("Subtraction Matrix: (2x2) 4 elements:\n" + matrixResultSubtraction.ToString());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();

                goto start;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                goto start;
            }
        }
    }
}