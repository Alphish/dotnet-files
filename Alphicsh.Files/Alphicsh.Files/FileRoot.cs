using System;
using System.IO;

namespace Alphicsh.Files;

public static class FileRoot
{
    public static string Location { get; } =
        Path.GetPathRoot(typeof(FileRoot).Assembly.Location)?.NormalizePath()
        ?? throw new NotSupportedException("Could not determine a reference file root.");
}
