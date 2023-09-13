using System.Runtime.InteropServices;

namespace MyProject;
class Program
{
    static Dialog? dialog;

    static void Main(string[] args)
    {
        if (ArgsValidation(args))
            throw new Exception("Error: Invalid arguments");

        Initialize(args);
        dialog.render();
    }

    static bool ArgsValidation(string[] args)
    {
        if (args.Length == 0)
        {
            return true;
        }
        return false;
    }

    static void Initialize(string[] args)
    {
        var os = args[0];

        if (os.ToLower() == "windows")
            dialog = new WindowsDialog();
        else if (os.ToLower() == "web")
            dialog = new WebDialog();
        else
            throw new ArgumentException("Invalid OS: " + os);
    }
}