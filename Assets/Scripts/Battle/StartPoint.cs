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

    private List<GameObject> Uplayer = new List<GameObject>();
    private List<GameObject> Uenemy = new List<GameObject>();

    private GameObject player;
    private GameObject enemy;

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

        ToPlace();
        CreateSlider();
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
                playerUnit.GetComponent<SpriteRenderer>().sortingOrder = i+1;
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
                enemyUnit.GetComponent<SpriteRenderer>().sortingOrder = i+1;
                enemyUnit.GetComponent<Unit>().Init();
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
    }
    private void CreateSlider() //создаем и расставляем полоски жизней
    {
        UnitListInit();
        PlayerSliderCreate();
        EnemySliderCreate();
    }
    private void UnitListInit()
    {
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
    }
    private void PlayerSliderCreate()
    {
        GameObject slider;
        float k = HPpointPlayer.GetComponent<RectTransform>().position.y;

        for (int i = 0; i < Uplayer.Count; i++)
        {
            slider = Instantiate(sliderHP, HPpointPlayer.transform.position, Quaternion.identity);
            slider.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            slider.transform.position = new Vector2(HPpointPlayer.GetComponent<RectTransform>().position.x, k);
            slider.GetComponent<HP>().Init(Uplayer[i]);
            k -= 0.5f;

        }

    }
    private void EnemySliderCreate()
    {
        GameObject slider;
        float k = HPpointEnemy.GetComponent<RectTransform>().position.y;

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

        }
        else
        {

            Story.Restart();
            SceneManager.LoadScene(1);
        }
    }







}
