using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speed = 2.0f;
    public float checkDistance = 0.5f;
    public float castRadius = 0.1f;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    public bool isMovingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = 0;
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, castRadius, -transform.up, checkDistance, groundLayer);

        if (hit.collider != null)
        {
            transform.position = hit.point + (Vector2)hit.normal * (checkDistance - hit.distance);

            float targetRotation = Mathf.Atan2(hit.normal.y, hit.normal.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0, 0, targetRotation);

            Vector2 tangent = new Vector2(hit.normal.y, -hit.normal.x);

            // Adjust the movement based on the isMovingRight variable
            float directionMultiplier = isMovingRight ? 1 : -1;
            //transform.position += (Vector3)tangent * speed * Time.deltaTime * directionMultiplier;
        }
        /*else
        {
            if (rb != null)
            {
                rb.gravityScale = 1;
            }
        }*/
    }

    // Add this function to flip the movement direction
    public void FlipMovementDirection()
    {
        isMovingRight = !isMovingRight;
    }
}
