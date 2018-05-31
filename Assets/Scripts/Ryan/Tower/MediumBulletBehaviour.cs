using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumBulletBehaviour : MonoBehaviour
{
    public GameObject midBullet;

    public Bullet bullet;

    private float speed;

    private bool isSelected;

    void Start()
    {
        isSelected = false;
    }

    void Update()
    {
        ShootBullet();
        Selecting();
    }

    private void Selecting()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
            isSelected = true;

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3))
            isSelected = false;
    }

    private void ShootBullet()
    {
        if (isSelected == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(midBullet);

            speed = bullet.FourthSolution();
        }
    }
}