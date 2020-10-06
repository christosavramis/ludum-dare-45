using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float sx;
    public float PatrolD = 4;//patrol direction
    bool PD = false;//returning
    float oldcall; //last time we turned sides on patrol
    // Start is called before the first frame update
    void Start()
    {
        sx = this.transform.position.x;
        oldcall = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        patrol();
    }
    void patrol() 
    {
        float x = this.transform.position.x;
        if(!PD){ controller.Move(runSpeed * Time.fixedDeltaTime, false, false); }//we do patrol right
        else { controller.Move(runSpeed * -1 * Time.fixedDeltaTime, false, false); }//we do returning patrol
        if (x > sx + PatrolD){ PD = true; }  //we reached our goal return
        if ( x <= sx) { PD = false; } //we returned to our position now move again
    }

    
}
