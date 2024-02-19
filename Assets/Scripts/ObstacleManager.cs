using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] tiles;
    [SerializeField]
    Material red;
    public List<int> redAreas = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ObstacleManage(int num){
        redAreas.Add(num);
        tiles[num].GetComponent<Renderer>().material  = red;
        tiles[num].GetComponent<TileInfo>().Create();
    }
    
}
