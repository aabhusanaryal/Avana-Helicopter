using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject firstPerson;
    public GameObject thirdPerson;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If Right mouse button is clicked, switch to first person view. Else, switch back to third person view.
       
        if (Input.GetMouseButton(1))
        {
            Debug.Log("RIGHT");
            firstPerson.SetActive(true);
            thirdPerson.SetActive(false);
        }
        else
        {
            thirdPerson.SetActive(true);
            firstPerson.SetActive(false);
        }
        
    }
}
