using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HorrorQuest.Gameplay.PlayerInput
{
    public class TouchPanel : MonoBehaviour, IPointerClickHandler
    {
        public static Action<Vector3> OnTouchDetected;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnTouchDetected?.Invoke(eventData.position);
            print(eventData.position);
        }
    }
}