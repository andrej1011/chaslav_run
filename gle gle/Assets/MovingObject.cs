using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObject : MonoBehaviour
{
    public float ptica;
    public GameObject GameOverUI;
    public static bool gameispaused = false;
    public Vector2 offset;
    public float kaktus=0;
    Vector2 pos;
    void Start()
    {
        
        pos = new Vector2(transform.position.x, transform.position.y);
    }
    void Update()
    {
        if (gameispaused == false&& kaktus== 0&&ptica==0)
        pos += new Vector2(-0.3f, 0);
        if (gameispaused == false && kaktus == 0&&ptica==1)
            pos += new Vector2(-0.35f, 0);
        if (pos.x <= -35    &&ptica==0)
        {
            pos = new Vector2(transform.position.x + 57.84f + Random.Range(offset.x,offset.y), transform.position.y);
        }
        else if(pos.x <= -26 && ptica ==1)
        {
            pos = new Vector2(transform.position.x + 70.84f + Random.Range(offset.x, offset.y), transform.position.y-transform.position.y+Random.Range(-2,2));
        }

        transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (kaktus == 0)
        {
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
            gameispaused = true;
            
        }
    }
    public void NewGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        gameispaused = false;
        GameOverUI.SetActive(false);
        kaktus = 0;
    }
}
    
