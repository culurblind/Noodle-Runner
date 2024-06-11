using UnityEngine;

public class SlowDamage : MonoBehaviour
{
    public float speedMultiplier;
    public float duration = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            // Find the root GameObject with the Player tag
            GameObject playerRoot = collision.transform.root.gameObject;
            PlayerMovement playerMovement = playerRoot.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                playerMovement.StartSpeedChanger(speedMultiplier, duration);
            }
    }
}