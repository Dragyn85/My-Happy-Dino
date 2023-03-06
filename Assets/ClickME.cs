using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickME : MonoBehaviour
{
    [SerializeField] GameObject clickme;
    private void OnMouseDown() {
        clickme.SetActive(true);
        Invoke("clickmeDeactivate",3f);
    }
    void clickmeDeactivate(){
        clickme.SetActive(false);
    }
}
