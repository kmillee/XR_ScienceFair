using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//create an instance of a specified object
public class Instanciate : MonoBehaviour
{  
    //specify the spawn distance from the controller
    public float spawnDistance = 0.5f;


    public GameObject instanciation_base_model;
    public Transform apearance_transform;
    public GameObject hierarchical_parent;
    public string instance_name;
    public bool name_num_add;
    public Vector3 dropping_force;
    public ForceMode force_mode;
    private int id;

    public Material[] materials;    //to choose a random material

    void Start()
    {
        id = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Instanciate_prefab();
    }
    public void Instanciate_prefab()
    {
        if (instanciation_base_model)
        { //Id increment
            id++;
            GameObject created;
            string name = instance_name;
            if (name_num_add) name += id;
            Debug.Log("droping : " + name);             //Create new instance from prefab model

            Vector3 instance_position = new Vector3();
            //instance_position = apearance_transform.position;
            instance_position = apearance_transform.position + apearance_transform.forward * spawnDistance;     //spawn in front of us
            GameObject parent = hierarchical_parent;

            if (hierarchical_parent != null)
                created = Instantiate(instanciation_base_model, instance_position, apearance_transform.rotation, hierarchical_parent.transform);
            else
                created = Instantiate(instanciation_base_model, instance_position, apearance_transform.rotation);             //Name it
            created.name = name;
            Debug.Log("-- " + name + "Dropped");             //Droping Impulse Force
            

            //added to choose a random material
            if (materials.Length > 0)
            {
                int randomIndex = Random.Range(0, materials.Length);
                Material randomMaterial = materials[randomIndex];

                created.GetComponent<Renderer>().material = randomMaterial;
            }

            created.GetComponent<Rigidbody>().AddForce(dropping_force, force_mode);
        }
    }
}
