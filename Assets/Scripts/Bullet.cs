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
        //�������Tilemap�������ӵ�
        if (other.CompareTag("Tilemap"))
        {
        Destroy(bullet);
        }
    }
}
