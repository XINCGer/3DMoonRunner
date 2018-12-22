using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

    //public float distance = 0.1f;
    private float totalTime = 0;
    private float speed = 1;
    private Material material;

	// Use this for initialization
	void Start () {
        material = GetComponent<MeshRenderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        totalTime += Time.deltaTime;
	}

    void OnTriggerEnter(Collider other)
    {
        speed = 0;
        Debug.Log(totalTime);
    }

    public void BeginUpdateColor()
    {
        StartCoroutine(UpdateColor());
    }

     IEnumerator UpdateColor()
    {
        for (byte i = 0; i < 255; i++)
        {
            material.color = new Color32(i,i,i,255);
            yield return 0;
        }
    }
}