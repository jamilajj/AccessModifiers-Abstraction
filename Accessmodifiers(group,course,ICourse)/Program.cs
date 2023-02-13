using System;

namespace Accessmodifiers_group_course_ICourse_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            string opt;
            do
            {

                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2. Butun qruplara bax");
                Console.WriteLine("3. Verilmiş point aralığındaki qruplara bax");
                Console.WriteLine("4. Verilmiş nömrəli qrupa bax");
                Console.WriteLine("5. Verilmiş qruplar üzrə axtarış et");
                Console.WriteLine("0 . Menudan cıx");

                Console.Write("\nEmeliyyat secin: ");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        string no;
                       
                            do
                            {
                                Console.Write("No: ");

                                no = Console.ReadLine();
                            } while (!CheckNo(no));

                         try
                         {
                            byte avgPoint;
                            string avgPointStr;
                            do
                            {
                                Console.Write("AvgPoint: ");
                                avgPointStr = Console.ReadLine();

                            } while (byte.TryParse(avgPointStr, out avgPoint) == false || avgPoint > 100);


                            Group group = new Group
                            {
                                AvgPoint = avgPoint,
                                No = no
                            };

                            course.AddGroup(group);
                            break;
                         }
                         catch(Exception ex)
                         {
                            Console.WriteLine(ex.Message);
                         }
                       
                    case "2":
                        foreach (var item in course.Groups)
                        {
                            Console.WriteLine($"No: {item.No} - AvgPoint: {item.AvgPoint}");
                        }
                        break;
                    case "3":
                        Console.Write("MinPoint: ");
                        byte minPoint = Convert.ToByte(Console.ReadLine());

                        Console.Write("MaxPoint: ");
                        byte maxPoint = Convert.ToByte(Console.ReadLine());

                        var arr = course.GetGroupByPointRange(minPoint, maxPoint);

                        foreach (var item in arr)
                        {
                            Console.WriteLine($"No: {item.No} - AvgPoint: {item.AvgPoint}");
                        }
                        break;
                    case "4":
                        Console.Write("No: ");
                        string wantedNo = Console.ReadLine();
                        var wantedGroup = course.GetGroupByNo(wantedNo);

                        if (wantedGroup == null)
                            Console.WriteLine($"{wantedNo} nomreli qrup yoxdur!");
                        else
                            Console.WriteLine($"No: {wantedNo} - AvgPoint: { wantedGroup.AvgPoint}");
                        break;
                    case "5":
                        Console.Write("Search: ");
                        string search = Console.ReadLine();

                        arr = course.Search(search);
                        try 
                        {
                            foreach (var item in arr)
                            {
                                Console.WriteLine($"No: {item.No} - AvgPoint: {item.AvgPoint}");
                            }
                        }
                        catch(Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "0":
                        Console.WriteLine("proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("\nSeciminiz sehvdir!");
                        break;
                }

            }
            
                 while (opt != "0");
        }

        private static bool CheckNo(string no)
        {
            {
                if (no != null)
                {
                    if (no.Length == 4)
                    {
                        if (char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                            return true;
                    }
                }

                return false;
                
            }
        }
    }
}
