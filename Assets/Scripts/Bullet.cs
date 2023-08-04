using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionPrefab;
    public AudioSource gunshot;
    // Start is called before the first frame update
    void Start()
    {
        gunshot.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        
        Destroy(gameObject);

        // Layer 10 is car
        // Upon collision of bullet with car
        if (collision.gameObject.layer == 10)
            Instantiate(explosionPrefab, position, rotation);
    }
}
