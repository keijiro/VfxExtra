using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using UnityEngine.InputSystem;

namespace VfxExtra
{
    [VFXBinder("Input/Input Value")]
    public class VFXInputValueBinder : VFXBinderBase
    {
        #region Bound property

        public string Property
        {
            get { return (string)_property; }
            set { _property = value; }
        }

        [VFXPropertyBinding("System.Single"), SerializeField]
        protected ExposedProperty _property = "FloatProperty";

        [Space]
        public InputAction Action;

        #endregion

        #region VFXBinder implementation

        public override bool IsValid(VisualEffect component)
        {
            return Action != null && component.HasFloat(_property);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            Action?.Enable();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            Action?.Disable();
        }

        public override void UpdateBinding(VisualEffect component)
        {
            component.SetFloat(_property, Action.ReadValue<float>());
        }

        public override string ToString()
        {
            return string.Format("Input Value: '{0}' -> {1}", _property, Action?.name);
        }

        #endregion
    }
}
