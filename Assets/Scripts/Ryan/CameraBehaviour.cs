using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CameraBehaviour : MonoBehaviour
{
    public Texture2D crosshairImage;
    public float mouseSensitivity = 50;

    float rotX;
    float rotY;

    private void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update ()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX -= mouseY * mouseSensitivity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(rotX, rotY, 0.0f);
    }
}
