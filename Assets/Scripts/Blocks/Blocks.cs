using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    
    void Start()
    {
        FindObjectOfType<GameManager>().AddBlock();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().RemoveBlock();
            Destroy(this.gameObject);
        }
    }
}
