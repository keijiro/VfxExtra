using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.InputSystem;

namespace VfxExtra
{
    public class VFXInputEventBinder : VFXEventBinderBase
    {
        public InputAction _action = null;

        ExposedProperty _alpha = "alpha";

        protected override void SetEventAttribute(object[] parameters)
        {
            if (_action != null)
                eventAttribute.SetFloat(_alpha, _action.ReadValue<float>());
        }

        void OnEnable()
        {
            if (_action != null)
            {
                _action.performed += OnPerformed;
                _action.Enable();
            }
        }

        void OnDisable()
        {
            if (_action != null)
            {
                _action.performed -= OnPerformed;
                _action.Disable();
            }
        }

        void OnPerformed(InputAction.CallbackContext ctx)
        {
            SendEventToVisualEffect();
        }
    }
}
