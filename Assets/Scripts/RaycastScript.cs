using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
public class RaycastScript : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    TMP_Text rowValue;
    [SerializeField]
    TMP_Text colValue;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100.0f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        if(Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,100)){
                rowValue.text = hit.transform.gameObject.GetComponent<TileInfo>().row.ToString();
                colValue.text = hit.transform.gameObject.GetComponent<TileInfo>().column.ToString();
                agent.SetDestination(hit.point);
            }
        }

    }
    
}
