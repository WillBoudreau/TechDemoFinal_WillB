using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : MonoBehaviour
{
    Renderer myMaterial;
    public GameObject Doortrigger;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial= GetComponent<Renderer>();
        myMaterial.material.color = Color.blue;
        Doortrigger.SetActive(false);
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
            Doortrigger.SetActive(true);
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
