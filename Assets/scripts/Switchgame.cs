using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switchgame : MonoBehaviour {

    public void Playbutton()
    {
        Debug.Log("SWITCH SCENE");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
