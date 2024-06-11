using UnityEngine;

public class SlowDamage : MonoBehaviour
{
    public float speedMultiplier;
    public float duration = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        Debug.Log("Collision tag is: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision with player detected, attempting to get PlayerMovement component.");

            // Find the root GameObject with the Player tag
            GameObject playerRoot = collision.transform.root.gameObject;
            PlayerMovement playerMovement = playerRoot.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                Debug.Log("PlayerMovement component found, starting speed changer.");
                playerMovement.StartSpeedChanger(speedMultiplier, duration);
            }
            else
            {
                Debug.Log("PlayerMovement component not found on: " + playerRoot.name);
            }
        }
        else
        {
            Debug.Log("Collision was not with player, tag was: " + collision.gameObject.tag);
        }
    }
}