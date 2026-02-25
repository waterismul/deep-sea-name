using System;
using UnityEngine;

public enum GrowthStage
{
    Baby,
    Kid,
    Teen,
    Adult
}
public class GrowthSystem : MonoBehaviour
{
    public GrowthStage CurrentStage { get; private set; }
    
    public int CurrentHunger { get; private set; }
    public int MaxHunger { get; private set; }
    
    public int CurrentHappiness { get; private set; }
    public int MaxHappiness { get; private set; }
    
    public event Action<GrowthStage> OnStageChanged;
    
    [SerializeField] private GrowthData[] stageDatas;

    private void Start()
    {
        SetStage(GrowthStage.Baby);
    }

    public void SetStage(GrowthStage newStage)
    {
        if (CurrentStage == newStage)
            return;
        CurrentStage = newStage;
        OnStageChanged?.Invoke(CurrentStage);
        Debug.Log($"현재 스테이지: {CurrentStage}");
        
    }

    public GrowthData GetCurrentStageData()
    {
        foreach (var data in stageDatas)
        {
            if (data.stage == CurrentStage)
                return data;
        }

        return null;
    }
    
    void OnChange(GrowthStage stage)
    {
        var data = GetCurrentStageData();
        
        MaxHunger = data.maxHunger;
        CurrentHunger = MaxHunger;
        
        MaxHappiness = data.maxHappiness;
        CurrentHappiness = MaxHappiness;
    }
}
