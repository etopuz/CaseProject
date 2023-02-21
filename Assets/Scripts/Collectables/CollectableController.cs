using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    [SerializeField] private CollectableData collectableData;
    private LayerMask playerLayer;

    private void Awake(){
        playerLayer = LayerMask.NameToLayer(TagLayerData.LAYER_PLAYER);
    }

    private void OnTriggerEnter(Collider collision){
        if(collision.gameObject.layer != playerLayer) return;

        Destroy(gameObject);
        collectableData.Apply(collision.gameObject);
    }
}
