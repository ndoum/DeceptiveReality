using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {
    bool musicPlay = true;
    bool musicFirstToggle = true;
    bool musicSecondToggle = true;

	// Use this for initialization
	void Start () {
        //Fetch AudioSource from GameObject
        //musicInitialAudio = null;
        //GetComponent<AudioSource>();
        //musicSecondAudio = null;
        //GetComponent<AudioSource>();
        //Toggled to play at startup
        musicPlay = true;

        //Will this work?
        musicFirstToggle = true;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (musicPlay == true && musicFirstToggle == true)
        {
            //Play audio
            musicInitialAudio.Play();
            //Ensure audio doesn't play more than once
            musicFirstToggle= false;
        }

        if (KeyTriggered.transitionSong == true && musicSecondToggle == true) {
            //Stop initial Song
            musicInitialAudio.Stop();
            //Start second intense song
            musicSecondAudio.Start();

            //This method is not run again
            musicSecondToggle = false;
        }*/
	}
}
