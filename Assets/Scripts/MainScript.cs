using Egam202;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MainScript : MonoBehaviour
{
    //visual feedback !!separate from previous code!!
    public SpriteRenderer CurrentRenderer;
    public int DrinksOrdered = 0;
    public Sprite Coke;
    public Sprite Pepsi;
    public Sprite RootBeer;
    public Sprite Sprite;
    public Sprite DrPepper;
    public Sprite Bojangles;
    




    public int difficultylvl = 1;
    public List<DrinkData> CurrentOrders;
    public TMP_Text SodaOrder;

    public int winscore = 1;
    public bool firstOrder;
    public bool secondOrder;
    public bool thirdOrder;
    public string ButtonString;

    void MicrogameStartDifficulty(MicrogameInstance.Difficulty difficulty)
    {      
        if (difficulty == MicrogameInstance.Difficulty.Medium)
            difficultylvl += 1;
        else if (difficulty == MicrogameInstance.Difficulty.Hard)
            difficultylvl += 2; 
        else
            difficultylvl = 1;

        MyStart();
    }

    // Start is called before the first frame update
    void MyStart()
    {
        CurrentRenderer = GameObject.Find("DrinkResult1").GetComponent<SpriteRenderer>();

        for (int i = 1; i <= difficultylvl; i++)
        {
            //gets random value within drink option list range
            int rand = Random.Range(0, drinkOptions.Count);

            //sets data equal to the random drink it selected
            DrinkData data = drinkOptions[rand];

            CurrentOrders.Add(data);

            Debug.Log(CurrentOrders[0].name);
        }
        WinDifficulty();
    }

    private void Update()
    {
        if (DrinksOrdered == 1)
            CurrentRenderer = GameObject.Find("DrinkResult2").GetComponent<SpriteRenderer>();

        else if (DrinksOrdered == 2)
            CurrentRenderer = GameObject.Find("DrinkResult3").GetComponent<SpriteRenderer>();

        else if (DrinksOrdered == 3)
            CurrentRenderer = GameObject.Find("DrinkResult4").GetComponent<SpriteRenderer>();

        else if (DrinksOrdered == 4)
            CurrentRenderer = GameObject.Find("DrinkResult5").GetComponent<SpriteRenderer>();

        else if (DrinksOrdered == 5)
            CurrentRenderer = GameObject.Find("DrinkResult6").GetComponent<SpriteRenderer>();


    }


    [System.Serializable]
    public class DrinkData
    {
        public string name;
        public Sprite image;
        public string machineNumber;
    }
    public List<DrinkData> drinkOptions;

    public void Method()
    {
        //Debug.Log(ButtonString);

        string orderOne = CurrentOrders[0].machineNumber;
        
        if (1 == difficultylvl)
        {
            if (ButtonString == orderOne)
            {
                

                if (firstOrder == true)
                {
                    winscore -= 1;
                    firstOrder = false;
                }
                    
                Debug.Log("Correct Drink");
            }
            else
            {
                Debug.Log("error 1");
                
            }
            

        }
        else if (2 == difficultylvl)
        {
            string orderTwo = CurrentOrders[1].machineNumber;

            if (ButtonString == orderOne || ButtonString == orderTwo)
            {
                

                if (firstOrder == true)
                {
                    winscore -= 1;
                    firstOrder = false;
                }

                else if (secondOrder == true)
                {
                    winscore -= 1;
                    secondOrder = false;
                }

                Debug.Log("Correct Drink");
                
            }
            

        }
        else if (3 == difficultylvl)
        {
            string orderTwo = CurrentOrders[1].machineNumber;
            string orderThree = CurrentOrders[2].machineNumber;

            if (ButtonString == orderOne || ButtonString == orderTwo || ButtonString == orderThree)
            {
                

                if (firstOrder == true)
                {
                    winscore -= 1;
                    firstOrder = false;
                }

                else if (secondOrder == true)
                {
                    winscore -= 1;
                    secondOrder = false;
                }
                else if (thirdOrder == true)
                {
                    winscore -= 1;
                    thirdOrder = false;
                }

                

                Debug.Log("Correct Drink");

            }

            
        }

        ButtonString = "";
    }

    public void WinDifficulty()
    {
        if (difficultylvl == 1)
        {
            SodaOrder.text = CurrentOrders[0].name;
            winscore = 1;

        }
        else if (difficultylvl == 2)
        {
            SodaOrder.text = CurrentOrders[0].name + ", " + CurrentOrders[1].name;
            winscore = 2;
        }
        else
        {
            SodaOrder.text = CurrentOrders[0].name + ", " + CurrentOrders[1].name + ", " + CurrentOrders[2].name;
            winscore = 3;
        }
    }

    public void Win()
    {
        SodaOrder.text = "You Win";
    }

    public void DrinkResultVisual()
    {
        if (ButtonString == "111")
        {
            //coke
            CurrentRenderer.sprite = Coke;
             
        }
        else if (ButtonString == "121")
        {
            //pepsi
            CurrentRenderer.sprite = Pepsi;
            
        }
        else if (ButtonString == "112")
        {
            //root beer
            CurrentRenderer.sprite = RootBeer;
            
        }
        else if (ButtonString == "211")
        {
            //Sprite
            CurrentRenderer.sprite = Sprite;
            
        }
        else if (ButtonString == "212")
        {
            //Dr Pepper
            CurrentRenderer.sprite = DrPepper;
            
        }
        else if (ButtonString == "221")
        {
            //bojangle
            CurrentRenderer.sprite = Bojangles;
            
        }

        DrinksOrdered++;



    }

}


