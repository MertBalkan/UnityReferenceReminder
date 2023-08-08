using UnityEngine;

public class ReminderTest : MonoBehaviour
{
    [Reminder()] public GameObject reminderTest;
    [Reminder("Doesn't matter whether assigned or not!")] public GameObject reminderTest1;
    [Reminder] public GameObject reminderTest2;
    [Reminder] public GameObject reminderTest3;
    public float a;
}
