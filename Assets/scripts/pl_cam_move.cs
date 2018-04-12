using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl_cam_move : MonoBehaviour
{
    //Animator anim;
    public Camera m_OrthographicCamera;
    public AudioSource jumpsound;
    public float moveSpeed = 5.0f;
    bool facingRight = true;
    public float smoothTimeY = 0.2f;
    public float smoothTimeX = 0.2f;
    GameObject Camera;
    Rigidbody2D rigid;
    Vector2 cameraVelocity;

    public float jumpSpeed;

    void Start()
    {
        //anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        m_OrthographicCamera.orthographicSize = 3.7f;
    }

    void Update()
    {
        float posX = Mathf.SmoothDamp(Camera.transform.position.x, transform.position.x, ref
        cameraVelocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(Camera.transform.position.y, transform.position.y, ref
        cameraVelocity.y, smoothTimeY);
        Camera.transform.position = new Vector3(posX, posY, Camera.transform.position.z);
    }
  
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        //anim.SetFloat("Speed", Mathf.Abs(move));
        rigid.velocity = new Vector2(move * moveSpeed, rigid.velocity.y);
        if (rigid.velocity.y == 0)
            if (Input.GetButtonDown("Vertical"))
            {
                //m_OrthographicCamera.orthographicSize += 1.0f;
                rigid.AddForce(Vector3.up * jumpSpeed);
                //GetComponent<Animator>().SetTrigger("jump");
                jumpsound.Play();
            }
        if (move > 0 && !facingRight)
        {
            FlipFacing();
        }
        else if (move < 0 && facingRight)
        {
            FlipFacing();
        }
    }
    void FlipFacing()
    {
        facingRight = !facingRight;
        Vector3 charScale = transform.localScale;
        charScale.x = charScale.x * -1;
        transform.localScale = charScale;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "lava")
            Application.LoadLevel("shit");
    }
}
