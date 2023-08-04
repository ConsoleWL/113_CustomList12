namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomList<string> str = new CustomList<string>();
            //str.Add("hello1");
            //str.Add("hello2");
            //str.Add("hello3");
            //str.Add("hello4");
            ////str.Add("hello5");
            // str.Remove("hello4");
            //str.Remove("hello3");


            ////Console.WriteLine($"{str[-1]}");
            ////Console.WriteLine($"{str[1]}");
            ////Console.WriteLine($"{str[2]}");
            ////Console.WriteLine($"{str[3]}");

            //CustomList<string> names = new CustomList<string>();
            //names.Add("Nikk");
            //names.Add("Bob");
            //names.Add("Tom");

            //CustomList<string> names2 = new CustomList<string>();
            //names2.Add("Jeka");
            //names2.Add("Pit");

            //CustomList<string> namesall = names + names2;
            //Console.WriteLine(namesall.ToString());
            //Console.WriteLine();
            //CustomList<string> names3 = new CustomList<string>();
            //names3.Add("Nikk");
            //names3.Add("Bob");
            //names3.Add("Tom");
            //names3.Add("Mark");
            //Console.WriteLine(names3.ToString());


            //CustomList<string> names4 = new CustomList<string>();
            //names4.Add("Bob");
            //names4.Add("Nikk");
            //Console.WriteLine(names4.ToString());

            //CustomList<string> names5 = names3 - names4;
            //Console.WriteLine(names5.ToString());


            //CustomList<int> numbers = new CustomList<int>();
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //Console.WriteLine(numbers.ToString());
            //numbers.Remove(1);
            //Console.WriteLine(numbers.ToString());

            //List<int> numbers2= new List<int>();
            //numbers2.Add(1);
            //numbers2.Add(1);
            //numbers2.Add(1);
            //Console.WriteLine(numbers2.ToString());

            //numbers2.Remove(1);
            //Console.WriteLine(numbers2.ToString());

            //Arrange
            //CustomList<string> names = new CustomList<string>();
            //names.Add("Bob");
            //names.Add("Nik");
            //names.Add("Tom");
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            ////Set
            //names.Remove("Bob");
            //result1 = "Bob" == names[0]; ;

            ////Assert
            //List<int> nums = new List<int>();
            //int[] aray = new int[] { 1, 3 };





            //List<int> list1 = new List<int>();
            //list1.Add(1);


            //CustomList<int> numbs = new CustomList<int>();
            //numbs.Add(5);
            //numbs.Add(6);

            //CustomList<int> rams = new CustomList<int>();
            //rams.Add(4);
            //rams.Add(7);
            //rams.Add(11);

            //numbs.Zip(rams);
            //foreach (int n in numbs)
            //{
            //    Console.WriteLine(n);
            //}


            //// First CustomList has a four values stored in it:
            //CustomList<int> list1 = new CustomList<int> { 1, 2, 3, 4 };

            //// Second CustomList has 2 values stores in it
            //CustomList<int> list2 = new CustomList<int> { 2, 4 };

            //// A new CustimList has to be created where we will be storing the results
            //CustomList<int> result;

            //// Now list one is looking for any matching occurances in the second list
            //// We can see its number 2 and 4
            //// - operator removes those items from the list
            //// The resuls are stored in the new CustomList<int> result
            //result = list1 - list2;

            ////Displaying the results

            //Console.WriteLine(result.ToString());



            ////Now lets do the same with string type
            //CustomList<string> names1 = new CustomList<string> { "Bob", "Mike", "Tom", "Tim" };

            //CustomList<string> names2 = new CustomList<string> { "Bob", "Tim" };

            //CustomList<string> namesResult = names1 - names2;

            //foreach (string name in namesResult)
            //{
            //    Console.WriteLine(name);
            //}



            //CustomList<int> numbers1 = new CustomList<int> { 1, 2, 3, 4 };
            //CustomList<string> names1 = new CustomList<string> { "Bob", "Mike", "Tom", "Tim" };

            //CustomList<int> resutl = numbers1 - names1;



            CustomList<string> names1 = new CustomList<string> { "AAA", "CCC", "EEE"};
            CustomList<string> names2 = new CustomList<string> { "BBB", "DDD", "FFF"};

            names1.Zip(names2);

            foreach (var item in names1)
            {
                Console.WriteLine(item);
            }

            CustomList<int> numbers1 = new CustomList<int> { 1, 3, 5 };
            CustomList<int> numbers2 = new CustomList<int> { 2, 4, 6 };

            numbers1.Zip(numbers2);

            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }

            List<int> numbs = new List<int> { 2, 3, 56, 4, 32, };
            numbs.Sort

            

        }
    }
}