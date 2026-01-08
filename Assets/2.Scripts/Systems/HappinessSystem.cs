using UnityEngine;

public class HappinessSystem : MonoBehaviour
{
   public int CurrentHappiness { get; private set; }
   public int MaxHappiness { get; private set; }
   
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
      MaxHappiness = data.maxHappiness;
      CurrentHappiness = MaxHappiness;
   }

   public void AddHunger(int amount)
   {
      CurrentHappiness = Mathf.Clamp(CurrentHappiness + amount, 0, MaxHappiness);
   }
}
