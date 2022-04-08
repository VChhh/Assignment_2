using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLights : MonoBehaviour
{
    public int houseNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (PublicVars.houses_completed[houseNumber] == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        } else 
        { 
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            print("house " + houseNumber + " is not");
        }
    }

}
