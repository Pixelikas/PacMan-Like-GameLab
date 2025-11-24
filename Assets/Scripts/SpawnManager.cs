using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject playerPrefab;
    public GameObject[] ghostsPrefabs;
    private int posPlayer;
    private int ghostCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        posPlayer = Random.Range(0,4);
        Debug.Log(posPlayer);

        for(int i=0; i < 4; i++){

            if(i != posPlayer){

                Instantiate(ghostsPrefabs[ghostCount], spawnPoints[i]);
                ghostCount++;
                Debug.Log("i ghost:" + i);

            }else{

                Instantiate(playerPrefab, spawnPoints[i]);
                Debug.Log("i player:" + i);

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
