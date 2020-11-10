using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingGun : MonoBehaviour
{
    public LayerMask Player;
    public float speed;
    public float radius;
    public bool Detected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Detected = Physics2D.OverlapCircle(Vector2.zero, radius, Player);
        
        if (Detected)
        {
            
        }
        else
        {
            Debug.Log("Detected");
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(gameObject.transform.position, radius);
    }
}
