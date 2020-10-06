using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppening : MonoBehaviour
{
    [SerializeField]
    GameObject d1, d2, d3;
    public void openDoor() 
    { print("anigma");
        d1.SetActive(false);
        d2.SetActive(false);
        d3.SetActive(false);
    }
}
