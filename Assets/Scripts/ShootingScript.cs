using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField]
    private GameObject arCamera;
    [SerializeField]
    private PointsManager pointsManager;
    
    public void Shoot()
    {
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out RaycastHit hit))
        {
            pointsManager.UpdateScore();
            Destroy(hit.transform.gameObject);
        }
    }
}
