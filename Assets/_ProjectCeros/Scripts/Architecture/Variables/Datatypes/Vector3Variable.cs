/// <summary>
/// A ScriptableObject-based container for a Vector3 value that allows runtime value modification.
/// Includes utility methods for setting, modifying and normalizing the value.
/// </summary>

/// <remarks>
/// 09/04/2025 by Damian Dalinger: Script Creation.
/// 28/05/2025 by Damian Dalinger: Changed to BaseVariable for saving.
/// </remarks>

using UnityEngine;

namespace ProjectCeros
{
    [CreateAssetMenu(menuName = "Variables/Vector3 Variable")]
    public class Vector3Variable : BaseVariable<Vector3>
    {
        #region Public Methods

        public void ApplyChange(Vector3 amount)
        {
            RuntimeValue += amount;
        }

        public void ApplyChange(Vector3Variable amount)
        {
            RuntimeValue += amount.RuntimeValue;
        }

        public void Normalize()
        {
            RuntimeValue = RuntimeValue.normalized;
        }

        public void SetValue(Vector3 value)
        {
            RuntimeValue = value;
        }

        public void SetValue(Vector3Variable value)
        {
            RuntimeValue = value.RuntimeValue;
        }

        #endregion
    }
}