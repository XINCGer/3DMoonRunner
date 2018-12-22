using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public float rotateSpeed = 1;
    public GameObject hitEffect;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    public virtual void HitItem()
    {
        PlayHitAudio();
        GameObject effect = Instantiate(hitEffect);
        effect.transform.parent = PlayerController.instance.gameObject.transform;
        effect.transform.localPosition = new Vector3(0, 0.5f, 0);

        Destroy(gameObject);
    }

    public virtual void PlayHitAudio()
    {
        AudioManager.instance.PlayGetItemAudio();
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HitItem();
        }
    }
}
