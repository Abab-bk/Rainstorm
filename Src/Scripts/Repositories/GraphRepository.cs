using System.Collections.Generic;
using System.Runtime.Serialization;
using Game.Scripts.Data;

namespace Game.Scripts.Repositories;

public class GraphRepository : Repository<Graph>
{
    [DataMember] protected override List<Graph> Items { get; set; } = new ();
}