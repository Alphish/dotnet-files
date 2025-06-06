﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alphicsh.Files;

public class FilePathJsonConverter : JsonConverter<FilePath>
{
    public override FilePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new FilePath(reader.GetString()!);
    }

    public override void Write(Utf8JsonWriter writer, FilePath value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);
    }
}
