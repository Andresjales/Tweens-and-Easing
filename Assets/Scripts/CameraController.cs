using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        var seq = DOTween.Sequence();
        seq.Append(GetComponent<Camera>().DOFieldOfView(29.4f, 1f));
        seq.Append(GetComponent<Camera>().DOFieldOfView(80, 0.1f));
        seq.Append(GetComponent<Camera>().DOFieldOfView(70, 0.2f));
    }
}
