using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 500;
    float xRotation = 0f;

    /*
    public Transform body; // set here the player transform 
    float xRotation = 0f;
    public Vector2 turn;
    public float sensitivity = 500;
    public Vector3 deltaMove;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;



        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        body.Rotate(Vector3.up * mouseX);
    }

    */


    public Transform cameraPosition;

    void Start()
    {

    }


    void Update()
    {
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.position = cameraPosition.position;
        transform.rotation = cameraPosition.rotation;
    }
    
}
