using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public int FuelAdd = 25;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == ("Car"))
        {
            collision.GetComponent<Car>().currentFuel += FuelAdd;
            Debug.Log("Fuel Added");
            Destroy(gameObject);
        }
    }
}
