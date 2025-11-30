using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovements : MonoBehaviour
{
    public Vector2 pos;
    public bool lezi = false;
    public bool isjump=false;
    public float speed;
    public float JumpForce;
    private float moveinput;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(transform.position.x, transform.position.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -2.35) { isjump = true;rb.gravityScale = 3; }

        else isjump = false;
        if (isjump == false)
        {

            if (CrossPlatformInputManager.GetButtonDown("Jump"))
            {
                transform.position = pos;
                
                rb.velocity = Vector2.up * JumpForce;

                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        if (CrossPlatformInputManager.GetButtonDown("Lezi"))
        {
            if(transform.position.y>-2.30)
                rb.velocity = Vector2.up * -JumpForce;
            if (transform.position.y < -2.30) {
                if (transform.localScale != new Vector3(1, 0.6f, 1))
                    transform.position = new Vector2(transform.position.x, transform.position.y - 0.42f);
               
                transform.localScale = new Vector3(1, 0.6f, 1);

            }



            }

    }
}
