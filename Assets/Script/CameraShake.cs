using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraShake : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private float ShakeIntensity = 1f;
    private float ShakeTime = 0.2f;
    private float timer;
    private void Awake()
    {
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    void Start()
    {
        
    }
    public void shakeCamera()
    {
        CinemachineBasicMultiChannelPerlin _cbmcp = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cbmcp.m_AmplitudeGain = ShakeIntensity;
        timer = ShakeTime;

    }

    void stopShake()
    {
        CinemachineBasicMultiChannelPerlin _cbmcp = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cbmcp.m_AmplitudeGain = 0f;
        timer = 0;
    }

    void shakeTime()
    {
        shakeCamera();
        if (timer > 0)
            timer -= Time.deltaTime;

        if (timer <= 0) stopShake();

    }
   
}
