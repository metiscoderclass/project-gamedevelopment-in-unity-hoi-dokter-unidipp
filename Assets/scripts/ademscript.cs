	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ademscript : MonoBehaviour {
	bool ademinbool_player;
	bool ademuitbool_player;
	public int ademgetal = 100;
	public int nietgeademgetal = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ademinbool_player = GameObject.Find ("adem in").GetComponent<ademin> ().ademinbool;
		ademuitbool_player = GameObject.Find ("adem uit").GetComponent<ademuit> ().ademuitbool;
	
		if (ademinbool_player == true) {
			ademgetal += 1; 
			nietgeademgetal = 100;
		} else if (ademinbool_player == true) {
			ademgetal -= 1; 
			nietgeademgetal = 100;
		} else {
			nietgeademgetal -= 1;
		}
	}

	public void ademinstate(bool adembool2) {
		ademinbool_player = adembool2;		
	}
}
