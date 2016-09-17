using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;

public class navigation : MonoBehaviour {
    public float camSpeed = 1;

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
        


    }
}
