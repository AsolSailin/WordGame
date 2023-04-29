using Assets.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System;

public class Game : MonoBehaviour
{
    [SerializeField]
    private Transform _answerPanel;
    [SerializeField]
    private Transform _keyboardPanel;
    [SerializeField]
    private GameObject _buttonPrefab;
    [SerializeField]
    private Text text;
    [SerializeField]
    private GameObject _canvas1;
    [SerializeField]
    private GameObject _canvas2;
    [SerializeField]
    private Button _buttonHintOne;
    [SerializeField]
    private Button _buttonHintTwo;
    [SerializeField]
    private Button _buttonHintThree;
    [SerializeField]
    private Button _buttonHintFour;
    [SerializeField]
    private Button _buttonHintFive;
    [SerializeField]
    private Button _buttonHintSix;
    public QuestionRnd questionRnd;
    private Keyboard keyboard;
    private string answer;

    void Start()
    {
        _canvas1.SetActive(false);
        _canvas2.SetActive(false);
        _buttonHintOne.onClick.AddListener(ClickHintOne);
        _buttonHintTwo.onClick.AddListener(ClickHintTwo);
        _buttonHintThree.onClick.AddListener(ClickHintThree);
        _buttonHintFour.onClick.AddListener(ClickHintFour);
        _buttonHintFive.onClick.AddListener(ClickHintFive);
        _buttonHintSix.onClick.AddListener(ClickHintSix);
        questionRnd = new QuestionRnd(PlayerPrefs.GetString("Topics"));
        keyboard = new Keyboard();
        text.text = questionRnd.CurrentDescription;
        answer = questionRnd.CurrentAnswer;
        var letters = keyboard.GenerateLetters(questionRnd.CurrentAnswer);

        for (int i = 0; i < answer.Length; i++)
        {
            var btn = Instantiate(_buttonPrefab, _answerPanel);
            btn.GetComponentInChildren<Text>().text = "";
            btn.GetComponent<Button>().onClick.AddListener(() => ReturnButton(btn.GetComponent<Button>()));
        }

        foreach (var letter in letters) 
        {
            var btn = Instantiate(_buttonPrefab, _keyboardPanel);
            btn.GetComponentInChildren<Text>().text = letter.ToString();
            btn.GetComponent<Button>().onClick.AddListener(() => ChooseLetter(btn.GetComponent<Button>()));
        }
    }

    private void Update()
    {
        string word = "";
        foreach (Button child in _answerPanel.GetComponentsInChildren<Button>())
        {
            word += child.GetComponentInChildren<Text>().text;
            
            if (word.Length == answer.Length)
            {
                Check(word, answer);
            }
            else
            {
                _canvas2.SetActive(false);
            }
        }
    }

    public void Check(string word, string answer)
    {
        if (word == answer)
        {
            _canvas1.SetActive(true);
            foreach (Button child in _answerPanel.GetComponentsInChildren<Button>())
            {
                child.interactable = false;
            }
        }
        else
        {
            _canvas2.SetActive(true);
        }
    }

    public void ChooseLetter(Button sender)
    {
        foreach (Button child in _answerPanel.GetComponentsInChildren<Button>())
        {
            if (child.GetComponentInChildren<Text>().text == "")
            {
                child.GetComponentInChildren<Text>().text = sender.GetComponentInChildren<Text>().text;
                sender.interactable = false;
                return;
            }
        }
    }

    public void ReturnButton(Button btn)
    {
        try
        {
            Button button = _keyboardPanel.GetComponentsInChildren<Button>()
                .Where(x => x.interactable == false && x.GetComponentInChildren<Text>().text == btn.GetComponentInChildren<Text>().text).FirstOrDefault();

            btn.GetComponentInChildren<Text>().text = "";
            button.interactable = true;
        }
        catch { }
    }

    void ClickHintOne()
    {
        int i = 0;
        foreach (Button child in _answerPanel.GetComponentsInChildren<Button>())
        {
            child.GetComponentInChildren<Text>().text = answer[i].ToString();
            i++;
        }
    }

    void ClickHintTwo()
    {
        SceneManager.LoadScene("Game");
    }

    void ClickHintThree()
    {

    }

    void ClickHintFour()
    {

    }

    void ClickHintFive()
    {

    }

    void ClickHintSix()
    {
        var random = new System.Random();
        int i = random.Next(answer.Length);
        foreach (Button child in _answerPanel.GetComponentsInChildren<Button>())
        {
            child.GetComponentInChildren<Text>().text = answer[i].ToString();
        }
    }
}
