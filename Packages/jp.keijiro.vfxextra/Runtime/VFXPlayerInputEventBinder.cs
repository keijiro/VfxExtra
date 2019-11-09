using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.InputSystem;

namespace VfxExtra
{
    //
    // An event binder class to invoke VFX event from an action in a PlayerInput
    //
    public class VFXPlayerInputEventBinder : VFXEventBinderBase
    {
        public PlayerInput Input = null;

        InputAction _action;
        ExposedProperty _alpha = "alpha";

        [SerializeField, HideInInspector] string _actionName = null;


        protected override void SetEventAttribute(object[] parameters)
        {
            if (_action != null)
                eventAttribute.SetFloat(_alpha, _action.ReadValue<float>());
        }

        void OnEnable()
        {
            if (Input != null && _actionName != null)
            {
                _action = Input.actions.FindAction(_actionName);
                if (_action != null) _action.performed += OnPerformed;
            }
        }

        void OnDisable()
        {
            if (_action != null)
                _action.performed -= OnPerformed;

            _action = null;
        }

        void OnPerformed(InputAction.CallbackContext ctx)
        {
            SendEventToVisualEffect();
        }
    }
}
