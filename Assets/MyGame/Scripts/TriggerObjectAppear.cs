using UnityEngine;

public class TriggerObjectAppear : MonoBehaviour
{
    public GameObject[] objectsToAppear;
    public GameObject[] textLittleButtons;

    private void OnMouseDown()
    {
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in textLittleButtons)
        {
            obj.SetActive(true);
        }
    }
}
