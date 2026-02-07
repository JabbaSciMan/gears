using UnityEngine;

public class SpinWithInput : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 100f;
    [SerializeField] private bool reverseDirection = false;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            float rotationAmount = horizontalInput * spinSpeed * Time.deltaTime;

            if (reverseDirection)
            {
                rotationAmount *= -1;
            }

            transform.Rotate(0f, 0f, rotationAmount);
        }
    }
}
