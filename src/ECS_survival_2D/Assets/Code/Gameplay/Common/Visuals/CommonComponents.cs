using Entitas;
using UnityEngine;

namespace Code.Gameplay.Common.Visuals
{
    [Game] public class Id : IComponent { public int Value; }
    [Game] public class WorldPosition : IComponent { public Vector3 Value; }
}