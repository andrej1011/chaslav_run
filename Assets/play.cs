using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
	public GameObject GameOverUI;
	public static bool gameispaused;
	public float kaktus;

    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
		gameispaused = false;
        GameOverUI.SetActive(false);
        kaktus = 0;
    }	 
    

}
