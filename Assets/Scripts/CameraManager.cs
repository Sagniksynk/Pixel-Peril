using Unity.Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    //[SerializeField] private Vector2 shakeVelocity;
    private CinemachineImpulseSource cinemachineImpulseSource;
    private void Awake()
    {
        instance = this;
        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
    }
    public void CameraShake(Vector2 shakeVelocity,float direction = 1f)
    {
        cinemachineImpulseSource.DefaultVelocity = new Vector2(shakeVelocity.x*direction, shakeVelocity.y);
        cinemachineImpulseSource.GenerateImpulse();
    }
}
