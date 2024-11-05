using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed;
    [SerializeField] float shootingCooldown;

    float lastShotTime;
    public void Shoot(Vector2 direction){
        if(Time.time - lastShotTime > shootingCooldown){
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            Projectiles projectileScript = projectile.GetComponent<Projectiles>();
            projectileScript.SourceTag = gameObject.tag;

            projectile.GetComponent<Rigidbody2D>().velocity = new Vector3(direction.x, direction.y, 0) * projectileSpeed;

            lastShotTime = Time.time;
        }
    }
}
