using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip rotateSound;
    public static AudioClip clickButton;
    public static AudioClip cabinetOpen;
    public static AudioClip pickUp;
    // public static AudioClip boxFall;

    // public static AudioClip manholeSound;
    static AudioSource audioSrc;
    void Start()
    {
        rotateSound = Resources.Load<AudioClip> ("rotateSound");
        clickButton = Resources.Load<AudioClip> ("clickButton");
        cabinetOpen = Resources.Load<AudioClip> ("cabinetOpen");
        pickUp = Resources.Load<AudioClip> ("pickUp");
        // boxFall = Resources.Load<AudioClip> ("boxFall");
        // cabinetOpen = Resources.Load<AudioClip> ("manholeSound");
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
        else if (clip == "pickUp") {
            audioSrc.PlayOneShot(pickUp);
        }
        // else if (clip == "boxFall") {
        //     audioSrc.PlayOneShot(boxFall);
        // }
        // else if (clip == "manholeSound") {
        //     audioSrc.PlayOneShot(manholeSound);
        // }
    }
}
