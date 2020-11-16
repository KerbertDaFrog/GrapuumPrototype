using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public WheelJoint2D wheel1;
    public float CurrentSpeed;
    public float SpeedSetting;
    public float currentFuel;
    public float consumptionRate;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * CurrentSpeed * Time.deltaTime);

        if (currentFuel <= 0)
        {
            CurrentSpeed = 0;
        }

        if (wheel1.jointSpeed != 0)
        {
            currentFuel -= Time.deltaTime;
        }

        if (currentFuel <= 0)
        {
            CurrentSpeed = 0;
        }
        else
        {
            CurrentSpeed = SpeedSetting;
        }

        if (currentFuel >1500)
        {
            currentFuel = 1500; //turn off intake
        }

        if(currentFuel < 0)
        {
            currentFuel = 0;
        }
    }

    public void LowGear()
    {
        SpeedSetting = 2;
        consumptionRate = 1;
    }

    public void HighGear()
    {
        SpeedSetting = 5;
        consumptionRate = 3;
    }
}
