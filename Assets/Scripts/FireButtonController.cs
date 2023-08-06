using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class FireButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject launcher;
    bool buttonPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(buttonPressed) launcher.GetComponent<WeaponController>().Fire();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
