using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    public Vector3 shapeCenter;
    public float shapeThickness;
    private MyCharacterController customCharacterController;
    private bool isFlipped = false;

    

    void Start()
    {
        customCharacterController = GetComponent<MyCharacterController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Change this to your desired input condition
        {
            // Calculate the direction from the shape center to the character
            Vector3 direction = (transform.position - shapeCenter).normalized;
            
            // Toggle the isFlipped state
            isFlipped = !isFlipped;

            // Calculate the new distance from the shape center to the character
            float newDistance;
            if (isFlipped)
            {
                newDistance = Vector3.Distance(transform.position, shapeCenter) - shapeThickness;
            }
            else
            {
                newDistance = Vector3.Distance(transform.position, shapeCenter) + shapeThickness;
            }

            // Calculate the new position for the character
            Vector3 newPosition = shapeCenter + direction * newDistance;

            // Assign the new position to the character
            transform.position = newPosition;

            // Rotate the character to adjust for the flip
            //transform.Rotate(0, 180, 0, Space.Self);

            float distance = Vector3.Distance(transform.position, shapeCenter);
            Debug.Log("Distance from character to shape center: " + distance);

            customCharacterController.FlipMovementDirection();
            
            // Calculate the mirrored rotation around the path
            Vector3 flippedRotation = new Vector3(-transform.eulerAngles.x, -transform.eulerAngles.y, transform.eulerAngles.z);

            // Assign the new rotation to the character
            transform.rotation = Quaternion.Euler(flippedRotation);
        }
    }
}
