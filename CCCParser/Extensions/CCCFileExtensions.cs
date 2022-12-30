using System;
using System.IO;
using System.Text.Json;
using CCCParser.Types;

namespace CCCParser.Types;

public class Extensions
{
    public static void CreateFiles(CCCFile file)
    {
        string Relative = Path.GetRelativePath(Directory.GetCurrentDirectory(), file.Path);
        string PathTemp = String.Concat((Directory.GetCurrentDirectory() + "/FatalFrame/"), Relative);

        if (PathTemp.Contains("../"))
        {
            PathTemp = PathTemp.Replace("../", "/");
        }

        string Absolute = Path.GetFullPath(PathTemp);

        if (!Directory.Exists(Path.GetDirectoryName(Absolute)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Absolute));
        }

        File.Create(Absolute).Close();
    }
}