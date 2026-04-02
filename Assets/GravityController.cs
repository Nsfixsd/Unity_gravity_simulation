using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float gravity = -9.81f;

    void Start()
    {
        Physics.gravity = new Vector3(0, gravity, 0);
    }
}