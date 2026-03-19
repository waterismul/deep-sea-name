using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private StateController stateController;
    [SerializeField] private GrowthSystem growthSystem;
    [SerializeField] private MoodSystem moodSystem;
    [SerializeField] private CoinSystem coinSystem;
    
    private void Start()
    {
        stateController.ChangeState(new AroundState());
        Invoke(nameof(ToEat), 1f);
        Invoke(nameof(ToPlay), 3f);
        growthSystem.SetStage(GrowthStage.Adult);
    }
    
    
    //test
    private void ToEat()
    {
        stateController.ChangeState(new EatState());
    }

    private void ToPlay()
    {
        stateController.ChangeState(new PlayState());
    }

   
}
