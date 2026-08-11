using UnityEngine;

public class rotateAround : MonoBehaviour
{
    public Transform target;
    public float speed=90f;

    [Tooltip("keep the values 1 its only direction, bigger number wont change anything try to mix the xyz direction")]
    public  Vector3 RotationDirection;

    private void Update()
    {
        transform.RotateAround(target.position , RotationDirection, speed * Time.deltaTime);
    }
}
