using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Color correct;
    public Color incorrect;
    public GameObject gameCanvas;

    private bool mouseDown = false;
    private Vector3 startMousePos;
    private Vector3 startPos;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Start");

        var package = (GameObject)Resources.Load("UserPackages/Package_" + ApplicationModel.packageName);
        Instantiate(package, gameCanvas.transform);
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
            card.GetComponent<Image>().color = card.correct ? correct : incorrect;
        }
    }

    private void Spawn(Transform card)
    {
        var size = GameObject.Find("background").GetComponent<SpriteRenderer>();
        //var cardSize = ((GameObject)Resources.Load("Card")).GetComponent<SpriteRenderer>();

        var positionMax = Vector3.Scale(size.bounds.max, new Vector3(0.5f, 0.5f));
        var positionMin = Vector3.Scale(size.bounds.min, new Vector3(0.5f, 0.5f));

        var position = new Vector3(Random.Range(positionMin.x, positionMax.x),
            Random.Range(positionMin.y, positionMax.y));

        card.position = position;
    }
}
