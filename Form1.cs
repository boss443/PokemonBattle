using Pokemonbattle.Pokemons;

namespace Pokemonbattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        Pokemon player;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Blastoise());
            pokemons.Add(new Charizard());
            pokemons.Add(new Pikachu());
            pokemons.Add(new Pidgeot());
            pokemons.Add(new Raichu());

            this.monster = new Blastoise();
            this.player = new Charizard();
            this.player= new Pikachu();
            this.player=new  Pidgeot();
            this.player=new Raichu();
            this.PBEnemy.Image = this.monster.getImage();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbName2.Text = "Blastoise";
            this.tbName.Text = "Charizard";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dam = this.monster.getHP()- this.selectedPokemon.getAttack();
            this.monster.takeDamage(dam);
            this.textBox2.Text = dam.ToString();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
            TimeEnAtk.Enabled = true;
            BtAtk.Enabled = false;
            BtAtk1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int dam = this.monster.getHP() - this.selectedPokemon.getAttack();
            this.monster.takeDamage(dam+dam);
            this.textBox2.Text = dam.ToString();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
            TimeEnAtk.Enabled = true;
            BtAtk.Enabled = false;
            BtAtk1.Enabled = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Charizard
            selectedPokemon = pokemons[1];
            this.PBPlayer.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //Pikachu
            selectedPokemon = pokemons[2];
            this.PBPlayer.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
        }

        private void TimeEnAtk_Tick(object sender, EventArgs e)
        {
            TimeEnAtk.Enabled = false;

            BtAtk.Enabled = true;
            BtAtk1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Pidgeot
            selectedPokemon = pokemons[3];
            this.PBPlayer.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Raichu 
            selectedPokemon = pokemons[4];
            this.PBPlayer.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.textBox1.Text = this.selectedPokemon.getHP().ToString();
        }
    }
}