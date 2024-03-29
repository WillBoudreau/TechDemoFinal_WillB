using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : MonoBehaviour
{
    Renderer myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial= GetComponent<Renderer>();
        myMaterial.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            myMaterial.material.color = Color.red;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            myMaterial.material.color = Color.green;
        }
    }
}
