using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //如果碰到Tilemap，销毁子弹
        if (other.CompareTag("Tilemap"))
        {
        Destroy(bullet);
        }
    }
}
