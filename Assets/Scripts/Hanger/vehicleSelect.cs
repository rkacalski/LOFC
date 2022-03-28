using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vehicleSelect : MonoBehaviour
{
    public GameObject popupPanel;
    public Image popupImage;

    public static vehicle selectedVehicle;
    public List<vehicle> Level1 = new List<vehicle>();
    public List<vehicle> Level2 = new List<vehicle>();
    public List<vehicle> Level3 = new List<vehicle>();
    public List<vehicle> Level4 = new List<vehicle>();
    public List<vehicle> Level5 = new List<vehicle>();

    public List<Sprite> blueprintSprites = new List<Sprite>();

    //Select Vehicle
    void Start()
    {
         popupPanel.transform.localScale = Vector2.zero;
    }

    public void selectVehicle()
    {
        SceneManager.LoadScene("Hanger");
    }

    public void closeVehicle()
    {
        popupPanel.transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
    }

    //Buttons
    public void Xwing()
    {
        int level;
        level = levelCheck("X-Wing");

        if(level.Equals(5))
        {
            print("Level 5");
        }
        if (level.Equals(4))
        {
            print("Level 4");
        }
        if (level.Equals(3))
        {
            print("Level 3");
        }
        if (level.Equals(2))
        {
            print("Level 2");
        }
        if (level.Equals(1))
        {
            print("Level 1");
            //selectedVehicle = Level1[];
        }
        if (level.Equals(0))
        {
            return;
        }

    }

    public void tieFighter()
    {

    }

    public void slave1()
    {
        player.slaveOne1 = 4;
        player.slaveOne2 = 3;
        player.slaveOne3 = 4;
        player.slaveOne4 = 2;
        player.slaveOne5 = 1;
        player.slaveOne6 = 1;

        int level;
        level = levelCheck("Slave 1");

        if (level.Equals(5))
        {
            print("Level 5");
        }
        if (level.Equals(4))
        {
            print("Level 4");
        }
        if (level.Equals(3))
        {
            print("Level 3");
        }
        if (level.Equals(2))
        {
            print("Level 2");
        }
        if (level.Equals(1))
        {
            print("Level 1");
            selectedVehicle = Level1[0];
        }
        if(level.Equals(0))
        {
            return;
        }

        popupImage.sprite = blueprintSprites[2];
        popupPanel.transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
    }

    public void blizzard1()
    {

    }

    int levelCheck(string Vehicle)
    {
        if(Vehicle.Equals("X-Wing"))
        {
            if (player.xwing1 > 4 && player.xwing2 > 4 && player.xwing3 > 4 && player.xwing4 > 4 && player.xwing5 > 4 && player.xwing6 > 4)
            {
                return 5;
            }
            if (player.xwing1 > 3 && player.xwing2 > 3 && player.xwing3 > 3 && player.xwing4 > 3 && player.xwing5 > 3 && player.xwing6 > 3)
            {
                return 4;
            }
            if (player.xwing1 > 2 && player.xwing2 > 2 && player.xwing3 > 2 && player.xwing4 > 2 && player.xwing5 > 2 && player.xwing6 > 2)
            {
                return 3;
            }
            if (player.xwing1 > 1 && player.xwing2 > 1 && player.xwing3 > 1 && player.xwing4 > 1 && player.xwing5 > 1 && player.xwing6 > 1)
            {
                return 2;
            }
            if (player.xwing1 > 0 && player.xwing2 > 0 && player.xwing3 > 0 && player.xwing4 > 0 && player.xwing5 > 0 && player.xwing6 > 0)
            {
                return 1;
            }
        }

        if (Vehicle.Equals("Tie Fighter"))
        {
            if (player.tieFighter1 > 4 && player.tieFighter2 > 4 && player.tieFighter3 > 4 && player.tieFighter4 > 4 && player.tieFighter5 > 4 && player.tieFighter6 > 4)
            {
                return 5;
            }
            if (player.tieFighter1 > 3 && player.tieFighter2 > 3 && player.tieFighter3 > 3 && player.tieFighter4 > 3 && player.tieFighter5 > 3 && player.tieFighter6 > 3)
            {
                return 4;
            }
            if (player.tieFighter1 > 2 && player.tieFighter2 > 2 && player.tieFighter3 > 2 && player.tieFighter4 > 2 && player.tieFighter5 > 2 && player.tieFighter6 > 2)
            {
                return 3;
            }
            if (player.tieFighter1 > 1 && player.tieFighter2 > 1 && player.tieFighter3 > 1 && player.tieFighter4 > 1 && player.tieFighter5 > 1 && player.tieFighter6 > 1)
            {
                return 2;
            }
            if (player.tieFighter1 > 0 && player.tieFighter2 > 0 && player.tieFighter3 > 0 && player.tieFighter4 > 0 && player.tieFighter5 > 0 && player.tieFighter6 > 0)
            {
                return 1;
            }
        }

        if (Vehicle.Equals("Slave 1"))
        {
            if (player.slaveOne1 > 4 && player.slaveOne2 > 4 && player.slaveOne3 > 4 && player.slaveOne4 > 4 && player.slaveOne5 > 4 && player.slaveOne6 > 4)
            {
                return 5;
            }
            if (player.slaveOne1 > 3 && player.slaveOne2 > 3 && player.slaveOne3 > 3 && player.slaveOne4 > 3 && player.slaveOne5 > 3 && player.slaveOne6 > 3)
            {
                return 4;
            }
            if (player.slaveOne1 > 2 && player.slaveOne2 > 2 && player.slaveOne3 > 2 && player.slaveOne4 > 2 && player.slaveOne5 > 2 && player.slaveOne6 > 2)
            {
                return 3;
            }
            if (player.slaveOne1 > 1 && player.slaveOne2 > 1 && player.slaveOne3 > 1 && player.slaveOne4 > 1 && player.slaveOne5 > 1 && player.slaveOne6 > 1)
            {
                return 2;
            }
            if (player.slaveOne1 > 0 && player.slaveOne2 > 0 && player.slaveOne3 > 0 && player.slaveOne4 > 0 && player.slaveOne5 > 0 && player.slaveOne6 > 0)
            {
                return 1;
            }
        }

        if (Vehicle.Equals("Blizzard 1"))
        {
            if (player.blizzardOne1 > 4 && player.blizzardOne2 > 4 && player.blizzardOne3 > 4 && player.blizzardOne4 > 4 && player.blizzardOne5 > 4 && player.blizzardOne6 > 4)
            {
                return 5;
            }
            if (player.blizzardOne1 > 3 && player.blizzardOne2 > 3 && player.blizzardOne3 > 3 && player.blizzardOne4 > 3 && player.blizzardOne5 > 3 && player.blizzardOne6 > 3)
            {
                return 4;
            }
            if (player.blizzardOne1 > 2 && player.blizzardOne2 > 2 && player.blizzardOne3 > 2 && player.blizzardOne4 > 2 && player.blizzardOne5 > 2 && player.blizzardOne6 > 2)
            {
                return 3;
            }
            if (player.blizzardOne1 > 1 && player.blizzardOne2 > 1 && player.blizzardOne3 > 1 && player.blizzardOne4 > 1 && player.blizzardOne5 > 1 && player.blizzardOne6 > 1)
            {
                return 2;
            }
            if (player.blizzardOne1 > 0 && player.blizzardOne2 > 0 && player.blizzardOne3 > 0 && player.blizzardOne4 > 0 && player.blizzardOne5 > 0 && player.blizzardOne6 > 0)
            {
                return 1;
            }
        }

        return 0;
    }
}
