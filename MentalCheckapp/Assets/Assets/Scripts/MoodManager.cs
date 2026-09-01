using UnityEngine;

public class MoodManager : MonoBehaviour
{
    public void SelectMood(Mood mood)
    {
        Debug.Log("User selected mood: " + mood);
    }
}
