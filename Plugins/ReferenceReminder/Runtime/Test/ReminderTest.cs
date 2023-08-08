using UnityEngine;

public class ReminderTest : MonoBehaviour
{
    [RefReminder("Scene assign")] public GameObject reminderTest;
    [RefReminder("Doesn't matter whether assigned or not!")] public GameObject reminderTest1;
    [RefReminder] public GameObject reminderTest2;
    [RefReminder("Change string")] public string mString;
    public float mFloat;
    public int mInt;
}
