using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctorvolger : MonoBehaviour
{
    public bool playonetime;
    public AudioSource dokter1;
    public float Speed;
    public float Triggerzone;
    public float Stopzone;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playonetime = true;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < Triggerzone)
        {
            if (Vector2.Distance(transform.position, target.position) > Stopzone)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, target.position) < Stopzone)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, 0);
                if (playonetime.Equals(true))
                {
                    dokter1.Play();
                    Debug.Log("sound play");
                    playonetime = false;
                }
            }
        }
    }
}
