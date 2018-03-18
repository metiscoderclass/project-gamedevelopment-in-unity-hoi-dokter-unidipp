using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ademin : MonoBehaviour {
	public bool ademinbool;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("click");
		} else {
			ademinbool = false;
		}
	}

	void OnMouseEnter(){
		if (Input.GetMouseButtonDown (0)) {
			ademinbool = true;
			Debug.Log ("ademinbool:" + ademinbool);
		}
	}
}
