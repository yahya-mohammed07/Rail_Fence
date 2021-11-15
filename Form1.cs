using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Rail_Fence
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public static string ReverseXor(string s)
    {
      if (s == null) return null;
      char[] charArray = s.ToCharArray();
      int len = s.Length - 1;

      for (int i = 0; i < len; i++, len--)
      {
        charArray[i] ^= charArray[len];
        charArray[len] ^= charArray[i];
        charArray[i] ^= charArray[len];
      }

      return new string(charArray);
    }

    private void Convert_Click(object sender, EventArgs e)
    {
      int key = int.Parse(Key.Text);
      string temp = Plain_text.Text;
      //
      if (Reverse.Checked)
      {
        temp = ReverseXor(temp);
      }
      //
      if (Remove_punctuation.Checked)
      {
        temp = new(temp.Where(
          c => !char.IsPunctuation(c)).ToArray());
      }
      //
      if (Remove_spaces.Checked)
      {
        temp = new(temp.Where(
          c => !char.IsWhiteSpace(c)).ToArray());
      }
      //
      int plainText_size = temp.Length;
      if (key >= plainText_size)
      {
        MessageBox.Show("Key must be less than the input's size!");
        return;
      }
      //
      char[,] rail_fence = new char[key, plainText_size];
      for (int i = 0; i < key; ++i)
      {
        for (int j = 0; j < plainText_size; ++j)
        {
          rail_fence[i, j] = '%';
        }
      }
      //
      string output = new("");
      for (int row = 0, col = 0, direc = 1; col < plainText_size; row += direc, ++col)
      {
        rail_fence[row, col] = temp[col];
        if (row == key - 1)
        {
          direc = -1;
        }
        else if (row == 0)
        {
          direc = 1;
        }
      }
      //
      for (int i = 0; i < key; ++i)
      {
        for (int j = 0; j < plainText_size; ++j)
        {
          if (rail_fence[i, j] != '%')
          {
            output += rail_fence[i, j];
          }
        }
      }
      Cipher_text.Text = Reverse.Checked ? ReverseXor(output) : output;
    }

    private void Convert_cipher_Click(object sender, EventArgs e)
    {
      int key = int.Parse(Key_cipher.Text);
      string temp = Ciphered_text.Text;
      //
      if (Reverse.Checked)
      {
        temp = ReverseXor(temp);
      }
      if (Remove_punctuation.Checked)
      {
        temp = new(temp.Where(
          c => !char.IsPunctuation(c)).ToArray());
      }
      //
      if (Remove_spaces.Checked)
      {
        temp = new(temp.Where(
          c => !char.IsWhiteSpace(c)).ToArray());
      }
      //
      int cipher_text_size = temp.Length;
      if (key >= cipher_text_size)
      {
        MessageBox.Show("Key must be less than the input's size!");
        return;
      }
      //
      char[,] rail_fence = new char[key, cipher_text_size];
      for (int i = 0; i < key; ++i)
      {
        for (int j = 0; j < cipher_text_size; ++j)
        {
          rail_fence[i, j] = '%';
        }
      }
      //
      for (int row = 0, col = 0, direc = 1; col < cipher_text_size; row += direc, ++col)
      {
        rail_fence[row, col] = '*';
        if (row == key - 1)
        {
          direc = -1;
        }
        else if (row == 0)
        {
          direc = 1;
        }
      }
      //
      int count = 0;
      for (int i = 0; i < key; ++i)
      {
        for (int j = 0; j < cipher_text_size; ++j)
        {
          if (rail_fence[i, j] == '*')
          {
            rail_fence[i, j] = temp[count++];
          }
        }
      }
      //
      string output = new("");
      for (int row = 0, col = 0, direc = 1; col < cipher_text_size; row += direc, ++col)
      {
        output += rail_fence[row, col];
        if (row == key - 1)
        {
          direc = -1;
        }
        else if (row == 0)
        {
          direc = 1;
        }
      }
      Plain_text_org.Text = Reverse.Checked ? ReverseXor(output) : output;
    }
  }
}
