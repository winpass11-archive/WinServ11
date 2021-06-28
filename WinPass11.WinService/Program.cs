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
            _process = Process.Start("regedit.exe", "/s C:\\CPU.reg"); // Location of the modified registry file
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
            var rc = HostFactory.Run(x =>
            {
                x.Service<RegeditProcess>(s =>
                {
                    s.ConstructUsing(name => new RegeditProcess());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("A tool for loading keys into the registry on startup");
                x.SetDisplayName("WinPass11");
                x.SetServiceName("WinPass11");
            });

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;
        }
    }
}
