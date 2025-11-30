using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaktus : MonoBehaviour
{
    public GameObject GameOverUI;
    public static bool gameispaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
            gameispaused = true;
			FindObjectOfType<AudioManager>().Play("Game Over");
        }
    }

