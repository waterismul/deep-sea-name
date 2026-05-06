using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private StateController stateController;
    [SerializeField] private GrowthSystem growthSystem;
    [SerializeField] private MoodSystem moodSystem;
    [SerializeField] private CoinSystem coinSystem;
    [SerializeField] private HungerSystem hungerSystem;
    
    private void Start()
    {
        stateController.ChangeState(new AroundState());
        Invoke(nameof(ToEat), 1f);
        Invoke(nameof(ToPlay), 3f);
        growthSystem.SetStage(GrowthStage.Adult);
        Debug.Log($"현재 소지액 : {coinSystem.CurrentCoin}");
        coinSystem.AddCoin(10000);
        Debug.Log($"돈 10000원 추가 \n 현재 소지액 : {coinSystem.CurrentCoin}");
        
        
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
