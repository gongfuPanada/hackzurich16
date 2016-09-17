using UnityEngine;
using System.Collections;

public class collision_detection : MonoBehaviour {
    public GameObject deathParticles;
    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
       
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Collision!!!");
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Collision with capsule!!!");

            Instantiate(deathParticles,  new Vector3(transform.position.x ,-1, transform.position.z) , Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}