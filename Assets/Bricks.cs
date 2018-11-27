using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public BallMove ballMove;

	void Start ()
    {
        ballMove = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMove>();
	}
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            ballMove.Increment();
            Destroy(gameObject);
        }
    }
}
