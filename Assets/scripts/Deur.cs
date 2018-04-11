using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class Deur : MonoBehaviour {

    public GameObject text;
    public SpriteRenderer deur;
    public Sprite deurB;

    void Start()
    {
        text.SetActive (false);
        deur = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("deur geklikt");
        deur.sprite = deurB;
        Application.LoadLevel("prikjegame");
    }

    void OnMouseOver()
    {
        Debug.Log("HOVER");
        text.SetActive(true);
    }

    void OnMouseExit()
    {
        text.SetActive(false);
    }

}
