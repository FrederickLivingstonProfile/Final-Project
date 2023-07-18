using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    [Tooltip("An array of transforms representing camera positions")]
    [SerializeField] Transform[] povs;
    [Tooltip("The speed at which the camera follows the plane")]
    [SerializeField] float speed;

    private int index = 1;
    private Vector3 target;

    private void Update()
    {
        // Numbers 1-4 represent different povs (you can add more)
        if (Input.GetKeyDown(KeyCode.Alpha1)) index = 0;
        else if (Input.GetKeyDown(KeyCode.Alpha1)) index = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha1)) index = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha1)) index = 3;

         // Set our target to the relevant POV.
         target = povs[index].position;
    }

        private void FixedUpdate()
        {
            // Move camera to desired position/orientation. Must be in FixedUpdate to avoid camera jitters
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            transform.forward = povs[index].forward;
        }
    
}