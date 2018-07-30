using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Ball : MonoBehaviour {

    public GameObject Ball;

    private Vector3 GoalPosition;
    public GameObject Pitch;
    // x 는 1.5 ~ -0.5
    // y는 1.5 ~ 0.5

    // GameObject temp = Instantiate (Parr [index], hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation); 

    // Vector3 tagetPosition = new Vector3(OpenDrawerX, OpenDrawerY, OpenDrawerZ);
    // transform.position = Vector3.Lerp(transform.position, tagetPosition, smooth* Time.deltaTime);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void Throw_Random_Ball()
    {
        if(!Pitch.gameObject.GetComponent<Animation>().IsPlaying("Take 001")) {
            Pitch.gameObject.GetComponent<Animation>().Play();
            Invoke("BallObject", 1.4f);
        }
    }

    private void BallObject()
    {
        float Ball_Speed = Random.Range(1000f, 1000.0f);
        GameObject RandomBall = Instantiate(Ball, Ball.transform.position, Ball.transform.rotation);
        RandomBall.GetComponent<Rigidbody>().AddForce(RandomBall.transform.forward * Ball_Speed);
    }
}
