using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;

    void Update ()
    {
        transform.position = player.position + offSet;

    }
}
