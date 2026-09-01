using UnityEngine;

public class MoodButton : MonoBehaviour
{
    public Mood mood;

    public void SelectMood()
    {
        Debug.Log("User selected mood: " + mood);
    }
}
