using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class Deur : MonoBehaviour {

    public SpriteRenderer deur;
    public Sprite deurB;

    void Start()
    {
        deur = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("deur geklikt");
        deur.sprite = deurB;
        Application.LoadLevel("prikjegame");
    }


}
