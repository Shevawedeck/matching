using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingApp
{
    public partial class MatchingGame : Form
    {
        enum TurnEnum { Player1, Player2 }
        TurnEnum currentturn = TurnEnum.Player1;
        enum GameStatusEnum { NotStarted, Playing, Winner }
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;

        List<Button> listbuttons;
        List<List<Button>> listmatch;
        List<String> listpictures;
        Random rnd = new Random();
        public MatchingGame()
        {
            InitializeComponent();
            listbuttons = new() { btnCard1, btnCard2, btnCard3, btnCard4, btnCard5, btnCard6, btnCard7, btnCard8,
                btnCard9, btnCard10, btnCard11, btnCard12, btnCard13, btnCard14, btnCard15, btnCard16, btnCard17, btnCard18 };
            listbuttons.ForEach(b => b.Click += btnCard_Click);
            listpictures = new() { "J", "J", "K", "K", "L", "L", "Q", "Q", "S", "S", "T", "T", "1", "1", "7", "7", "6", "6" };
            btnStart.Click += BtnStart_Click;

        }
        private void DetectWinner()
        {
            if (listbuttons.Count(b => b.BackColor == Color.Pink) == 18)
            {
                gamestatus = GameStatusEnum.Winner;
                if (int.Parse(lblPlayer1Score.Text) > int.Parse(lblPlayer2Score.Text))
                {
                    lblGameStatus.Text = "Winner is: Player 1!"; 
                }
                else
                {
                    lblGameStatus.Text = "Winner is: Player 2!";
                }
                btnStart.Enabled = true;

            }
        }
        private void SwitchTurn()
        {
            if (currentturn == TurnEnum.Player1 && listbuttons.Where(b => b.ForeColor == Color.LightBlue).ToList().Count() == listbuttons.Count())
            { currentturn = TurnEnum.Player2; }
            else if (currentturn == TurnEnum.Player2 && listbuttons.Where(b => b.ForeColor == Color.LightBlue).ToList().Count() == listbuttons.Count())
            { currentturn = TurnEnum.Player1; }
            DisplayCurrentTurn();
        }
        private void DisplayCurrentTurn()
        {
            lblGameStatus.Text = "Current Turn: " + currentturn.ToString();
        }
        private void AssignPictures()
        { 
            foreach (Button b in listbuttons)
            {
                b.Text = "";
                int r = rnd.Next(0, listpictures.Count);
                b.ForeColor = Color.LightBlue;
                b.Text = listpictures[r];
                if (b.Text == listpictures[r]) ;
                {
                    listpictures.Remove(listpictures[r]);
                }
            }
            listpictures.Add("J"); listpictures.Add("J");
            listpictures.Add("K"); listpictures.Add("K");
            listpictures.Add("L"); listpictures.Add("L");
            listpictures.Add("Q"); listpictures.Add("Q");
            listpictures.Add("S"); listpictures.Add("S");
            listpictures.Add("T"); listpictures.Add("T");
            listpictures.Add("1"); listpictures.Add("1");
            listpictures.Add("6"); listpictures.Add("6");
            listpictures.Add("7"); listpictures.Add("7");


            listmatch = new(){
               {listbuttons.Where(b => b.Text == "J").ToList()},
               {listbuttons.Where(b => b.Text == "K").ToList()},
               {listbuttons.Where(b => b.Text == "L").ToList()},
               {listbuttons.Where(b => b.Text == "Q").ToList()},
               {listbuttons.Where(b => b.Text == "S").ToList()},
               {listbuttons.Where(b => b.Text == "T").ToList()},
               {listbuttons.Where(b => b.Text == "1").ToList()},
               {listbuttons.Where(b => b.Text == "7").ToList()},
               {listbuttons.Where(b => b.Text == "6").ToList()}
            };
        }
        private void FlipCards()
        {
            if (listbuttons.Count(b => b.ForeColor == Color.Black) == 3)
            {
                listbuttons.ForEach(b => b.ForeColor = Color.LightBlue);
            }
            if (listbuttons.Count(b => b.ForeColor == Color.Black) == 2)
            { 
                listmatch.ForEach(l => DetectMatch(l)); 
            }
        }
        private void DetectMatch(List<Button> lst)
        {
            if (lst.Count(b => b.ForeColor == Color.Black) == 2)
            {
                lst.ForEach(b => b.BackColor = Color.Pink);
                if (currentturn == TurnEnum.Player1)
                {
                    lblPlayer1Score.Text = (int.Parse(lblPlayer1Score.Text) + 1).ToString();
                }
                if (currentturn == TurnEnum.Player2)
                {
                    lblPlayer2Score.Text = (int.Parse(lblPlayer2Score.Text) + 1).ToString();
                }
            }
        }
        private void StartGame()
        {
            listbuttons.ForEach(b => b.BackColor = Color.LightBlue);
            listbuttons.ForEach(b => b.ForeColor = Color.LightBlue);
            btnStart.Enabled = false;
            AssignPictures();
            gamestatus = GameStatusEnum.Playing;
            DisplayCurrentTurn();
            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";
        }
        private void btnCard_Click(object? sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.Black;
            FlipCards();
            SwitchTurn();
            DetectWinner();
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
