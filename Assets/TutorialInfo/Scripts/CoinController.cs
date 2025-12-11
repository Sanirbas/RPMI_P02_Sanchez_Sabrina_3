using UnityEngine;


public class CoinController : MonoBehaviour
{ 
    public Inventory inventory;

    private void Start()
    {
       inventory = GameObject.Find("Inventory").GetComponent<Inventory>(); //En "Find" se debería buscar el nombre que tenga por jerarquía - En "GetComponent" se pone el tipo que es el inventario, va parentesis aunque no tenga nada adentro
    }

    private void OnMouseDown()
    {
        //inventory.coins++; es solo para sumar de a uno
        //inventory.coins+= 1;
        inventory.coins = inventory.coins + 1;

        print(inventory.coins);
    }


}
