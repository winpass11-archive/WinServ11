using System;
using System.Diagnostics;
using System.Timers;
using Topshelf;

namespace WinPass11.WinService
{
    public class RegeditProcess
    {
        readonly Process _process;

        public RegeditProcess()
        {
            _process = Process.Start("regedit.exe", "/s C:\\CPU.reg");
        }

        public void Start()
        {
            _process.WaitForExit();
        }
        public void Stop()
        {
        }
    }

    public class Program
    {
        public static void Main()
        {
            var rc = HostFactory.Run(x =>                                   //1
            {
                x.Service<RegeditProcess>(s =>                                   //2
                {
                    s.ConstructUsing(name => new RegeditProcess());                //3
                    s.WhenStarted(tc => tc.Start());                         //4
                    s.WhenStopped(tc => tc.Stop());                          //5
                });
                x.RunAsLocalSystem();                                       //6

                x.SetDescription("Sample Topshelf Host");                   //7
                x.SetDisplayName("WinPass11");                                  //8
                x.SetServiceName("WinPass11");                                  //9
            });                                                             //10

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());  //11
            Environment.ExitCode = exitCode;
        }
    }
}
