using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Destroy(this.gameObject, 10);
    }

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.5f);
        transform.LookAt(new Vector3(0.0f, 0.0f, 0.0f));
    }
}
