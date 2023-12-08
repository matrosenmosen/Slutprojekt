using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Bestämmer kamerans rörlighet


public class MouseLook : MonoBehaviour
  
{
    
    // Bestämmer känslighet, hur "snabbt" man kan vrida kameran
        public float mouseSensetivity = 100f;

        
    // Refererar till karaktären 
         public Transform playerBody;

       
    // Roationen av Kameran
        float xRotation = 0f;

    
    void Start()
    {
        //Gör muspekaren osynlig

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    void Update()
    {
        //Hämtar mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;


        //Gör att man bara kan vrida upp i 90 grader
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
