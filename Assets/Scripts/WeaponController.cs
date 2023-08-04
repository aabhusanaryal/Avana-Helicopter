using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject launcher;
    public GameObject[] weapons;
    public float[] FireRate = {1.0f, 0.1f, 0.2f};
    int i = 0;
    public float[] speed = { 10.0f, 30.0f, 50.0f };
    public Canvas crosshair;
    

    private float nextLaunch; //Time until next launch is available
    // Start is called before the first frame update
    void Start()
    {
        crosshair = GetComponentInChildren<Canvas>();
        crosshair.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1) && Input.GetMouseButton(0))
        {
            Fire();
        }
        
        if (Input.GetKeyDown("1"))
        {
            i = 0;
        }
        if (Input.GetKeyDown("2"))
        {
            i = 1;
        }
        if (Input.GetKeyDown("3"))
        {
            i = 2;
        }
        try
        {
            if(Camera.main.name == "1st Person Camera")
            {
                crosshair.gameObject.SetActive(true);
            }
        }
        catch
        {
                crosshair.gameObject.SetActive(false);
        }

    }

    void Fire()
    {
        Debug.Log("Dishum");
        // Firing the weapon if current time has exceeded nextLaunch time
        if(Time.time >= nextLaunch)
        {
            GameObject bullet = GameObject.Instantiate(weapons[i], this.transform.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = this.transform.forward * speed[i];
            UpdateNextLaunchTime();
        }        
    }
    void UpdateNextLaunchTime()
    {
        nextLaunch = Time.time + FireRate[i];
    }
}
