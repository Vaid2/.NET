/*Q3>Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o/p 22]
Which will return square .cube and rounded number.
Create object and call method and print the result.*/
namesapce Assign
{
          public static void Main()
        {
            
            Calculator cal = new Calculator();
            Console.WriteLine("enter the int num");
            String s = Console.ReadLine();
            float a;
            bool b = float.TryParse(s, out a);
          
            if (b == true)
            {
                Console.WriteLine("sqr:"+cal.square(a));
                Console.WriteLine("cube:"+cal.cube(a));
                Console.WriteLine("round:" + cal.round(a));

            }
            else{
                Console.WriteLine("enter the vaild data");
            }

        }
        public float square(float a)
        {
            return a * a;
        }
        public float cube(float a)
        {
            return a * a * a;

        }
        public int round(float a)
        {

            //return Convert.ToInt32(a);
            int b = (int)a;
            return b;
        }
        
}

