using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerpos;
    
    void Update()
    {
        if(playerpos.position.y> transform.position.y)
        {
            transform.position = new Vector3(playerpos.position.x, playerpos.position.y, playerpos.position.z - 15);
        }
    }
}
