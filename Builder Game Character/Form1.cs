using System;
using System.Drawing;
using System.Windows.Forms;
using BuilderLib;

namespace Builder_Game_Character
{
    public partial class Form1 : Form
    {
        private CharacterBuilder builder;
        private GameCharacter character;        


        public Form1()
        {
            InitializeComponent();

            
            comboBox1.Items.AddRange(new string[] { "Захисник", "Нападаючий" });
            comboBox1.SelectedIndex = 0; 
            textBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Захисник")
            {
                builder = new DefenderBuilder();
            }
            else if (comboBox1.SelectedItem.ToString() == "Нападаючий")
            {
                builder = new AttackerBuilder();
            }

            builder.BuildName();
            builder.BuildClass();
            builder.BuildWeapon();
            builder.BuildArmor();

            character = builder.GetCharacter();

            textBox1.Text = character.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (character != null)
            {
                e.Graphics.DrawString(character.Name, new Font("Arial", 16), Brushes.Black, new Point(10, 10));
                e.Graphics.DrawString("Class: " + character.Class, new Font("Arial", 16), Brushes.Black, new Point(10, 40));
                e.Graphics.DrawString("Weapon: " + character.Weapon, new Font("Arial", 16), Brushes.Black, new Point(10, 70));
                e.Graphics.DrawString("Armor: " + character.Armor, new Font("Arial", 16), Brushes.Black, new Point(10, 100));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }      

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}




