using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ademscript : MonoBehaviour {
	public bool ademinbool_player;
	public bool ademuitbool_player;
	public int ademgetal = 100;
	public int nietgeademgetal = 100;

	bool eersteadem = false;
	int tijdsindseersteadem;

	public Text ademgetaltext;
	public Text nietademgetaltext;

	public Transform prefab;

	Animator animator;

	//public Animation ademinanim;
	//public Animation ademuitanim;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();


		// animation = GetComponent<Animation> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (eersteadem == true) {
			tijdsindseersteadem++;
		}


		if (GameObject.Find ("message_rood(Clone)") == null) {
			if (nietgeademgetal < 0 && tijdsindseersteadem > 1) {
				Instantiate (prefab, new Vector3 (0, 3, 0), Quaternion.identity);
			}
		}


		if (Input.GetKey (KeyCode.A)) {
			ademinbool_player = true;
			animator.SetBool("ademIn", true);
		} else {
			ademinbool_player = false;
			animator.SetBool("ademIn", false);
		}



		if (Input.GetKey (KeyCode.D)) {
			ademuitbool_player = true;
			animator.SetBool("ademUit", true);
		} else {
			ademuitbool_player = false;
			animator.SetBool("ademUit", false);
		}



		if (ademinbool_player == true) {
			
			if (eersteadem == false) {
				eersteadem = true;
			}

			Destroy (GameObject.FindGameObjectWithTag("message"));


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
