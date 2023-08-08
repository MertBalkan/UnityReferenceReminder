using System;
using UnityEngine;

/// <summary>
/// Reminder attribute can be applied to fields.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class ReminderAttribute : PropertyAttribute
{
    public string reminderText;

    public ReminderAttribute(string reminderText = "")
    {
        this.reminderText = reminderText;
    }
}