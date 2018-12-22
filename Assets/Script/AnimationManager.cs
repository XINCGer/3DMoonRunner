using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour {

    public delegate void AnimationHandler();

    Animation animation;

    public static AnimationManager instance;

    public AnimationClip Dead;
    public AnimationClip JumpDown;
    public AnimationClip JumpLoop;
    public AnimationClip JumpUp;
    public AnimationClip Roll;
    public AnimationClip Run;
    public AnimationClip TurnLeft;
    public AnimationClip TurnRight;

    public AnimationHandler animationHandler;

	// Use this for initialization
	void Start () {
        instance = this;
        animationHandler = PlayRun;
        animation = GetComponent<Animation>();
	}
 
    public void PlayDead()
    {
        animation.Play(Dead.name);
    }

    public void PlayJumpDown()
    {
        animation.Play(JumpDown.name);
    }

    public void PlayJumpLoop()
    {
        animation.Play(JumpLoop.name);
    }

    public void PlayJumpUp()
    {
        animation.Play(JumpUp.name);
        if (animation[JumpUp.name].normalizedTime > 0.95f)
        {
            animationHandler = PlayRun;
        }
    }

    public void PlayRoll()
    {
        animation.Play(Roll.name);
        if (animation[Roll.name].normalizedTime > 0.95f)
        {
            animationHandler = PlayRun;
            PlayerController.instance.isRoll = false;
        }
        else
        {
            PlayerController.instance.isRoll = true;
        }
    }

    public void PlayDoubleJump()
    {
        animation.Play(Roll.name);
        if (animation[Roll.name].normalizedTime > 0.95f)
        {
            animationHandler = PlayJumpLoop;
        }
    }

    public void PlayRun()
    {
        animation.Play(Run.name);
    }

    public void PlayTurnLeft()
    {
        animation.Play(TurnLeft.name);
        if(animation[TurnLeft.name].normalizedTime > 0.95f)
        {
            animationHandler = PlayRun;
        }
    }

    public void PlayTurnRight()
    {
        animation.Play(TurnRight.name);
        if (animation[TurnRight.name].normalizedTime > 0.95f)
        {
            animationHandler = PlayRun;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(animationHandler !=null)
        {
            animationHandler();
        }
	}
}