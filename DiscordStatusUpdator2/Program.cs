using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordStatusUpdator2
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;


        public static Channel lastchannel;
        public static DateTime stime;
        public static bool isbot = true;
        public static List<ulong> admin = new List<ulong>();
        public static List<String> commands = new List<String>();



        public static String bname = "DSU";
        public static String bver = "1.0";
        public static String i = "-";
        public static String motd = "Bot";

        public static Boolean m_cmds = true;
        public static Boolean s_speak = false;
        public static Boolean s_msgrm = false;


        public static Boolean abot = true;
        public static String auser = "";
        public static String apass = "";
        public static String atoken = "";
        public static Boolean atry = false;

        public static Boolean mst = false;

        public static Boolean mafk = false;
        public static Boolean mmen = false;
        public static Boolean mstat = true;
        public static String mstatm = "";
        public static String mmenm = "";
        public static String mafkm = "";

        public static String mstats = "";

        public static DiscordClient client = new DiscordClient();

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            // Show
            //ShowWindow(handle, SW_SHOW);


            Console.WriteLine("Formatting Console");
            test();
            Console.WriteLine("Defining variables");

            
            //client = new DiscordSocketClient(new DiscordSocketConfig() { AudioMode = AudioMode.Outgoing });

            Console.WriteLine("Defining Admins");
            //admin shit
            //so jordan: 
            

            Console.WriteLine("Defining Events");


            client.MessageReceived += (sender, e) =>
            {

                //Commands
                //Setup
                String t = e.Message.Text;
                User s = e.User;
                String[] a;
                a = e.Message.Text.ToLower().Split(' ');
                Channel c = e.Channel;

                String at = e.User.Mention + "\n";
                //End of Setup

                //Commands

                //Mention?
                if (e.Message.IsMentioningMe())
                {
                    if (!(e.Message.IsAuthor))
                    {
                        if (mafk)
                        {
                            c.SendMessage(e.User.Mention +"\n "+ mafkm);
                        }
                        if (mmen)
                        {
                            c.SendMessage(e.User.Mention + "\n" + mmenm);
                            System.Media.SystemSounds.Beep.Play();
                            MessageBox.Show(e.User.Name + " Mentioned You in #" + e.Channel.Name + "("+ e.Server.Name+")", "Mention!",
MessageBoxButtons.OK, MessageBoxIcon.None);
                            
                        }


                    }
                }

            };


            //new Channel

           


            //  Don't want messages to be removed? this piece of code will
            //  Keep messages for you. Remove if unused :)
          

            client.JoinedServer += (sender, e) =>
            {
                log("Joined Server: " + e.Server.Name + "(" + e.Server.Id + ")");
            };

            //Client Shit


            Application.Run(new LoginForm());
            ShowWindow(handle, SW_SHOW);
            client.ExecuteAndWait(async () => {
                Console.WriteLine("");
                Console.WriteLine("Starting : " + bname + " Version: " + bver);
                Console.WriteLine("");
                String aw = "";
                Console.WriteLine("");


                Console.WriteLine("Connecting to Client");

                Console.Title = "Bot: Connecting";
                //token stuff
                if (atry)
                {
                    if (abot)
                    {
                        Console.WriteLine("Connecting as BOT");
                        try
                        {
                            await client.Connect(atoken);
                        }
                        catch
                        {
                            Console.Write("Error!");
                            
                            MessageBox.Show("An error occured while connecting.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                            end(false);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Connecting as USER");
                        try
                        {
                            await client.Connect(auser,apass);
                        }
                        catch
                        {
                            Console.Write("Error!");
                            MessageBox.Show("An Error Occured while connecting.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            end(false);
                        }

                    }
                    Console.WriteLine("Connected As:" + client.CurrentUser.Name);
                    if (client.CurrentGame.Name == null)
                    {
                        mstats = "";
                    }
                    //if u want user:
                    //isbot = false;
                    //await client.Connect("email@email.com","password");
                    ShowWindow(handle, SW_HIDE);
                    Application.Run(new MainForm());

                } else
                {
                    Console.WriteLine("Form Read Failure");
                    end(false);
                }
                while (true)
                {
                    if (mst)
                    {
                        client.SetGame(mstatm, GameType.Default, "https://collectivedev.com");
                        mst = false;
                    }
                }
            });





        }

        public static void update_stat(Boolean ac,String msg)
        {
            if (!ac)
            {
                client.SetGame(null);
            } else
            {
                mstatm = msg;
                Console.WriteLine("Getting msg as " + msg);
                mst = true;
            }
            
        }
        public static void update_afk(Boolean ac,String msg)
        {
            mafk = ac;
            mafkm = msg;
        }
        public static void update_men(Boolean ac, String msg)
        {
            mmen = ac;
            mmenm = msg;
        }

        private static void Client_JoinedServer1(object sender, ServerEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Client_JoinedServer(object sender, ServerEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void randomcat(object channel)
        {

        }


        public static void test()
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Title = "Bot: Loading";

            //Console.Clear();
            //Console.SetCursorPosition(0, 0);
            //Console.WriteLine("Formating Console");
        }


        public static void log(String msg)
        {
            String tpre = "[" + System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString() + "]  ";
            Console.WriteLine(tpre + msg);
        }
        public static void end(Boolean dis)
        {
            if (dis)
            {
                client.Disconnect();
            }
            System.Environment.Exit(1);
            new LoginForm().Close();
            new MainForm().Close();
            
            System.Windows.Forms.Application.Exit();
            
        }
    }
}

