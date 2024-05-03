using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    private PuzzleDoor puzzleDoor;
    // Start is called before the first frame update
    void Start()
    {
        puzzleDoor = GameObject.Find("Door").GetComponent<PuzzleDoor>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            puzzleDoor.OpenDoor();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            puzzleDoor.CloseDoor();
        }
    }
}
