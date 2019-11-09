using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.InputSystem;

namespace VfxExtra
{
    //
    // A simple class that holds action name
    // This class is just needed to present a action selection drop-down using
    // a custom property drawer.
    //
    [System.Serializable]
    public class PlayerInputActionReference { public string Name; }

    //
    // VFX property binder with an action value in a PlayerInput
    //
    [VFXBinder("Input/Player Input Value")]
    public class VFXPlayerInputValueBinder : VFXBinderBase
    {
        #region Bound property

        public string Property
        {
            get { return (string)_property; }
            set { _property = value; }
        }

        [VFXPropertyBinding("System.Single"), SerializeField]
        protected ExposedProperty _property = "FloatProperty";

        #endregion

        #region Bound PlayerInput and InputAction selection

        public PlayerInput Input;
        public PlayerInputActionReference Action;

        #endregion

        #region VFXBinder implementation

        InputAction _cachedAction = null;

        public override bool IsValid(VisualEffect component)
        {
            // Check if the selection is valid.
            return Input != null && Action != null &&
                Input.actions.FindAction(Action.Name) != null &&
                component.HasFloat(_property);
        }

        public override void UpdateBinding(VisualEffect component)
        {
            // Try caching the bound action.
            if (_cachedAction == null && Input != null && Action != null)
                _cachedAction = Input.actions.FindAction(Action.Name);

            // Carry the value.
            component.SetFloat(_property, _cachedAction.ReadValue<float>());
        }

        public override string ToString()
        {
            return string.Format("Player Input Value: '{0}' -> {1}", _property, Action?.Name);
        }

        #endregion
    }
}
