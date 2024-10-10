using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
    //    transform.Rotate(0, 30, 0);
    }

    /// <summary>
    /// Rotate the object based on user input
    /// </summary>
    void Update()
    {
        transform.Rotate(rotationSpeed.x* Input.GetAxis("Horizontal"), rotationSpeed.y, rotationSpeed.z* Input.GetAxis("Vertical"));    
    }
}
