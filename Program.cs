// Everything is wrong with this program. Make it better.
// Objective: mine all my posts on FaceBook which consist of thousands and thousands of comments.
// What it does now: the absolute bare minimum

using System.Text.RegularExpressions;

class WhatsUp {

static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(args[0]);

        try
        {
            for (int i = 0; i < lines.Length; i++)
            {
                IfNoGarbyThenPrinty(lines[i]);
            }
        }
        catch { }
        //debug pause
        Console.ReadKey();
    }

    static void IfNoGarbyThenPrinty(string input)
    {
        if (input == "Comments") return;
        if (input == "Andrew Jones") return;
        if (Regex.IsMatch(input, "Reply.*?[hd]")) return;
        Console.WriteLine(input);

    }
}