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
    
    public int CurrentHungerGauge { get; private set; } //현재 배고픔 게이지
    public int MaxHungerGauge { get; private set; } // 현재 최대 배고픔 게이지
    
    public int CurrentHappinessGauge { get; private set; } // 현재 행복 게이지
    public int MaxHappinessGauge { get; private set; } //현재 최대 행복 게이지
    
    //public event Action<GrowthStage> OnStageChanged;
    
    [SerializeField] private GrowthData[] stageDatas;
    

    public void SetStage(GrowthStage newStage)
    {
        if (CurrentStage == newStage)
            return;
        CurrentStage = newStage;
        //OnStageChanged?.Invoke(CurrentStage);
        OnChange(CurrentStage);
        Debug.Log($"현재 스테이지: {CurrentStage}");
        Debug.Log($"현재 데이터 : {CurrentHungerGauge}");
        
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
    
    private void OnChange(GrowthStage stage)
    {
        var data = GetCurrentStageData();
        
        MaxHungerGauge = data.maxHungerGauge;
        CurrentHungerGauge = MaxHungerGauge;
        
        MaxHappinessGauge = data.maxHappinessGauge;
        CurrentHappinessGauge = MaxHappinessGauge;
    }
}
