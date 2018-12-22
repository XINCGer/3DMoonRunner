using UnityEngine;
using System.Collections;

public class MagnetCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Coin")
        {
            StartCoroutine(HitCoin(other.gameObject));
        }
    }

    IEnumerator HitCoin(GameObject coin)
    {
        bool isLoop = true;
        while(isLoop)
        {
            if (coin == null)
            {
                isLoop = false;
                continue;
            }
            coin.transform.position = Vector3.Lerp(coin.transform.position, PlayerController.instance.gameObject.transform.position, Time.deltaTime * 20);
            if (Vector3.Distance(coin.transform.position, PlayerController.instance.gameObject.transform.position) < 0.5f)
            {
                coin.GetComponent<Coin>().HitItem();
                isLoop = false;
            }
            yield return null;
        }
    }
}
