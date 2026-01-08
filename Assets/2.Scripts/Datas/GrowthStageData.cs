using UnityEngine;

[CreateAssetMenu(menuName="Growth Stage Data")]
public class GrowthStageData : ScriptableObject
{
    public GrowthStage stage;
    public int maxFood;
    public int maxHappiness;
}
