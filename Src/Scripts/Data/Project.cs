using System;
using System.IO;
using System.Runtime.Serialization;
using Game.Scripts.Repositories;
using Tomlyn;

namespace Game.Scripts.Data;

public class Project
{
    [DataMember] public string Name { get; set; } = "";
    [DataMember] public string Path { get; set; } = "";
    [DataMember] public EntityRepository EntityRepository { get; set; } = new ();
    [DataMember] public GraphRepository GraphRepository { get; set; } = new ();
    
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

            return model;
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