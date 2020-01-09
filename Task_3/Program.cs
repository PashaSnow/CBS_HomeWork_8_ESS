using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            return false;
        }
    }
    enum Post
    {
        Director = 160,
        Developer = 160,
        ProjectManager = 100,
        HR = 130
    }
    class Program
    {
        static void Main()
        {
            Post x = Post.Director;
            Console.WriteLine(Accauntant.AskForBonus(x, 180));
        }
    }
}
