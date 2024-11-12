using System.Collections.Generic;
using System.Runtime.Serialization;
using Game.Scripts.Data;

namespace Game.Scripts.Repositories;

public class EntityRepository : Repository<Entity>
{
    [DataMember] protected override List<Entity> Items { get; set; } = new ();
}