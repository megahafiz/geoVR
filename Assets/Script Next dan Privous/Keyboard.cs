using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    public GameObject label;
    public TextMeshPro textApply;
    public GameObject lastObject;
    string teks = "";
    string teks1 = "A";
    // Start is called before the first frame update
    public GameObject LastObject
    {
        set
        {
            lastObject = value;
        }
    }
    public TextMeshPro TextApply
    {
        set
        {
            textApply = value;
        }
        get
        {
            return textApply;
        }
    }
    public void ResetText()
    {
        label.GetComponent<Text>().text = "";
        teks = "";
    }
    public void SetText()
    {
        textApply.text = label.GetComponent<Text>().text;
        lastObject.SetActive(true);
    }
    private void OnEnable()
    {
        ResetText();
    }
    void Start()
    {
        teks = "";
        teks1 = "A";
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1)) {
        //    label.GetComponent<Text>().text = "1";
        //}
    }

    public void input1() {
        teks= string.Concat(teks, "1");
       // label.GetComponent<Text>().text = "1";
        label.GetComponent<Text>().text = teks;
        Debug.Log("input1");
    }
    public void input2()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "2");
        label.GetComponent<Text>().text =teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input2");
    }
    public void input3()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "3");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input3");
    }
    public void input4()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "4");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input4");
    }
    public void input5()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "5");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input5");
    }
    public void input6()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "6");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input6");
    }
    public void input7()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "7");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input7");
    }
    public void input8()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "8");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input8");
    }
    public void input9()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "9");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input9");
    }
    public void input0()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "0");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("input0");
    }

    public void inputA()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "A");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputA");
    }
    public void inputB()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "B");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputB");
    }
    public void inputC()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "C");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputC");
    }
    public void inputD()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "D");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputD");
    }
    public void inputE()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "E");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputE");
    }
    public void inputF()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "F");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputF");
    }
    public void inputG()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "G");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputG");
    }
    public void inputH()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "H");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputH");
    }
    public void inputI()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "I");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputI");
    }
    public void inputJ()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "J");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputJ");
    }
    public void inputK()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "K");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputK");
    }
    public void inputL()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "L");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputL");
    }
    public void inputM()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "M");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputM");
    }
    public void inputN()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "N");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputN");
    }
    public void inputO()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "O");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputO");
    }
    public void inputP()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "P");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputP");
    }
    public void inputQ()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "Q");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputQ");
    }
    public void inputR()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "R");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputR");
    }
    public void inputS()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "S");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputS");
    }
    public void inputT()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "T");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputT");
    }
    public void inputU()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "U");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputU");
    }
    public void inputV()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "V");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputV");
    }
    public void inputW()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "W");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputW");
    }
    public void inputX()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "X");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputX");
    }
    public void inputY()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "Y");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputY");
    }
    public void inputZ()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "Z");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputZ");
    }
    public void inputKutip()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "`");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputKutip");
    }
    public void inputPetikSatu()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "'");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputPetikSatu");
    }
    public void inputTitik()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, ".");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputTitik");
    }
    public void inputKoma()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, ",");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputKoma");
    }
    public void inputGarisMiring()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "/");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputGarisMiring");
    }
    public void inputBintang()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "*");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputBintang");
    }
    public void inputMin()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "-");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputMin");
    }
    public void inputPlus()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "+");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputPlus");
    }
    public void inputEqual()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "=");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputEqual");
    }
    public void inputSpasi()
    {
        //string.Concat(teks,"2");
        teks = string.Concat(teks, "  ");
        label.GetComponent<Text>().text = teks;
        //label.GetComponent<Text>().text = teks;
        Debug.Log("inputSpasi");
    }
}
