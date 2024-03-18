using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public AudioSource doors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Player")
        {
            Debug.Log("inside");
            transform.Rotate(0,180,0); 
        doors.Play();
                }
    }


}
