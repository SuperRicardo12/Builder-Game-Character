using System;

namespace BuilderLib
{
    public class GameCharacter : ICloneable
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Weapon { get; set; }
        public string Armor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Class: {Class}, Weapon: {Weapon}, Armor: {Armor}";
        }
    }

    public abstract class CharacterBuilder
    {
        protected GameCharacter character = new GameCharacter();

        public abstract void BuildName();
        public abstract void BuildClass();
        public abstract void BuildWeapon();
        public abstract void BuildArmor();

        public GameCharacter GetCharacter()
        {
            return character;
        }
    }

    public class DefenderBuilder : CharacterBuilder
    {
        public override void BuildName()
        {
            character.Name = "Захисник";
        }

        public override void BuildClass()
        {
            character.Class = "Defender";
        }

        public override void BuildWeapon()
        {
            character.Weapon = "Shield";
        }

        public override void BuildArmor()
        {
            character.Armor = "Heavy Armor";
        }
    }

    public class AttackerBuilder : CharacterBuilder
    {
        public override void BuildName()
        {
            character.Name = "Нападаючий";
        }

        public override void BuildClass()
        {
            character.Class = "Attacker";
        }

        public override void BuildWeapon()
        {
            character.Weapon = "Sword";
        }

        public override void BuildArmor()
        {
            character.Armor = "Light Armor";
        }
    }
}


