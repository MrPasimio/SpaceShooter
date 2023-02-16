using UnityEngine;

public class TrigMovement : MonoBehaviour
{
    public Transform trigObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(trigObject.position.x, transform.position.y);
    }
}
