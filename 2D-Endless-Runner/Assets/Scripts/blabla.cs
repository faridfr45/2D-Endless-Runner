using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blabla : MonoBehaviour
{
    public Camera gameCamera;
    public float waktu;

    [Header("Musuh")]
    public GameObject musuh;
    public Enemy scriptMusuh;
    public float spawnRateMusuh = 20f;
    public float waktuSpawnMusuh;

    [Header("Coin")]
    public GameObject coin;
    public float spawnRateCoin = 2f;
    public float waktuSpawnCoin;
    

    
    private bool bisaSpawn;
    private Vector2 lebarLayar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lebarLayar.x = gameCamera.ViewportToWorldPoint(new Vector2(0f, 0f)).x + -5f;

        if(musuh.transform.position.x < lebarLayar.x){
            musuh.SetActive(false);
            bisaSpawn = true;
            waktu += Time.deltaTime;
        }
        
        if(waktu > spawnRateMusuh && bisaSpawn){
            waktuSpawnMusuh = Random.Range(5, 15);
            spawnRateMusuh += waktuSpawnMusuh;
            Spawn();
        }
    }

    private void Spawn(){
        musuh.SetActive(true);
        musuh.transform.position = this.transform.position;
        scriptMusuh.Meluncur();
        bisaSpawn = false;
    }

    private void OnDrawGizmos() {
        lebarLayar.x = gameCamera.ViewportToWorldPoint(new Vector2(0f, 0f)).x + -5f;

        Debug.DrawLine(lebarLayar + Vector2.up * 10f / 2, lebarLayar + Vector2.down * 10f / 2, Color.blue);
        Debug.DrawLine(lebarLayar + Vector2.up * 10f / 2, lebarLayar + Vector2.down * 10f / 2, Color.blue);
    }
}
