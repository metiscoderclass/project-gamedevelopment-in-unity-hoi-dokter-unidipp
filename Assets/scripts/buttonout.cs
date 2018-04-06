using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttonout : MonoBehaviour
{

    public Camera m_OrthographicCamera;

    void OnMouseDown()
    {
        Debug.Log("out");
        m_OrthographicCamera.orthographicSize = 5;
    }
}
