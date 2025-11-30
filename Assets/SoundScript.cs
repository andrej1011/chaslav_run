using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
	private AudioManager Audio;
	public Button AudioToggleButton;
	public Sprite AudioOnSprite;
	public Sprite AudioOffSprite;


	void Start()
	{
		Audio = GameObject.FindObjectOfType<AudioManager>();
		UpdateIconAndVolume();
	}



	public void PauseAudio()
	{
		Audio.ToggleSound();
		UpdateIconAndVolume();
	}
	void UpdateIconAndVolume()
	{
		if (PlayerPrefs.GetInt("Muted", 0) == 0)
		{
			AudioListener.volume = 1;
			AudioToggleButton.GetComponent<Image>().sprite = AudioOnSprite;
		}
		else
		{
			AudioListener.volume = 0;
			AudioToggleButton.GetComponent<Image>().sprite = AudioOffSprite;
		}
	}
}
