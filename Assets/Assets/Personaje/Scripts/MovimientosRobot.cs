using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosRobot : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    private Transform _transform;

    //public GameObject Bala;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.gravityScale = 10;
        rb.velocity = new Vector2(0, rb.velocity.y);
        animator.SetInteger("Cambio", 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(10, rb.velocity.y); 
            animator.SetInteger("Cambio", 1);
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-10, rb.velocity.y); 
            animator.SetInteger("Cambio", 1);
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            animator.SetInteger("Cambio", 2);
            rb.AddForce(new Vector2(0, 23), ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.C))
            animator.SetInteger("Cambio",3);

        if (Input.GetKeyUp(KeyCode.V))
        {
            //Instantiate(Bala, _transform.position, Quaternion.identity);
        }

        if(Input.GetKey(KeyCode.V))
            animator.SetInteger("Cambio", 5);
    }
}
