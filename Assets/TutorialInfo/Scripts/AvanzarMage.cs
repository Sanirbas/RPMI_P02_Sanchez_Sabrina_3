using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Avanzar : MonoBehaviour
{
    bool move = true;
    int vida = 100;
    public GameObject moneda;


    float player2 = 0.2f;

    void Start()
    {
        //Desactiva la visual de la moneda - moneda.SetActive(false); 


        if (transform.gameObject.CompareTag("Player2"))
        { transform.Translate(0, 0, -player2 * Time.deltaTime, Space.World); }
    }

    void Update()
    {
        if  (move == true)
        {
            transform.Translate(0, 0, -0.005f, Space.World);
        }
    
    }


    private void OnCollisionEnter(Collision collision)
    {
          if (collision.gameObject.CompareTag("Collectable")) //Bruja deja de avanzar
          {
            move = false;
          }

          if (collision.gameObject.CompareTag("Flecha")) //Flechas restan vida y destruyen bruja
          {

            if (vida >= 0)
            {
                vida = vida - 40;
                print("Vida: " + vida);
       
            }
            else
            {
                Instantiate(moneda, transform.position, Quaternion.identity);
                Destroy(gameObject); //Destruye a Margerie
                //Deberia aparecer la moneda, pero no - moneda.SetActive(true); 
                
            }








        }






    } 

        

        




      
}

    



    


