using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBulletBehaviour : MonoBehaviour
{
    public GameObject largeBullet;

    public Bullet bullet;

    private float speed;

    private bool isSelected;

	void Start ()
    {
        isSelected = false;
	}
	
	void Update ()
    {
        ShootBullet();
        Selecting();
    }

    private void Selecting()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
            isSelected = true;

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
            isSelected = false;
    }
    private void ShootBullet()
    {
        if (isSelected == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(largeBullet);

            speed = bullet.FourthSolution();
        }
    }
}
