using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {
    public AudioSource monsterdead;
    public float Speed;
    public float Triggerzone;
    float jumpSpeed = 700.0f;
    private Transform target;

    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
	}

    void Update () {
        if (Vector2.Distance(transform.position, target.position) < Triggerzone)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            monsterdead.Play();
        }
        if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "lava")
        {
            Destroy(gameObject);
            monsterdead.Play();
        }
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("shit");
        }
    }
}
