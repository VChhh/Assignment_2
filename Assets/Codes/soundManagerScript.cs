using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip rotateSound;
    static AudioSource audioSrc;
    void Start()
    {
        rotateSound = Resources.Load<AudioClip> ("rotateSound");
        audioSrc = GetComponent<AudioSource> ();
    }

    public static void playSound(){
        audioSrc.PlayOneShot(rotateSound);
    }
}
