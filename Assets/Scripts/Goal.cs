using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
        {
            if (!GameManager.instance.hasStarted)
            {
                Debug.Log("まだスタートしてない");
                return;
            }
            Debug.Log("ゴール！");
            GameManager.instance.GameClear();
        }
    }
}
