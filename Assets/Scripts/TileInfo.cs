using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfo : MonoBehaviour
{
    [SerializeField]
    public int row;
    [SerializeField]
    public int column;
    [SerializeField]
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Create(){
        Instantiate(prefab, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
    }
}
