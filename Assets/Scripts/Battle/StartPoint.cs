using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPoint : MonoBehaviour
{

    public GameObject[] squadPoint = new GameObject[3];
    public GameObject[] enemySquadPoint = new GameObject[3];

    public GameObject HPpointPlayer;
    public GameObject HPpointEnemy;

    GameObject player;
    GameObject enemy;

    List<GameObject> units = new List<GameObject>();

    public GameObject battleManager;
    public GameObject sliderHP;

    public GameObject background;

    void Start()
    {



        //расставляем юнитов
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        background.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<Avatar>().location;
        player.transform.position = enemy.transform.position;

        ToPlace();
        gameObject.GetComponent<BattleManager>().BattleSetup(units); //запускаем бой
        SelectUnit.battleManager = battleManager;
    }

    void ToPlace() //создаем и расставляем юнитов
    {
        //расставляем отряд
        GameObject[] squad = player.GetComponent<Avatar>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            GameObject playerUnit;
            if (squad[i] != null)
            {

                playerUnit = Instantiate<GameObject>(squad[i], squadPoint[i].transform.position, Quaternion.identity);

                units.Add(playerUnit);
            }

        }

        //Вражеский сквад
        squad = enemy.GetComponent<Avatar>().squad;
        for (int i = 0; i < squad.Length; i++)
        {
            GameObject enemyUnit;
            if (squad[i] != null)
            {
                enemyUnit = Instantiate<GameObject>(squad[i], enemySquadPoint[i].transform.position, Quaternion.identity);
                units.Add(enemyUnit);
            }

        }
        //делаем активными и пересчитываем
        for (int i = 0; i < units.Count; i++)
        {
            units[i].SetActive(true);
            units[i].GetComponent<Unit>().Recalc();
            // print("Активирован и пересчитан: " + units[i].name);

        }
        //вырубаем аватары
        player.SetActive(false);
        enemy.SetActive(false);


        CreateSlider();

    }
    void CreateSlider() //создаем и расставляем полоски жизней
    {
        List<GameObject> Uplayer = new List<GameObject>();
        List<GameObject> Uenemy = new List<GameObject>();
        float k = HPpointPlayer.GetComponent<RectTransform>().position.y;

        GameObject slider;

        for (int i = 0; i < units.Count; i++)
        {
            if (units[i].tag.Equals("Player"))
            {
                Uplayer.Add(units[i]);
            }
            else if (units[i].tag.Equals("Enemy"))
            {
                Uenemy.Add(units[i]);
            }
        }
        // расставляем
        for (int i = 0; i < Uplayer.Count; i++)
        {
            slider = Instantiate(sliderHP, HPpointPlayer.transform.position, Quaternion.identity);
            slider.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            slider.transform.position = new Vector2(HPpointPlayer.GetComponent<RectTransform>().position.x, k);
            slider.GetComponent<HP>().Init(Uplayer[i]);
            k -= 0.5f;

        }
        k = HPpointEnemy.GetComponent<RectTransform>().position.y;


        for (int i = 0; i < Uenemy.Count; i++)
        {
            slider = Instantiate(sliderHP, HPpointEnemy.transform.position, Quaternion.identity);
            slider.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            slider.transform.position = new Vector2(HPpointEnemy.GetComponent<RectTransform>().position.x, k);
            slider.GetComponent<HP>().Init(Uenemy[i]);

            k -= 0.5f;
            slider.GetComponent<Slider>().direction = Slider.Direction.RightToLeft;

        }


    }
    public void ExitBattle(bool result)
    {
        if (result)
        {
            string sceneName = player.GetComponent<Avatar>().sceneName;
            SceneManager.LoadScene(sceneName);

            Destroy(enemy);

            player.SetActive(true);
            player.transform.position = player.GetComponent<Avatar>().transform.position;
        }
        else
        {

            player.GetComponent<PlayerKeyboardController>().Reset();
            Destroy(player);
            Destroy(enemy);
          //  Story.Restart();
            SceneManager.LoadScene(1);
        }
    }







}
