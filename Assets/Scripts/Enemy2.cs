using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float range;
    public bool seePlayer;
    public Transform player;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.transform.position.x <= 100)
        {
            rb.AddForce(player.transform.position - transform.position);
        }
        else
        {

        }
    }
}
