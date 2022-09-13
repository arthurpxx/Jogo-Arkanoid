using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class Player : MonoBehaviour
{
    public float speedPlayer;
    public float xMin;
    public float xMax;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMin, xMax),transform.position.y);

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speedPlayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speedPlayer * Time.deltaTime);
        }
    }
}
