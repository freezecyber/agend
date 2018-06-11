using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendconsol
{
    static class Program
    {
        private static string label20;
        private static string label19;
        private static int hj;
        private static string ftg;
        private static Thread hsd;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("Bienvenue sur le programe Pour la Compagnie" + Environment.NewLine + "nous sommes fier de vous presenter" + Environment.NewLine + " linterface avec intelligence artificiel" + Environment.NewLine + "elle peut apprendre evoluer et changer");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("Creer par : YAN BERGERON");
            Console.WriteLine("--------");

            string fth = File.ReadAllText("directory.tx");
            ftg = fth;
            System.IO.Directory.SetCurrentDirectory(fth);
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(ftg);
                Environment.CurrentDirectory = ftg;

                Properties.Settings.Default.Save();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
            // Print to console the results.
            Console.WriteLine("Root directory: {0}", Directory.GetDirectoryRoot(ftg));
            Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());



            try
            {
                string myHost = System.Net.Dns.GetHostName();
                string myIP = null;

                for (int i = 0; i <= System.Net.Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
                {
                    if (System.Net.Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                    {
                        myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[i].ToString();
                    }
                }
                Console.WriteLine("--------");
                Console.WriteLine("local ip : " + myIP);
                var xg = Environment.SystemPageSize;
                Console.WriteLine("--------");
                Console.WriteLine("memory paging loaded : " + xg);
                string[] sss = Environment.GetLogicalDrives();
                Console.WriteLine("logical drives : ");
                foreach (string bf in sss)
                {
                    Console.Write(bf);
                }
                var stt = Environment.MachineName;
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.WriteLine("machinne name : " + stt);
                int tre = Environment.ProcessorCount;
                Console.WriteLine("--------");
                Console.WriteLine("processor count : " + tre);
                
                var sut = Environment.UserDomainName;
                Console.WriteLine("--------");
                Console.WriteLine("network name : " + myHost);
                var scx = Environment.UserName;
                Console.WriteLine("--------");
                Console.WriteLine("user name : " + scx);
                var syr = Environment.Version;
                Console.WriteLine("--------");
                var syre = Environment.OSVersion;
                Console.WriteLine("os ver : " + syre);
                Console.WriteLine("--------");
                Console.WriteLine("ver : " + syr);
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                Console.WriteLine("--------");
                Console.WriteLine("ip adress : " + externalip);

                Console.WriteLine("--------");

                var sfg = Environment.UserInteractive;
                Console.WriteLine("interactif : " + sfg);
            }
            catch { Console.WriteLine("error environement"); }
         
            hsd = new Thread(fsdfh);
            hsd.Start();
            Console.WriteLine("starting started check.....");
            do
            {
                hj = 1;
                var stgd = Console.ReadLine();

                if(stgd=="open")
                {
                    Console.WriteLine("opening...");
                    Thread shf = new Thread(pfkj);
                    shf.SetApartmentState(ApartmentState.STA);
                    shf.Start();
                }
                else if(stgd=="restart")
                {
                    Console.WriteLine("restart...");
                    hsd.Abort();
                    Console.WriteLine("sleep.");
                    Thread.Sleep(2500);
                
                    hsd.Start();
                    Console.WriteLine("all done.");
                }
                else
                {
                    Console.WriteLine("TYPE : open  : restart : TYPE");
                }
               
            } while (true);


        }

        private static void pfkj()
        {
            Console.WriteLine("run...");
            sIrc.agenda22 ksjd = new sIrc.agenda22();
            Application.Run(ksjd);
        }

        public static void sayt(string dhjgf)
        {

            System.Speech.Synthesis.SpeechSynthesizer syh = new System.Speech.Synthesis.SpeechSynthesizer();


            syh.SpeakAsync(dhjgf);
        }
        public static void fsdfh()
        {
            do
            {
                DateTime kg = DateTime.Now;
                label20 = kg.ToString("dd.MM");
                label19 = kg.ToString("HH.mm");


                if (File.Exists(label20 + label19 + ".txt"))
                {
                    Console.WriteLine("alarm detected");

                    hj++;
                    string fty = File.ReadAllText(label20 + label19 + ".txt");
                    if (hj <= 2)
                    {
                        sayt("alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm");
                        SoundPlayer ksj = new SoundPlayer();
                        ksj.SoundLocation = "tada.wav";
                        ksj.PlayLooping();

                        Application.DoEvents();
                        DialogResult jah = new DialogResult();
                        jah = MessageBox.Show("RAPPEL  .il est " + label19 + " et " + fty, "ALARM", MessageBoxButtons.OK);
                        if (jah == DialogResult.OK)
                        {
                            Console.WriteLine("stoping...");
                            ksj.Stop();

                        }
                        Console.WriteLine("alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm");
                    }
                    try
                    {
                        Console.WriteLine("deleted...");
                        File.Delete(label20 + label19 + ".txt");
                    }
                    catch { Console.WriteLine("error not deleting file in use"); }

                }

                Thread.Sleep(400);

            } while (true);
        }

    }
}
