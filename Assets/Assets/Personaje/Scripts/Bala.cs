using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D rb;
    //public GameObject Robot;
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        Destroy(this.gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        rb.gravityScale = 0;
        //var a = Robot.transform.position.x;
        rb.velocity = new Vector2(-5, rb.velocity.y);
    }
}
