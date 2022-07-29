using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console = Colorful.Console;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Windows_Darkmemer_Farmer
{
    internal class Program
    {

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        static void Main(string[] args)
        {
            Console.Title = "Dark Memer Farmer";
            farmer();
        }

        private static int loopedtimes = 0;

        static void robTEXT()
        {
            //don't make methods for everything this is just because it's easier for me
            Console.WriteLine("digging", Color.FromArgb(92, 83, 173));
            Console.WriteLine("used pls dig", Color.White);
            Console.WriteLine("digged successfully", Color.LimeGreen);
        }

        static void huntTEXT()
        {
            Console.WriteLine("hunting", Color.FromArgb(92, 83, 173));
            Console.WriteLine("used pls hunt", Color.White);
            Console.WriteLine("hunted successfully", Color.LimeGreen);
        }

        static void begTEXT()
        {
            Console.WriteLine("begging", Color.FromArgb(92, 83, 173));
            Console.WriteLine("used pls beg", Color.White);
            Console.WriteLine("begged successfully", Color.LimeGreen);
        }

        static void fishTEXT()
        {
            Console.WriteLine("fishing", Color.FromArgb(92, 83, 173));
            Console.WriteLine("used pls fish", Color.White);
            Console.WriteLine("fished successfully", Color.LimeGreen);
        }
        static void farmer()
        {

            //dig
            Console.WriteLine("dank memer farmer has looped" + $" {loopedtimes}" + " times");
            Console.WriteLine("");
            cooldown();
            SendKeys.SendWait("pls dig {ENTER}");
            robTEXT();
            cooldown();

            //hunt
            Console.WriteLine("");
            cooldown();
            SendKeys.SendWait("pls hunt {ENTER}");
            huntTEXT();
            cooldown();

            //beg
            Console.WriteLine("");
            cooldown();
            SendKeys.SendWait("pls beg {ENTER}");
            begTEXT();
            cooldown();

            //fish
            Console.WriteLine("");
            cooldown();
            SendKeys.SendWait("pls fish {ENTER}");
            fishTEXT();
            cooldown();

            //selling

            //dig sell
            Console.WriteLine("");
            Console.WriteLine("selling items from digging", Color.FromArgb(92, 83, 173));
            cooldown();
            SendKeys.SendWait("pls sell box of sand {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell worm {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell ant {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell ladybug {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell stickbug {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell spider {ENTER}");

            Console.WriteLine("finished successfully", Color.FromArgb(84, 81, 207));
            cooldown();

            //hunt sell
            Console.WriteLine("");
            Console.WriteLine("selling items from hunting", Color.FromArgb(92, 83, 173));
            cooldown();
            SendKeys.SendWait("pls sell rabbits {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell skunk {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell boar {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell duck {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell deer {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell dragon {ENTER}");

            Console.WriteLine("finished successfully", Color.FromArgb(84, 81, 207));
            cooldown();

            //fish sell
            Console.WriteLine("");
            Console.WriteLine("selling items from fishing", Color.FromArgb(92, 83, 173));
            cooldown();
            SendKeys.SendWait("pls sell common fish {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell rare fish {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell exotic fish {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell legendary fish {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell laptop {ENTER}");
            cooldown();
            SendKeys.SendWait("pls sell garbage {ENTER}");
            Console.WriteLine("finished successfully", Color.FromArgb(84, 81, 207));
            cooldown();

            //check bal
            Console.WriteLine("");
            Console.WriteLine("depositing money", Color.FromArgb(92, 83, 173));
            cooldown();
            SendKeys.SendWait("pls bal {ENTER}");
            cooldown();
            SendKeys.SendWait("pls use banknote {ENTER}");
            cooldown();
            SendKeys.SendWait("pls deposit max {ENTER}");

            Console.WriteLine("finished successfully", Color.FromArgb(84, 81, 207));
            cooldown();

            loopedtimes = loopedtimes + 1;
            Console.Clear();
            farmer();
        }
        static void cooldown()
        {
            Thread.Sleep(6000);
        }
    }

}
