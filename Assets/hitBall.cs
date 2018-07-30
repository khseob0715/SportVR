using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBall : MonoBehaviour {
    public GameObject ParentObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.gameObject.transform.position = ParentObject.transform.position;
    }

    private void OnCollisionEnter(Collision collision){
        collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
        collision.gameObject.GetComponent<SphereCollider>().isTrigger = true;
        //  collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,0.0f,0.0f) * 1f);
    }
}
