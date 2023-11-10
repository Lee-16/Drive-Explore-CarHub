using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(-5, 5, 5);

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {
            // Update the camera position
            transform.position = player.transform.position + offset;
        }
    }
}
