using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class doorscript : MonoBehaviour
{
    [SerializeField]
    public Oppening script;
    [SerializeField]
    public TextMeshProUGUI text;
    [SerializeField]
    private string code = "1234";
    private string givenCode="";
    // Start is called before the first frame update
 

    // Update is called once per frame

    void Update()
    {
  
        string key="";
        if (Input.GetButtonUp("Num1")) { key = "3"; }
        else if (Input.GetButtonUp("Num2")) { key = "2"; }
        else if (Input.GetButtonUp("Num3")) { key = "4"; }
        else if (Input.GetButtonUp("Num4")) { key = "5"; }
        else if (Input.GetButtonUp("Num5")) { key = "6"; }
        else if (Input.GetButtonUp("Num6")) { key = "7"; }
        else if (Input.GetButtonUp("Num7")) { key = "9"; }
        else if (Input.GetButtonUp("Num8")) { key = "8"; }
        else if (Input.GetButtonUp("Num9")) { key = "1"; }
        givenCode = givenCode + key;
        text.text = givenCode;
        if(givenCode == code) { script.openDoor(); this.enabled = false; }//if you open the door disable this script
        if (givenCode.Length > 4) 
        { 
            text.text = ""; 
            givenCode = ""; 
        }

    }

}
