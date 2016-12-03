using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int coinCounter;
    public Text text;

	// Use this for initialization
	void Start ()
    {
        coinCounter = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.GetComponent<Text>().text = coinCounter.ToString();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("OpenDoor"))
        {
            other.gameObject.SetActive(false);
            coinCounter++;
        }
    }
}
