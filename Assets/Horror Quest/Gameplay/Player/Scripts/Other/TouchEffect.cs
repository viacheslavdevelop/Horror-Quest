using HorrorQuest.Gameplay.PlayerInput;
using UnityEngine;

namespace HorrorQuest.Gameplay.Other
{
    public class TouchEffect : MonoBehaviour
    {
        private const string TOUCHED_BOOL_NAME = "Touched";

        private Transform _transform;
        private Animator _anim;

        public void Initialize()
        {
            _transform = transform;
            _anim = GetComponent<Animator>();
        }

        private void ToMovePosition(Vector3 movePosition)
        {
            _transform.position = movePosition;
            _anim.SetBool(TOUCHED_BOOL_NAME, true);
        }

        public void StopAnim()
        {
            _anim.SetBool(TOUCHED_BOOL_NAME, false);
        }
    }
}