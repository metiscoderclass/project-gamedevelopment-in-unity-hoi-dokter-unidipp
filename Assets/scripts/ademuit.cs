using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ademuit : MonoBehaviour {
	public bool ademuitbool;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ademuitbool = true;
			Debug.Log ("ademuitbool:" + ademuitbool);
		} else {
			ademuitbool = false;
			//Debug.Log ("ademuitbool:" + ademuitbool);
		}
	}
}
