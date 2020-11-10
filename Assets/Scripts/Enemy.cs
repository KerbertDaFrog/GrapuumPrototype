using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public bool SeePlayer;
    public Transform Player;
    public bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(WallCheck() == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        
    }

    private bool WallCheck()
    {
        LayerMask mask = LayerMask.GetMask("Wall");
        bool WallHit = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, mask);
        if (hit.collider != null)
        {
            WallHit = true;
            //Debug.Log(hit.point);
        }
        return WallHit;
    }
}
