using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_button : MonoBehaviour
{
    private Color[] colors = new Color[3]{PublicVars.my_red, PublicVars.my_blue, PublicVars.my_yellow};
    private int index;
    private Renderer _rd;
    private void Start() {
        _rd = GetComponent<Renderer>();
        for(int i = 0; i < 3; i++){
            if(colors[i] == _rd.material.color){
                index = i;
                break;
            }
        }
    }
    public void Interact(){
        if(Input.GetKeyDown("f")){
            index = (index++) % 3;
            _rd.material.color = colors[index];
        }
    }
}
