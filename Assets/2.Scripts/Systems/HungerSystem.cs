using UnityEngine;
using UnityEngine.Serialization;

public class HungerSystem : MonoBehaviour
{
    public int CurrentHunger { get; private set; } //현재 배고픔 정도
    public int MaxHunger { get; private set; }
    
    [SerializeField] private GrowthSystem growthSystem;

    /*void OnEnable()
    {
        growthSystem.OnStageChanged += OnChange;
    }

    void OnDisable()
    {
        growthSystem.OnStageChanged -= OnChange;
    }

    void OnChange(GrowthStage stage)
    {
        var data = growthSystem.GetCurrentStageData();
        /*MaxFood = data.maxHunger;
        CurrentFood = MaxFood;#1#
    }*/

    public void AddHunger(int amount)
    {
        CurrentHunger=Mathf.Clamp(CurrentHunger+amount ,0, growthSystem.CurrentHungerGauge);
        Debug.Log($"현재 포만감 :  {CurrentHunger} / {growthSystem.CurrentHungerGauge}");
    }
}
