//In the escape room i made with my partner in exercise 3 we basically had the player
// sort objects into their correct bin and this is an example of the code we had for 
// our shapes category in terms of throwing objects into a bucket and adding to a counter

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

/*
public class ShapeCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public AudioClip correctSound;

    AudioSource _audioSource; 

    private void Start() {
        scoreUI.text = "Score: " + PublicVars.score;
        _audioSource = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Shape"))
        {
            _audioSource.PlayOneShot(correctSound);
            Destroy(other.gameObject);
            PublicVars.score++;
            scoreUI.text = "Score: " + PublicVars.score;
            
        }else{
            PublicVars.score = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }

}
*/