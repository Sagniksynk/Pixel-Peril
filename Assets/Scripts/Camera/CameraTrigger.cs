using Unity.Cinemachine;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    private LevelCamera levelCamera;
    private void Awake()
    {
        levelCamera = GetComponentInParent<LevelCamera>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null )
        {
            levelCamera.EnableCamera(true);
            levelCamera.GetPlayer(player.transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            levelCamera.EnableCamera(false);
        }
    }
}
