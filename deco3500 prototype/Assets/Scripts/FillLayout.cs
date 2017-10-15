using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FillLayout : MonoBehaviour {

    public GameObject packageButton;

	// Use this for initialization
	void Start ()
    {
        var parent = gameObject.GetComponent<RectTransform>();
        var userPackages = Resources.LoadAll("UserPackages");

        foreach(var package in userPackages)
        {
            var btn = Instantiate(packageButton, parent);
            Debug.Log(package.name.Split('_')[1]);
            btn.GetComponentInChildren<Text>().text = package.name.Split('_')[1];
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
}
