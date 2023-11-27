

using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool opcion;
        static void Main(string[] args)
        {

            IfTree();
            //ArraysSoft();
        }

        public static bool AskToExit()
        {
            while (true)
            {
                Console.WriteLine("Do you want to exit? (Y/N)");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid option.");
                }
            }
        }

        public static void PrintArray()
        {

            //bool opcion;
            /*
            var list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("!");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(); 

            int edad = 0;
            String nombre = "";

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su nombre es: " + nombre + " y su edad es: " + edad);
            */
            String[] stringArray = { "Hello", "Bye", "Hola", "Adios" };
            int[] intArray = { 1, 2, 3, 4, 5 };


            String[] arryWOValues = new String[5];
            arryWOValues[0] = "a";
            arryWOValues[1] = "b";
            arryWOValues[2] = "c";
            arryWOValues[3] = "d";

            //Console.WriteLine(stringArray[0] + " " + arryWOValues[0] + " " + arryWOValues[1] + " " + arryWOValues[0]);
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("Bye");
            arrayList.Add("Hola");
            do
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    //Console.WriteLine(stringArray[i]);
                    if (stringArray[i] == "Adios")
                    {
                        Console.WriteLine(stringArray[i]);
                    }
                }


                Console.WriteLine("\nWhat word do you want add?\n");
                string word = Console.ReadLine();
                arrayList.Add(word);
                Console.WriteLine("\nThe word added was:\n");




                for (int i = 0; i < arrayList.Count; i++)
                {
                    Console.WriteLine(arrayList[i]);
                }


                opcion = AskToExit();

            } while (opcion == false);
        }


        public static void ArraysSoft()
        {
            int optionList = 0;
            string wordForAdd;
            bool opcion4 = false;
            bool isNumeric;
            string optionInput;
            ArrayList arrayList = new ArrayList();
            do
            {
                Console.WriteLine("\nWhat operation do you want to do?\n");
                Console.WriteLine("1. Show list");
                Console.WriteLine("2. Add Word");
                Console.WriteLine("3. Delete Word");
                Console.WriteLine("4. Exit\n\n");
                optionInput = Console.ReadLine();
                isNumeric = int.TryParse(optionInput, out optionList);
                if (isNumeric)
                {
                    Console.Clear();
                    switch (optionList)
                    {
                        case 1:
                            PrintArrayList(arrayList);
                            break;
                        case 2:
                            Console.WriteLine("\nWhat word do you want add?\n");
                            wordForAdd = Console.ReadLine();
                            arrayList.Add(wordForAdd);
                            Console.WriteLine("\nThe word added was:\n");
                            break;
                        case 3:

                            PrintArrayList(arrayList);
                            //wordForAdd = Console.ReadLine();//Esta tambien sera la palabra a eliminar o numero
                            //arrayList.Remove(wordForAdd);//FUncion para eliminar ya sea por numero o letra
                            DelteByNumberOrWord(arrayList);

                            Console.WriteLine("\nThe word deleted was:\n");
                            break;
                        case 4:
                            Console.WriteLine("\nGood Bye\n");
                            opcion4 = true;
                            break;
                    }

                    if (optionList != 1)
                    {
                        Console.Clear();
                    }
                    opcion = opcion4;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(optionInput + " is not a valid number, try again");
                }

            } while (opcion == false);

        }
        public static void PrintArrayList(ArrayList arrayList)
        {
            if (arrayList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\nThe list is empty :( insert a data first\n");
            }
            else
            {
                Console.WriteLine("\n--------This is the list--------\n");
                for (int i = 0; i < arrayList.Count; i++)
                {
                    int position = i + 1;
                    Console.WriteLine(position + "- " + arrayList[i]);

                }
                Console.WriteLine("\n--------------------------------\n\n");
            }
        }
        public static void DelteByNumberOrWord(ArrayList arrayList)
        {
            Console.WriteLine("\nWhat word do you want delete?\n");
            string word = Console.ReadLine();
            bool isNumericOption = int.TryParse(word, out int optionNumber);
            if (isNumericOption)
            {
                arrayList.RemoveAt(optionNumber - 1);
            }
            else
            {
                arrayList.Remove(word);
            }

        }
        public static void IfTree()
        {

            int baseTree = 0;
            int altTree = 0;

            Console.WriteLine("Set the base of the tree: ");
            baseTree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Set the alt of the tree: ");
            altTree = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i == baseTree; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
