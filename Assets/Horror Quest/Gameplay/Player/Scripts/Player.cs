using HorrorQuest.Gameplay.Other;
using UnityEngine;

namespace HorrorQuest.Gameplay.PlayerLogic
{
    public class Player : MonoBehaviour
    {
        #region CONSTANTS
        private const string CAMERA_NAME = "Main Camera";
        private const string TOUCH_EFFECT_NAME = "Touch Effect";
        #endregion

        private TouchMovement _touchMovement;
        private CameraLook _cameraLook;
        private PlayerAnimator _playerAnimator;
        private TouchEffect _touchEffect;

        public void Initialize()
        {
            _touchMovement = GetComponent<TouchMovement>();
            _playerAnimator = GetComponent<PlayerAnimator>();
            _cameraLook = GameObject.Find(CAMERA_NAME).GetComponent<CameraLook>();
            _touchEffect = GameObject.Find(TOUCH_EFFECT_NAME).GetComponent<TouchEffect>();

            _touchMovement.Initialize();
            _cameraLook.Initialize();
            _playerAnimator.Initialize();
            _touchEffect.Initialize();
        }
    }
}