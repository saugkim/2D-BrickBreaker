using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public float max = 2.9f;

    public float speed;

	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();

	}
	
	void Update ()
    {
       
        float moveX = Input.GetAxis("Horizontal");
        //position.x += moveX * Time.deltaTime * speed;
        rb2d.velocity = new Vector2(moveX * speed, 0);

        if (moveX == 0)
        {
            Stop();
        }

        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -max, max);
        transform.position = pos;

	}

    void Stop()
    {
        rb2d.velocity = Vector2.zero;
    }


}
