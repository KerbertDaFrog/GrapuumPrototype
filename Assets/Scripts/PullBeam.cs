using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullBeam : MonoBehaviour
{
    public LayerMask player;
    public float force;
    public float speed;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * range, Color.green);

        if (Physics2D.Raycast(gameObject.transform.position, Vector2.up, Mathf.Infinity, LayerMask.GetMask("Player")))
        {

        }
    }
}
