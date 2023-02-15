using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float moveSpeed;
    private float halfway;

    // Start is called before the first frame update
    void Start()
    {
        halfway = (Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x) / 2;
        if(transform.position.x > halfway)
        {
            moveSpeed *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
