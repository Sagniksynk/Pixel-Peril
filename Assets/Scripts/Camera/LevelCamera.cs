using Unity.Cinemachine;
using UnityEngine;

public class LevelCamera : MonoBehaviour
{
    private CinemachineCamera cinemachineCamera;
    private void Awake()
    {
        cinemachineCamera = GetComponentInChildren<CinemachineCamera>(true);
        EnableCamera(false);
    }
    public void EnableCamera(bool enable)
    {
        cinemachineCamera.gameObject.SetActive(enable);
    }
    public void GetPlayer(Transform playerTransform)
    {
        cinemachineCamera.Follow = playerTransform;
    }
   
}
