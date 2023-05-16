// See https://aka.ms/new-console-template for more information
using System;

namespace VersionE
{
    class VerE
    {
        static void Main(string[] args)
        {

            DisplayOptions();
            
            string ch;
            do
            {
                ch = Console.ReadLine().ToLower();
                
                switch (ch)
                {

                    case "1":
                        Question3();
                        break;
                    case "2":
                        Question4();
                        break;
                    case "3":
                        Question5();
                        break;
                    case "4":
                        Question6();
                        break;
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Error!!!!! Invalid Choice!");
                        break;
                        
                }
            }
            while (ch != "x");
        }

        

    

        #region Question 1
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * 
         * |------------------Programming I---------------------|
         * |           1. Working with array of doubles         |
         * |           2. Working with Hyperbolic functions     |
         * |           3. Calculate Kinetic Energy              |
         * |           4. Calculate Federal Tax                 |
         * |                                                    |
         * |           X. To exit the program                   |
         * |----------------------------------------------------|
         * Press the letter corresponding to your choice-> ");
         * 
         */
        public static void DisplayOptions()
        {

            Console.WriteLine("|------------------Programming I---------------------|");
            Console.WriteLine("|           1. Working with array of doubles         |");
            Console.WriteLine("|           2. Working with Hyperbolic functions     |");
            Console.WriteLine("|           3. Calculate Kinetic Energy              |");
            Console.WriteLine("|           4. Calculate Federal Tax                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           X. To exit the program                   |");
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("Press the letter corresponding to your choice-> \");");


        }

    #endregion

    #region Question 2
    /* 
     * In your Main() method, using a suitable looping structure, write the 
     * code to call the method from question 1 repeatedly. 
     * Using a suitable branching structure, write the code to implement the 
     * following required functionality for all valid responses.
     * Valid responses includes both upper and lower case of the input. The 
     * following must be implemented:

     * 1 will call the Question3() method
     * 2 will call the Question4() method
     * 3 will call the Question5() method
     * 4 will call the Question6() method
     * X will terminate the program
     * Any other key will produce an error message
     * 
     * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
     */
    #endregion

    #region Question 3
    /* Question 3c
     * 
     * Write a method with the following specification
     * name     : DisplayLargeDoublesOnly
     * arguments: array of double
     * returns  : nothing
     * display  : only the items that are greater than 0.6
     * task     : use a suitable looping structure to send each
     *            suitable item to the screen.
     *            
     * YOU MUST USE A FOR loop
     */
    static void DisplayLargeDoublesOnly(double[] array)
    {
        for(int i =0;i<array.Length;i++)
        {
            if (array[i]>0.6)
            {
                Console.WriteLine(array[i]);
            }
        }

    }

        /* Question 3b
         * 
         * Write a method with the following specification
         * name     : DisplayDoubleArray
         * arguments: array of double
         * returns  : nothing
         * display  : all the items in the array separated by a space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         * 
         * YOU MUST USE A FOREACH loop
         */
        static void DisplayDoubleArray(double[] array)
        {
            foreach(double num in array)
            {
                Console.Write($"{ num:F4}{"  "}");
            }
        }

    /* Question 3a
     * 
     * Write a method with the following specification
     * name     : GenerateDoubleArray
     * arguments: int representing the number of items to generate
     *            i.e. the size of the resulting array
     * returns  : double array
     * display  : nothing
     * task     : 1) create the random object to generate random numbers
     *            2) declare and allocate storage for the array
     *            3) using a suitable looping structure get a random value 
     *               and assign it the element of the array
     *               use random.NextDouble() to obtain a random double
     *            4) return the array
     */
    static double[] GenerateDoubleArray(int size)
        {
            Random ran = new Random();
            double[] array = new double[size];
            for(int i = 0;i<size;i++)
            {
                array[i] = ran.NextDouble();
            }
            return array;
        }

    /* The driver for question 3
     * 
     * 1) Call GenerateDoubleArray with argument 32 and assign the 
     *    returned value to a suitable variable
     * 2) Use DisplayDoubleArray to print the above stored value
     * 3) Print an empty line
     * 4) Use DisplayLargeDoublesOnly to print only items greater than 0.6
     */
        static void Question3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            Double[] array = GenerateDoubleArray(32);
            Console.WriteLine("All the items in the array separated by a space");
            DisplayDoubleArray(array);
            Console.WriteLine("\nOnly the items that are greater than 0.6");
            DisplayLargeDoublesOnly(array);
            Console.WriteLine("--------------------------------------\n");


            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4
        /* Question 4
         * 
         * Write a method with the following specification
         * name     : HyperBolic
         * arguments: an double representing the angle to convert
         *            an double to store the sinh value
         *            an double to store the cosh value
         *            an double to store the tanh value
         * returns  : nothing
         * display  : nothing
         * task     : uses the first argument to compute the other three values
         *           
         * hint     : use Math.Sinh, math.Cosh and Math.Tanh to compute the second,
         *            third and fourth arguments respectively
         */
        static void HyperBolic(double angle, out double sinh, out double cosh, out double tanh)
        {
            sinh = Math.Sinh(angle);
            cosh = Math.Cosh(angle);
            tanh = Math.Tanh(angle);
        }
        /* The driver for question 4
         * 
         * Use a loop and call the HyperBolic method as needed to create the following table:
		 *
         *  angle    sinh     cosh     tanh
         * 0.0000   0.0000   1.0000   0.0000
         * 0.1500   0.1506   1.0113   0.1489
         * 0.3000   0.3045   1.0453   0.2913
         * 0.4500   0.4653   1.1030   0.4219
         * 0.6000   0.6367   1.1855   0.5370
         *
         */
        static void Question4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4 goes here
            Console.WriteLine("{0,-8}{1,-8}{2,-8}{3,-8}", "angle", "sinh", "cosh", "tanh");
            Console.WriteLine("{0,-8}{1,-8}{2,-8}{3,-8}", "0.0000", Math.Sinh(0), Math.Cosh(0), Math.Tanh(0));

            for (double angle = 0.15; angle <= 0.6; angle += 0.15)
            {
                double sinh, cosh, tanh;
                HyperBolic(angle, out sinh, out cosh, out tanh);
                Console.WriteLine("{0,-8:F4}{1,-8:F4}{2,-8:F4}{3,-8:F4}", angle, sinh, cosh, tanh);
            }

            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5
        /* Question 5
         * 
         * The kinetic energy of a moving object is the product of mass and the 
         * square of the velocity. See the attached word document for the formulae
         * 
         * Write a method that calculates and returns the kinetic energy of a moving object. 
         * The specifications is as follows:
         * 
         * Name: 
         *  CalculateKineticEnergy
         *  
         * Argument: 
         *  a double representing the mass of the object
         *  a double representing the speed of the object
         *  
         * Returns:
         *  a double indicating the energy by virtue of its motion
         *  
         * Action:
         *  Calculates and return the kinetic enrgy of the body.
         *  
         * Displays: 
         *  nothing.
         * 
         */
        static double CalculateKineticEnergy(double mass, double speed)
        {
            double kineticEnergy = 0.5 * mass * Math.Pow(speed, 2);
            return kineticEnergy;
        }

        /* The driver for question 5
         * 
         * In the Question5() method, write the code to call this method two
         * times with arguments 1 and 1 and 5 and 3 respectively and display the 
         * return value after each call
         * 
         */
        static void Question5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            double energy = CalculateKineticEnergy(1,1);
            Console.WriteLine($"The kinetic energy of the object is {energy} joules.");
            double energy1 = CalculateKineticEnergy(5, 3);
            Console.WriteLine($"The kinetic energy of the object is {energy1} joules.");
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6
        /* Question 6
         * 
         * All Canadian are required to pay federal and provincial taxes. This question deals 
         * with federal tax calculation. The question specification are as follows:
         * 
         * Name: 
         *  CalculateFederalTax
         *  
         * Argument: 
         *  a double representing the annual taxable income
         *  
         * Returns:
         *  a double indicating the federal tax owned to the government 
         *    
         * Action:
         *  Calculates and return the tax based on the following abridge table:
         *  15% on the first $45,282 of taxable income, +
         *  20.5% on the next $45,281 of taxable income (on the portion of taxable income over $45,282 up to $90,563), +
         *  33% of taxable income over $90,563.
         *  
         * Displays: nothing.
         *         
         */
        static double CalculateFederalTax(double taxableIncome)
        {
            double fedraltax = 0.0;
            if (taxableIncome > 0.00)
            {
                if(taxableIncome<=45282.0)
                {
                    fedraltax = taxableIncome * 0.15;
                }
                else if(taxableIncome<=90563.0)
                {
                    fedraltax = 45282.00 * 0.15 + (taxableIncome - 45282.0) * 0.205;
                }
                else
                {
                    fedraltax = 45282 * 0.15 + (90563 - 45282) * 0.205 + (taxableIncome - 90563) * 0.33;
                }
                
            }
            return fedraltax;
        }

        /* The driver for question 6
         * 
         * 1) Declare a double variable and initialized it to 45,000
         * 2) Invoke the CalculateFederalTax method with this variable and print the returned value
         * 3) Change the variable to 75,000 and repeat step 2
         * 4) Change the variable to 115,000 and repeat step 2
         */
        static void Question6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double income = 45000.00;
            double fedralTax = CalculateFederalTax(income);
            Console.WriteLine($"The federal tax owed is {fedralTax:F2} Canadian dollars.");
            double income2 = 75000.00;
            double fedralTax2 = CalculateFederalTax(income2);
            Console.WriteLine($"The federal tax owed is {fedralTax2:F2} Canadian dollars.");
            double income3 = 115000.00;
            double fedralTax3 = CalculateFederalTax(income3);
            Console.WriteLine($"The federal tax owed is {fedralTax3:F2} Canadian dollars.");
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        #endregion
    }
}
