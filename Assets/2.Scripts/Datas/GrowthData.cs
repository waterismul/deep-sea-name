using UnityEngine;

[CreateAssetMenu(menuName="Growth Stage Data")]
public class GrowthData : ScriptableObject
{
    public GrowthStage stage;
    public int maxHunger;
    public int maxHappiness;
}
