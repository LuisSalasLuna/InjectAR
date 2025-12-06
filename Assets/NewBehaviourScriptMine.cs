using UnityEngine;
using Vuforia;

public class NewBehaviorScriptMine : MonoBehaviour
{
    private ObserverBehaviour observer;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();

        if (observer != null)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnDestroy()
    {
        if (observer != null)
        {
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            Debug.Log("🎯 Model Target detectado");
            // Aquí puedes activar contenido
        }
        else if (targetStatus.Status == Status.NO_POSE)
        {
            Debug.Log("🛑 Model Target perdido");
            // Aquí puedes desactivar contenido
        }
    }
}
