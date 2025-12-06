using UnityEngine;
using Vuforia;

public class MergeCubeController : MonoBehaviour
{
    [SerializeField] 
    private GameObject centralObject; // Este campo ahora aparecerá en el Inspector

    private int trackedCount = 0;

    void Start()
    {
        var imageTargets = GetComponentsInChildren<ObserverBehaviour>();

        foreach (var target in imageTargets)
        {
            target.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool isTracked = status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED;

        if (isTracked)
            trackedCount++;
        else
            trackedCount--;

        trackedCount = Mathf.Clamp(trackedCount, 0, 6);

        if (centralObject != null)
            centralObject.SetActive(trackedCount > 0);
    }
}
