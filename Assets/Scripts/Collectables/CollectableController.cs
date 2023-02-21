using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    [SerializeField] private CollectableData collectableData;

    private void OnTriggerEnter(Collider collision){

        if(collision.TryGetComponent<PlayerScore>(out PlayerScore playerScore)){
            Destroy(gameObject);
            collectableData.Apply(collision.gameObject);
        }
    }
}
