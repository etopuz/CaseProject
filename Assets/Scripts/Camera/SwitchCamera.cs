using UnityEngine;
using Cinemachine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera[] cameras;
    [SerializeField] int currentCameraIndex = 0;

    private void Start()
    {
        cameras[0].Priority = 10;

        for(int i=1; i<cameras.Length; i++){
            cameras[i].Priority = 0;
        }
    }
    public void Switch(int index){
        cameras[currentCameraIndex].Priority = 0;
        currentCameraIndex = index;
        cameras[currentCameraIndex].Priority = 10;
    }
}
