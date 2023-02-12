using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public bool isDragging = false;
    public BoxCollider2D boxCollider;

    public Vector2 mousePos;

    public GameObject bullet;
    public Transform bulletSpawn;
    public bool canShoot = true;
    public float fireRate;

    public Transform leftBorder;
    public Transform rightBorder;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        /* 
         * 02/11/2023 - Changing from touch controls to mouse controls.  I was originally going to publish this as an app,
         * but I think that it will be more effective as a WebGL.
         */

        if(Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x >= leftBorder.position.x && mousePos.x <= rightBorder.position.x)
            {
                transform.position = new Vector2(mousePos.x, transform.position.y);
            }
            isDragging = true;
        }
        else
        {
            isDragging = false;
        }

        if(isDragging)
        {
            SpawnBullet();
        }
        
    }

    public void SpawnBullet()
    {
        if(canShoot)
        {
            canShoot = false;
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            StartCoroutine(nameof(ShootDelay));

        }
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(fireRate);
        canShoot = true;
    }
}
