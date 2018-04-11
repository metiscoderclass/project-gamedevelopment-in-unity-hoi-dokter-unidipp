using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttonout : MonoBehaviour
{

    public Camera m_OrthographicCamera;

    void OnMouseDrag()
    {
        Debug.Log("out");
        m_OrthographicCamera.orthographicSize += 0.1f;
    }
}
