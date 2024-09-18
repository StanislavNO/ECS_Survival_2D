//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherId;

    public static Entitas.IMatcher<GameEntity> Id {
        get {
            if (_matcherId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Id);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherId = matcher;
            }

            return _matcherId;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Common.Visuals.Id id { get { return (Code.Gameplay.Common.Visuals.Id)GetComponent(GameComponentsLookup.Id); } }
    public int Id { get { return id.Value; } }
    public bool hasId { get { return HasComponent(GameComponentsLookup.Id); } }

    public GameEntity AddId(int newValue) {
        var index = GameComponentsLookup.Id;
        var component = (Code.Gameplay.Common.Visuals.Id)CreateComponent(index, typeof(Code.Gameplay.Common.Visuals.Id));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceId(int newValue) {
        var index = GameComponentsLookup.Id;
        var component = (Code.Gameplay.Common.Visuals.Id)CreateComponent(index, typeof(Code.Gameplay.Common.Visuals.Id));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveId() {
        RemoveComponent(GameComponentsLookup.Id);
        return this;
    }
}
