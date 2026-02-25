using System;
using UnityEngine;

public enum MoodType
{
    Happy,
    Calm,
    Hungry,
    Sick
}
public class MoodSystem : MonoBehaviour
{
   public MoodType CurrentMood { get; private set; }
   public event Action<MoodType> OnMoodChanged;
    void Start()
    {
        ChangeMood(MoodType.Hungry);
    }

    public void ChangeMood(MoodType newMood)
    {
        if (CurrentMood == newMood)
            return;
        CurrentMood = newMood;
        OnMoodChanged?.Invoke(CurrentMood);
    }
    

    // Update is called once per frame
    void Update() 
    {
        
    }
}
