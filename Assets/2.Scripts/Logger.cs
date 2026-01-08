using UnityEngine;

public class Logger : MonoBehaviour
{
    [SerializeField] private MoodSystem moodSystem;

    void OnEnable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged += OnMoodChanged;
    }

    void OnDisable()
    {
        if(moodSystem != null)
            moodSystem.OnMoodChanged -= OnMoodChanged;
    }

    void OnMoodChanged(MoodType moodType)
    {
        Debug.Log($"Mood changed to {moodType}");
    }
}
