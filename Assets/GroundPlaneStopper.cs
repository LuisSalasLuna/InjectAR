using UnityEngine;
using Vuforia;

public class GroundPlaneController : MonoBehaviour
{
    [SerializeField] private PlaneFinderBehaviour planeFinder;

    // Esta función se puede llamar desde un botón de UI
    public void DesactivarPlaneFinder()
    {
        if (planeFinder != null)
        {
            planeFinder.enabled = false;
            Debug.Log("PlaneFinder desactivado manualmente desde botón.");
        }
        else
        {
            Debug.LogWarning("PlaneFinder no asignado.");
        }
    }

    public void ActivarPlaneFinder()
    {
        if (planeFinder != null)
        {
            planeFinder.enabled = true;
            Debug.Log("PlaneFinder reactivado.");
        }
    }

    public void TogglePlaneFinder()
    {
        if (planeFinder == null)
        {
            Debug.LogWarning("PlaneFinder no asignado.");
            return;
        }

        // Cambia el estado actual
        planeFinder.enabled = !planeFinder.enabled;

        // Mensaje de depuración
        if (planeFinder.enabled)
        {
            Debug.Log("PlaneFinder activado.");
        }
        else
        {
            Debug.Log("PlaneFinder desactivado.");
        }
    }
}
