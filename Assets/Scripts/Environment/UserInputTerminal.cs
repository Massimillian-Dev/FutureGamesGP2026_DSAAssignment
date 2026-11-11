using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class UserInputTerminal : MonoBehaviour
{
    public List<string> terminalDisplayLines;

    public string terminalScreen;

    [SerializeField] public  string inputText;
    [SerializeField] public  GameObject terminalText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        terminalDisplayLines = new List<string>();
        for (int i = 0; i < 12; i++) {
            terminalDisplayLines.Add("");
        }

        TextMesh textMesh = terminalText.GetComponent<TextMesh>();
    }
    public void inputTextField(string input) {
        inputText = input;
        terminalText.GetComponent<TextMesh>().text = inputText;
    }

    private float lastUpdateTime;
    public void FixedUpdate() {
        
        
        const float SimulatedFrameRate = 15f;
        if (Time.time - lastUpdateTime < (1f / SimulatedFrameRate)) {
            return;
        } else {
            lastUpdateTime = Time.time;
        }
        //....
        //example: the gameObject will move 15 frames a second
        terminalText.GetComponent<TextMesh>().text = ReturnTerminalScreen();    
    }
    
//max string length is 23
    int eachOtherFrameCounter = 0;
    private string ReturnTerminalScreen() {
        if(terminalDisplayLines.Count >= 13) {
            terminalDisplayLines.RemoveAt(1);
        }
        string terminalScreen = "";  
        terminalScreen += "_____________________________"+ "\n";       
        
        if(eachOtherFrameCounter <= 5) {
            terminalScreen += "Amber Terminal v1.0 ---- : " + "\n";
        }
        else if(eachOtherFrameCounter <= 10) {
            terminalScreen += "Amber Terminal v1.0 ----  " + "\n";

        }
        else if(eachOtherFrameCounter > 10) {
            terminalScreen += "Amber Terminal v1.0 ---- . " + "\n";

        }

        terminalScreen += " ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅"+ "\n"; 

        for(int i = 1; i < terminalDisplayLines.Count - 3; i++) {
            terminalScreen += ReturnRandomLine() + "\n";
        }

        terminalScreen += "_____________________________"+ "\n";  

        //Admin User Control Input : 
        if(eachOtherFrameCounter <= 5) {
            terminalScreen += "Processing The Big Data : " + "\n";;
            eachOtherFrameCounter++;
        }
        else if(eachOtherFrameCounter <= 10) {
            terminalScreen += "Processing The Big Data   " + "\n";
            eachOtherFrameCounter++;
        }
        else if(eachOtherFrameCounter > 10) {
            terminalScreen += "Processing The Big Data . " + "\n";
            eachOtherFrameCounter = 0;
        }
        terminalScreen += " ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅ ̅"+ "\n"; 
        
        return terminalScreen;
    }
    private string ReturnRandomLine() {
        string line = "|  ";
        for(int i = 0; i < 30; i++) {
            
            char randomChar = (char)Random.Range(97, 200);//97, 123 for just lowercase letters
            line += randomChar;
        }
        ///string line = "wwwwwwwwwwwwwwwwwwwwwww";

        return line;
    }
}
