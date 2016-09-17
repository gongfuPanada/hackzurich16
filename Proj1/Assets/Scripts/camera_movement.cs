using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {
    public float camSpeed = 1;
    float previousMouseX, previousMouseY;

    // Use this for initialization
    void Start () {
    
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * camSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Camera.main.transform.position -= Camera.main.transform.forward * Time.deltaTime * camSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Camera.main.transform.position -= Camera.main.transform.right * Time.deltaTime * camSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Camera.main.transform.position += Camera.main.transform.right * Time.deltaTime * camSpeed;
        }

        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.Rotate(Camera.main.transform.up, camSpeed * Time.deltaTime * (Input.mousePosition.x - previousMouseX));
            Camera.main.transform.Rotate(Camera.main.transform.right, camSpeed * Time.deltaTime * (previousMouseY - Input.mousePosition.y));
        }

        previousMouseX = Input.mousePosition.x;
        previousMouseY = Input.mousePosition.y;
    }
}