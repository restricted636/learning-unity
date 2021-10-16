using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershooting : MonoBehaviour
{
    public Projectile projectilePrefab;
    public LayerMask mask;
    // Start is called before the first frame update
    void shoot(RaycastHit hit)
    {
        // 1
        var projectile = Instantiate(projectilePrefab).GetComponent<Projectile>();
        // 2
        var pointAboveFloor = hit.point + new Vector3(0, this.transform.position.y, 0);

        // 3
        var direction = pointAboveFloor - transform.position;

        // 4
        var shootRay = new Ray(this.transform.position, direction);
        Debug.DrawRay(shootRay.origin, shootRay.direction * 100.1f, Color.green, 2);

        // 5
        Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());

        // 6
        projectile.FireProjectile(shootRay);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
