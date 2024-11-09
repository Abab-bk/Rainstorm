﻿using System;
using System.Collections.Generic;
using System.Linq;
using Godot;
using KaimiraGames;

namespace AcidWallStudio;

public static class Wizard
{
    private static readonly List<Vector2> EightDirs = new ();
    
    static Wizard()
    {
        for (int i = 0; i < 8; i++)
        {
            float angle = i * 45; // 计算每个方向的角度（0, 45, 90, ...）
            Vector2 direction = Vector2.Right.Rotated(Mathf.DegToRad(angle)); // 使用向量旋转计算方向
            EightDirs.Add(direction);
        }
    }

    public static bool FileExists(string path)
    {
        // return FileAccess.FileExists(path);
        return ResourceLoader.Exists(path);
    }

    public static float GetChance()
    {
        return Random.Shared.FloatRange();
    }

    public static string ReadAllText(string path)
    {
        return FileAccess.Open(path, FileAccess.ModeFlags.Read).GetAsText();
    }

    public static Vector2 GetRandom8Dir()
    {
        return EightDirs.PickRandom();
    }
    
    public static Vector2 Bezier(Vector2 p0, Vector2 p1, Vector2 p2, float t)
    {
        var q0 = p0.Lerp(p1, t);
        var q1 = p1.Lerp(p2, t);
        var r = q0.Lerp(q1, t);
        return r;
    }


    public static string GetRandomTexturePath(string path)
    {
        List<string> list = new List<string>();

        var dir = DirAccess.Open(path);

        dir.ListDirBegin();
        var fileName = dir.GetNext();

        while (fileName != "")
        {
            if (fileName.EndsWith(".png") || fileName.EndsWith(".tres"))
            {
                list.Add(fileName);
            }
            fileName = dir.GetNext();
        }

        return path + list.PickRandom();
    }

    /// <summary>
    /// 根据 chance 返回 bool，做随机概率使用
    /// </summary>
    /// <param name="chance"> 概率, 0 - 100 </param>
    /// <returns></returns>
    public static bool ChanceOverThreshold(int chance)
    {
        WeightedList<bool> list = new WeightedList<bool>();
        list.Add(true, chance);
        list.Add(false, 100 - chance);
        return list.Next();
    }

    public static Timer CreateTimer(float time)
    {
        Timer timer = new Timer();
        timer.WaitTime = time;
        return timer;
    }

    public static float GetTriangularSample(float max, float min, float mode)
    {
        float u = (float)Random.Shared.NextDouble();
        float f = (mode - min) / (max - min);

        if (u <= f)
            return min + (float)Math.Sqrt(u * (max - min) * (mode - min));
        
        return max - (float)Math.Sqrt((1 - u) * (max - min) * (max - mode));
    }

    public static Vector2 ReverseVectorX(Vector2 vector)
    {
        return new Vector2(-vector.X, vector.Y);
    }
    
    public static Vector2 ReverseVectorY(Vector2 vector)
    {
        return new Vector2(vector.X, -vector.Y);
    }

    public static Vector2 ReverseVector(Vector2 vector)
    {
        return new Vector2(-vector.X, -vector.Y);
    }
    
    public static Vector2 Reverse(this Vector2 vector)
    {
        return new Vector2(-vector.X, -vector.Y);
    }

    public static float FloatRange(this Random random, float min = 0.0f, float max = 1.0f) {
        return (float) (random.NextDouble() * (max - min) + min);
    }
    
    public static T GetRandomEnum<T>(this Random random)
        where T : struct, Enum
    {
        var values = Enum.GetValues<T>();

        return values[random.Next(values.Length)];
    }

    public static Vector2 GetForwardVector2(this Node2D source, float step)
    {
        return source.GlobalPosition + Vector2.Right.Rotated(source.Rotation) * step;
    }

    public static T PickRandom<T>(this IEnumerable<T> source)
    {
        return source.PickRandom(1).Single();
    }

    public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
    {
        return source.Shuffle().Take(count);
    }

    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
    {
        return source.OrderBy(x => Guid.NewGuid());
    }

    /// <summary>
    /// 寻找 groupName 组中最近的 node
    /// </summary>
    /// <param name="node"></param> Node2D 自身
    /// <param name="groupName"></param> 组名
    /// <returns></returns>
    public static Node2D GetClosestTarget(this Node2D node, string groupName)
    {
        Node2D target = null;
        var minDistance = float.MaxValue;
        
        foreach (Node child in node.GetTree().GetNodesInGroup(groupName))
        {
            if (child is not Node2D node2D) continue;
            var distance = node.GlobalPosition.DistanceSquaredTo(node2D.GlobalPosition);
            if (distance > minDistance) continue;
            minDistance = distance;
            target = node2D;
        }
        
        return target;
    }
}