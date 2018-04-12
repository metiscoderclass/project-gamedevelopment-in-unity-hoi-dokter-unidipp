using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLobbyGame : MonoBehaviour {

    public AudioSource click;
    public GameObject segment;
    public GameObject wolk1;
    public GameObject wolk2;
    public GameObject backbutton;

    public void PlayLobbyButton()
    {
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HulpButton()
    {
        click.Play();
        segment.SetActive(false);
        wolk1.SetActive(false);
        wolk2.SetActive(true);
        backbutton.SetActive(true);
    }

    public void BackButton()
    {
        click.Play();
        segment.SetActive(true);
        wolk1.SetActive(true);
        wolk2.SetActive(false);
        backbutton.SetActive(false);
    }
}
