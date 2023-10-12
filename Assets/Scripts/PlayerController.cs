using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
