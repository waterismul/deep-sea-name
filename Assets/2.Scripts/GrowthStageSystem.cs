using System;
using UnityEngine;

public enum GrowthStage
{
    Baby,
    Kid,
    Teen,
    Adult
}
public class GrowthStageSystem : MonoBehaviour
{
    public GrowthStage CurrentStage { get; private set; }
    
    public event Action<GrowthStage> OnStageChanged;
    
    [SerializeField] private GrowthStageData[] stageDatas;

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
        
    }

    public GrowthStageData GetCurrentStageData()
    {
        foreach (var data in stageDatas)
        {
            if (data.stage == CurrentStage)
                return data;
        }

        return null;
    }
}
