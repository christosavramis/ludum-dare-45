using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class enableText : MonoBehaviour
{


    public TextMeshProUGUI floatingText;
    public float fadeSpeed;


    void OnTriggerEnter2D(Collider2D co){
        if(co.name == "Player"){
            startFading();
            GetComponent<Collider2D>().enabled=false;
        }
    }

    IEnumerator fadeIn(){
        for (float f = fadeSpeed;f<1;f+=fadeSpeed){
            Color c = floatingText.color;
            c.a = f;
            floatingText.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading(){
        StartCoroutine("fadeIn");
    }
}
