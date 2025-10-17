using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    public Vector3 rotSpeedEulerAnglesDegsPerSec = new Vector3(15.0f, 90.0f, 0.0f);

    private Vector3 eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eulerAngles = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 rotOffset = rotSpeedEulerAnglesDegsPerSec * dt;
        eulerAngles += rotOffset;
        transform.eulerAngles = eulerAngles;
    }
}
