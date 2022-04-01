using System;
using Pracrtice31._03._2022_ehtiyyat_.Models;

namespace Pracrtice31._03._2022_ehtiyyat_
{
    class Program
    {
        
            static void Main(string[] args)
            {
            Start:
                string fullName;
                try
                {
                    Console.WriteLine("Ad ve Soyadinizi daxil edin");
                    fullName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
                int age;
                try
                {
                    Console.WriteLine("Yasinizi daxil edin");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
                string email;
                try
                {
                    Console.WriteLine("Emailinizi daxil edin");
                    email = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
                string password;
                try
                {
                    Console.WriteLine("Sifrenizi daxil edin");
                    password = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
                User user = new User(email, password);
                Console.WriteLine("------------Menu------------");
                int choose;
                try
                {
                    do
                    {
                        Console.WriteLine("1. Show info\n2. Create new group\n3-Info\n0-Cixis");
                        Console.WriteLine("---------------------------");
                        choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 3:
                                Console.WriteLine("---------------------------");
                                break;
                            case 1:
                                Console.WriteLine("---------------------------");
                                user.ShowInfo();
                                Console.WriteLine("---------------------------");
                                break;
                            case 0:
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Saqolun");
                                break;
                            case 2:
                                string groupNo;
                                try
                                {
                                    Console.WriteLine("Qrup nomresini daxil edin");
                                    groupNo = Console.ReadLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto Start;
                                }
                                int studentLimit;
                                try
                                {
                                    Console.WriteLine("Telebe sayini daxil edin");
                                    studentLimit = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto Start;
                                }
                                Group group = new Group(groupNo, studentLimit);
                                string fullName1;
                                try
                                {
                                    Console.WriteLine("Ad ve Soyadinizi daxil edin");
                                    fullName1 = Console.ReadLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto Start;
                                }
                                int age1;
                                try
                                {
                                    Console.WriteLine("Yasinizi daxil edin");
                                    age1 = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto Start;
                                }
                                double point;
                                try
                                {
                                    Console.WriteLine("Balinizi daxil edin");
                                    point = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    goto Start;
                                }
                                Student student = new Student(fullName1, point);
                                Console.WriteLine("------------Menu------------");
                                int edit;
                                do
                                {
                                    Console.WriteLine("1. Show all students\n2-Get student by id\n3-Add student\n4-Info\n0-Quit");
                                    edit = int.Parse(Console.ReadLine());
                                    switch (edit)
                                    {
                                        case 1:
                                            Console.WriteLine("---------------------------");
                                            foreach (var item in group.GetAllStudents())
                                            {
                                                item.FullName = "";
                                            }
                                            Console.WriteLine("---------------------------");
                                            break;
                                        case 2:
                                            int id;
                                            try
                                            {
                                                Console.WriteLine("Bir Id daxil edin");
                                                id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("---------------------------");
                                                group.GetStudent(id);
                                                Console.WriteLine("---------------------------");
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                                goto Start;
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("---------------------------");
                                            group.AddStudents(student);
                                            Console.WriteLine("---------------------------");
                                            break;
                                        case 4:
                                            Console.WriteLine("---------------------------");
                                            break;
                                        case 0:
                                            Console.WriteLine("---------------------------");
                                            Console.WriteLine("Saqolun");
                                            break;
                                        default:
                                            Console.WriteLine("Sehv Daxil Etdiniz...");
                                            break;
                                    }
                                } while (edit != 0);
                                break;
                            default:
                                Console.WriteLine("Sehv Daxil Etdiniz...");
                                break;
                        }
                    } while (choose != 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
            }
        }
    }

