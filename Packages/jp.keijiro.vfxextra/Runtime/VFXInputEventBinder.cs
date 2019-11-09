using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.InputSystem;

namespace VfxExtra
{
    //
    // An event binder class to invoke VFX event from an InputAction
    //
    public class VFXInputEventBinder : VFXEventBinderBase
    {
        public InputAction Action = null;

        ExposedProperty _alpha = "alpha";

        protected override void SetEventAttribute(object[] parameters)
        {
            if (Action != null)
                eventAttribute.SetFloat(_alpha, Action.ReadValue<float>());
        }

        void OnEnable()
        {
            if (Action != null)
            {
                Action.performed += OnPerformed;
                Action.Enable();
            }
        }

        void OnDisable()
        {
            if (Action != null)
            {
                Action.performed -= OnPerformed;
                Action.Disable();
            }
        }

        void OnPerformed(InputAction.CallbackContext ctx)
        {
            SendEventToVisualEffect();
        }
    }
}
