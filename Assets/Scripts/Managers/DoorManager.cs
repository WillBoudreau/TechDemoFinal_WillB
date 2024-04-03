using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Transform Door;
    public float Speed = 15f;
    public Transform StartPOS;
    public Transform EndPOS;
    public bool IsOpening;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOpening == true)
        {
            Door.transform.position = Vector3.MoveTowards(Door.position,EndPOS.position,(Time.deltaTime * Speed));
        }
        if(IsOpening == false)
        {
            Door.transform.position = Vector3.MoveTowards(Door.position,StartPOS.position,(Time.deltaTime * Speed));
        }
    }
    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
       {
            IsOpening = true;
       } 
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            IsOpening = false;
        }
    }
}