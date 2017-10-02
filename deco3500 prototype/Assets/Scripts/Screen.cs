using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour {

    public Card.Category category;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        var card = other.gameObject.GetComponent<Card>();

        if(card != null && this.category == card.category)
        {
            card.correct = true;
        }
    }
}
