using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankParts : MonoBehaviour
{
    public float health;
    public bool broken = false;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(health <=0)
        {
            broken = true;
        }

        if(broken == true)
        {
            sprite.color = new Color(1, 0, 0, 1);
        }
        
        if(health >=100)
        {
            sprite.color = new Color(1, 1, 1, 1);
        }

        if(health >= 100)
        {
            health = 100;
        }
    }
}
