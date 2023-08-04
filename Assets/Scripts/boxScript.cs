using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control the speed of the object's movement to the right

    // Update is called once per frame
    void Update()
    {
        // Move the object to the right using the "Translate" method in the "Update" function.
        // We'll move it in the x-axis direction (right) and multiply it by Time.deltaTime to make it frame rate independent.
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
