using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public AudioSource launch;
    public AudioSource blast;
    public GameObject explosionPrefab;
    int hasExploded = 0;
    // Start is called before the first frame update
    void Start()
    {
        launch.Play();
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
        
        if (hasExploded == 0)
        {
            Instantiate(explosionPrefab, position, rotation);
            blast.Play();
            hasExploded = 1;
        }


        // Destroying the gameobject after a small delay
        GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(destroyGameObject());
        
        // Layer 10 is car
        // Upon collision of bullet with car
        if(collision.gameObject.layer == 10)
            Destroy(collision.gameObject);
    }

    IEnumerator destroyGameObject()
    {
        yield return new WaitForSeconds(1.6f);
        Destroy(gameObject);
    }
}
