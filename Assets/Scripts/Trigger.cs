using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private GameObject aDesactivar;
    [SerializeField]
    private GameObject aActivar;

    private void OnTriggerEnter(Collider other)
    {
        aDesactivar.SetActive(false);
        aActivar.SetActive(true);

        Destroy(gameObject);
    }
}
