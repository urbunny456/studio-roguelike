using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] float damage = 1f;
    [SerializeField] public string SourceTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (!other.gameObject.CompareTag(SourceTag)){
            Entity entity = other.GetComponent<Entity>();
            if (entity) {
                entity.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
