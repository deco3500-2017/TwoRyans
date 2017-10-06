using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IDragHandler, IBeginDragHandler
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
    void Update()
    {

    }

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
