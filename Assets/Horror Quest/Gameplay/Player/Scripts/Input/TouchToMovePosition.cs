using System;
using UnityEngine;

namespace HorrorQuest.Gameplay.PlayerInput
{
    [RequireComponent(typeof(Camera))]
    public class TouchToMovePosition : MonoBehaviour
    {
        public static Action<Vector3> OnMovePositionConverted;

        private Camera _camera;
        private Ray _ray;
        private RaycastHit _raycastHit;

        #region MONO

        private void OnEnable() => TouchPanel.OnTouchDetected += SetMovePosition;

        private void OnDisable() => TouchPanel.OnTouchDetected -= SetMovePosition;
        
        #endregion

        public void Initialize()
        {
            _camera = GetComponent<Camera>();
        }

        private void SetMovePosition(Vector3 touchPosition)
        {
            _ray = _camera.ScreenPointToRay(touchPosition);

            if (Physics.Raycast(_ray, out _raycastHit))
            {
                OnMovePositionConverted?.Invoke(_raycastHit.point);
            }
        }
    }
}