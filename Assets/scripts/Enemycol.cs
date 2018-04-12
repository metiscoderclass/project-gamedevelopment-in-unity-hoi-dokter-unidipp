using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycol : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Enemy"))
        {
            Destroy(gameObject);
			Application.LoadLevel ("blokjes");
        }
    }
}
