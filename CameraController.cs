using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;

    Vector3 lastPosition;
    float distanceToMove;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();

        lastPosition = player.transform.position;
    }

    private void Update()
    {
        distanceToMove = player.transform.position.x - lastPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPosition = player.transform.position;
    }

}
