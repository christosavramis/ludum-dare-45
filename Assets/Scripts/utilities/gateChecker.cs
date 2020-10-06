using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateChecker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public doorscript script;


    void OnTriggerEnter2D(Collider2D co)
    {
        script.enabled = true;
    }
    void OnTriggerExit2D(Collider2D co)
    {
        script.enabled = false;
    }
}
