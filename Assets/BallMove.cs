using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    public Text scoreText;
    public int score;
    public bool isForced;

    public GameObject WinPopup;

    Rigidbody2D rb2d;

    public GameObject ballChecker;
    Vector2 startPosition;

    public float force;

    void Start()
    {
        isForced = false;
        score = 0;
        startPosition = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score;

        if (Input.GetKey(KeyCode.Space) && !isForced)
        {
            transform.parent = null;  //transform.SetParent("null");
            rb2d.isKinematic = false;
            rb2d.AddForce(new Vector2(force, force) * Time.deltaTime);
            isForced = true;
        }

        if(transform.position.y < ballChecker.transform.position.y)
        {
            transform.position = startPosition;
            SceneManager.LoadScene(0);
        }

        if(score >= 30)
        {
            Debug.Log("You win");
            WinPopup.SetActive(true);
        }
    }

    public void Increment()
    {
        score++;
    }
}
