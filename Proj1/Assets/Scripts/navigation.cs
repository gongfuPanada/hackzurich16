using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;

public class navigation : MonoBehaviour {
    public float camSpeed = 1;
    float previousMouseX, previousMouseY;

    // Use this for initialization
void Start () {
	
	}


    public void OnSelect()
    {
        GetComponent<NavMeshAgent>().SetDestination(GazeManager.Instance.Position);

    }

    // Update is called once per frame
    void Update () {

        GetComponent<Animator>().SetBool("swim", GetComponent<NavMeshAgent>().velocity.magnitude > 0.01);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            RaycastHit rayinfo;
            

            if (Physics.Raycast(ray, out rayinfo))
            {
                GetComponent<NavMeshAgent>().SetDestination(rayinfo.point);
            }
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            
            Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * camSpeed;
        }

        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.Rotate(Camera.main.transform.up, 10 * Time.deltaTime * (Input.mousePosition.x - previousMouseX));
            Camera.main.transform.Rotate(Camera.main.transform.right, 10 * Time.deltaTime * (previousMouseY - Input.mousePosition.y));


        }

        previousMouseX = Input.mousePosition.x;
        previousMouseY = Input.mousePosition.y;
    }
}
