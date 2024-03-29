using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    float RespawnDelay = 1.0f;
    float ColorSpeed = 15f;

    float hue;
    float sat;
    float bri;

    Renderer CollectMat;
    // Start is called before the first frame update
    void Start()
    {
        CollectMat = GetComponent<Renderer>();
        CollectMat.material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        Color.RGBToHSV(CollectMat.material.color,out hue,out sat, out bri);
        hue += ColorSpeed /10000;
        if(hue >= 1)
        {
            hue = 0;
        }
        sat = 1;
        bri = 1;
        CollectMat.material.color = Color.HSVToRGB(hue,sat,bri);
    }
    void Respawn()
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {  
            gameObject.SetActive(false);
            Invoke("Respawn", RespawnDelay);
        }
    }
}
