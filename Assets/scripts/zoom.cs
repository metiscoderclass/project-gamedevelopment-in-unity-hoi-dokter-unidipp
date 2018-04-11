using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour {
    public Camera m_OrthographicCamera;

    float max = 4.6f;
    float num = 5f;
    float meer = 0.1f;
    string label;
    bool increase = false;
	
	void Update () {
        Debug.Log(num);
        //m_OrthographicCamera.orthographicSize = num;
        if(increase && num < max)
            num += meer;
        if (Input.GetButtonDown("Horizontal"))
            increase = !increase;
	       }
}
