using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public enum Category
    {
        Category1,
        Category2,
        Category3,
        Category4
    };

    public enum Media
    {
        Text,
        Image,
        Video,
        Multimedia
    };

    public Category category;

    public Media media;

    public string text;

    public bool correct = false;

    private Vector3 startPos;

	void Start()
	{
		gameObject.GetComponentInChildren<Text> ().text = text;
	}

    // Update is called once per frame
    /*void Update()
    {
        var cardHits = new List<Transform>();
        var cardTouches = new List<Touch>();

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                Debug.DrawRay(ray.origin, ray.direction);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.transform.gameObject.name);
                    if (hit.transform.gameObject.tag == "Card")
                    {
                        cardHits.Add(hit.transform);
                        cardTouches.Add(touch);
                    }
                }
            }
        }

        foreach(var cardHit in cardHits.Distinct())
        {
            if(cardHits.Count(x => x == cardHit) == 1)
            {
                Debug.Log(1);
                var touchPos = cardTouches.ElementAt(cardHits.IndexOf(cardHit));
                var cardPos = Camera.main.ScreenToWorldPoint(touchPos.position);
                cardPos.z = 0f;
                cardHit.position = cardPos;
            }
            else
            {
                Debug.Log(2);
                var touchPos = cardTouches.ElementAt(cardHits.IndexOf(cardHit));
                cardHit.Rotate(0f, 0f, 0.1f * (touchPos.deltaPosition.x + touchPos.deltaPosition.y));
            }
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Card>() != null)
        {
            return;
        }

        SetCorrect(other, true);

        Debug.Log("Entering: " + other.gameObject.name);
    }

    private void SetCorrect(Collider other, bool isCorrect)
    {
        var screen = other.gameObject.GetComponent<Screen>();

        if (screen != null)
        {
            if (this.category == screen.category)
            {
                correct = isCorrect;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Card>() != null)
        {
            return;
        }

        SetCorrect(other, false);

        Debug.Log("Exiting: " + other.gameObject.name);
    }

    public void OnDrag(PointerEventData eventData)
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 10f;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = transform.position;
    }
}
