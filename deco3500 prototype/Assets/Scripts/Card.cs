using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
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

    float x;
    float y;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;

        //Debug.Log("X: " + x + "," + " Y: " + y);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }

    void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 1f));
    }
}
