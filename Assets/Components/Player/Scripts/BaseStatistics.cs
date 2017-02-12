using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatistics : MonoBehaviour {

    public Attributes attributes;
    public List<Trait> traits;
    public List<Skill> skills;
    public Experience exp;
    public int age;
    public bool isInnerSphere = true;

    // Use this for initialization
    public BaseStatistics()
    {
        isInnerSphere = true;
        age = (int)(isInnerSphere ? StartingAge.InnerSphere : StartingAge.Clan);

        exp = new Experience();
        attributes = new Attributes(this);
        traits = new List<Trait>();
        skills = PopulateSkills();
    }
    
    public enum StartingAge
    {
        InnerSphere = 21,
        Clan = 18
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    private List<Skill> PopulateSkills()
    {
        List<Skill> s = new List<Skill>();
        s.Add(new Skill(Skills.Acrobatics, Attribute.RFL, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Acting, Attribute.CHA, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.Administration, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.AnimalHandling, Attribute.WIL, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Appraisal, Attribute.INT, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.Archery, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.ArtBasicTier, Attribute.DEX, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.ArtAdvancedTier, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Artillery, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Career, Attribute.INT, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Climbing, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Communications, Attribute.INT, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.ComputersBasicTier, Attribute.INT, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.ComputersAdvancedTier, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Cryptography, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Demolitions, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Disguise, Attribute.CHA, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Driving, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.EscapeArtist, Attribute.STR, Attribute.DEX, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Forgery, Attribute.DEX, Attribute.INT, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Gunnery, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.InterestBasicTier, Attribute.INT, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.InterestAdvancedTier, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Interrogation, Attribute.WIL, Attribute.CHA, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Investigation, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Language, Attribute.INT, Attribute.CHA, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Leadership, Attribute.WIL, Attribute.CHA, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.MartialArtsBasicTier, Attribute.RFL, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.MartialArtsAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.MedTech, Attribute.INT, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.MeleeWeaponsBasicTier, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.MeleeWeaponsAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Navigation, Attribute.INT, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Negotiation, Attribute.CHA, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.Perception, Attribute.INT, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Piloting, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.PrestidigatationBasicTier, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.PrestidigatationAdvancedTier, Attribute.RFL, Attribute.DEX, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Protocol, Attribute.WIL, Attribute.CHA, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Running, Attribute.RFL, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Science, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.SecuritySystems, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.SensorOperations, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.SmallArms, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Stealth, Attribute.RFL, Attribute.INT, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Strategy, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Streetwise, Attribute.CHA, 8, Complexity.ComplexBasic, this));
        s.Add(new Skill(Skills.SupportWeapons, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Surgery, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Survival, Attribute.BOD, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Swimming, Attribute.STR, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Tactics, Attribute.INT, Attribute.WIL, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.Technician, Attribute.DEX, Attribute.INT, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.ThrownWeapons, Attribute.DEX, 7, Complexity.SimpleBasic, this));
        s.Add(new Skill(Skills.Tracking, Attribute.INT, Attribute.WIL, 8, Complexity.SimpleAdvanced, this));
        s.Add(new Skill(Skills.Training, Attribute.INT, Attribute.CHA, 9, Complexity.ComplexAdvanced, this));
        s.Add(new Skill(Skills.ZeroGOperations, Attribute.RFL, 7, Complexity.SimpleBasic, this));
        return s;
    }

    public class Attributes
    {
        private Dictionary<Attribute, int> values = new Dictionary<BaseStatistics.Attribute, int>();
        private BaseStatistics baseStats;

        public Attributes(BaseStatistics _baseStats)
        {
            baseStats = _baseStats;
            values.Add(Attribute.STR, 0);
            values.Add(Attribute.BOD, 0);
            values.Add(Attribute.RFL, 0);
            values.Add(Attribute.DEX, 0);
            values.Add(Attribute.INT, 0);
            values.Add(Attribute.WIL, 0);
            values.Add(Attribute.CHA, 0);
            values.Add(Attribute.EDG, 0);

            LevelUp(Attribute.STR);
            LevelUp(Attribute.BOD);
            LevelUp(Attribute.RFL);
            LevelUp(Attribute.DEX);
            LevelUp(Attribute.INT);
            LevelUp(Attribute.WIL);
            LevelUp(Attribute.CHA);
            LevelUp(Attribute.EDG);
        }

        public int Get(Attribute att)
        {
            int val = 0;
            values.TryGetValue(att, out val);
            return val;
        }

        public int LevelUp(Attribute att)
        {
            int expToLevel = ExpToLevel(att);
            int cur = Get(att);

            if (baseStats.exp.Get() >= expToLevel)
            {
                values.Remove(att);
                values.Add(att, cur + 1);
                baseStats.exp.Spend(expToLevel);
                cur = Get(att);
            }

            return cur;
        }

        private int ExpToLevel(Attribute att)
        {
            int cur = Get(att);
            int toLevel = (cur + 1) * 100;
            return toLevel;
        }

        public int LevelDown(Attribute att)
        {
            int cur = Get(att);

            if (cur > 1)
            {
                int expToReturn = cur * 100;
                values.Remove(att);
                values.Add(att, cur - 1);
                baseStats.exp.Recieve(expToReturn);
            }
            
            return cur;
        }
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
            parent = new BaseStatistics();
        }

        public Skill(Skills skillName, Attribute link, int targetNumber, Complexity complexity, BaseStatistics _parent)
        {
            SkillName = skillName;
            Links = new Attribute[] { link };
            TargetNumber = targetNumber;
            Complexity = Complexity;
            parent = _parent;
        }

        public Skill(Skills skillName, Attribute link1, Attribute link2, int targetNumber, Complexity complexity, BaseStatistics _parent)
        {
            SkillName = skillName;
            Links = new Attribute[] { link1, link2 };
            TargetNumber = targetNumber;
            Complexity = Complexity;
            parent = _parent;
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
            { 10 , 570 },
            { 11, int.MaxValue }
        };

        public int ExpToLevel()
        {
            int expRequired;
            ExpPerLevel.TryGetValue(Level + 1, out expRequired);

            return expRequired;
        }
    }

    public class Experience
    {
        private int current;

        public Experience()
        {
            current = 5000;
        }

        public int Get()
        {
            return current;
        }

        public int Spend(int value)
        {
            current -= value;
            return current;
        }

        public int Recieve(int value)
        {
            current += value;
            return current;
        }
    }
}
