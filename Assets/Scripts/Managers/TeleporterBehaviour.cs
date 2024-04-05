using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{
    public GameObject TeleEnd;
    //public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Teleportation");
            other.transform.position = TeleEnd.transform.position;
        }
    }
}
