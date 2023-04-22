using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake() {
        foreach (Sound s in sounds)
    {
        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.clip;

        s.source.volume = s.volume;
        s.source.pitch = s.pitch; 
        s.source.loop = s.loop;
    }


    }
    
    //PLAY OR STOP ANY GIVEN STRING CLIP
    public void Play (string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop (string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
        
    }


    // CHANGE PITCH BY STRING
    public void PitchInc (string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.pitch += 0.1f;
    }

    // PLAY ONLY MAIN MENU MUSIC
    public void PlayMainMenu(string name) {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Debug.Log("MainMEnu");
            Sound s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();

        }
    }


}