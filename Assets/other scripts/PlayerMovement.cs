using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 2f; // Adjust the rotation speed
    public Transform playerCamera;

    private float verticalRotation = 0f;

    private void Start()
    {
        RenderSettings.ambientLight = Color.black;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;
        transform.Translate(movement * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the player based on the camera's forward direction
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);

        // Rotate the camera based on the mouse's vertical movement
        verticalRotation -= mouseY * rotationSpeed;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Limit the vertical rotation
        playerCamera.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}