using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace romaMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, double>ranks;//movieId,rank
        int index;

        Movie[] recommends;
        Movie[] popular;
        int Ipopular;
        int loadMore;
        int linear;
    

        int max = 20;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600,600);

            ranks = new Dictionary<string, double>();
            index = 0;
            linear = 0;
            popular = rating.getTopMovies(max).ToArray();
            Ipopular = 0;

            showMovie();
            loadMore = 0;
      

        }

        private string getLink(string imdbid)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = null;
            try
            {
                webData = wc.DownloadString("https://www.imdb.com/title/" + imdbid);
            }
            catch (Exception e)
            {

            }


            if (webData != null && webData.Length > 0)
            {
                string[] lines = webData.Split('\n','\r');
                if (lines.Length > 0)
                {
                    for (int i = 1140; i < lines.Length; i++)
                    {

                        if (i < lines.Length - 1&&lines[i].TrimStart(' ').StartsWith("<div class=\"poster\">"))
                        {

                            while (!lines[i].Contains("src") && i < lines.Length - 1)
                            {
                                i++;
                            }
                            if (i < lines.Length - 1)
                            {
                                int start = lines[i].IndexOf('\"');
                                string fromStart = lines[i].Substring(start + 1);
                                int end = fromStart.IndexOf('\"');
                                string link = fromStart.Substring(0, end);
                                return link;
                            }
                        }
                    }
                }
            }
            return "";
        }



        ////////////////////////////////////////////////////////////////////////////////
        //ranking
        private void rank_rank_btn_Click(object sender, EventArgs e)
        {
            int grade = 0;
            if (chk1_rank_radio.Checked)
                grade = 1;
            else if (chk2_rank_radio.Checked)
                grade = 2;
            else if (chk3_rank_radio.Checked)
                grade = 3;
            else if (chk4_rank_radio.Checked)
                grade = 4;
            else if (chk5_rank_radio.Checked)
                grade = 5;
            else
            {
                MessageBox.Show("please select rank or skip");
                return;
            }

            if (ranks.Count<9)
            {
                ranks[movieID_rank_lbl.Text] =  grade;
                index++;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Logic l = new Logic();
                recommends = l.getMovies(ranks).ToArray();
                loadRecommands();
                return;
            }

            if (Ipopular + 1 >= max)
            {
                //no more pic
                //send to omer
                //move panel
                MessageBox.Show("No more movies to rank");
                Cursor.Current = Cursors.WaitCursor;
                Logic l = new Logic();
                recommends = l.getMovies(ranks).ToArray();
                loadRecommands();
                return;
            }
            else
                showMovie();
        }

        private void skip_rank_btn_Click(object sender, EventArgs e)
        {
            if (Ipopular + 1 >= max)
            {
                //no more pic
                //send to omer
                //move panel
                MessageBox.Show("No more movies to rank");
                Cursor.Current = Cursors.WaitCursor;
                Logic l = new Logic();
                recommends = l.getMovies(ranks).ToArray();
                loadRecommands();
                return;
            }
            else
                showMovie();
        } 

        private void showMovie()
        {
            Cursor.Current = Cursors.WaitCursor;
            
            Movie tmp = popular[Ipopular];
            Ipopular++;
            movieID_rank_lbl.Text = tmp.id;
        
            movie_rank_pick.ImageLocation = getLink(tmp.url);
            movie_rank_pick.Visible = true;
            if(tmp.name[0]=='"'&& tmp.name[tmp.name.Length-1] =='"')
            {
                movieName_rank_lbl.Text = tmp.name.Substring(1, tmp.name.Length-2);
            }
            else
            {
                movieName_rank_lbl.Text = tmp.name;
            }
            chk1_rank_radio.Checked = true;
            count_lbl.Text = ranks.Count+1 + "/10";
            Cursor.Current = Cursors.Default;
        }

        ////////////////////////////////////////////////////////////////////////////////
        //recommand


        PictureBox[] picA;
        Label[] nameA;
        Label[] idA;

        private void loadRecommands()
        {
          
            rank_pnl.Visible = false;
           
            rcm_up_pnl.Visible = true;
            pnl_hide.Visible = true;
          
            picA = new PictureBox[40];
            nameA = new Label[40];
            idA = new Label[40];

            showMovies();
        }
        private void showMovies()
        {
            Cursor.Current = Cursors.WaitCursor;
            recommand_pnl.Controls.Clear();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4&& i * 4 + j < recommends.Length; j++)
                {
                    linear = i * 4 + j+(loadMore*8);
                    picA[linear] = new PictureBox();
                    nameA[linear] = new Label();
                    idA[linear] = new Label();

                    recommand_pnl.Controls.Add(picA[linear]);
                    recommand_pnl.Controls.Add(nameA[linear]);
                    recommand_pnl.Controls.Add(idA[linear]);

                    picA[linear].Size = new Size(146, 220);
                    picA[linear].Location = new Point(260*j+10,260*i + 30);
                    picA[linear].ImageLocation= getLink(recommends[linear].url);
                    picA[linear].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    //picA[linear].Visible = true;

                    nameA[linear].Location = new Point(260 * j + 10, 260 * i);
                    nameA[linear].Size = new Size(260, 17);
                    
                    if (recommends[linear].name[0] == '"' && recommends[linear].name[recommends[linear].name.Length - 1] == '"')
                    {
                        nameA[linear].Text = recommends[linear].name.Substring(1, recommends[linear].name.Length - 2);
                    }
                    else
                    {
                        nameA[linear].Text = recommends[linear].name;
                    }
                    
                }
            }
            loadMore++;
            recommend_lbl.Visible = true;
            Cursor.Current = Cursors.Default;
            recommand_pnl.Visible = true;
            pnl_hide.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if(loadMore==4)
            {
                recommand_pnl.Visible = false;
                showMovies();
                more_btn.Enabled = false;
   
            }
            else
            {
                recommand_pnl.Visible = false;
                showMovies();
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            recommend_lbl.Visible = false;
            recommand_pnl.Visible = false;
            rcm_up_pnl.Visible = false;      
            more_btn.Enabled = true;
            Form1_Load(sender, e);
            rank_pnl.Visible = true;


        }
    }
}
