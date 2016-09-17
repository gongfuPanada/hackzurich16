using UnityEngine;
using System.Collections;

public class cube_coll : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
	}
	
    void OnCollisionEnter (Collision other){
        if (other.collider.tag == "Player"){
            print("Player ouch!");
        }
    }
}
