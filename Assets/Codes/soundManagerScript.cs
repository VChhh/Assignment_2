using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip rotateSound;
    public static AudioClip clickButton;
    public static AudioClip cabinetOpen;
    public static AudioClip manhole;
    static AudioSource audioSrc;
    void Start()
    {
        rotateSound = Resources.Load<AudioClip> ("rotateSound");
        clickButton = Resources.Load<AudioClip> ("clickButton");
        cabinetOpen = Resources.Load<AudioClip> ("cabinetOpen");
        // cabinetOpen = Resources.Load<AudioClip> ("manhole");
        audioSrc = GetComponent<AudioSource> ();
    }

    public static void playSound(string clip){
        if (clip == "rotateSound") {
            audioSrc.PlayOneShot(rotateSound);
        }
        else if (clip == "clickButton") {
            audioSrc.PlayOneShot(clickButton);
        }
        else if (clip == "cabinetOpen") {
            audioSrc.PlayOneShot(cabinetOpen);
        }
        // else if (clip == "manhole") {
        //     audioSrc.PlayOneShot(manhole);
        // }
    }
}
