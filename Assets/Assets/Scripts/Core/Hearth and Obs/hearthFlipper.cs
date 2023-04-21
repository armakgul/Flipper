using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearthFlipper : MonoBehaviour
{
    public int rotationRate = 200;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.forward * rotationRate * Time.deltaTime);  
    }
}
