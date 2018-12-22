using UnityEngine;
using System.Collections;

public class AutoDestory : MonoBehaviour {

    public float destoryTime = 0.7f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destoryTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}