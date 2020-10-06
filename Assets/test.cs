using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class test : MonoBehaviour
{
    public string jumpAnimation = "jump";
    public string walkAnimation = "walk";
    public string idleAnimation = "idle";
    public string creationAnimation = "creation";

    enum State { JUMP, WALK, IDLE, CREATION };
    private State state = State.IDLE;

    private UnityArmatureComponent armatureComponent;
    // Start is called before the first frame update
    void Start()
    {
        armatureComponent = transform.GetComponentInChildren<UnityArmatureComponent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void idle()
    {
        if (state != State.IDLE)
        {
            armatureComponent.animation.FadeIn(idleAnimation, 0.5f, -1);
            armatureComponent.animation.timeScale = 1f;
            state = State.IDLE;
        }
    }

    public void walk (float speed)
    {
        if (speed > 0 && transform.lossyScale.x > 0 || speed < 0 && transform.lossyScale.x < 0)
        {
            if (state != State.WALK)
            {
                armatureComponent.animation.FadeIn(walkAnimation, 0.25f, -1);
                state = State.WALK;
            }
            armatureComponent.animation.timeScale = speed;
        }

        else if (speed < 0 && transform.lossyScale.x > 0 || speed > 0 && transform.lossyScale.x < 0)
        {
            if (state != State.WALK)
            {
                armatureComponent.animation.FadeIn(walkAnimation, 0.25f, -1);
                state = State.WALK;
            }
            armatureComponent.animation.timeScale = -speed;
        }
    }

    public void Jump()
    {
        if (state != State.JUMP)
        {
            armatureComponent.animation.FadeIn(jumpAnimation, 0.25f, 1);
            armatureComponent.animation.timeScale = 1f;
            state = State.JUMP;
        }
    }
}
