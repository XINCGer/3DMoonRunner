using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatternManager : MonoBehaviour {

    public static PatternManager instance;

    public List<Pattern> Patterns = new List<Pattern>();

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class Pattern
{
    public List<PatternItem> PatternItems = new List<PatternItem>();
}

[System.Serializable]
public class PatternItem
{
    public GameObject gameobject;
    public Vector3 position;
}