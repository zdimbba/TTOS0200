//TTOS0200 Olio-ohjelmointi demo Lotto
//Programmed by: Esa Salmikangas 29.8.2017
using System;

namespace Hello
{
  public class Lotto
  {
    //ohjelma arpoo käyttäjän antaman määrän lottorivejä, arvotaan seitsemän numeroa väliltä 1-40
    public static void  DrawLotto()
    {
      //muuttujat
      bool[] numerot = new bool[40];
      int hits;
      int lkm;
      int nro;
      Random rnd;
      string rivi = "";
      Console.WriteLine("Anna arvottavien rivien määrä");
      lkm = int.Parse(Console.ReadLine());
      //arvotaan rivit
      rnd = new Random();
      for (int i = 1; i <= lkm; i++)
      {
        hits = 0;
        do
        {
          nro = rnd.Next(0, 40);
          if (numerot[nro] == false)
          {
            numerot[nro] = true;
            hits++;
          }
        } while (hits < 7);
        rivi = String.Format("Rivi {0}: ", i);
        for (int j = 0; j < 40; j++)
        {
          if (numerot[j])
          {
            rivi +=  (j+1).ToString() + " ";
          }
        }
        Console.WriteLine(rivi);
        //tyhjätään array
        numerot = new bool[40];
      }
    }
  }
}
