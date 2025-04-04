using System;

namespace Alphicsh.Files;

public static class FileRoot
{
    public static string Location { get; } =
        System.IO.Path.GetPathRoot(typeof(FileRoot).Assembly.Location)?.NormalizePath()
        ?? throw new NotSupportedException("Could not determine a reference file root.");

    public static FilePath Path { get; } = new FilePath(Location);
}
