using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    // Declare variables
    private Transform planeTransform;
    private Rigidbody planeRigidbody;
    private Vector3 forward;
    private Vector3 up;
    private float roll;
    private float pitch;
    private float yaw;

    // Adjust these parameters to control the plane's movement
    public float forwardAcceleration = 50f;
    public float upAcceleration = 30f;
    public float rollSpeed = 30f;
    public float pitchSpeed = 20f;
    public float yawSpeed = 40f;

    private void Start()
    {
        // Get the required components
        planeTransform = GetComponent<Transform>();
        planeRigidbody = GetComponent<Rigidbody>();

        // Initialize values
        forward = planeTransform.forward;
        up = planeTransform.up;
        roll = 0f;
        pitch = 0f;
        yaw = 0f;
    }

    private void Update()
    {
        // Read input axes
        float rollInput = Input.GetAxis("Horizontal");
        float pitchInput = Input.GetAxis("Vertical");
        float yawInput = Input.GetAxis("Rotation");

        // Update roll, pitch, and yaw
        roll += rollInput * rollSpeed * Time.deltaTime;
        pitch += pitchInput * pitchSpeed * Time.deltaTime;
        yaw += yawInput * yawSpeed * Time.deltaTime;

        // Keep angles between -180 and 180 degrees
        roll = Mathf.Clamp(roll, -180f, 180f);
        pitch = Mathf.Clamp(pitch, -180f, 180f);
        yaw = Mathf.Clamp(yaw, -180f, 180f);

        // Apply rotations to the plane
        planeTransform.rotation = Quaternion.Euler(pitch, yaw, -roll);
    }

    private void FixedUpdate()
    {
        // Apply forces to the plane
        planeRigidbody.AddForce(forward * forwardAcceleration * Time.deltaTime);
        planeRigidbody.AddForce(up * upAcceleration * Time.deltaTime);
        planeRigidbody.AddForce(planeTransform.right * Input.GetAxis("Horizontal") * forwardAcceleration * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Handle collisions with other objects (e.g., stop the plane from moving)
        // Add your collision handling code here
    }

    private void OnCollisionExit(Collision collision)
    {
        // Handle collisions with other objects (e.g., start the plane moving again)
        // Add your collision handling code here
    }
}
