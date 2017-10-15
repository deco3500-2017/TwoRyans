using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PackageButton : MonoBehaviour, IPointerDownHandler {

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log(data.selectedObject.GetComponentInChildren<Text>().text);
        ApplicationModel.packageName = data.selectedObject.GetComponentInChildren<Text>().text;
        SceneManager.LoadScene("Act1", LoadSceneMode.Single);
    }

    /*public void OnMouseDown()
    {
        Debug.Log("Mouse down");
    }*/

    /*void Update()
    {

        /*RaycastHit2D buttonHit;
        buttonHit = Physics2D.Raycast(this.transform.position, Input.mousePosition);
        //Debug.Log(buttonHit);
        if (buttonHit)
        {
            var objectHit = buttonHit.transform.gameObject;
            //objectHit.SendMessage("LoadScene", 1, SendMessageOptions.DontRequireReceiver);
        }
        if (Input.GetMouseButtonDown(0))
        {
            var mPosition = Input.mousePosition;
            mPosition.z = 0;
            Ray ray = Camera.main.ScreenPointToRay(mPosition);
            Debug.Log(ray);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }*/
}
