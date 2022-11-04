using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("GameBayBall");
    }

    void Update()
    {
        eyeFollow();
    }

    void eyeFollow()
    {
        Vector3 playerpos = player.transform.position;

        Vector2 direction = new Vector2(
            playerpos.x - transform.position.x,
            playerpos.z - transform.position.z
        );
        transform.up = direction;
    }
}
