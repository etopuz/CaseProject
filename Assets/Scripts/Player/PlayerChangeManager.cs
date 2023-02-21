using UnityEngine;

public class PlayerChangeManager : MonoBehaviour
{
    public GameObject[] Players;
    public int CurrentPlayerIndex = 0;
    public SwitchCamera switchCamera;
    public void ChangePlayer(){
        
        Players[CurrentPlayerIndex].GetComponent<PlayerMovement>().enabled = false;
        CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Players.Length;
        Players[CurrentPlayerIndex].GetComponent<PlayerMovement>().enabled = true;

        switchCamera.Switch(CurrentPlayerIndex);
        
    }

}
