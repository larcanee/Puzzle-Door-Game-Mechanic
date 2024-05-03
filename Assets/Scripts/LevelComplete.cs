using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= gameObject.transform.position.x && gameObject.activeSelf)
        {
            Debug.Log("Level Complete!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
