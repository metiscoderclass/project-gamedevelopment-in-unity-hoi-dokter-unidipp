using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttonin : MonoBehaviour {

	public Camera m_OrthographicCamera;

    void OnMouseDrag() {
        Debug.Log("in");
        if (m_OrthographicCamera.orthographicSize > 3)
        {
            m_OrthographicCamera.orthographicSize -= 0.1f;
        }
    }
}
