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
            Console.WriteLine("4 = Weight");
            Console.WriteLine("5 = Mass");
            Console.WriteLine("6 = Exit\n");
            int MainMenuChoice = Convert.ToInt16(Console.ReadLine());

            if (MainMenuChoice == 6)
            {
                Console.WriteLine("Exiting Application");
            }

            switch (MainMenuChoice)
            {
                case 1:
                    Console.WriteLine("Proceeding to the Scientifc Calculator...");
                    scientific();
                    break;

                case 2:
                    Console.WriteLine("Proceeding to the Length Calculator...");
                    length();
                    break;

                case 3:
                    Console.WriteLine("Proceeding to the Volume Calculator...");
                    volume();
                    break;

                case 4:
                    Console.WriteLine("Proceeding to the Weight Calculator...");
                    weight();
                    break;

                case 5:
                    Console.WriteLine("Proceeding to the Mass Calculator...");
                    mass();
                    break;
            }
        }

        public static void weight()
        {
            while (true)
            {
                Console.WriteLine("Welcome To The Weight Calculator!\n");

                double kilogram;
                double pound;
                double ounce;
                double gram;
                double stone;
                double ton;
                double miligram;
                double metricton;
                double carat;
                double centigram;
                double decigram;
                double tryoounce;
                double pennyweight;
                double tolas;
                double answer;
                double slug;
                double tonne;
                double microgram;

                Console.WriteLine("Please choose one by entering the number for the desired conersion/calculation\n");
                Console.WriteLine("1 = Kilograms to grams");
                Console.WriteLine("2 = Kilograms to pounds");
                Console.WriteLine("3 = Kilograms to ounces");
                Console.WriteLine("4 = Kilograms to metric tons");
                Console.WriteLine("5 = Kilograms to carats");
                Console.WriteLine("6 = Kilograms to stones");
                Console.WriteLine("7 = Pounds to ounces");
                Console.WriteLine("8 = Pounds to grams");
                Console.WriteLine("9 = Pounds to kilograms");
                Console.WriteLine("10 = Pounds to stones");
                Console.WriteLine("11 = Pounds to metric stones");
                Console.WriteLine("12 = Ounces to grams");
                Console.WriteLine("13 = Ounces to pounds");
                Console.WriteLine("14 = Ounces to kilograms");
                Console.WriteLine("15 = Grams to milligrams");
                Console.WriteLine("16 = Grams to centigrams");
                Console.WriteLine("17 = Grams to decigrams");
                Console.WriteLine("18 = Grams to kilograms");
                Console.WriteLine("19 = Grams to pounds");
                Console.WriteLine("20 = Grams to ounces");
                Console.WriteLine("21 = Grams to carats");
                Console.WriteLine("22 = Metric tons to kilograms");
                Console.WriteLine("23 = Metric tons to pounds");
                Console.WriteLine("24 = Metric tons to ounces");
                Console.WriteLine("25 = Metric tons to grams");
                Console.WriteLine("26 = Metric tons to carats");
                Console.WriteLine("27 = Carats to grams");
                Console.WriteLine("28 = Carats to ounces");
                Console.WriteLine("29 = Carats to pounds");
                Console.WriteLine("30 = Carats to kilograms");
                Console.WriteLine("31 = Stones to pounds");
                Console.WriteLine("32 = Stones to kilograms");
                Console.WriteLine("33 = Troy ounces to grams");
                Console.WriteLine("34 = Troy ounces to ounces");
                Console.WriteLine("35 = Troy ounces to pounds");
                Console.WriteLine("36 = Pennyweights to grams");
                Console.WriteLine("37 = Pennyweights to ounces");
                Console.WriteLine("38 = Pennyweights to pounds");
                Console.WriteLine("39 = Tolas to grams");
                Console.WriteLine("40 = Tolas to ounces");
                Console.WriteLine("41 = Tolas to pounds");
                Console.WriteLine("42 = Return back to main menu");
                Console.WriteLine("43 = Exit\n");

                int MenuChoice = Convert.ToInt16(Console.ReadLine());

                if (MenuChoice == 43)
                {
                    Console.WriteLine("Exiting the application");
                }

                switch (MenuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        gram = kilogram * 1000;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        pound = kilogram * 2.20462;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        ounce = kilogram * 35.27396;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 4:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        metricton = kilogram / 1000;
                        Console.WriteLine(metricton + "metric tons");
                        break;

                    case 5:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        carat = kilogram / 0.0002;
                        Console.WriteLine(carat + "carats");
                        break;

                    case 6:
                        Console.WriteLine("Enter the amount of kilogram");
                        kilogram = Convert.ToInt16(Console.ReadLine());
                        stone = kilogram / 6.35029318;
                        Console.WriteLine(stone + "stones");
                        break;

                    case 7:
                        Console.WriteLine("Enter the amount of pounds");
                        pound = Convert.ToInt16(Console.ReadLine());
                        ounce = pound * 16;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 8:
                        Console.WriteLine("Enter the amount of pounds");
                        pound = Convert.ToInt16(Console.ReadLine());
                        gram = pound * 453.59237;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 9:
                        Console.WriteLine("Enter the amount of pounds");
                        pound = Convert.ToInt16(Console.ReadLine());
                        kilogram = pound / 2.20462;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 10:
                        Console.WriteLine("Enter the amount of pounds");
                        pound = Convert.ToInt16(Console.ReadLine());
                        stone = pound / 14;
                        Console.WriteLine(stone + "stones");
                        break;

                    case 11:
                        Console.WriteLine("Enter the amount of pounds");
                        pound = Convert.ToInt16(Console.ReadLine());
                        metricton = pound / 2204.62;
                        Console.WriteLine(metricton + "metric tons");
                        break;

                    case 12:
                        Console.WriteLine("Enter the amount of ounces");
                        ounce = Convert.ToInt16(Console.ReadLine());
                        gram = ounce * 28.34952;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 13:
                        Console.WriteLine("Enter the amount of ounces");
                        ounce = Convert.ToInt16(Console.ReadLine());
                        pound = ounce / 16;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 14:
                        Console.WriteLine("Enter the amount of ounces");
                        ounce = Convert.ToInt16(Console.ReadLine());
                        kilogram = ounce / 35.274;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 15:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        miligram = gram * 1000;
                        Console.WriteLine(miligram + "miligrams");
                        break;

                    case 16:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        centigram = gram * 100;
                        Console.WriteLine(centigram + "centigrams");
                        break;

                    case 17:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        decigram = gram * 10;
                        Console.WriteLine(decigram + "decigrams");
                        break;

                    case 18:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        kilogram = gram / 1000;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 19:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        pound = gram / 453.59237;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 20:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        ounce = gram / 28.34952;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 21:
                        Console.WriteLine("Enter the amount of grams");
                        gram = Convert.ToInt16(Console.ReadLine());
                        carat = gram / 0.2;
                        Console.WriteLine(carat + "carat");
                        break;

                    case 22:
                        Console.WriteLine("Enter the amount of metric tons");
                        metricton = Convert.ToInt16(Console.ReadLine());
                        kilogram = metricton * 1000;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 23:
                        Console.WriteLine("Enter the amount of metric tons");
                        metricton = Convert.ToInt16(Console.ReadLine());
                        pound = metricton * 2204.62;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 24:
                        Console.WriteLine("Enter the amount of metric tons");
                        metricton = Convert.ToInt16(Console.ReadLine());
                        ounce = metricton * 35274;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 25:
                        Console.WriteLine("Enter the amount of metric tons");
                        metricton = Convert.ToInt16(Console.ReadLine());
                        gram = metricton * 1000000;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 26:
                        Console.WriteLine("Enter the amount of metric tons");
                        metricton = Convert.ToInt16(Console.ReadLine());
                        carat = metricton * 5000000;
                        Console.WriteLine(carat + "carats");
                        break;

                    case 27:
                        Console.WriteLine("Enter the amount of carats");
                        carat = Convert.ToInt16(Console.ReadLine());
                        gram = carat * 0.2;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 28:
                        Console.WriteLine("Enter the amount of carats");
                        carat = Convert.ToInt16(Console.ReadLine());
                        ounce = carat * 0.00705479239;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 29:
                        Console.WriteLine("Enter the amount of carats");
                        carat = Convert.ToInt16(Console.ReadLine());
                        pound = carat * 0.000440924524;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 30:
                        Console.WriteLine("Enter the amount of carats");
                        carat = Convert.ToInt16(Console.ReadLine());
                        kilogram = carat * 0.00705479239;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 31:
                        Console.WriteLine("Enter the amount of stones");
                        stone = Convert.ToInt16(Console.ReadLine());
                        pound = stone * 14;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 32:
                        Console.WriteLine("Enter the amount of stones");
                        stone = Convert.ToInt16(Console.ReadLine());
                        kilogram = stone * 6.35029;
                        Console.WriteLine(kilogram + "kilograms");
                        break;

                    case 33:
                        Console.WriteLine("Enter the amount of troy ounces");
                        tryoounce = Convert.ToInt16(Console.ReadLine());
                        gram = tryoounce * 31.1035;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 34:
                        Console.WriteLine("Enter the amount of troy ounces");
                        tryoounce = Convert.ToInt16(Console.ReadLine());
                        ounce = tryoounce * 1.09714;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 35:
                        Console.WriteLine("Enter the amount of troy ounces");
                        tryoounce = Convert.ToInt16(Console.ReadLine());
                        pound = tryoounce * 0.0685714;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 36:
                        Console.WriteLine("Enter the amount of pennyweights");
                        pennyweight = Convert.ToInt16(Console.ReadLine());
                        gram = pennyweight * 1.55517;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 37:
                        Console.WriteLine("Enter the amount of pennyweights");
                        pennyweight = Convert.ToInt16(Console.ReadLine());
                        ounce = pennyweight * 0.05;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 38:
                        Console.WriteLine("Enter the amount of pennyweights");
                        pennyweight = Convert.ToInt16(Console.ReadLine());
                        pound = pennyweight * 0.00390625;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 39:
                        Console.WriteLine("Enter the amount of tolas");
                        tolas = Convert.ToInt16(Console.ReadLine());
                        gram = tolas * 11.6638038;
                        Console.WriteLine(gram + "grams");
                        break;

                    case 40:
                        Console.WriteLine("Enter the amount of tolas");
                        tolas = Convert.ToInt16(Console.ReadLine());
                        ounce = tolas * 0.37593895;
                        Console.WriteLine(ounce + "ounces");
                        break;

                    case 41:
                        Console.WriteLine("Enter the amount of tolas");
                        tolas = Convert.ToInt16(Console.ReadLine());
                        pound = (tolas * 0.37593985) / 16;
                        Console.WriteLine(pound + "pounds");
                        break;

                    case 42:
                        MainMenu();
                        break;
                }
            }
        }

        public static void mass()
        {
            while (true)
            {
                Console.WriteLine("Welcome To The Mass Calculator!\n");

                double kilogram;
                double pound;
                double ounce;
                double gram;
                double stone;
                double ton;
                double miligram;
                double metricton;
                double carat;
                double centigram;
                double decigram;
                double tryoounce;
                double pennyweight;
                double tolas;
                double answer;
                double slug;
                double tonne;
                double microgram;

                Console.WriteLine("Please choose one by entering the number for the desired conersion/calculation\n");
                Console.WriteLine("1 = Kilogram to gram");
                Console.WriteLine("2 = Kilogram to miligram");
                Console.WriteLine("3 = Kilogram to microgram");
                Console.WriteLine("4 = Kilogram to pound");
                Console.WriteLine("5 = Kilogram to ounce");
                Console.WriteLine("6 = Kilogram to stone");
                Console.WriteLine("7 = Kilogram to tonne(metric ton)");
                Console.WriteLine("8 = Gram to kilogram");
                Console.WriteLine("9 = Gram to miligram");
                Console.WriteLine("10 = Gram to microgram");
                Console.WriteLine("11 = Gram to pound");
                Console.WriteLine("12 = Gram to ounce");
                Console.WriteLine("13 = Gram to grain");
                Console.WriteLine("14 = Gram to carat");
                Console.WriteLine("15 = Miligram to kilogram");
                Console.WriteLine("16 = Miligram to gram");
                Console.WriteLine("17 = Miligram to pound");
                Console.WriteLine("18 = Miligram to ounce");
                Console.WriteLine("19 = Miligram to grain");
                Console.WriteLine("20 = Miligram to carat");
                Console.WriteLine("21 = Microgram to kilogram");
                Console.WriteLine("22 = Microgram to gram");
                Console.WriteLine("23 = Microgram to miligram");
                Console.WriteLine("24 = Microgram to pound");
                Console.WriteLine("25 = Microgram to ounce");
                Console.WriteLine("26 = Ounce to kilogram");
                Console.WriteLine("27 = Ounce to gram");
                Console.WriteLine("28 = Ounce to miligram");
                Console.WriteLine("29 = Ounce to pound");
                Console.WriteLine("30 = Ounce to grain");
                Console.WriteLine("31 = Ounce to carat");
                Console.WriteLine("32 = Pound to kilogram");
                Console.WriteLine("33 = Pound to gram");
                Console.WriteLine("34 = Pound to miligram");
                Console.WriteLine("35 = Pound to microgram");
                Console.WriteLine("36 = Pound to ounce");
                Console.WriteLine("37 = Pound to stone");
                Console.WriteLine("38 = Pound to tonne(metric ton)");
                Console.WriteLine("39 = Stone to kilogram");
                Console.WriteLine("40 = Stone to pound");
                Console.WriteLine("41 = Tonne (metric ton) to kilogram");
                Console.WriteLine("42 = Tonne (metric ton) to pound");
                Console.WriteLine("43 = Grain to gram");
                Console.WriteLine("45 = Grain to miligram");
                Console.WriteLine("46 = Grain to ounce");
                Console.WriteLine("47 = Carat to gram");
                Console.WriteLine("48 = Carat to miligram");
                Console.WriteLine("49 = Slug to kilogram\n");
                Console.WriteLine("50 = Return back to main menu");
                Console.WriteLine("51 = Exit\n");

                int MenuChoice = Convert.ToInt16(Console.ReadLine());

                if (MenuChoice == 51)
                {
                    Console.WriteLine("Exiting the application");
                }

                switch(MenuChoice)
                {
                    case 1:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    gram = kilogram * 1000;
                    Console.WriteLine(grams + "grams");
                    break;

                    case 2:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    miligram = kilogram * 1000000;
                    Console.WriteLine(miligram + "miligrams");
                    break;
                    
                    case 3:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    microgram = kilogram * 1000000000;
                    Console.WriteLine(microgram + "micrograms");
                    break;

                    case 4:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    pound = kilogram * 2.20462;
                    Console.WriteLine(pound + "pounds");
                    break;

                    case 5:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    ounce = kilogram * 35.27396;
                    Console.WriteLine(ounce + "ounces");
                    break;

                    case 6:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    stone = kilogram * 0.157473;
                    Console.WriteLine(stone + "stones");
                    break;

                    case 7:
                    Console.WriteLine("Enter the amount of kilograms");
                    kilogram = Convert.ToInt16(Console.ReadLine());
                    tonne = kilogram * 0.001;
                    Console.WriteLine(tonne + "tonnes");
                    break;
                }
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
