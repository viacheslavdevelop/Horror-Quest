using HorrorQuest.Gameplay.PlayerInput;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace HorrorQuest.Gameplay.PlayerLogic
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class TouchMovement : MonoBehaviour
    {
        #region ACTIONS
        public static Action OnPlayerWalk;
        public static Action OnPlayerStop;
        #endregion

        [SerializeField] private float CheckTargetReachTiming = 0.5f;

        private NavMeshAgent _agent;
        private bool _isChecking;

        #region MONO

        private void OnEnable() => TouchToMovePosition.OnMovePositionConverted += StartWalk;

        private void OnDisable() => TouchToMovePosition.OnMovePositionConverted -= StartWalk;
        
        #endregion

        public void Initialize()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        private void StartWalk(Vector3 moveTarget)
        {
            _agent.isStopped = false;
            _agent.SetDestination(moveTarget);
            OnPlayerWalk?.Invoke();

            if (!_isChecking)
            {
                StartCoroutine(IsTargetReached());
            }
        }

        private void StopWalk()
        {
            _agent.isStopped = true;
            OnPlayerStop?.Invoke();
        }

        private IEnumerator IsTargetReached()
        {
            yield return new WaitForSeconds(CheckTargetReachTiming);

            if(_agent.velocity == Vector3.zero)
            {
                StopWalk();
                _isChecking = false;
            }
            else
            {
                StartCoroutine(IsTargetReached());
                _isChecking = true;
            }
        }
    }
}