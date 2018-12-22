using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public bool isPause;
    public bool isPlay;

    public static GameController instance;

	// Use this for initialization
	void Start () {
        instance = this;
        isPause = true;
        isPlay = true;
	}

    public void Play()
    {
        isPause = false;
    }

    public void Pause()
    {
        isPause = true;
    }

    public void Resume()
    {
        isPause = false;
    }

    public void Restart()
    {
        GameAttribute.instance.Reset();
        PlayerController.instance.Reset();
        PlayerController.instance.Play();
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
