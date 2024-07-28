using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public Transform sparkle;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(sparkle, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
