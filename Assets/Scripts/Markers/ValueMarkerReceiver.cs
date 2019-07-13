using UnityEngine;
using UnityEngine.Playables;

public class ValueMarkerReceiver : MonoBehaviour, INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        var marker = notification as ValueMarker;
        if (marker == null)
        {
            return;
        }

        Debug.Log(marker.Value);
        //this.PrintValue(marker.Value);
    }

    void PrintValue(float value)
    {
        print(value);
    }
}
