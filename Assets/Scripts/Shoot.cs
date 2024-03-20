using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint; // 子弹发射点
    public GameObject bulletPrefab; // 子弹Prefab
    public float bulletForce = 10f; // 子弹速度

    void Update()
    {
        // 获取鼠标在世界坐标中的位置
        UnityEngine.Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 计算发射方向
        UnityEngine.Vector2 shootDirection = (mousePosition - transform.position).normalized;

        // 设置子弹的方向
        firePoint.right = shootDirection;

        if (Input.GetButtonDown("Fire1")) // 检测鼠标左键点击
        {
            shoot1();
        }
    }

    private void shoot1()
    {
        // 创建子弹实例并设置位置和旋转
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 获取子弹的Rigidbody2D组件
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // 设置子弹的速度
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
