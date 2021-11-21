﻿using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(
        fileName = "Vector2ScriptableEvent",
        menuName = "Scriptable Events/Vector2 Scriptable Event",
        order = ScriptableEventConstants.UnityPrimitiveScriptableEventOrder + 0
    )]
    public class Vector2ScriptableEvent : BaseScriptableEvent<Vector2>
    {
    }
}
