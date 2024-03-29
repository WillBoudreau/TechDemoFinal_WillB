using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{
    public GameObject TeleEnd;
    public GameObject Player;
    bool IsTeleporting = false;
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
        if (IsTeleporting == false && other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Teleport());
        }
    }
    IEnumerator Teleport()
    {
        IsTeleporting = true;
        yield return new WaitForSeconds(1f);
        Player.transform.position = TeleEnd.transform.position;
        yield return new WaitForSeconds(5f);
        IsTeleporting = false;
    }
}
