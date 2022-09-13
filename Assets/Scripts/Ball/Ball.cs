using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speedBall;
    public Rigidbody2D rig;
    public AudioSource songBall;
    public bool starGame; 

    void Start()
    {
        starGame = false;
    }

    void Update()
    {
        if (starGame == false)
        {
           if(Input.GetKeyDown(KeyCode.Space))
            {
                MoveBall();
                starGame = true;
            }
        }
    }

    private void MoveBall()
    {
        rig.velocity = Vector2.up * speedBall;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        songBall.Play();
    }
}
