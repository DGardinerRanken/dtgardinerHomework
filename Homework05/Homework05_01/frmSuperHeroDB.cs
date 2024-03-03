namespace Homework05_01
{
    /* Create a GUI application to look up information about superheroes.
   1.	Program must contain information about at least 5 superheroes.
   2.	Dropdown must be populated programmatically.
   3.	Dropdown must contain an option to select no superhero. (hint: null)
   4.	When the user selects an option from the dropdown, display all available information about that superhero.
    */
    using System.Drawing;


    public partial class frmSuperHeroDB : Form
    {

        //  Declare and initialize class variables
        string[] superHeroNames = {
        "Marvel SuperHeroes",
        "Captain America",
        "The Incredible Hulk",
        "The Invincible Iron Man",
        "The Mighty Thor",
        "The Sub-Mariner"
    };

        string[] superHeroAlterEgo = {
        "Not Applicable",
        "Steve Rogers",
        "Bruce Banner",
        "Tony Stark",
        "Thor Odinson",
        "Prince Namor"
    };

        //	Remember to change your paths to the image files accordingly!!!
        string[] superHeroImages = {
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\00-all.png",
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\01-captainamerica.png",
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\02-hulk.png",
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\03-ironman.png",
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\04-thor.png",
        @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHomework\Homework05\Homework05_01\Images\05-submariner.png"
    };

        string[] superHeroBio = {
        "The Marvel Super Heroes is an American animated television series starring five comic book superheroes from Marvel Comics. The first TV series based on Marvel characters, it debuted in syndication on U.S. television in 1966. The segments were Captain America, The Incredible Hulk, Iron Man, The Mighty Thor and The Sub-Mariner.",
        "Captain America was designed as a patriotic supersoldier who often fought the Axis powers of World War II. Captain America is the alter ego of Steve Rogers, a frail young artist enhanced to the peak of human perfection by an experimental super-soldier serum after joining the military to aid the United States government's efforts in World War II.",
        "The Hulk is a green-skinned, hulking and muscular humanoid possessing a limitless degree of physical strength, and his alter ego Dr. Robert Bruce Banner, a physically weak, socially withdrawn, and emotionally reserved physicist. The two exist as independent dissociative personalities, and resent each other, following Banner's accidental exposure to gamma rays.",
        "Iron Man is a superhero appearing in comic books published by Marvel Comics. Wealthy business magnate, playboy, philanthropist, inventor and scientist Anthony Edward Stark suffers a severe chest injury during a kidnapping. When his captors attempt to force him to build a weapon of mass destruction, he instead creates a mechanized suit of armor to save his life and escape captivity.",
        "Thor Odinson, or simply Thor, is a fictional character appearing in American comic books published by Marvel Comics. The character is based on the Norse deity of the same name, the Asgardian god of thunder whose enchanted hammer Mjolnir enables him to fly and manipulate weather, among his other superhuman attributes.",
        "Namor McKenzie, also known as the Sub-Mariner, is a fictional character appearing in American comic books published by Marvel Comics. The mutant son of a human sea captain and a princess of the mythical undersea kingdom of Atlantis, Namor possesses the super-strength and aquatic abilities of the Homo mermanus race, as well as the mutant ability of flight, along with other superhuman powers."
    };

        string[] superHeroURL = {
        "https://en.wikipedia.org/wiki/The_Marvel_Super_Heroes",
        "https://en.wikipedia.org/wiki/Captain_America",
        "https://en.wikipedia.org/wiki/Hulk",
        "https://en.wikipedia.org/wiki/Iron_Man",
        "https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)",
        "https://en.wikipedia.org/wiki/Namor"
    };

        public frmSuperHeroDB()
        {
            InitializeComponent();
        }
        private void ddlName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSuperHeroInfo();
        }
        private void frmSuperHeroDB_Load(object sender, EventArgs e)
        {
            LoadTheDDL();
        }
        private void LoadTheDDL()
        {
            for (int lcv =0; lcv < superHeroNames.Length; lcv++)
            {
                ddlName.Items.Add(superHeroNames[lcv]);
            }
        }
        private void FillSuperHeroInfo()
        {
            int selection = ddlName.SelectedIndex;

            if (ddlName.SelectedIndex == -1)
            {
                ShowMessage("You Must Choose a Super Hero", "NO SUPERHERO SELECTED");

                return;
            }

            switch (selection)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    CreateSuperHero(selection);
                    break;

                default: break;
            }
        }
        private void CreateSuperHero(int s)
        {
            pbHeros.Image = Image.FromFile(superHeroImages[s]);

            lblName.Text = ($"Name: {superHeroNames[s]}");
            lblAlterEgo.Text = ($"Alter Ego: {superHeroAlterEgo[s]}");
            lblURL.Text = ($"URL: {superHeroURL[s]}");
            lblBio.Text = ($"Bio: {superHeroBio[s]}");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            pbHeros.Image = System.Drawing.Image.FromFile(superHeroImages[0]);
            lblName.Text = "";
            lblAlterEgo.Text = "";
            lblBio.Text = "";
            lblURL.Text = "";
            ddlName.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }
        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Are You Sure You Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

       
    }
}
