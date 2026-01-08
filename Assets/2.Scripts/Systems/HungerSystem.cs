using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    public int CurrentFood { get; private set; }
    public int MaxFood { get; private set; }
    
    [SerializeField] private GrowthStageSystem growthStageSystem;

    void OnEnable()
    {
        growthStageSystem.OnStageChanged += OnStageChange;
    }

    void OnDisable()
    {
        growthStageSystem.OnStageChanged -= OnStageChange;
    }

    void OnStageChange(GrowthStage stage)
    {
        var data = growthStageSystem.GetCurrentStageData();
        MaxFood = data.maxFood;
        CurrentFood = MaxFood;
    }

    public void AddHunger(int amount)
    {
        CurrentFood=Mathf.Clamp(CurrentFood+amount,0,MaxFood);
    }
}
