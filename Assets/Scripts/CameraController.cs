using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject firstPerson;
    public GameObject thirdPerson;
    int cmode = 3;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If Right mouse button is clicked, switch to first person view. Else, switch back to third person view.
       
        //if (Input.GetMouseButton(1))
        //{
        //    setCameraMode(1);
        //}
        //else
        //{
        //    setCameraMode(3);
        //}
        
    }

    public void setCameraMode(int mode)
    {
        if(mode == 1)
        {
            Debug.Log("First person activated");
            cmode = 1;
            firstPerson.SetActive(true);
            thirdPerson.SetActive(false);
        }
        else
        {
            Debug.Log("Third person activated");
            cmode = 3;
            thirdPerson.SetActive(true);
            firstPerson.SetActive(false);
        }
    }

    public void toggleCamera()
    {
        Debug.Log(cmode);
        if (cmode == 1) setCameraMode(3);
        else setCameraMode(1);
    }
}
