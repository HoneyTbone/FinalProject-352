using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    [SerializeField] float reloadTime = 1f;

    private float waitForReloadTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && waitForReloadTime <= 0)
        {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
            waitForReloadTime = reloadTime;
        }
        else
        {
            waitForReloadTime = waitForReloadTime - Time.deltaTime;
        }
    }
}
