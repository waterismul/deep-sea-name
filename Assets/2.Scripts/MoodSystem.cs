using System;
using UnityEngine;

public enum MoodType
{
    Happy,
    Calm,
    Mad,
    Sick
}
public class MoodSystem : MonoBehaviour
{
   public MoodType CurrentMood { get; private set; }
    void Start()
    {
        OnMoodChanged(MoodType.Calm);
    }

    public void ChangeMood(MoodType newMood)
    {
        if (CurrentMood == newMood)
            return;
        CurrentMood = newMood;
        
    }

    private void OnMoodChanged(MoodType mood)
    {
        switch (mood)
        {
            case MoodType.Happy:
                Debug.Log("Mood: Happy");
                break;
            case MoodType.Calm:
                Debug.Log("Mood: Calm");
                break;
            case MoodType.Mad:
                Debug.Log("Mood: Mad");
                break;
            case MoodType.Sick:
                Debug.Log("Mood: Sick");
                break;
        }
    }

    // Update is called once per frame
    void Update() 
    {
        
    }
}
