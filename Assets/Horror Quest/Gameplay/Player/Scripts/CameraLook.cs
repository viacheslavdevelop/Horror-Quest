using UnityEngine;

namespace HorrorQuest.Gameplay.PlayerLogic
{
    public class CameraLook : MonoBehaviour
    {
        private const string PLAYER_TAG = "Player";

        [SerializeField] private Vector3 _offset;
        [SerializeField] private float _smooth;

        private Transform _camera;
        private Transform _player;

        public void Initialize()
        {
            _camera = transform;
            _player = GameObject.Find(PLAYER_TAG).transform;
        }

        private void Update()
        {
            _camera.position = Vector3.Lerp(_camera.position, _player.position + _offset, _smooth * Time.deltaTime);
        }
    }
}