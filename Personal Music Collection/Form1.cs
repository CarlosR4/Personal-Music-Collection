using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Personal_Music_Collection
{
    public partial class Form1 : Form
    {

        public List<Album> Albums = new List<Album>();
        public List<Song> Songs = new List<Song>();


        public Form1()
        {
            InitializeComponent();
        }

        StreamReader inputFile;



        // IS THIS WORKING ???????????????????????????????????
        // NOO DUDE WTF!!!!



        /// <summary>
        /// Opens music.txt, reads each line and if its an album
        /// add it to the Albums list along with all of its parameters then add it
        /// to the albumslistbox.If its a song add it to the Songs list along with all of
        /// its parameters then display it in the songs list box.
        /// And fianlly close the music.txt file
        /// </summary>
        private void ReadFile()
        {

            try
            {
                string line;

                Album currentAlbum = new Album();
                Song currentSong = new Song();

                char[] delim = { ',' };

                //open input file
                inputFile = File.OpenText("myMusic.txt");

                //read lines
                while(!inputFile.EndOfStream)
                {
                    //read line from user
                    line = inputFile.ReadLine();

                    //tokenize
                    string[] tokens = line.Split(delim);

                    if(tokens[0]=="Album")
                    {
                        
                        //hold the album year
                        int year = Convert.ToInt32(tokens[2]);

                        //convert the year to DateTime
                        DateTime date = new DateTime(year, 1, 1);

                        //assign the album all its properties
                        currentAlbum = new Album();
                        currentAlbum.AlbumName = tokens[1];
                        currentAlbum.Year = date;
                        currentAlbum.Artist = tokens[3];

                        //add the album to the list
                        Albums.Add(currentAlbum);

                        //display the album in the listbox  
                        albumListBox.Items.Add(currentAlbum.AlbumName);

                    }

                    
                    else if(tokens[0]=="Song")
                    {
                        currentSong = new Song();
                        currentSong.Title = tokens[1];
                        currentSong.Length = (tokens[2]);
                        currentSong.Artist = tokens[3];
                        currentSong.AlbumTitle = tokens[4];

                        //add the song to the list
                        Songs.Add(currentSong);

                        //songsListBox.Items.Add(currentSong.Title);
                    }
                    
                    
                }

                inputFile.Close();
            }


            catch
            {
                //close the file
                inputFile.Close();

                //display an error message
                MessageBox.Show("");

                //THIS IS NOTT A TESTT

            }
        }

        /// <summary>
        /// Calls the ReadFile method on startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();

            MessageBox.Show("Your Mom gay");
        }


        /// <summary>
        /// When an album in selected display all of its information in the textboxes
        /// and display its songs in the sing list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //clar the song information when a new song is selected
                songTitleTextBox.Text = "";
                songLengthTextBox.Text = "";
                songArtistTextBox.Text = "";
                //clear the song listbox
                songsListBox.Items.Clear();

                //hold the selected index of albumlistbox
                int index = albumListBox.SelectedIndex;

                //MessageBox.Show(Albums[index].AlbumName);

                albumNameTextBox.Text = Albums[index].AlbumName;

                //convert date time to a readable year and display it.
                string year = Albums[index].Year.ToString();

                year = year.Substring(4, 4);

                yearTextBox.Text = year;

                albumArtistTextBox.Text = Albums[index].Artist;

                foreach (Song entry in Songs)
                {

                    if (entry.AlbumTitle == Albums[index].AlbumName)
                    {
                        //MessageBox.Show(entry.Title);
                        songsListBox.Items.Add(entry.Title);
                    }
                }
            }

            catch { }
        }

        /// <summary>
        /// if a song is selected display all of its information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //int SongIndex = songsListBox.SelectedIndex;

                songArtistTextBox.Text = songsListBox.SelectedItem.ToString();

                foreach (Song entry in Songs)
                {
                    if (entry.Title == songsListBox.SelectedItem.ToString())
                    {
                        songTitleTextBox.Text = entry.Title;
                        songLengthTextBox.Text = entry.Length;
                        songArtistTextBox.Text = entry.Artist;
                        songAlbumTextBox.Text = entry.AlbumTitle;

                    }
                }
            }

            catch { }
        }

        /// <summary>
        /// used to clear all of the textboxes used for the application
        /// </summary>
        private void ClearTextBoxes()
        {
            songTitleTextBox.Text = "";
            songLengthTextBox.Text = "";
            songArtistTextBox.Text = "";
            albumArtistTextBox.Text = "";
            albumNameTextBox.Text = "";
            yearTextBox.Text = "";
        }

        /// <summary>
        /// used to set the necessary textboxes to read only
        /// </summary>
        private void SetTextBoxReadOnly()
        {
            //set the Text Boxes to Read Only
            songTitleTextBox.ReadOnly = true;
            songLengthTextBox.ReadOnly = true;
            songArtistTextBox.ReadOnly = true;

            albumNameTextBox.ReadOnly = true;
            yearTextBox.ReadOnly = true;
            albumArtistTextBox.ReadOnly = true;
        }

        /// <summary>
        /// allow the text boxes to be written on
        /// </summary>
        private void SetTextBoxWrite()
        {
            //Allow the user to Write in the Text Boxes
            songTitleTextBox.ReadOnly = false;
            songLengthTextBox.ReadOnly = false;
            songArtistTextBox.ReadOnly = false;

            albumNameTextBox.ReadOnly = false;
            yearTextBox.ReadOnly = false;
            albumArtistTextBox.ReadOnly = false;

        }

        private void AddOnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(addOnRadioButton.Checked)
            {
                addAlbumButton.Visible = true;
                addSongButton.Visible = true;
                SetTextBoxWrite();
                ClearTextBoxes();
            }
            else
            {
                addAlbumButton.Visible = false;
                addSongButton.Visible = false;
                SetTextBoxReadOnly();
            }
        }

        /// <summary>
        /// when the onEdit radio button is checked set the buttons and texboxes to visible
        /// and allow the textboxes to be written on
        /// 
        /// if its not then hide hte buttons and textboxes and set them to read only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(onEditRadioButton.Checked)
            {
                deleteSongButton.Visible = true;
                deleteAlbumButton.Visible = true;
                saveButton.Visible = true;
                songAlbumTextBox.Visible = true;
                label13.Visible = true;
                SetTextBoxWrite();
            }
            else
            {
                deleteSongButton.Visible = false;
                deleteAlbumButton.Visible = false;
                saveButton.Visible = false;
                songAlbumTextBox.Visible = false;
                label13.Visible = false;
                SetTextBoxReadOnly();
            }
        }

        /// <summary>
        /// add the album to the Albums list and set all its information
        /// also clears the textboxes associated with album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAlbumButton_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album();

            newAlbum = new Album();
            newAlbum.AlbumName = albumNameTextBox.Text;

            int year = Convert.ToInt32(yearTextBox.Text);

            //convert the year to DateTime
            DateTime date = new DateTime(year, 1, 1);
            
            //assign the new album all of its properties.
            newAlbum.Year = date;

            newAlbum.Artist = albumArtistTextBox.Text;

            Albums.Add(newAlbum);

            albumListBox.Items.Add(newAlbum.AlbumName);

            ClearTextBoxes(); 
        }

        /// <summary>
        /// adds the users song to the Songs list and give it all its properties
        /// also clear all the textboxes associated with a song
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSongButton_Click(object sender, EventArgs e)
        {
            //hold the selected index of albumlistbox
            int index = albumListBox.SelectedIndex;

            Song newSong = new Song();

            newSong = new Song();

            //assign the new song all of its properties
            newSong.Title = songTitleTextBox.Text;
            newSong.Length = songLengthTextBox.Text;
            newSong.Artist = songArtistTextBox.Text;
            newSong.AlbumTitle = Albums[index].AlbumName;

            //add the new song to the Songs list
            Songs.Add(newSong);

            if(Albums[index].AlbumName==newSong.AlbumTitle)
            {
                songsListBox.Items.Add(newSong.Title);
            }
        }

        /// <summary>
        /// clears the mymusic.txt file then writes the albums in Albums[] one by one, line by line
        /// then writes the songs in Songs[] one by one and fianlly closes the file
        /// </summary>
        private void SaveFile()
        {
            System.IO.File.WriteAllText("myMusic.txt", string.Empty);

            // Declare a StreamWriter variable.
            StreamWriter outputFile;

            // Create a file and get a StreamWriter object.
            outputFile = File.AppendText("myMusic.txt");

            for(int i = 0; i<Albums.Count;i++)
            {

                string StringYear = Albums[i].Year.ToString().Substring(4, 4);


                outputFile.WriteLine("Album," +Albums[i].AlbumName+","+StringYear+","+Albums[i].Artist);
            }

            for (int i = 0; i < Songs.Count; i++)
            {
                outputFile.WriteLine("Song," + Songs[i].Title + "," + Songs[i].Length + "," + Songs[i].Artist+","+Songs[i].AlbumTitle);
            }

            outputFile.Close();
        }

        /// <summary>
        /// saves the changes to the list and refreshes the lists then saves the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Albums.Count; i++)
                {
                    if(albumListBox.SelectedItem.ToString()==Albums[i].AlbumName)
                    {

                        Albums[i].AlbumName = albumNameTextBox.Text;

                        int year = Convert.ToInt32(yearTextBox.Text);

                        //convert the year to DateTime
                        DateTime date = new DateTime(year, 1, 1);

                        //assign the new album all of its properties.
                        Albums[i].Year = date;

                        Albums[i].Artist = albumArtistTextBox.Text;
                    }
                }

                for (int i = 0; i < Songs.Count; i++)
                {
                    if(songsListBox.SelectedItem.ToString()== Songs[i].Title)
                    {
                        Songs[i].Title = songTitleTextBox.Text;
                        Songs[i].Length = songLengthTextBox.Text;
                        Songs[i].Artist = songArtistTextBox.Text;
                        Songs[i].AlbumTitle = songAlbumTextBox.Text;
                    }
                }
                SaveFile();
                refreshItems();
            }
            

            catch
            {

            }
        }

        /// <summary>
        /// saves the file then closes the form1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            SaveFile();
            this.Close();
        }

        /// <summary>
        /// goes to each entry in song then deletes the on selected by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Songs.Count; i++)
            {
            #pragma warning disable CS0253 // Possible unintended reference comparison; right hand side needs cast

                if(Songs[i].Title==songsListBox.SelectedItem)
            #pragma warning restore CS0253 // Possible unintended reference comparison; right hand side needs cast

                {
                    Songs.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// goes to each entry in albums then deletes the on selected by the user
        /// finally updates the albums in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Albums.Count; i++)
            {
                #pragma warning disable CS0253 // Possible unintended reference comparison; right hand side needs cast


                if (Albums[i].AlbumName == albumListBox.SelectedItem)

                #pragma warning restore CS0253 // Possible unintended reference comparison; right hand side needs cast
                {
                    Albums.RemoveAt(i);
                }
            }

            
            refreshItems();
        }

        /// <summary>
        /// clears both listboxes then adds the albums to the Albums List box
        /// if an album is selected display its updated music list aswell
        /// </summary>
        private void refreshItems()
        {
            albumListBox.Items.Clear();
            songsListBox.Items.Clear();

            

            foreach (Album entry in Albums)
            {
                albumListBox.Items.Add(entry.AlbumName);
            }

            foreach (Song entry in Songs)
            {

                if (entry.AlbumTitle == albumNameTextBox.Text)
                {
                    songsListBox.Items.Add(entry.Title);
                }
            }
        }
    }
}
