using UnityEngine;

public class SpinningObstacleController : MonoBehaviour
{
    [SerializeField]
    float xAngle, yAngle, zAngle;
    
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
