using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[System.Serializable]
public class ValueMarker : Marker, INotification
{
    [SerializeField]
    private float value;

    public float Value => value;

    public PropertyName id => new PropertyName("Value");
}
