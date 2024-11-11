using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Tomlyn;

namespace Game.Scripts.Data;

public class Project
{
    [DataMember] public string Name { get; set; } = "";
    [DataMember] public string Path { get; set; } = "";
    [DataMember] public List<Entity> Entities { get; set; } = new ();
    [DataMember] public List<Graph> Graphs { get; set; } = new ();

    public static Project FromTomlFile(string path)
    {
        try
        {
            var reader = new StreamReader(path);
            var content = reader.ReadToEnd();
            
            var model = Toml.ToModel<Project>(content, options: new TomlModelOptions
            {
                ConvertPropertyName = s => s
            });
            
            return new Project
            {
                Name = model.Name,
                Path = model.Path,
                Entities = model.Entities
            };
        }
        catch (Exception e)
        {
            Logger.LogError("[Project reader ERROR]: ", e);
            throw;
        }
    }

    public string ToToml()
    {
        return Toml.FromModel(this, new TomlModelOptions
        {
            ConvertPropertyName = s => s
        });
    }
}