using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrusters : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrust;
    public float height;
    public Transform player;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        height = transform.position.y;

        rb.AddForceAtPosition(Vector2.up * thrust, gameObject.transform.position);
        rb.AddForceAtPosition(Vector2.right * thrust, gameObject.transform.position);

        if (transform.position.y < height)
        {
            rb.AddForceAtPosition(Vector2.up * 0f * Time.deltaTime, gameObject.transform.position);
        }
    }
}
