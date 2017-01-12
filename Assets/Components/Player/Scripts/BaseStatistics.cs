using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatistics : MonoBehaviour {

    private Attributes attributes;
    private List<Trait> traits;
    private List<Skill> skills;

    // Use this for initialization
    void Start()
    {
        skills = PopulateSkills();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private List<Skill> PopulateSkills()
    {
        List<Skill> s = new List<Skill>();
        s.Add(new Skill(Skills.Acrobatics, Attribute.RFL, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Acting, Attribute.CHA, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.Administration, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.AnimalHandling, Attribute.WIL, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Appraisal, Attribute.INT, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.Archery, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.ArtBasicTier, Attribute.DEX, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.ArtAdvancedTier, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Artillery, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Career, Attribute.INT, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Climbing, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Communications, Attribute.INT, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.ComputersBasicTier, Attribute.INT, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.ComputersAdvancedTier, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Cryptography, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Demolitions, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Disguise, Attribute.CHA, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Driving, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.EscapeArtist, Attribute.STR, Attribute.DEX, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Forgery, Attribute.DEX, Attribute.INT, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Gunnery, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.InterestBasicTier, Attribute.INT, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.InterestAdvancedTier, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Interrogation, Attribute.WIL, Attribute.CHA, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Investigation, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Language, Attribute.INT, Attribute.CHA, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Leadership, Attribute.WIL, Attribute.CHA, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.MartialArtsBasicTier, Attribute.RFL, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.MartialArtsAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.MedTech, Attribute.INT, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.MeleeWeaponsBasicTier, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.MeleeWeaponsAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Navigation, Attribute.INT, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Negotiation, Attribute.CHA, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.Perception, Attribute.INT, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Piloting, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.PrestidigatationBasicTier, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.PrestidigatationAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Protocol, Attribute.WIL, Attribute.CHA, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Running, Attribute.RFL, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Science, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.SecuritySystems, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.SensorOperations, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.SmallArms, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Stealth, Attribute.RFL, Attribute.INT, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Strategy, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Streetwise, Attribute.CHA, 8, Complexity.ComplexBasic));
        s.Add(new Skill(Skills.SupportWeapons, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Surgery, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Survival, Attribute.BOD, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Swimming, Attribute.STR, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Tactics, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.Technician, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.ThrownWeapons, Attribute.DEX, 7, Complexity.SimpleBasic));
        s.Add(new Skill(Skills.Tracking, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced));
        s.Add(new Skill(Skills.Training, Attribute.INT, Attribute.CHA, 9, Complexity.ComplexAdvanced));
        s.Add(new Skill(Skills.ZeroGOperations, Attribute.RFL, 7, Complexity.SimpleBasic));
        return s;
    }

    public class Attributes
    {
        private int strength = 0;
        private int body = 0;
        private int reflexes = 0;
        private int dexterity = 0;
        private int intelligence = 0;
        private int willpower = 0;
        private int charisma = 0;
        private int edge = 0;

        public int Strength { get { return strength; } set { strength = value; } }
        public int STR { get { return strength; } set { strength = value; } }

        public int Body { get { return body; } set { body = value; } }
        public int BOD { get { return body; } set { body = value; } }

        public int Reflexes { get { return reflexes; } set { reflexes = value; } }
        public int RFL { get { return reflexes; } set { reflexes = value; } }

        public int Dexterity { get { return dexterity; } set { dexterity = value; } }
        public int DEX { get { return dexterity; } set { dexterity = value; } }

        public int Intelligence { get { return intelligence; } set { intelligence = value; } }
        public int INT { get { return intelligence; } set { intelligence = value; } }

        public int Willpower { get { return willpower; } set { willpower = value; } }
        public int WIL { get { return willpower; } set { willpower = value; } }

        public int Charisma { get { return charisma; } set { charisma = value; } }
        public int CHA { get { return charisma; } set { charisma = value; } }

        public int Edge { get { return edge; } set { edge = value; } }
        public int EDG { get { return edge; } set { edge = value; } }
    }

    public enum Traits
    {
        AlternateID, Ambidextrous, AnimalEmpathy, Attractive, CitizenshipTruborn, CombatSense, Connections,
        ExceptionalAttribute, FastLearner, Fit, GTolerance, GoodHearing, GoodVision, Gregarious, ImplantProsthetic,
        NaturalAptitude, PainResistance, Patient, Phenotype,PoisonResistance, Property, Rank, SixthSense, TechEmpathy,
        ThickSkinned, TitleBloodname, Toughness, Equipped, ExtraIncome, Reputation, Wealth, AnimalAntipathy, Bloodmark,
        CombatParalysis, Compulsion, DarkSecret, Dependent, Enemy, GlassJaw, Gremlins, Handicap, Illiterate, Impatient,
        InForLife, Introvert, LostLimb, PoorHearing, PoorVision, SlowLearner, ThinSkinned, TDS, Unattractive, Unlucky,
        CustomVehicle, DesignQuirk, VehicleLevel
    }

    public class Trait
    {
        public Traits TraitName { get; set; }
        public int TraitPoints { get; set; }
        public string Note { get; set; }
    }

    public bool HasTrait(Traits t)
    {
        foreach (Trait trait in traits)
        { if (trait.TraitName == t) { return true; } }

        return false;
    }

    public enum Attribute
    {
        STR, BOD, RFL, DEX, INT, WIL, CHA, EDG
    }

    public enum Complexity
    {
        ComplexAdvanced, ComplexBasic, SimpleAdvanced, SimpleBasic
    }

    public enum Skills
    {
        Acrobatics, Acting, Administration, AnimalHandling, Appraisal, Archery, ArtBasicTier, ArtAdvancedTier, Artillery,
        Career, Climbing, Communications, ComputersBasicTier, ComputersAdvancedTier, Cryptography, Demolitions, Disguise,
        Driving, EscapeArtist, Forgery, Gunnery, InterestBasicTier, InterestAdvancedTier, Interrogation, Investigation,
        Language, Leadership, MartialArtsBasicTier, MartialArtsAdvancedTier, MedTech, MeleeWeaponsBasicTier, MeleeWeaponsAdvancedTier,
        Navigation, Negotiation, Perception, Piloting, PrestidigatationBasicTier, PrestidigatationAdvancedTier, Protocol,
        Running, Science, SecuritySystems, SensorOperations, SmallArms, Stealth, Strategy, Streetwise, SupportWeapons,
        Surgery, Survival, Swimming, Tactics, Technician, ThrownWeapons, Tracking, Training, ZeroGOperations
    }

    public class Skill
    {
        private int experience = 0;

        public Skills SkillName { get; set; }
        public Attribute[] Links { get; set; }
        public int TargetNumber { get; set; }
        public Complexity Complexity { get; set; }

        private BaseStatistics parent;

        public Skill()
        {
            SkillName = Skills.Acrobatics;
            Links = new Attribute[0];
            TargetNumber = 0;
            Complexity = Complexity.SimpleBasic;
        }

        public Skill(Skills skillName, Attribute link, int targetNumber, Complexity complexity)
        {
            SkillName = skillName;
            Links = new Attribute[] { link };
            TargetNumber = targetNumber;
            Complexity = Complexity;
        }

        public Skill(Skills skillName, Attribute link1, Attribute link2, int targetNumber, Complexity complexity)
        {
            SkillName = skillName;
            Links = new Attribute[] { link1, link2 };
            TargetNumber = targetNumber;
            Complexity = Complexity;
        }

        public int Experience { get { return experience; } set { experience = value; } }

        public int Level
        {
            get
            {
                int level = -1;
                bool isFastLearner = parent.HasTrait(Traits.FastLearner);
                bool isSlowLearner = parent.HasTrait(Traits.SlowLearner);

                foreach (KeyValuePair<int, int> levelExpPair in ExpPerLevel)
                {
                    int expRequired = levelExpPair.Value;
                    
                    if (isFastLearner)
                    { expRequired *= (9 / 10); } //0.9
                    else if (isSlowLearner)
                    { expRequired *= (11 / 10); } //1.1

                    if (expRequired <= experience)
                    { level = levelExpPair.Key; }
                }

                return level;
            }
        }

        private Dictionary<int, int> ExpPerLevel = new Dictionary<int, int>() {
            { 0, 20 },
            { 1 , 30 },
            { 2 , 50 },
            { 3 , 80 },
            { 4 , 120 },
            { 5 , 170 },
            { 6 , 230 },
            { 7 , 300 },
            { 8 , 380 },
            { 9 , 470 },
            { 10 , 570 }
        };
    }
}
