using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookFPS : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	public Transform playerBody;

	float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked; //Hide the cursor  
    }

    // Update is called once per frame
    void Update()
    {
    	float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //Because we are in void Update and we want our mouvement to be independant of frames
    	float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    	xRotation -= mouseY; //-= and not += because it will flip after ... 
    	xRotation = Mathf.Clamp(xRotation, -90f,90f); //Restriction of rotation of the head (up/down)

    	transform.localRotation = Quaternion.Euler(xRotation,0f,0f); //We are not using Rotate because we want to restrict movemenent

    	playerBody.Rotate(Vector3.up*mouseX);

        
    }
}
