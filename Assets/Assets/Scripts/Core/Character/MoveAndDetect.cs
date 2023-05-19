using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveAndDetect : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float checkDistance = 0.5f;
    public float castRadius = 0.1f;
    public LayerMask pathLayer;
    private bool isFlipped = false ;

    public GameObject optionsButton;
    
   
    void Update()
    {
        CustomMovement();

        if (Input.GetMouseButtonDown(0))
        {
            // below makes it twisted : first consume do not effect, continue button flips it.
            // without it every click on button makes a consume
            
            /*
            if (EventSystem.current.IsPointerOverGameObject())
            {
                Flip();
                
            }else return;

            
            */

            

            if (Time.timeScale != 0 && EventSystem.current.currentSelectedGameObject != optionsButton)
            {
                Flip();
            }

            
            

        }
    }

    void CustomMovement() {

        // Use a circle cast to detect the closest point on the path
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, castRadius, -transform.up, checkDistance, pathLayer);

        if (hit.collider != null)
        {
            // Set the character position to the surface of the path with the desired distance
            transform.position = hit.point + (Vector2)hit.normal * (checkDistance - hit.distance);

            // Rotate the character to align with the path normal
            float targetRotation = Mathf.Atan2(hit.normal.y, hit.normal.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0, 0, targetRotation);

            // Calculate the tangent of the path
            Vector2 tangent = new Vector2(hit.normal.y, -hit.normal.x);

            // Determine the clockwise direction based on flipped state 
            float directionMultiplier = isFlipped ? -1 : 1;

            // Move the character along the tangent in the clockwise direction
            transform.position += (Vector3)tangent * moveSpeed * Time.deltaTime * directionMultiplier;

           

        }
    }

    void Flip()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, castRadius, -transform.up, checkDistance, pathLayer);

        if (hit.collider != null)
        {
            Vector2 hitPoint = hit.point;
            Vector2 hitNormal = hit.normal;
            Vector2 newPosition = hitPoint + hitNormal * checkDistance * -1;
            transform.position = newPosition;

            /* Rotate the character to align with the path's surface and make it mirrored
            float targetRotation = Mathf.Atan2(hitNormal.y, hitNormal.x) * Mathf.Rad2Deg + 90;
            transform.rotation = Quaternion.Euler(0, 0, targetRotation);

            if (isFlipped) {
                isFlipped = false;
            } else {
                isFlipped = true;
            }
            */ 

            // Rotate the character to adjust for the flip
            transform.Rotate(0, 0, 180, Space.Self);
           
            
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
            spriteRenderer.flipX = !spriteRenderer.flipX;
            }   
            

            // Toggle the isFlipped state
            isFlipped = !isFlipped;
        }
    }
}
