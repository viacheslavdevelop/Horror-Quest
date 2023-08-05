using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private Text _FPSText;
    private float _fps;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(Fpser());
    }

    private IEnumerator Fpser()
    {
        _fps = 1f / Time.deltaTime;
        _FPSText.text = $"{(int)_fps}";
        yield return new WaitForSeconds(1);

        StartCoroutine(Fpser());
    }
}