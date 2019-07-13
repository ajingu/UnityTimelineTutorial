using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{
    [SerializeField]
    PlayableDirector playableDirector;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playableDirector.Play();
        }
    }
}
