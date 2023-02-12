using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigMovement : MonoBehaviour
{
    public Transform trigObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(trigObject.position.x, transform.position.y);
    }
}
