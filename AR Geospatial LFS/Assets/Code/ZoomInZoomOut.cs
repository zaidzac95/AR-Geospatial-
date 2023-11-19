using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInZoomOut : MonoBehaviour
{
    private float initialDistance;
    private Vector3 initialScale;

    private void Update()
    {
        // Check if there are two touches on the screen
        if (Input.touchCount == 2)
        {
            // Get the first two touches
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Check the phase of the touches
            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                // Store the initial distance between the touches and the initial scale of the object
                initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                initialScale = transform.localScale;
            }
            else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved)
            {
                // Calculate the new distance between the touches
                float currentDistance = Vector2.Distance(touchZero.position, touchOne.position);

                // Calculate the scale factor based on the ratio of the current distance to the initial distance
                float scaleFactor = currentDistance / initialDistance;

                // Apply the scale factor to the initial scale of the object
                transform.localScale = initialScale * scaleFactor;
            }
        }
    }
}