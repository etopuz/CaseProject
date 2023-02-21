using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeInput : MonoBehaviour
{
    private PlayerChangeManager playerChange;

    private void Start() {
        playerChange = GetComponent<PlayerChangeManager>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerChange.ChangePlayer();
            Debug.Log("Player Changed");
        }
    }
}
