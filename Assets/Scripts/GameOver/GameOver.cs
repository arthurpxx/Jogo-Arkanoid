using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
