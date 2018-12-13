using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   public void PlaySound()
    {
        AudioSource[] Sound = GameObject.Find("Audiofiles").GetComponents<AudioSource>();
        Sound[0].Play();
    }


}
