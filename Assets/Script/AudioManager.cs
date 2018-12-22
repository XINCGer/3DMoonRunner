using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public AudioClip button;
    public AudioClip coin;
    public AudioClip getitem;
    public AudioClip hit;
    public AudioClip slide;

    public static AudioManager instance;

    public Sprite soundOnSprite;
    public Sprite soundOffSprite;

    public Image soundImage;

    private void PlayAudio(AudioClip clip)
    {
        if(GameAttribute.instance.soundOn)
            AudioSource.PlayClipAtPoint(clip, PlayerController.instance.transform.position);
    }

    public void SwichSound()
    {
        GameAttribute.instance.soundOn = !GameAttribute.instance.soundOn;
        soundImage.sprite = GameAttribute.instance.soundOn ? soundOnSprite : soundOffSprite;
    }

    public void PlayButtonAudio()
    {
        PlayAudio(button);
    }

    public void PlayCoinAudio()
    {
        PlayAudio(coin);
    }

    public void PlayGetItemAudio()
    {
        PlayAudio(getitem);
    }

    public void PlayHitAudio()
    {
        PlayAudio(hit);
    }

    public void PlaySlideAudio()
    {
        PlayAudio(slide);
    }

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}