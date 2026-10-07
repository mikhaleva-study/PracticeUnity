using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform visualModel;
    public ParticleSystem moveParticles;

    private float currentSpeed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        currentSpeed = movement.magnitude * speed;

        transform.Translate(
            movement * speed * Time.deltaTime,
            Space.World
        );

        if (movement.sqrMagnitude > 0.01f)
        {
            if (visualModel != null)
            {
                float angle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
                visualModel.rotation = Quaternion.Euler(0f, angle, 0f);
            }

            if (moveParticles != null && !moveParticles.isPlaying)
                moveParticles.Play();
        }
        else
        {
            if (moveParticles != null && moveParticles.isPlaying)
                moveParticles.Stop();
        }
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }
}