using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Security.Authentication.ExtendedProtection;

namespace TestWFA
{
    public partial class LibForm : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private bool isCorrect = true;
        public LibForm()
        {
            InitializeComponent();
        }

        private void LibForm_Load(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT min(card) FROM lib";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = (int)command.ExecuteScalar();

                getRecord("SELECT * FROM lib where card=" + number);
            }

        }

        private void tstButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getStringChList(genres, "детектив;исторический роман;");
        }

        private void searchCard(object sender, EventArgs e)
        {
            getRecord("SELECT * FROM lib where card = " + search.Text);

        }

        private void getRecord(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //                SqlCommand command = new SqlCommand(sqlExpression, connection);
                //                int number = (int)command.ExecuteScalar();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows == false) { MessageBox.Show("Такого номера нет!"); }
                // если есть данные
                else
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        card.Text = "";
                        object cardItem = reader["card"];
                        card.Text = cardItem.ToString();

                        TSSLabel1.Text = "";
                        TSSLabel1.Text = "Вы смотрите номер " + cardItem;

                        author.Text = "";
                        object authorItem = reader["author"];
                        author.Text = authorItem.ToString();

                        object genreItem = reader["genre"];
                        getStringChList(genres, genreItem.ToString());

                        title.Text = "";
                        object titleItem = reader["title"];
                        title.Text = titleItem.ToString();

                        ISBN.Text = "";
                        object ISBNItem = reader["ISBN"];
                        ISBN.Text = ISBNItem.ToString();

                        readmen.Text = "";
                        object readmenItem = reader["reader"];
                        readmen.Text = readmenItem.ToString();

                        bool BlnVoidIndicator = Convert.ToBoolean(reader["inlibrary"]); ///!
                        inLibrary.Checked = BlnVoidIndicator;

                        dateout.Text = "";
                        object dateoutItem = reader["dateout"];
                        dateout.Text = dateoutItem.ToString();

                        datein.Text = "";
                        object dateinItem = reader["datein"];
                        datein.Text = dateinItem.ToString();

                        object ratingItem = reader["rating"];
                        getStringChList(ratingLB, ratingItem.ToString());

                    }
                }
                reader.Close();
            }
        }

        private void getStringChList(CheckedListBox checkedListBox, string isChecks)
        {
            //    isChecks = "";
            string[] values = isChecks.Split(';');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);//First uncheck the old value!
                                                //
                for (int x = 0; x < values.Length; x++)
                {
                    if (checkedListBox.Items[i].ToString() == values[x].ToString())
                    {
                        //Check only if they match! 
                        checkedListBox.SetItemChecked(i, true);
                    }
                }
            }
        }

        private string setChListToString(CheckedListBox checkedListBox)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object o in checkedListBox.CheckedItems)
            {
                sb.Append(o.ToString() + ";");
            }
            string s = sb.ToString();
            //MessageBox.Show(s);
            return s;
        }

        private void saveCard(object sender, EventArgs e)
        {



            if (validateCard() && validateFields(author) && validateFields(title) && validateFields(ISBN))
            {   
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "SELECT * FROM lib where card=" + card.Text;
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows == false)
                // если нет данных
                {
                    SqlConnection insConn = new SqlConnection(connectionString);
                    string insert = "INSERT INTO lib (card, author, genre, title, ISBN, reader, inlibrary, dateout, datein, opens, rating)" +
                        "VALUES(@card, @author, @genre, @title, @ISBN, @reader, @inlibrary, @dateout, @datein, @opens, @rating)";

                    SqlCommand sqlInsert = new SqlCommand(insert, insConn);

                    sqlInsert.Parameters.AddWithValue("@card", card.Text);
                    sqlInsert.Parameters.AddWithValue("@author", author.Text);
                    sqlInsert.Parameters.AddWithValue("@genre", setChListToString(genres));
                    sqlInsert.Parameters.AddWithValue("@title", title.Text);
                    sqlInsert.Parameters.AddWithValue("@ISBN", ISBN.Text);
                    sqlInsert.Parameters.AddWithValue("@reader", readmen.Text);
                    sqlInsert.Parameters.AddWithValue("@inlibrary", inLibrary.Checked);
                    sqlInsert.Parameters.AddWithValue("@dateout", DateTime.Parse(dateout.Text));
                    sqlInsert.Parameters.AddWithValue("@datein", DateTime.Parse(datein.Text));
                    sqlInsert.Parameters.AddWithValue("@opens", DateTime.Today);
                    sqlInsert.Parameters.AddWithValue("@rating", setChListToString(ratingLB));

                    insConn.Open();

                    int resQuery = sqlInsert.ExecuteNonQuery();

                    //MessageBox.Show(sqlInsert.CommandText);
                    if (resQuery > 0)
                    {
                        MessageBox.Show("Карточка успешно добавлена!");
                    }
                    insConn.Close();
                }
                // если есть данные
                else
                {

                    while (reader.Read()) // построчно считываем данные
                    {

                        object id = reader["id"];

                        SqlConnection insConn = new SqlConnection(connectionString);
                        string update = "UPDATE lib SET " +
                            "card=@card, author=@author, genre=@genre, " +
                            "title=@title, ISBN=@ISBN, " +
                            "reader=@reader, " +
                            "inlibrary=@inlibrary, dateout=@dateout, " +
                            "datein=@datein, " +
                            "opens=@opens, " +
                            "rating=@rating " +
                            "WHERE @id=id";

                        SqlCommand sqlUpdate = new SqlCommand(update, insConn);

                        sqlUpdate.Parameters.AddWithValue("@card", card.Text);
                        sqlUpdate.Parameters.AddWithValue("@author", author.Text);
                        sqlUpdate.Parameters.AddWithValue("@genre", setChListToString(genres));
                        sqlUpdate.Parameters.AddWithValue("@title", title.Text);
                        sqlUpdate.Parameters.AddWithValue("@ISBN", ISBN.Text);
                        sqlUpdate.Parameters.AddWithValue("@reader", readmen.Text);
                        sqlUpdate.Parameters.AddWithValue("@inlibrary", inLibrary.Checked);
                        sqlUpdate.Parameters.AddWithValue("@dateout", DateTime.Parse(dateout.Text));
                        sqlUpdate.Parameters.AddWithValue("@datein", DateTime.Parse(datein.Text));
                        sqlUpdate.Parameters.AddWithValue("@opens", DateTime.Today);
                        sqlUpdate.Parameters.AddWithValue("@rating", setChListToString(ratingLB));
                        sqlUpdate.Parameters.AddWithValue("@id", id);

                        insConn.Open();

                        int resQuery = sqlUpdate.ExecuteNonQuery();

                        //MessageBox.Show(sqlUpdate.CommandText);
                        if (resQuery > 0)
                        {
                            MessageBox.Show("Карточка успешно обновлена!");
                        }
                        insConn.Close();
                    }
                }
                reader.Close();
                isCorrect = true;
            }
            }
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setChListToString(genres);
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            int index;
            index = Convert.ToInt32(card.Text);
            index -= 1;

            getRecord("SELECT * FROM lib where card = " + index + " ORDER BY card");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int index;
            index = Convert.ToInt32(card.Text);
            index += 1;

            getRecord("SELECT * FROM lib where card = " + index + " ORDER BY card");
        }

        private void elementClear(object sender, EventArgs e)
        {
            foreach (Control cntrl in Controls)
                if (cntrl is TextBox)
                    ((TextBox)cntrl).Text = null;

            readmen.Text = null;
            dateout.Text = null;
            datein.Text = null;

            inLibrary.Checked = false;

            for (int i = 0; i < genres.Items.Count; i++)
            {
                genres.SetItemChecked(i, false);//First uncheck the old value!

            }

            for (int i = 0; i < ratingLB.Items.Count; i++)
            {
                ratingLB.SetItemChecked(i, false);//First uncheck the old value!

            }

            TSSLabel1.Text = "Режим вставки новой записи"; 

            string sqlExpression = "SELECT MAX(card) FROM lib";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int maxnumber = (int)command.ExecuteScalar();
                maxnumber += 1;
                card.Text = maxnumber.ToString();
                connection.Close();
            }
        }

        private void ratingLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp = ratingLB.SelectedIndex;
            for (int i = 0; i < ratingLB.Items.Count; i++)
                ratingLB.SetItemChecked(i, false);
            ratingLB.SetItemChecked(tmp, true);
        }

        protected bool validateCard()
        {
            if (card.Text == "")
            {
                MessageBox.Show("Не введён номер!");
                card.Undo();
                isCorrect = false;
            }
            else { isCorrect = true; }
            return isCorrect;
        }

        protected bool validateFields(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Не заполнен " + textBox.Tag);
                isCorrect = false;
            }
            else { isCorrect = true; }
            return isCorrect;
        }


    }
}


