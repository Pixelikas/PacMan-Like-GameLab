using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject playerPrefab;
    public GameObject[] ghostsPrefabs;
    private int posPlayer;
    private int ghostCount = 0;

    void Start()
    {

        SpawnPlayers();
        
    }

    void SpawnPlayers(){

        posPlayer = Random.Range(0,4);

        for(int i=0; i < spawnPoints.Length; i++){

            if(i != posPlayer){

                Instantiate(ghostsPrefabs[ghostCount], spawnPoints[i]);
                ghostCount++;

            }else{

                Instantiate(playerPrefab, spawnPoints[i]);

            }

        }

    }

}
