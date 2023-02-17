using System;
using System.Linq.Expressions;
using System.Net.Http;

namespace PracticeCalculator
{
    internal class Program
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome To The C# Calculator\n");
            Console.WriteLine("Choose one of the options below:\n");
            Console.WriteLine("1 = Scientific");
            Console.WriteLine("2 = Length");
            Console.WriteLine("3 = Volume");
            Console.WriteLine("4 = Exit\n");
            int MainMenuChoice = Convert.ToInt16(Console.ReadLine());

            if (MainMenuChoice == 4)
            {
                Console.WriteLine("Exiting Application");
            }

            switch (MainMenuChoice)
            {
                case 1:
                    Console.WriteLine("Proceeding to the Sceintifc Calculator...");
                    scientific();
                    break;

                case 2:
                    Console.WriteLine("Proceeding to the Length Calculator...");
                    length();
                    break;

                case 3:
                    Console.WriteLine("Proceeding to the Volume Calculator Calculator...");
                    volume();
                    break;
            }
        }

        public static void volume()
        {
            Console.WriteLine("Welcome To The Volume Calculator!\n");

            while (true)
            {
                double cubicmeters;
                double litres;
                double cubicinches;
                double cubiccentimeters;
                double cubicfeet;
                double gallonsUS;
                double gallonsUK;
                double fluidouncesUS;
                double milimetres;
                double fluidouncesUK;
                double teaspoonsUS;
                double tablespoonsUS;
                double cubicyards;
                double answer;

                Console.WriteLine("Please choose one by entering the number for the desired conersion/calculation\n");
                Console.WriteLine("1 = Cubic metres to litres");
                Console.WriteLine("2 = Litres to Cubic metres");
                Console.WriteLine("3 = Cubic inches to Cubic centimetres");
                Console.WriteLine("4 = Cubic centimetres to Cubic inches");
                Console.WriteLine("5 = Cubic feet to Cubic metres");
                Console.WriteLine("6 = Cubic metres to Cubic feet");
                Console.WriteLine("7 = Gallons(US) to litres");
                Console.WriteLine("8 = Litres to Gallons(US)");
                Console.WriteLine("9 = Gallons(UK) to litres");
                Console.WriteLine("10 = Litres to Gallons(UK)");
                Console.WriteLine("11 = Fluid Ounces(US) to milimetres");
                Console.WriteLine("12 = Milimetres to Fluid Ounces(US)");
                Console.WriteLine("13 = Fluid Ounces(UK) to milimetres");
                Console.WriteLine("14 = Milimetres to Fluid Ounces(UK)");
                Console.WriteLine("15 = Teaspoons(US) to milimetres");
                Console.WriteLine("16 = Milimetres to Teaspoons(US)");
                Console.WriteLine("17 = Tablespoons(US) to Milimetres");
                Console.WriteLine("18 = Milimetres to tablespoons");
                Console.WriteLine("19 = Cubic yards to cubic metres");
                Console.WriteLine("20 = Cubic metres to Cubic yards");
                Console.WriteLine("21 = Return back to main menu");
                Console.WriteLine("22 = Exit\n");
                Console.WriteLine("Please enter your choice");

                int MenuChoice = Convert.ToInt16(Console.ReadLine());

                if (MenuChoice == 22)
                {
                    Console.WriteLine("Exiting the application");
                }

                switch (MenuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount of cubic metres that are to be converted to litres");
                        cubicmeters = Convert.ToInt16(Console.ReadLine());
                        litres = cubicmeters * 1000;
                        Console.WriteLine(cubicmeters + "cubic metres is " + litres + "litres");
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount of litres that are to be converted to cubic metres");
                        litres = Convert.ToInt16(Console.ReadLine());
                        cubicmeters = litres / 1000;
                        Console.WriteLine(litres + "litres is " + cubicmeters + "cubicmetres");
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount of cubic inches to be converted to cubic centimetres");
                        cubicinches = Convert.ToInt16(Console.ReadLine());
                        cubiccentimeters = cubicinches * 16.387064;
                        Console.WriteLine(cubiccentimeters + "cubic centimetres");
                        break;

                    case 4:
                        Console.WriteLine("Enter the amount of cubic centimetres to be converted to cubic inches");
                        cubiccentimeters = Convert.ToInt16(Console.ReadLine());
                        cubicinches = cubiccentimeters / 16.387064;
                        Console.WriteLine(cubicinches + "cubic inches");
                        break;

                    case 5:
                        Console.WriteLine("Enter the amount of cubic feet to be converted to cubic metres");
                        cubicfeet = Convert.ToInt16(Console.ReadLine());
                        cubicmeters = cubicfeet * 0.0283168466;
                        Console.WriteLine(cubicmeters + "cubic metres");
                        break;

                    case 6:
                        Console.WriteLine("Enter the amount of cubic metre to be converted to cubic feet");
                        cubicmeters = Convert.ToInt16(Console.ReadLine());
                        cubicfeet = cubicmeters / 0.0283168466;
                        Console.WriteLine(cubicmeters + "cubic metres");
                        break;

                    case 7:
                        Console.WriteLine("Enter the amount of Gallons(US) to be converted to litres");
                        gallonsUS = Convert.ToInt16(Console.ReadLine());
                        litres = gallonsUS / 3.78541178;
                        Console.WriteLine(litres + "litres");
                        break;

                    case 8:
                        Console.WriteLine("Enter the amount of litres to be converted to Gallons(US)");
                        litres = Convert.ToInt16(Console.ReadLine());
                        gallonsUS = litres * 3.78541178;
                        Console.WriteLine(gallonsUS + "Gallons(US)");
                        break;

                    case 9:
                        Console.WriteLine("Enter the amount of Gallons(UK) to be converted to litres");
                        gallonsUK = Convert.ToInt16(Console.ReadLine());
                        litres = gallonsUK * 4.54609;
                        Console.WriteLine(litres + "litres");
                        break;

                    case 10:
                        Console.WriteLine("Enter the amount of litres to be converted to Gallons(UK)");
                        litres = Convert.ToInt16(Console.ReadLine());
                        gallonsUK = litres / 4.54609;
                        Console.WriteLine(gallonsUK + "Gallons(UK)");
                        break;

                    case 11:
                        Console.WriteLine("Enter the amount of fluid ounces(US) to be converted to milimetres");
                        fluidouncesUS = Convert.ToInt16(Console.ReadLine());
                        milimetres = fluidouncesUS * 29.5735;
                        Console.WriteLine(milimetres + "milimetres(mm)");
                        break;

                    case 12:
                        Console.WriteLine("Enter the amount of milimetres to be converted to fluid ounces(US)");
                        milimetres = Convert.ToInt16(Console.ReadLine());
                        fluidouncesUS = milimetres / 29.5735;
                        Console.WriteLine(fluidouncesUS + "fluid ounces(US)");
                        break;

                    case 13:
                        Console.WriteLine("Enter the amount of fluid ounces(UK) to be converted to milimetres");
                        fluidouncesUK = Convert.ToInt16(Console.ReadLine());
                        milimetres = fluidouncesUK * 28.4131;
                        Console.WriteLine(milimetres + "milimetres(m)");
                        break;

                    case 14:
                        Console.WriteLine("Enter the amount of milimetres to be converted to fluid ounces(UK)");
                        milimetres = Convert.ToInt16(Console.ReadLine());
                        fluidouncesUK = milimetres / 28.4131;
                        Console.WriteLine(fluidouncesUK + "fluid ounces(UK)");
                        break;

                    case 15:
                        Console.WriteLine("Enter the amount of teaspoons(US) to be converted to milimetres");
                        teaspoonsUS = Convert.ToInt16(Console.ReadLine());
                        milimetres = teaspoonsUS * 4.92892;
                        Console.WriteLine(milimetres + "milimetres(m)");
                        break;

                    case 16:
                        Console.WriteLine("Enter the amount of milimetres to be converted to teaspoons(US)");
                        milimetres = Convert.ToInt16(Console.ReadLine());
                        teaspoonsUS = milimetres / 4.92892;
                        Console.WriteLine(teaspoonsUS + "teaspoons(US)");
                        break;

                    case 17:
                        Console.WriteLine("Enter the amount of tablespoons(US) to be converted to milimetres");
                        tablespoonsUS = Convert.ToInt16(Console.ReadLine());
                        milimetres = tablespoonsUS * 14.7868;
                        Console.WriteLine(milimetres + "milimetres(m)");
                        break;

                    case 18:
                        Console.WriteLine("Enter the amount of milimetres to be converted to tablespoons(US)");
                        milimetres = Convert.ToInt16(Console.ReadLine());
                        tablespoonsUS = milimetres / 14.7868;
                        Console.WriteLine(tablespoonsUS + "tablespoons(US)");
                        break;

                    case 19:
                        Console.WriteLine("Enter the amount of cubic yards to be converted to cubic metres");
                        cubicyards = Convert.ToInt16(Console.ReadLine());
                        cubicmeters = cubicyards * 0.76455485798;
                        Console.WriteLine(cubicmeters + "cubic metres");
                        break;

                    case 20:
                        Console.WriteLine("Enter the amount of cubic metres to be converted to cubic yards");
                        cubicmeters = Convert.ToInt16(Console.ReadLine());
                        cubicyards = cubicmeters / 0.76455485798;
                        Console.WriteLine(cubicyards + "cubic yards");
                        break;

                    case 21:
                        Console.WriteLine("Going back to main menu...");
                        MainMenu();
                        break;
                }
            }
        }

        public static void length()
        {
            Console.WriteLine("Welcome To The Length Calculator!\n");

            while (true)
            {
                double milimetre;
                double centimetre;
                double metre;
                double kilometre;
                double foot;
                double inch;
                double yard;
                double mile;
                double nauticalmile;

                double answer;

                Console.WriteLine("Please choose one by entering the number for the desired conersion/calculation\n");
                Console.WriteLine("1 = Milimetre to Centimetre");
                Console.WriteLine("2 = Centimetre to Milimetre");
                Console.WriteLine("3 = Meter to Kilometre");
                Console.WriteLine("4 = Kilometre to Metre");
                Console.WriteLine("5 = Foot to Metre");
                Console.WriteLine("6 = Metre to Foot");
                Console.WriteLine("7 = Inch to Centimetre");
                Console.WriteLine("8 = Centimetre to Inch");
                Console.WriteLine("9 = Yard to Metre");
                Console.WriteLine("10 = Metre to Yard");
                Console.WriteLine("11 = Mile to Kilometre");
                Console.WriteLine("12 = Kilometre to Mile");
                Console.WriteLine("13 = Nautical Mile to Kilometre");
                Console.WriteLine("14 = Kilometre to Nautical Mile");
                Console.WriteLine("15 = Return Back to Main Menu");
                Console.WriteLine("16 = Exit\n");
                Console.WriteLine("Please enter your choice");

                int MenuChoice = Convert.ToInt16(Console.ReadLine());


                if (MenuChoice == 16)
                {
                    Console.WriteLine("About to exit application");
                }

                switch (MenuChoice)
                {
                    case 1:
                        Console.WriteLine("Please state the amount of milimetres you would like to convert to centimetres");
                        milimetre = Convert.ToInt16(Console.ReadLine());
                        centimetre = milimetre / 10;
                        Console.WriteLine(milimetre + "(mm) is " + centimetre + "(cm)");
                        break;

                    case 2:
                        Console.WriteLine("Please state the amount of centimetres you would like to convert to milimetres");
                        centimetre = Convert.ToInt16(Console.ReadLine());
                        milimetre = centimetre * 10;
                        Console.WriteLine(centimetre + "(cm) is " + milimetre + "(mm)");
                        break;

                    case 3:
                        Console.WriteLine("Please state the amount of metres you would like to convert to kilometres");
                        metre = Convert.ToInt16(Console.ReadLine());
                        kilometre = metre / 1000;
                        Console.WriteLine(metre + "(m) is " + kilometre + "(km)");
                        break;

                    case 4:
                        Console.WriteLine("Please state the amount of kilometres you would like to convert to metres");
                        kilometre = Convert.ToInt16(Console.ReadLine());
                        metre = kilometre * 1000;
                        Console.WriteLine(kilometre + "(km) is " + metre + "(m)");
                        break;

                    case 5:
                        Console.WriteLine("Please state the amount of feet you would like to convert to metres");
                        foot = Convert.ToInt16(Console.ReadLine());
                        metre = foot * 0.3048;
                        Console.WriteLine(foot + "foot/feet is " + metre + "(m)");
                        break;

                    case 6:
                        Console.WriteLine("Please state the amount of metres you would like to convert to feet");
                        metre = Convert.ToInt16(Console.ReadLine());
                        foot = metre / 0.3048;
                        Console.WriteLine(metre + "(m) is " + foot + "foot/feet");
                        break;

                    case 7:
                        Console.WriteLine("Please state the amount of inches you would like to convert to centimetres");
                        inch = Convert.ToInt16(Console.ReadLine());
                        centimetre = inch * 2.54;
                        Console.WriteLine(inch + "inch is " + centimetre + "(m)");
                        break;

                    case 8:
                        Console.WriteLine("Please state the amount of centimetres you would like to convert to inches");
                        centimetre = Convert.ToInt16(Console.ReadLine());
                        inch = centimetre / 2.54;
                        Console.WriteLine(centimetre + "(cm) is " + inch + "inch");
                        break;

                    case 9:
                        Console.WriteLine("Please state the amount of yards you would like to convert to metres");
                        yard = Convert.ToInt16(Console.ReadLine());
                        metre = yard * 0.9144;
                        Console.WriteLine(yard + "yards is " + metre + "(m)");
                        break;

                    case 10:
                        Console.WriteLine("Please state the amount of metres you would like to convert to yards");
                        metre = Convert.ToInt16(Console.ReadLine());
                        yard = metre / 0.9144;
                        Console.WriteLine(metre + "(m) is " + yard + "yards");
                        break;

                    case 11:
                        Console.WriteLine("Please state the amount of miles you would like to convert to kilometres");
                        mile = Convert.ToInt16(Console.ReadLine());
                        kilometre = mile * 1.609344;
                        Console.WriteLine(mile + "miles is " + kilometre + "(km)");
                        break;

                    case 12:
                        Console.WriteLine("Please state the amount of kilometres you would like to convert to miles");
                        kilometre = Convert.ToInt16(Console.ReadLine());
                        mile = kilometre / 1.609344;
                        Console.WriteLine(kilometre + "(km) is " + mile + "(m)");
                        break;

                    case 13:
                        Console.WriteLine("Please state the amount of nautical miles you would like to convert to kilometres");
                        nauticalmile = Convert.ToInt16(Console.ReadLine());
                        kilometre = nauticalmile * 1.852;
                        Console.WriteLine(nauticalmile + "nautical miles is " + kilometre + "(km)");
                        break;

                    case 14:
                        Console.WriteLine("Please state the amount of kilometres you would like to convert to nautical miles");
                        kilometre = Convert.ToInt16(Console.ReadLine());
                        nauticalmile = kilometre / 1.852;
                        Console.WriteLine(kilometre + "(km) is " + nauticalmile + "nautical miles");
                        break;

                    case 15:
                        Console.WriteLine("Going back to main menu...");
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine("Error: Invalid Choice.");
                        break;
                }
            }
        }

        public static void scientific()
        {
            Console.WriteLine("Welcome To The Scientific Calculator!");

            while (true)
            {
                Console.WriteLine("This is the menu containing the operations you might like to calculate, please choose by entering one of the operators\n");
                Console.WriteLine("1 = +");
                Console.WriteLine("2 = -");
                Console.WriteLine("3 = /");
                Console.WriteLine("4 = *");
                Console.WriteLine("5 = %");
                Console.WriteLine("6 = ^");
                Console.WriteLine("7 = Sqrt");
                Console.WriteLine("8 = Sin of an Angle");
                Console.WriteLine("9 = Cos of an Angle");
                Console.WriteLine("10 = Tan of an Angle");
                Console.WriteLine("11 = Sin Inverse of a number");
                Console.WriteLine("12 = Cos Inverse of a number");
                Console.WriteLine("13 = Tan Inverse of a number");
                Console.WriteLine("14 = Return Back to Main Menu");
                Console.WriteLine("15 = Exit\n");
                Console.WriteLine("Please enter your choice");

                int MenuChoice = Convert.ToInt16(Console.ReadLine());

                if (MenuChoice == 15)
                {
                    Console.WriteLine("About to exit the application...");
                    break;
                }

                double NUM;
                double degrees;
                double x;
                double result;
                double sinTheta;
                double cosTheta;
                double tanTheta;
                double angle;
                double radians;
                double num;
                double num1;
                double num2;
                double baase;
                double exponent;

                double answer = 0;

                switch (MenuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        answer = num1 + num2;
                        break;

                    case 2:
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        answer = num1 - num2;
                        break;

                    case 3:
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: cannot divide by 0!");
                        }
                        else
                        {
                            answer = num1 / num2;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        answer = num1 * num2;
                        break;

                    case 5:
                        Console.WriteLine("Enter the first number:");
                        num1 = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        num2 = Convert.ToInt16(Console.ReadLine());

                        answer = (num1 / num2) * 100;
                        break;

                    case 6:
                        Console.WriteLine("Enter the base:");
                        baase = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter the exponent:");
                        exponent = Convert.ToInt16(Console.ReadLine());

                        answer = Math.Pow(baase, exponent);
                        break;

                    case 7:
                        Console.WriteLine("Enter the number you want square root to be calculated for:");
                        num = Convert.ToInt16(Console.ReadLine());

                        answer = Math.Sqrt(num);
                        break;

                    case 8:
                        Console.WriteLine("Please enter your angle size in degrees.");
                        angle = Convert.ToInt16(Console.ReadLine());

                        radians = angle * Math.PI / 180;

                        sinTheta = Math.Sin(radians);

                        Console.WriteLine("Sine of {0} degrees = {1}", angle, sinTheta);
                        break;

                    case 9:
                        Console.WriteLine("Please enter your angle size in degrees.");
                        angle = Convert.ToInt16(Console.ReadLine());

                        radians = angle * Math.PI / 180;

                        cosTheta = Math.Cos(radians);

                        Console.WriteLine("Sine of {0} degrees = {1}", angle, cosTheta);
                        break;

                    case 10:
                        Console.WriteLine("Please enter your angle size in degrees.");
                        angle = Convert.ToInt16(Console.ReadLine());

                        radians = angle * Math.PI / 180;

                        tanTheta = Math.Tan(radians);

                        Console.WriteLine("Sine of {0} degrees = {1}", angle, tanTheta);
                        break;

                    case 11:
                        Console.WriteLine("Please enter number.");
                        x = double.Parse(Console.ReadLine());

                        if (x < -1 || x > 1)
                        {
                            Console.WriteLine("Invalid input for Inverse Sin function. Please enter a number between -1 and 1.");
                        }
                        else
                        {
                            result = Math.Asin(x);
                            Console.WriteLine(/*"arcsin({0}) = {1}", x, */result);
                        }
                        break;

                    case 12:
                        Console.WriteLine("Please enter number.");
                        x = double.Parse(Console.ReadLine());

                        if (x < -1 || x > 1)
                        {
                            Console.WriteLine("Invalid input for Inverse Cos function. Please enter a number between -1 and 1.");
                        }
                        else
                        {
                            result = Math.Acos(x);
                            Console.WriteLine(result);
                        }
                        break;

                    case 13:
                        Console.WriteLine("Please enter number.");
                        x = double.Parse(Console.ReadLine());
                        if (x < -1 || x > 1)
                        {
                            Console.WriteLine("Invalid input for Inverse Tan function. Please enter a number between -1 and 1.");
                        }
                        else
                        {
                            result = Math.Tan(x);
                            Console.WriteLine(result);
                        }
                        break;

                    case 14:
                        Console.WriteLine("Going back to main menu...");
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine("Error: Invalid Choice.");
                        break;
                }
                Console.WriteLine("The answer is: " + answer);
            }
        }

        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
