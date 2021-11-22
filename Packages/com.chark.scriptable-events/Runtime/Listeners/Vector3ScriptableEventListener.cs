﻿using UnityEngine;

namespace ScriptableEvents.Listeners
{
    [AddComponentMenu(
        ScriptableEventConstants.MenuNamePrefix + "/Vector3 Scriptable Event Listener",
        ScriptableEventConstants.MenuOrderUnityPrimitiveEvent + 1
    )]
    public class Vector3ScriptableEventListener : BaseScriptableEventListener<Vector3>
    {
    }
}
