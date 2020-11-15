using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public GameObject fuelcan;
    public float speed;
    public float startSpeed;
    public float currentFuel;
    public float maxFuel;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (currentFuel <= 0)
        {
            speed = 0;
        }

        if (speed >= 0.1)
        {
            currentFuel -= 1 * Time.deltaTime;
        }

        if (currentFuel >=0.1)
        {
            speed = startSpeed;
        }

        if (currentFuel >150)
        {
            currentFuel = 150;
        }
    }
}
