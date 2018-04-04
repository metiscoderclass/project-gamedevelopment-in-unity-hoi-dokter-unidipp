using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ademscript : MonoBehaviour {
	public bool ademinbool_player;
	public bool ademuitbool_player;
	public int ademgetal = 100;
	public int nietgeademgetal = 100;

	bool eersteadem = false;
	int tijdsindseersteadem;

	public Text ademgetaltext;
	public Text nietademgetaltext;

	public GameObject UI;

	public Transform prefab;
	public Transform prefab2;

	public Button reload;

	bool afgegaan;

	Animator animator;





	void Start () {

		animator = GetComponent<Animator>();

		Button btn = reload.GetComponent<Button>();
		btn.onClick.AddListener(reloadscene);
	
	}
	
	// Update is called once per frame
	void Update () {


		if (eersteadem == true) {
			
			tijdsindseersteadem++;

		}


		//even niet geademd message (bij nietademgetal < 0)
		if (GameObject.Find ("message_rood(Clone)") == null && nietgeademgetal < 0 && tijdsindseersteadem > 1 && afgegaan == false) {
				
			Transform nietgeademdmessage = Instantiate (prefab, new Vector3 (0, 3, 0), Quaternion.identity);
			nietgeademdmessage.transform.parent = UI.transform;
		
		}


		//lang niet geademd en af message (bij nietademgetal = 300)
		if (GameObject.Find ("afmessage(Clone)") == null && nietgeademgetal == -300 && tijdsindseersteadem > 1) {

			afgegaan = true;

			Destroy (GameObject.FindGameObjectWithTag("message"));
			Transform afgeademdmessage = Instantiate (prefab2, new Vector3 (0, 3, 0), Quaternion.identity);
			afgeademdmessage.transform.parent = UI.transform;
		
		}


		if (afgegaan == false) { // alleen als je nog leeft kan je ademen

			//inademen bool zetten en animatie starten en stoppen
			if (Input.GetKey (KeyCode.A)) {
				ademinbool_player = true;
				animator.SetBool ("ademIn", true);
			} else {
				ademinbool_player = false;
				animator.SetBool ("ademIn", false);
			}


			//uitademen bool zetten en animatie starten en stoppen
			if (Input.GetKey (KeyCode.D)) {
				ademuitbool_player = true;
				animator.SetBool ("ademUit", true);
			} else {
				ademuitbool_player = false;
				animator.SetBool ("ademUit", false);
			}



			if (ademinbool_player == true) { // als er word ingeademd
				
				if (eersteadem == false) { // als er nog niet geademd is dan word eersteadem true
					eersteadem = true; 
				}

				Destroy (GameObject.FindGameObjectWithTag ("message")); // even niet geademd message word weggehaald


				ademgetal += 1; 
				nietgeademgetal = 100;
			} else if (ademuitbool_player == true) {

				ademgetal -= 1; 
				nietgeademgetal = 100;
			} else {
				nietgeademgetal -= 1;
			}
		}



		ademgetaltext.text = ademgetal.ToString();
		nietademgetaltext.text = nietgeademgetal.ToString();
	}



	//public void ademinstate(bool adembool2) {
	//	ademinbool_player = adembool2;		
	//}

	public void reloadscene () {
		Debug.Log ("reloading scene...");
		SceneManager.LoadScene("scenes/prikjegame");
		Debug.Log ("scene reloaded");
	}
}
