using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class Deur : MonoBehaviour {

    public Button Btndeur;

    void Start()
    {
        Button btn = Btndeur.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("deur open!");
    }
}
