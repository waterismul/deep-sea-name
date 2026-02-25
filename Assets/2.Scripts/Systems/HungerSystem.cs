using UnityEngine;
using UnityEngine.Serialization;

public class HungerSystem : MonoBehaviour
{
    public int CurrentFood { get; private set; }
    public int MaxFood { get; private set; }
    
    [SerializeField] private GrowthSystem growthSystem;

    void OnEnable()
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
        MaxFood = data.maxHunger;
        CurrentFood = MaxFood;
    }

    public void AddHunger(int amount)
    {
        CurrentFood=Mathf.Clamp(CurrentFood+amount,0,MaxFood);
    }
}
