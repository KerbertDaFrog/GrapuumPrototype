using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacGun : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 gunPos;



    Vector3 mouse_pos;
    Vector3 object_pos;
    float angle;
 
 void  Update()
    {
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 5.23f; //The distance between the camera and object
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;

        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    // Update is called once per frame
    //void FixedUpdate()
    //{
    //    gunPos = transform.position;
    //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

    //    Vector3 gunDirection = (mousePos - gunPos).normalized;
    //    transform.rotation = Quaternion.LookRotation(gunDirection, Vector3.left);

    //    Debug.DrawRay(transform.position, gunDirection * 5, Color.red);
    //}
}
