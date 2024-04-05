using Core.Models;

namespace RecordsTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title, description, choice, content, idStr;
            int id;

            do
            {

                Console.WriteLine("\t\tEsas menyu\n1.Blog yarat\n0.Proqramdan cix");
                choice = Console.ReadLine();


                if (choice == "1")
                {
                    do
                    {
                        Console.WriteLine("Blog-un title hissesini daxil edin: ");
                        title = Console.ReadLine();
                    } while (!Helper.CheckBlogTitle(title));

                    do
                    {
                        Console.WriteLine("Blog-un description hissesini daxil edin: ");
                        description = Console.ReadLine();

                    } while (!Helper.CheckBlogDescription(description));



                    Blog blog = new Blog(title, description);

                    do
                    {

                        Console.WriteLine("\n1.Comment yarat\n2.Commentlere bax\n3.Commente bax\n4.Commenti sil\n5.Commenti deyis(update)\n0.Esas menyuya qayit");
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "0":
                                break;


                            case "1":


                                Console.WriteLine("Comment ucun content daxil edin: ");
                                content = Console.ReadLine();

                                Comment comment = new Comment(content);

                                blog.AddComment(comment);
                                break;



                            case "2":

                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Butun commentlerin siyahisi : ");



                                for (int i = 0; i < blog.GetAllComments().Length; i++)
                                {
                                    Console.WriteLine(blog.GetAllComments()[i].ToString());
                                }

                                break;



                            case "3":

                                do
                                {
                                    Console.WriteLine("Axtarilan commentin Id nomresini daxil edin: ");
                                    idStr = Console.ReadLine();
                                } while (!(int.TryParse(idStr, out id)));

                                Console.WriteLine(blog.GetComment(id).ToString());
                                break;



                            case "4":

                                do
                                {
                                    Console.WriteLine("Silinecek commentin Id nomresini daxil edin: ");
                                    idStr = Console.ReadLine();
                                } while (!(int.TryParse(idStr, out id)));


                                blog.RemoveComment(id);
                                Console.WriteLine($"\n{id} - nomreli comment silindi...");
                                break;

                            case "5":

                                do
                                {
                                    Console.WriteLine("Deyisilmeli olan commentin Id nomresini daxil edin: ");
                                    idStr = Console.ReadLine();
                                } while (!(int.TryParse(idStr, out id)));

                                Console.WriteLine("Yeni comment ucun content daxil edin: ");
                                content = Console.ReadLine();

                                Comment newcomment = new Comment(content);
                                blog.UpdateComment(id, newcomment);
                                break;

                            default:
                                Console.WriteLine("Secim yanlisdir!\n");
                                break;
                        }
                    } while (choice != "0");

                }

                else if (choice == "0")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Secim yanlisdir!\n");
                }

            } while (true);
        }
    }
}
