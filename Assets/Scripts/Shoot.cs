using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint; // �ӵ������
    public GameObject bulletPrefab; // �ӵ�Prefab
    public float bulletForce = 10f; // �ӵ��ٶ�

    void Update()
    {
        // ��ȡ��������������е�λ��
        UnityEngine.Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // ���㷢�䷽��
        UnityEngine.Vector2 shootDirection = (mousePosition - transform.position).normalized;

        // �����ӵ��ķ���
        firePoint.right = shootDirection;

        if (Input.GetButtonDown("Fire1")) // ������������
        {
            shoot1();
        }
    }

    private void shoot1()
    {
        // �����ӵ�ʵ��������λ�ú���ת
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // ��ȡ�ӵ���Rigidbody2D���
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // �����ӵ����ٶ�
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
