using UnityEngine;
using UnityEngine.Serialization;

public class HappinessSystem : MonoBehaviour
{
   public int CurrentHappiness { get; private set; }
   public int MaxHappiness { get; private set; }
   
   [FormerlySerializedAs("growthStageSystem")] [SerializeField] private GrowthSystem growthSystem;

   /*void OnEnable()
   {
      growthSystem.OnStageChanged += OnChange;
   }

   void OnDisable()
   {
      growthSystem.OnStageChanged -= OnChange;
   }*/

   void OnChange(GrowthStage stage)
   {
      var data = growthSystem.GetCurrentStageData();
      MaxHappiness = data.maxHappinessGauge;
      CurrentHappiness = MaxHappiness;
   }

   public void AddHunger(int amount)
   {
      CurrentHappiness = Mathf.Clamp(CurrentHappiness + amount, 0, MaxHappiness);
   }
}
