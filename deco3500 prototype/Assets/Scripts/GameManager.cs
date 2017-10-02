using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Color correct;
    public Color incorrect;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Start");

        var package = (GameObject)Resources.Load("Grammar");
        foreach(Transform card in package.transform)
        {
            Spawn(card);
        }
    }

    public void Validate()
    {
        Debug.Log("Validate");
        var cards = FindObjectsOfType<Card>();

        foreach(var card in cards)
        {
            card.GetComponent<SpriteRenderer>().color = card.correct ? correct : incorrect;
        }
    }

    private void Spawn(Transform card)
    {
        var size = GameObject.Find("background").GetComponent<SpriteRenderer>();
        var cardSize = ((GameObject)Resources.Load("Card")).GetComponent<SpriteRenderer>();

        var positionMax = Vector3.Scale(size.bounds.max, new Vector3(0.9f, 0.9f));
        var positionMin = Vector3.Scale(size.bounds.min, new Vector3(0.9f, 0.9f));

        var position = new Vector3(UnityEngine.Random.Range(positionMin.x, positionMax.x),
            UnityEngine.Random.Range(positionMin.y, positionMax.y));

        Instantiate(card, position, Quaternion.identity);
    }
}
