using UnityEngine;

public class TriggerObjectAppear : MonoBehaviour
{
    public GameObject[] objectsToAppear;

    private void OnMouseDown()
    {
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(true);
        }
    }
}
