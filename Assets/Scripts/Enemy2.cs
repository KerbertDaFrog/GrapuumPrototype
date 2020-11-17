using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float range;
    public bool seePlayer;
    public LayerMask player;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player <= range)
        {
            rb.AddForce((target.position - transform.position));
        }
    }
}
