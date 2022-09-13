using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int blocks;
    public AudioSource songBlock;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void AddBlock()
    {
        blocks ++;
    }
    public void RemoveBlock()
    {
        blocks--;
        songBlock.Play();

        if(blocks == 0)
        {
            NextNivel();
        }
    }

    public void NextNivel()
    {
        if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Exit()
    {
        Application.Quit();
        Debug.Log("saiu do jogo");
    }
}
