using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatACornDog : MonoBehaviour
{

    public int corndogsEaten;
    BuyUpgrade buyUpgrade;
    [SerializeField] GameObject Temp;

    private void Awake()
    {
        buyUpgrade = Temp.GetComponent<BuyUpgrade>();
    }




    public void Eat()
    {

        
        if (buyUpgrade.eatBoost == 0)
        {

            corndogsEaten++;

        } else if (buyUpgrade.eatBoost == 1)
        {

            corndogsEaten++;
            corndogsEaten++;

        }
        else if (buyUpgrade.eatBoost == 2)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;

        }
        else if (buyUpgrade.eatBoost == 3)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;

        }
        else if (buyUpgrade.eatBoost == 4)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;

        }
        else if (buyUpgrade.eatBoost == 5)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;

        }
        else if (buyUpgrade.eatBoost == 6)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 7)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 8)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 9)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 10)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 11)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 12)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 13)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 14)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }
        else if (buyUpgrade.eatBoost == 15)
        {

            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;
            corndogsEaten++;


        }

    }

}
