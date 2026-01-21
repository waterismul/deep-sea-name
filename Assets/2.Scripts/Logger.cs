using Unity.VisualScripting;
using UnityEngine;

public class Logger : MonoBehaviour
{
    [SerializeField] private MoodSystem moodSystem;
    [SerializeField] private GrowthStageSystem growthStageSystem;
    [SerializeField] private CoinSystem coinSystem;
    private StateController stateController;

    void Start()
    {
        stateController = GetComponent<StateController>();
        stateController.ChangeState(new AroundState());
        Invoke(nameof(ToEat), 3f);
        Invoke(nameof(ToPlay), 10f);
    }

    private void ToEat()
    {
        stateController.ChangeState(new EatState());
    }

    private void ToPlay()
    {
        stateController.ChangeState(new PlayState());
    }

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
        
    }

    void OnCoinChanged(int amount)
    {
        Debug.Log($"Coins changed to {amount}");
    }
    
}
