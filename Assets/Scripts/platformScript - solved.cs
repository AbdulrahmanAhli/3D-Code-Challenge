using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour
{
    public float speed = 1.0f; // You can adjust this value to change the speed of the object
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Set the target position
        targetPosition = new Vector3(53, 5, 12);
    }

    // Update is called once per frame
    void Update()
    {
        // If the object has not reached the target position
        if (transform.position != targetPosition)
        {
            // Move the object towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}