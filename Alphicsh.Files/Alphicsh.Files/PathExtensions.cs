using System.IO;

namespace Alphicsh.Files;

public static class PathExtensions
{
    public static string NormalizePath(this string path) => path
        .Replace(Path.DirectorySeparatorChar, '/')
        .Replace(Path.AltDirectorySeparatorChar, '/');
}
