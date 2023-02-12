using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour
{
    public string message;
    public TextMeshPro textMeshPro;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                textMeshPro = message;
                //GUI.Label(new Rect(0, 0, 100, 100), message);
            }
        }
    }
}

