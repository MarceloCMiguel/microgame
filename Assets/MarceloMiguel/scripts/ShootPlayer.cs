using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MarceloMiguel{
        
    public class ShootPlayer : MonoBehaviour
    {
        public Transform firePoint;
        public GameObject bulletPrefab;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0)){
                
                Shoot();
            }
            
        }

        void Shoot(){
            Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        }
    }

}