using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public int hurtValue = 1;
    public int moveSpeed = 0;
    public Vector3 moveDirection = Vector3.back;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
	}

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.instance.PlayHitAudio();
            CameraManager.instance.CameraShake();
            GameAttribute.instance.life -= hurtValue;
            //Debug.Log(name);
        }
        if (other.tag != "Road" && other.tag != "MagnetCollider")
        {
            moveSpeed = 0;
            //Debug.Log(other.name);
        }
    }
}