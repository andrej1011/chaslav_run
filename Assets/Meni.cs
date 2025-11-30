using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Meni : MonoBehaviour
{
    public GameObject GameOverUI;
	public static bool gameispaused;
	public float kaktus;

    public void NewGame()
    {
        SceneManager.LoadScene("Menu");
    }	
}
