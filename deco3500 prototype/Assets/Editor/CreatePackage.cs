using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class CreatePackage : MonoBehaviour {

    public GameObject package;
    private List<Card> cards;
    private Package script;
    public string packageName;

    public GameObject packagePanel;
    public GameObject cardPanel;

	public void Create()
    {
        packageName = GameObject.Find("Name").GetComponent<Text>().text;

        var categories = GameObject.FindGameObjectsWithTag("Category").OrderBy(x => x.GetComponent<InputField>().text);

        package = Instantiate((GameObject) Resources.Load("Package"));
        package.name = packageName;
        cards = new List<Card>();

        script = package.GetComponent<Package>();

        foreach (var category in categories)
        {
            Debug.Log(category);
            script.categories.Add(category.GetComponent<InputField>().text);
        }

        packagePanel.SetActive(false);
        cardPanel.SetActive(true);

        var categoryLabels = GameObject.Find("Category").GetComponent<Dropdown>();
        for(var i = 0; i < categoryLabels.options.Count; i++)
        {
            categoryLabels.options.ElementAt(i).text = script.categories.ElementAt(i);
        }

        var label = GameObject.Find("CatDropdownLabel").GetComponent<Text>();

        label.text = script.categories.ElementAt(0);
    }

    public void CreateCard()
    {
        // Add in logic for other card types.
        var type = GameObject.Find("Type").GetComponent<Dropdown>().value;
        var category = GameObject.Find("Category").GetComponent<Dropdown>().value;
        var text = GameObject.Find("CardText").GetComponent<InputField>();

        //TODO: Alert about creating duplicate card.
        if(cards.FirstOrDefault(x => x.text == text.text) != null)
        {
            return;
        }

        var card = Instantiate((GameObject)Resources.Load("Card"), package.transform).GetComponent<Card>();
        card.media = (Card.Media) type;
        card.category = (Card.Category) category;
        card.text = text.text;

        cards.Add(card);

        type = 0;
        category = 0;
        text.text = string.Empty;
    }

    public void SaveAndExit()
    {
        CreateCard();

        //TODO: potentially change to Application.datapath
        PrefabUtility.CreatePrefab("Assets/Resources/UserPackages/Package_" + packageName + ".prefab", package);

        gameObject.GetComponent<CustomSceneManager>().LoadStartUp();
    }

    /*private void Next()
    {
        throw new NotImplementedException();
    }

    private void Back()
    {
        throw new NotImplementedException();
    }*/
}
