using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameAttribute : MonoBehaviour {

    public int coin;

    public int multiply = 1;

    public static GameAttribute instance;

    public int life = 1;
    public int init_life = 1;

    public Text Text_Coin;

    public bool soundOn = true;

	// Use this for initialization
	void Start () {
        coin = 0;
        instance = this;
	}

    public void Reset()
    {
        life = init_life;
        coin = 0;
        multiply = 1;
    }
	
	// Update is called once per frame
	void Update () {
        Text_Coin.text = coin.ToString();
	}

    public void AddCoin(int coinNumber)
    {
        coin += multiply * coinNumber;
    }
}
