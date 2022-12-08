using static System.String;

namespace Solver.Day7;

public class Day7
{
    private Stack<string> DirStack;
    private List<File> files;
    private List<string> existing;

    public int Solve1(List<string> input)
    {
        GetInfo(input);

        return existing.Distinct().Select(CalculateInPath).Where(size => size < 100000).Sum();
    }

    public int Solve2(List<string> input)
    {
        GetInfo(input);
        var sizeToClear = Math.Abs(70000000 - CalculateInPath("//") - 30000000);
        var sortedFiles = existing.Distinct().Select(CalculateInPath).OrderBy(a => a).ToList();
        return sortedFiles.First(e => e > sizeToClear);
    }

    private void GetInfo(List<string> input)
    {
        DirStack = new Stack<string>();
        existing = new List<string>();
        files = new List<File>();
        foreach (var line in input)
        {
            if (line == "$ cd ..")
                DirStack.Pop();
            else if (line.Contains("$ cd"))
                DirStack.Push(line.Split(" ")[2]);
            else if (line.Split(" ")[0] == "dir")
            {
                existing.Add(getCurrentDir());
            }
            else if (line == "$ ls")
            {
                existing.Add(getCurrentDir());
            }
            else
            {
                files.Add(new File { path = getCurrentDir(line), size = int.Parse(line.Split(" ")[0]) });
            }
        }
    }

    private int CalculateInPath(string path)
    {
        return files.Where(f => f.path.StartsWith(path)).Sum(e => e.size);
    }

    private string getCurrentDir(string line = "")
    {
        var enumerable = DirStack.ToArray().Reverse().Select(e => e).ToList();
        enumerable.Add(line);
        return Join("/", enumerable);
    }

    private class File
    {
        public string path;
        public int size;
    }
}