using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private GameObject aDesactivar;
    [SerializeField]
    private GameObject aActivar;

    private void OnTriggerEnter(Collider other)
    {
        aDesactivar?.SetActive(false);
        aDesactivar?.SetActive(true);

        Destroy(gameObject);
    }
}
