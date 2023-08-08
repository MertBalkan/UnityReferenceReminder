using System;
using UnityEngine;

/// <summary>
/// Reminder attribute can be applied to fields.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class RefReminderAttribute : PropertyAttribute
{
    public string reminderText;

    public RefReminderAttribute(string reminderText = "")
    {
        this.reminderText = reminderText;
    }
}