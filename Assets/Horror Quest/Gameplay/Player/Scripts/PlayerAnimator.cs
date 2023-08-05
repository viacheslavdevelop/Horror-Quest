using UnityEngine;

namespace HorrorQuest.Gameplay.PlayerLogic
{
    public class PlayerAnimator : MonoBehaviour
    {
        private const string IS_WALKING_BOOL_NAME = "IsWalking";

        private Animator _anim;

        #region MONO
        private void OnEnable()
        {
            TouchMovement.OnPlayerWalk += PlayerWalk;
            TouchMovement.OnPlayerStop += PlayerStop;
        }

        private void OnDisable()
        {
            TouchMovement.OnPlayerWalk -= PlayerWalk;
            TouchMovement.OnPlayerStop -= PlayerStop;
        }
        #endregion

        public void Initialize()
        {
            _anim = GetComponent<Animator>();
        }

        private void PlayerWalk()
        {
            _anim.SetBool(IS_WALKING_BOOL_NAME, true);
        }

        private void PlayerStop()
        {
            _anim.SetBool(IS_WALKING_BOOL_NAME, false);
        }
    }
}