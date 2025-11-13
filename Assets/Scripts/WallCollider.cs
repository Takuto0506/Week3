using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
        {
            Debug.Log("•Ç‚É“–‚½‚Á‚½");
            GameManager.instance.GameOver();
        }
    }
}
