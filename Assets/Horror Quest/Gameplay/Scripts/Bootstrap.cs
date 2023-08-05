using UnityEngine;
using HorrorQuest.Gameplay.PlayerLogic;
using HorrorQuest.Gameplay.PlayerInput;

namespace HorrorQuest.Gameplay 
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private TouchToMovePosition _touchToMovePosition;

        private void Awake()
        {
            _touchToMovePosition.Initialize();
            _player.Initialize();
        }
    } 
}