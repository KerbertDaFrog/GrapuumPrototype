using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HomingAmmo : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float rotateSpeed;
    public int damageGiven;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        Vector3.Cross(direction, transform.up);

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
        //var lookDir = Target.transform.position - transform.position;
        //transform.Translate(Target.transform.position * speed * Time.deltaTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDir), rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}
