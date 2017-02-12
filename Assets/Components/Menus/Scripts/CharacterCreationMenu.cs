using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationMenu : MonoBehaviour {
    
    public Text Strength;
    public Text Body;
    public Text Reflexes;
    public Text Dexterity;
    public Text Intelligence;
    public Text Willpower;
    public Text Charisma;
    public Text Edge;

    public Text Experience;

    private BaseStatistics newChar;

	// Use this for initialization
	void Start () {
        newChar = new BaseStatistics();
        UpdateDisplay();
    }

    public void StrengthAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.STR);
        UpdateDisplay();
    }

    public void StrengthSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.STR);
        UpdateDisplay();
    }

    public void BodyAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.BOD);
        UpdateDisplay();
    }

    public void BodySubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.BOD);
        UpdateDisplay();
    }

    public void ReflexesAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.RFL);
        UpdateDisplay();
    }

    public void ReflexesSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.RFL);
        UpdateDisplay();
    }

    public void DexterityAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.DEX);
        UpdateDisplay();
    }

    public void DexteritySubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.DEX);
        UpdateDisplay();
    }

    public void IntelligenceAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.INT);
        UpdateDisplay();
    }

    public void IntelligenceSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.INT);
        UpdateDisplay();
    }

    public void WillpowerAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.WIL);
        UpdateDisplay();
    }

    public void WillpowerSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.WIL);
        UpdateDisplay();
    }

    public void CharismaAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.CHA);
        UpdateDisplay();
    }

    public void CharismaSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.CHA);
        UpdateDisplay();
    }

    public void EdgeAdd()
    {
        newChar.attributes.LevelUp(BaseStatistics.Attribute.EDG);
        UpdateDisplay();
    }

    public void EdgeSubtract()
    {
        newChar.attributes.LevelDown(BaseStatistics.Attribute.EDG);
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        Strength.text = newChar.attributes.Get(BaseStatistics.Attribute.STR).ToString();
        Body.text = newChar.attributes.Get(BaseStatistics.Attribute.BOD).ToString();
        Reflexes.text = newChar.attributes.Get(BaseStatistics.Attribute.RFL).ToString();
        Dexterity.text = newChar.attributes.Get(BaseStatistics.Attribute.DEX).ToString();
        Intelligence.text = newChar.attributes.Get(BaseStatistics.Attribute.INT).ToString();
        Willpower.text = newChar.attributes.Get(BaseStatistics.Attribute.WIL).ToString();
        Charisma.text = newChar.attributes.Get(BaseStatistics.Attribute.CHA).ToString();
        Edge.text = newChar.attributes.Get(BaseStatistics.Attribute.EDG).ToString();
        Experience.text = newChar.exp.Get().ToString("000000");
    }
}
