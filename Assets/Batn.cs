using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batn : MonoBehaviour
{
	public GameObject pauseMenuUI;
	public static bool gameispaused=false;
	public void Pauza(){
		

			if(gameispaused==true){
				Resume();
			}
			else{
				Pause();
			}
			
		
	}
	void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale=1f;
		gameispaused=false;
	}
	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale=0f;
		gameispaused=true;
	}
}
