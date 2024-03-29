using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Transform CubeSpawn;
    bool InRange;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && InRange)
        {
            Explosion();
        }
        
    }
    void Explosion()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject cube;
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
            cube.AddComponent<Rigidbody>();
            cube.transform.position = CubeSpawn.transform.position;
            Destroy(cube,2f);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("In range");
        if(other.gameObject.CompareTag("Player"))
        {
            InRange = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            InRange = false;
        }
    }
}
