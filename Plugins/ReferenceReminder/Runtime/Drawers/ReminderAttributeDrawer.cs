using UnityEditor;
using UnityEngine;

// Defines a custom property drawer for properties with ReminderAttribute
[CustomPropertyDrawer(typeof(RefReminderAttribute))]
public class ReminderAttributeDrawer : PropertyDrawer
{
    private const float AdditionalPropertyHeight = 55f;
    private const float HelpBoxHeight = 40;
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        RefReminderAttribute refReminderAttribute = (RefReminderAttribute) attribute;

        EditorGUI.BeginProperty(position, label, property);

        if (IsRefNull(property))
        {
            Rect helpBoxRect = new Rect(position.x, position.y + 5, position.width, HelpBoxHeight);
            EditorGUI.HelpBox(helpBoxRect, $"{label.text} ({refReminderAttribute.reminderText})", MessageType.Warning);

            Rect propertyRect = new Rect(position.x, position.y + AdditionalPropertyHeight, position.width, EditorGUIUtility.singleLineHeight);
            EditorGUI.PropertyField(propertyRect, property, label);
        }
        else
        {
            EditorGUI.PropertyField(position, property, label);
        }

        EditorGUI.EndProperty();
    }
    
    /// <summary>
    /// This function determines the height of the property field in the inspector based on whether the property is null.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (IsRefNull(property))
            return AdditionalPropertyHeight + EditorGUIUtility.singleLineHeight;

        return EditorGUIUtility.singleLineHeight;
    }

    /// <summary>
    /// Just a helper function to check if the property's object reference is null.
    /// </summary>
    /// <param name="property"></param>
    /// <returns></returns>
    private bool IsRefNull(SerializedProperty property)
    {
        return IsPropertyObjectReference(property) && property.objectReferenceValue == null;
    }
    
    /// <summary>
    /// Selecting only object reference types.
    /// </summary>
    /// <param name="property"></param>
    /// <returns></returns>
    private bool IsPropertyObjectReference(SerializedProperty property)
    {
        return property.propertyType == SerializedPropertyType.ObjectReference;
    }
}