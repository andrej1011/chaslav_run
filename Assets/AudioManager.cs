using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;
	static AudioManager instance = null;

	// Start is called before the first frame update
	void Awake()
	{
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}

		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}


	void Start()
	{
		Play("Theme");
	}


	public void Play(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		s.source.Play();
	}
	public void ToggleSound()
	{
		if (PlayerPrefs.GetInt("Muted", 0) == 0)
		{
			PlayerPrefs.SetInt("Muted", 1);
			//AudioListener.volume = 1;
		}
		else
		{
			PlayerPrefs.SetInt("Muted", 0);
			//AudioListener.volume = 0;
		}
	}
}

