using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttonin : MonoBehaviour {

	public Camera m_OrthographicCamera;

    void OnMouseDown() {
        Debug.Log("in");
        m_OrthographicCamera.orthographicSize = 3;
    }
}
