using Unity.VisualScripting;
using UnityEngine;

public class Logger : MonoBehaviour
{
    [SerializeField] private MoodSystem moodSystem;
    [SerializeField] private GrowthStageSystem growthStageSystem;
    [SerializeField] private CoinSystem coinSystem;

    void OnEnable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged += OnMoodChanged;

        if (growthStageSystem != null)
            growthStageSystem.OnStageChanged += OnStageChanged;

        if (coinSystem != null)
            coinSystem.OnCoinChanged += OnCoinChanged;

    }

    void OnDisable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged -= OnMoodChanged;
        
        if (growthStageSystem != null)
            growthStageSystem.OnStageChanged -= OnStageChanged;
        
        if (coinSystem != null)
            coinSystem.OnCoinChanged -= OnCoinChanged;
    }

    void OnMoodChanged(MoodType moodType)
    {
        Debug.Log($"Mood changed to {moodType}");
    }

    void OnStageChanged(GrowthStage stage)
    {
        Debug.Log($"Stage changed to {stage}");
    }

    public void AddCoinButton()
    {
        coinSystem.AddCoin(100);
        Debug.Log($"Coins added to {coinSystem.CurrentCoin}");
        
    }

    void OnCoinChanged(int amount)
    {
        Debug.Log($"Coins changed to {amount}");
    }
    
}
