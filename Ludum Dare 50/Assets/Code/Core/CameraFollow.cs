using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform player;
    Vector3 tempPos;

    [SerializeField]
    float minX, MaxX, MinY;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
            return;
        }
        tempPos = transform.position;
        tempPos.x = player.position.x;
        tempPos.y = player.position.y;
        if (tempPos.x < minX)
        {
            tempPos.x = minX;
        }
        else if (tempPos.x > MaxX)
        {
            tempPos.x = MaxX;
        }
        if (tempPos.y < MinY)
        {
            tempPos.y = MinY;
        }
        transform.position = tempPos;
    }
}
