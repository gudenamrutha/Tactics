using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGenerator : MonoBehaviour
{
    
    [SerializeField]
    GameObject OM;
    
    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0 ; i<10; i++){
            for(int j = 0; j<10; j++){
                int r = Random.Range(0,9);
                if( (i == 0 && j== 0) && ( i== 9 && j == 9)){
                    continue;
                }
                if(r==0){
                   
                    
                    int num = int.Parse(i.ToString() + j.ToString());
                    OM.GetComponent<ObstacleManager>().ObstacleManage(num);
                    
                }
            }
        }
    }

    
}
