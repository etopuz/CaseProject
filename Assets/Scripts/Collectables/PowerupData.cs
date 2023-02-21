
using UnityEngine;

[CreateAssetMenu(fileName = "Powerup", menuName = "Collectables/PowerupData")]
public class PowerupData : CollectableData
{
    public float scaleChangeRate = 1f;
    public int scoreValue = 1;
    public override void Apply(GameObject target){
        
        target.transform.localScale += Vector3.one * scaleChangeRate;
        target.transform.position += Vector3.up * scaleChangeRate;

        target.GetComponent<PlayerScore>().AddScore(scoreValue);

    }

}
