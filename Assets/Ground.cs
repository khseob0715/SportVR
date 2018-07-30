using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Ground")
        {
            this.gameObject.GetComponent<SphereCollider>().isTrigger = false;
            //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 1.0f, this.gameObject.transform.position.z);
        }
    }
}
