using System.Text.Json;
using Shouldly;

namespace Alphicsh.Files.FilePaths;

public class FilePath_Json
{
    [Fact]
    public void FilePathJson_ShouldWriteString()
    {
        var path = new FilePath("C:/Lorem/Ipsum");
        var json = JsonSerializer.Serialize(path);
        var expectedJson = "\"C:/Lorem/Ipsum\"";
        json.ShouldBe(expectedJson);
    }

    [Fact]
    public void FilePathJson_ShouldWriteNull()
    {
        FilePath? path = null;
        var json = JsonSerializer.Serialize(path);
        var expectedJson = "null";
        json.ShouldBe(expectedJson);
    }

    [Fact]
    public void FilePathJson_ShouldReadString()
    {
        var json = "\"C:\\\\Lorem\\\\Ipsum\"";
        var path = JsonSerializer.Deserialize<FilePath>(json);
        path.Value.ShouldBe("C:/Lorem/Ipsum");
    }

    [Fact]
    public void FilePathJson_ShouldReadNull()
    {
        var json = "null";
        var path = JsonSerializer.Deserialize<FilePath?>(json);
        path.ShouldBeNull();
    }
}
