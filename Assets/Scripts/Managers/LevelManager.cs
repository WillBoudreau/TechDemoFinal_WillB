using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public PlayerMovementController player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(1);
        }
    }
}
