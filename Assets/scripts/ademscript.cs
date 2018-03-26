using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ademscript : MonoBehaviour {
	public bool ademinbool_player;
	public bool ademuitbool_player;
	public int ademgetal = 100;
	public int nietgeademgetal = 100;

	public Text ademgetaltext;
	public Text nietademgetaltext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ademinbool_player = GameObject.Find ("adem in").GetComponent<ademin> ().ademinbool;
		//ademuitbool_player = GameObject.Find ("adem uit").GetComponent<ademuit> ().ademuitbool;
	
		if (Input.GetKey (KeyCode.A)) {
			ademinbool_player = true;
		} else {
			ademinbool_player = false;
		}

		if (Input.GetKey (KeyCode.D)) {
			ademuitbool_player = true;
		} else {
			ademuitbool_player = false;
		}

		if (ademinbool_player == true) {
			ademgetal += 1; 
			nietgeademgetal = 100;
		} else if (ademuitbool_player == true) {
			ademgetal -= 1; 
			nietgeademgetal = 100;
		} else {
			nietgeademgetal -= 1;
		}

		ademgetaltext.text = ademgetal.ToString();
		nietademgetaltext.text = nietgeademgetal.ToString();
	}

	public void ademinstate(bool adembool2) {
		ademinbool_player = adembool2;		
	}
}
