using UnityEngine;

public class Logger : MonoBehaviour
{
    [SerializeField] private MoodSystem moodSystem;
    [SerializeField] private GrowthStageSystem growthStageSystem;

    void OnEnable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged += OnMoodChanged;

        if (growthStageSystem != null)
            growthStageSystem.OnStageChanged += OnStageChanged;

    }

    void OnDisable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged -= OnMoodChanged;
        
        if (growthStageSystem != null)
            growthStageSystem.OnStageChanged -= OnStageChanged;
    }

    void OnMoodChanged(MoodType moodType)
    {
        Debug.Log($"Mood changed to {moodType}");
    }

    void OnStageChanged(GrowthStage stage)
    {
        Debug.Log($"Stage changed to {stage}");
    }
    
}
