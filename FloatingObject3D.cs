using UnityEngine;

[DisallowMultipleComponent]
public class FloatingObject3D : MonoBehaviour
{
    [Header("Floating Settings")]
    [SerializeField] private float amplitude = 0.5f;   // Height of float
    [SerializeField] private float frequency = 1f;     // Speed of float
    [SerializeField] private Vector3 floatAxis = Vector3.up;

    [Header("Optional Rotation")]
    [SerializeField] private bool enableRotation = false;
    [SerializeField] private Vector3 rotationSpeed = new Vector3(0f, 45f, 0f);

    private Vector3 startPosition;
    private float randomOffset;

    private void Awake()
    {
        startPosition = transform.position;
        randomOffset = Random.Range(0f, Mathf.PI * 2f); // Prevent synchronized motion
    }

    private void Update()
    {
        FloatMotion();
        Rotate();
    }

    private void FloatMotion()
    {
        float offset = Mathf.Sin((Time.time + randomOffset) * frequency) * amplitude;
        transform.position = startPosition + floatAxis.normalized * offset;
    }

    private void Rotate()
    {
        if (!enableRotation) return;

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

    // Optional: Call this if object moves dynamically and you want to reset base height
    public void ResetStartPosition()
    {
        startPosition = transform.position;
    }
}
