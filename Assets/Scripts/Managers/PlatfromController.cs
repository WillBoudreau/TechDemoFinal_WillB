using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromController : MonoBehaviour
{
    public Transform StartPOS;
    public Transform EndPOS;
    public GameObject Player;
    public float Speed = 1;
    public float time = 5;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(StartPOS.position,EndPOS.position,Mathf.Sin(Time.time * Speed));
        //Debug.Log("Start: "+StartPOS.position.z);
        //Debug.Log("End: "+EndPOS.position.z);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Platform");
        if(other.gameObject.CompareTag("Player"))
        {
           Player.transform.position = transform.position;
           other.transform.parent = transform;
        }
    }
    // void OnTriggerExit(Collider other)
    //     {
    //         if(other.gameObject.CompareTag("Player"))
    //         {
    //             other.transform.parent = null;
    //         }
    //     }   
}
