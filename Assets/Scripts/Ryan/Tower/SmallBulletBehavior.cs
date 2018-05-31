using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBulletBehavior : MonoBehaviour
{
    public GameObject smallBullet;
    GravityBehaviour pull;
    public Bullet bullet;

    private float speed;

    private bool isSelected;

    void Start()
    {
        speed = 0;
        isSelected = false;
    }

    void Update()
    {
        ShootBullet();
        Selecting();
    }

    private void Selecting()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            isSelected = true;
        
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))
            isSelected = false;
    }

    private void ShootBullet()
    {
        //float down = pull.gravity * Time.deltaTime;

        if (isSelected == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(smallBullet);

            speed = bullet.FirstSolution();
        }
    }
}
