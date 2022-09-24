using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuyUpgrade : MonoBehaviour
{
    public int eatBoost;
    eatACornDog eat;
    [SerializeField] GameObject Canvas;


    void Awake()
    {
        eat = Canvas.GetComponent<eatACornDog>();
    }

    public void Clicked()
    {
        if (eatBoost < 10)
        {
            if (eat.corndogsEaten >= 15)
            {
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eatBoost++;
                Debug.Log("You will now eat " + eatBoost + " extras corndogs!");

            }




        }

    }
    public void Clickedd()
    {
        if (eatBoost < 15)
        {
            if (eat.corndogsEaten >= 15)
            {
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eatBoost++;
                eatBoost++;
                Debug.Log("You will now eat " + eatBoost + " extras corndogs!");

            }
        }

    }

    public void Clickeddd()
    {
        {
            if (eat.corndogsEaten >= 20)
            {
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eat.corndogsEaten--;
                eatBoost++;
                eatBoost++;
                eatBoost++;
                Debug.Log("You will now eat " + eatBoost + " extras corndogs!");

            }
        }

    }

}