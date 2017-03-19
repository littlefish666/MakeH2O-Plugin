using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace MakeH2O_plugin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Make H2O plugin by Frazzlee";


            Console.WriteLine(@"plugin must be placed in scene folder to work (*car name*\scene\) - SMALL S");

            
            string execpath;
            execpath = System.IO.Path.GetDirectoryName(
               System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            Console.WriteLine("Current executable location{0}", execpath);

            var isScene = execpath.Substring(execpath.Length - 5);
            Console.WriteLine(@"topfolder name (should be ""scene"") is:{0}", isScene);
            
            string execpath1 = execpath.Remove(0, 6);

            if (!isScene.Equals("scene"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"application will close ERROR: exe is not located in ""scene"" folder");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("exe is in correct location");
            }


            Thread.Sleep(500);

            Console.WriteLine("working...");

            string path = execpath1 +@"\Exterior\BumperF";
            if (Directory.Exists(path))
            {
                string[] files = System.IO.Directory.GetFiles(path, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string bumperF = execpath1 + @"\Exterior\BumperF\modelbins.txt";
                File.WriteAllLines(bumperF, files);
                File.AppendAllText("log.log", "Front Bumper Processed" + System.Environment.NewLine);
            }
            else
            {

            }


            string path1 = execpath1 + @"\Exterior\BumperR";
            if (Directory.Exists(path1))
            {
                string[] files1 = System.IO.Directory.GetFiles(path1, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string bumperR = execpath1 + @"\Exterior\BumperR\modelbins.txt";
                File.WriteAllLines(bumperR, files1);
                File.AppendAllText("log.log", "Rear Bumper Processed" + System.Environment.NewLine);
            }
            else
            {

            }


            string path2 = execpath1 + @"\Exterior\chassis";
            if (Directory.Exists(path2))
            {
                string[] files2 = System.IO.Directory.GetFiles(path2, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string chassis = execpath1 + @"\Exterior\chassis\modelbins.txt";
                File.WriteAllLines(chassis, files2);
                File.AppendAllText("log.log", "Chassis Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path3 = execpath1 + @"\Exterior\doors";
            if (Directory.Exists(path3))
            {
                string[] files3 = System.IO.Directory.GetFiles(path3, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string doors = execpath1 + @"\Exterior\doors\modelbins.txt";
                File.WriteAllLines(doors, files3);
                File.AppendAllText("log.log", "Exterior Doors" + System.Environment.NewLine);
            }
            else
            {

            }

            string path4 = execpath1 + @"\Exterior\engine";
            if (Directory.Exists(path4))
            {
                string[] files4 = System.IO.Directory.GetFiles(path4, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string engine = execpath1 + @"\Exterior\engine\modelbins.txt";
                File.WriteAllLines(engine, files4);
                File.AppendAllText("log.log", "Engine Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path5 = execpath1 + @"\Exterior\fenders";
            if (Directory.Exists(path5))
            {
                string[] files5 = System.IO.Directory.GetFiles(path5, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string fenders = execpath1 + @"\Exterior\fenders\modelbins.txt";
                File.WriteAllLines(fenders, files5);
                File.AppendAllText("log.log", "Fenders Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path6 = execpath1 + @"\Exterior\hood";
            if (Directory.Exists(path6))
            {
                string[] files6 = System.IO.Directory.GetFiles(path6, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string hood = execpath1 + @"\Exterior\hood\modelbins.txt";
                File.WriteAllLines(hood, files6);
                File.AppendAllText("log.log", "Hood Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path7 = execpath1 + @"\Exterior\plate";
            if (Directory.Exists(path7))
            {
                string[] files7 = System.IO.Directory.GetFiles(path7, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string plate = execpath1 + @"\Exterior\plate\modelbins.txt";
                File.WriteAllLines(plate, files7);
                File.AppendAllText("log.log", "Plate Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path8 = execpath1 + @"\Exterior\platform";
            if (Directory.Exists(path8))
            {
                string[] files8 = System.IO.Directory.GetFiles(path8, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string platform = execpath1 + @"\Exterior\platform\modelbins.txt";
                File.WriteAllLines(platform, files8);
                File.AppendAllText("log.log", "Platform Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path9 = execpath1 + @"\Exterior\PrimaryLights";
            if (Directory.Exists(path9))
            {
                string[] files9 = System.IO.Directory.GetFiles(path9, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string primLights = execpath1 + @"\Exterior\PrimaryLights\modelbins.txt";
                File.WriteAllLines(primLights, files9);
                File.AppendAllText("log.log", "Primary Lights Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path10 = execpath1 + @"\Exterior\SecondaryLights";
            if (Directory.Exists(path10))
            {
                string[] files10 = System.IO.Directory.GetFiles(path10, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string secLights = execpath1 + @"\Exterior\SecondaryLights\modelbins.txt";
                File.WriteAllLines(secLights, files10);
                File.AppendAllText("log.log", "Secondary Lights Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path11 = execpath1 + @"\Exterior\SideSkirts";
            if (Directory.Exists(path11))
            {
                string[] files11 = System.IO.Directory.GetFiles(path11, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string skirts = execpath1 + @"\Exterior\SideSkirts\modelbins.txt";
                File.WriteAllLines(skirts, files11);
                File.AppendAllText("log.log", "SideSkirts Processed" + System.Environment.NewLine);
            }
            else
            {

            }


            string path12 = execpath1 + @"\Exterior\trunk";
            if (Directory.Exists(path12))
            {
                string[] files12 = System.IO.Directory.GetFiles(path12, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string trunk = execpath1 + @"\Exterior\trunk\modelbins.txt";
                File.WriteAllLines(trunk, files12);
                File.AppendAllText("log.log", "Trunk Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path13 = execpath1 + @"\Exterior\windows";
            if (Directory.Exists(path13))
            {
                string[] files13 = System.IO.Directory.GetFiles(path13, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string windows = execpath1 + @"\Exterior\windows\modelbins.txt";
                File.WriteAllLines(windows, files13);
                File.AppendAllText("log.log", "Exterior Windows Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path14 = execpath1 + @"\Interior\CenterConsole";
            if (Directory.Exists(path14))
            {
                string[] files14 = System.IO.Directory.GetFiles(path14, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string console = execpath1 + @"\Interior\CenterConsole\modelbins.txt";
                File.WriteAllLines(console, files14);
                File.AppendAllText("log.log", "Centre Console Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path15 = execpath1 + @"\Interior\CenterStack";
            if (Directory.Exists(path15))
            {
                string[] files15 = System.IO.Directory.GetFiles(path15, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string stack = execpath1 + @"\Interior\CenterStack\modelbins.txt";
                File.WriteAllLines(stack, files15);
                File.AppendAllText("log.log", "Centre Stack Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path16 = execpath1 + @"\Interior\dash";
            if (Directory.Exists(path16))
            {
                string[] files16 = System.IO.Directory.GetFiles(path16, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string dash = execpath1 + @"\Interior\dash\modelbins.txt";
                File.WriteAllLines(dash, files16);
                File.AppendAllText("log.log", "Dash Processed - reccomended to do 1 modelbin at a time to make it easier to scale this" + System.Environment.NewLine);
            }
            else
            {

            }

            string path17 = execpath1 + @"\Interior\details";
            if (Directory.Exists(path17))
            {
                string[] files17 = System.IO.Directory.GetFiles(path17, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string details = execpath1 + @"\Interior\details\modelbins.txt";
                File.WriteAllLines(details, files17);
                File.AppendAllText("log.log", "Details Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path18 = execpath1 + @"\Interior\doors";
            if (Directory.Exists(path18))
            {
                string[] files18 = System.IO.Directory.GetFiles(path18, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string doors1 = execpath1 + @"\Interior\doors\modelbins.txt";
                File.WriteAllLines(doors1, files18);
                File.AppendAllText("log.log", "Doors Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path19 = execpath1 + @"\Interior\floor";
            if (Directory.Exists(path19))
            {
                string[] files19 = System.IO.Directory.GetFiles(path19, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string floor = execpath1 + @"\Interior\floor\modelbins.txt";
                File.WriteAllLines(floor, files19);
                File.AppendAllText("log.log", "Floor Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path20 = execpath1 + @"\Interior\gauges";
            if (Directory.Exists(path20))
            {
                string[] files20 = System.IO.Directory.GetFiles(path20, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string gauges = execpath1 + @"\Interior\gauges\modelbins.txt";
                File.WriteAllLines(gauges, files20);
                File.AppendAllText("log.log", "Gauges Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path21 = execpath1 + @"\Interior\InteriorLOD";
            if (Directory.Exists(path21))
            {
                string[] files21 = System.IO.Directory.GetFiles(path21, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string InteriorLOD = execpath1 + @"\Interior\InteriorLOD\modelbins.txt";
                File.WriteAllLines(InteriorLOD, files21);
                File.AppendAllText("log.log", "Interior LOD Processed - better to not use this, it's not useful at all" + System.Environment.NewLine);
            }
            else
            {

            }

            string path22 = execpath1 + @"\Interior\InteriorWindows";
            if (Directory.Exists(path22))
            {
                string[] files22 = System.IO.Directory.GetFiles(path22, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string intWindows = execpath1 + @"\Interior\InteriorWindows\modelbins.txt";
                File.WriteAllLines(intWindows, files22);
                File.AppendAllText("log.log", "Interior Windows Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path23 = execpath1 + @"\Interior\Pillar";
            if (Directory.Exists(path23))
            {
                string[] files23 = System.IO.Directory.GetFiles(path23, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Pillar = execpath1 + @"\Interior\Pillar\modelbins.txt";
                File.WriteAllLines(Pillar, files23);
                File.AppendAllText("log.log", "Pillar Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path24 = execpath1 + @"\Interior\Seats";
            if (Directory.Exists(path24))
            {
                string[] files24 = System.IO.Directory.GetFiles(path24, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Seats = execpath1 + @"\Interior\Seats\modelbins.txt";
                File.WriteAllLines(Seats, files24);
                File.AppendAllText("log.log", "Seats Processed" + System.Environment.NewLine);
            }
            else
            {

            }


            string path25 = execpath1 + @"\_library\Scene\Brakes\Calipers";
            if (Directory.Exists(path25))
            {
                string[] files25 = System.IO.Directory.GetFiles(path25, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Calipers = execpath1 + @"\_library\Scene\Brakes\Calipers\modelbins.txt";
                File.WriteAllLines(Calipers, files25);
                File.AppendAllText("log.log", "Calipers Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path26 = execpath1 + @"\_library\Scene\Brakes\Rotors";
            if (Directory.Exists(path26))
            {
                string[] files26 = System.IO.Directory.GetFiles(path26, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Rotors = execpath1 + @"\_library\Scene\Brakes\Rotors\modelbins.txt";
                File.WriteAllLines(Rotors, files26);
                File.AppendAllText("log.log", "Rotors Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path27 = execpath1 + @"\_library\Scene\Undercarriage";
            if (Directory.Exists(path27))
            {
                string[] files27 = System.IO.Directory.GetFiles(path27, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Undercarriage = execpath1 + @"\_library\Scene\Undercarriage\modelbins.txt";
                File.WriteAllLines(Undercarriage, files27);
                File.AppendAllText("log.log", "Undercarriage Processed" + System.Environment.NewLine);
            }
            else
            {

            }

            string path28 = execpath1 + @"\_library\Scene\Wheels";
            if (Directory.Exists(path28))
            {
                string[] files28 = System.IO.Directory.GetFiles(path28, "*.modelbin", System.IO.SearchOption.AllDirectories);
                string Wheels = execpath1 + @"\_library\Scene\Wheels\modelbins.txt";
                File.WriteAllLines(Wheels, files28);
                File.AppendAllText("log.log", "Wheels Processed" + System.Environment.NewLine);
            }
            else
            {

            }





            //foreach (string models in files)
            {
                //string logpath = @"G:\Visual Studio Shared Projects\MakeH2O_Plugin\MakeH2O plugin\bin\Debug\log.ini";
                //Console.WriteLine(models);
                //File.WriteAllLines(models, logpath);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("work finished...");

            Console.WriteLine("enjoy - love from frazzlee");


            Console.ReadLine();




        }
    }
}
