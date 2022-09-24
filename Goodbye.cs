using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goodbye : MonoBehaviour
{

    eatACornDog eat;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject UI_Main;
    [SerializeField] GameObject ShopMenu;
    [SerializeField] GameObject AccuseUI;

    void Awake()
    {

        eat = Canvas.GetComponent<eatACornDog>();

    }

    // Update is called once per frame
    void Update()
    {

       if (eat.corndogsEaten >= 3000)
        {


            UI_Main.SetActive(false);
            AccuseUI.SetActive(true);
            ShopMenu.SetActive(false);
            Debug.Log("Bro stap");
            


        }
    }
}
