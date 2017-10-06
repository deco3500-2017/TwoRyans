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

    private void OnTriggerEnter(Collider other)
    {
        var card = other.gameObject.GetComponent<Card>();

        if (card != null)
        {
            if (this.category == card.category)
            {
                card.correct = true;
            }
            else
            {
                card.correct = false;
            }
        }
    }
}
