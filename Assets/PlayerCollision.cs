using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;
    public GameObject GameOverUI;
    public static bool gameispaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        

    }
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        gameispaused = false;
        GameOverUI.SetActive(false);
    }
}
	