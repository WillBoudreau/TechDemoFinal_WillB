using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    private int count;
    [SerializeField]private TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hi");
        count++;
        countText.text = "Collectables Collected: " + count.ToString();
    }
}
