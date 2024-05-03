using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoor : MonoBehaviour
{
    public Transform doorTransform; // Reference to the door's transform
    public Transform doorOpenPosition; // Reference to the open door position
    public GameObject openDoorSprite; // Reference to the GameObject representing the open door sprite
    public GameObject closedDoorSprite; // Reference to the GameObject representing the closed door sprite
    public Transform groundCheck; // Reference to the ground check position
    public LayerMask groundLayer; // The layer mask for detecting the ground
    public float groundCheckRadius = 0.2f; // The radius of the ground check circle

    void Start()
    {
        closedDoorSprite.SetActive(true);
        openDoorSprite.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OpenDoor()
    {
        openDoorSprite.SetActive(true); // Set the open door sprite to active
        closedDoorSprite.SetActive(false); // Set the closed door sprite to inactive
    }

    public void CloseDoor()
    {
        openDoorSprite.SetActive(false); // Set the open door sprite to inactive
        closedDoorSprite.SetActive(true); // Set the closed door sprite to active
    }
}
