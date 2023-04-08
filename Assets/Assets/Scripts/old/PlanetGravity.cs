using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    
    public GameObject planet;

    Rigidbody2D rb;
    public float gravityForce;
    public float gravityDistance;

    float lookAngle;
    public float speed;

    
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, planet.transform.position);

        Vector3 v = planet.transform.position - transform.position;

        rb.AddForce(v.normalized*(1.0f - dist / gravityDistance) * gravityForce);

        lookAngle = 90 + Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);

        transform.Translate(Vector2.right * (Time.deltaTime * speed));
    }
}
