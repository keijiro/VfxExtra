// This script file is simply copy-and-pasted from the Visual Effect Graph
// package to circumvent the class protection.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;

namespace VfxExtra
{
    public abstract class VFXEventBinderBase : MonoBehaviour
    {
        [SerializeField]
        protected VisualEffect target;
        public string EventName = "Event";

        [SerializeField, HideInInspector]
        protected VFXEventAttribute eventAttribute;

        private void OnValidate()
        {
            if (target != null)
                eventAttribute = target.CreateVFXEventAttribute();
            else
                eventAttribute = null;
        }

        protected abstract void SetEventAttribute(object[] parameters = null);

        protected void SendEventToVisualEffect(params object[] parameters)
        {
            if (target != null)
            {
                SetEventAttribute(parameters);
                target.SendEvent(EventName, eventAttribute);
            }
        }
    }
}
