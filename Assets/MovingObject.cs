using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovingObject : MonoBehaviour
{
	public GameObject pauseMenuUI;
	public float zemlja;
	public bool DedBool=false;
    public float ptica;
    public float klaud;
    public GameObject GameOverUI;
    public static bool gameispaused = false;
    public Vector2 offset;
    public float kaktus=0;
	public float Velocity;
	public float scoreamount;
    public float pointincrease;
	public int skorint;
	public Text scoretext;
	public Text scoretextdead;
    Vector2 pos;
    void Start()
    {
        Velocity =-0.20f;

        pointincrease = 20f;
        pos = new Vector2(transform.position.x, transform.position.y);
        scoreamount = 0;
		

    }
    void Update()
    {
		if (scoreamount<300f) Velocity =-0.20f;
		else if (scoreamount<600f) Velocity-= 0.0001f;
		else if (scoreamount<900f) Velocity -= 0.0001f;
		else if (scoreamount<1200f) Velocity -= 0.0001f;
		else if (scoreamount<1500f) Velocity -= 0.0001f;
		else if (scoreamount<1700f) Velocity -= 0.0001f;
		else if (scoreamount<2000f) Velocity -= 0.0001f;
		        if (gameispaused == false&& zemlja==1)
        pos += new Vector2(Velocity, 0);
        if (gameispaused == false&& kaktus== 0&&ptica==0)
        pos += new Vector2(Velocity, 0);
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
        else if(pos.x <= -26 && klaud ==1)
        {
            pos = new Vector2(transform.position.x + 70.84f + Random.Range(offset.x, offset.y), transform.position.y);
        }

        transform.position = pos;
		scoreamount += pointincrease * Time.deltaTime;
		skorint = (int)scoreamount;
        scoretext.text = skorint.ToString();
		scoretextdead.text = skorint.ToString();
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if(kaktus==0){
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
            gameispaused = true;
			DedBool = true;
			scoretextdead.text = skorint.ToString();
			

		}
            
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        gameispaused = false;
        GameOverUI.SetActive(false);
        kaktus = 0;
		
    }
			public void Pauza(){
		

			if(gameispaused==true){
				Resume();
			}
			else{
				Pause();
			}
			}
		
	
	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale=1f;
		gameispaused=false;
	}
	public void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale=0f;
		gameispaused=true;
	}
	    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
		Time.timeScale = 1f;
        gameispaused = false;
    }
}
    
