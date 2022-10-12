﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Author@ Karoliina Salo
/// Version 12.10.2022
/// <summary>
/// Dictionary-class for wc. Finished.
/// Dictionary may hold some unused words due to lack of graphics received in time.
/// </summary>

namespace The_Crib
{
    public class DictionaryWC
    {
        Dictionary<string, string> wordLibrary = new Dictionary<string, string>() // library to store all wc-words
        {
            // order ENG-FI-UA-RUS
            {"ToiletPB", "a toilet bowl,pönttö,унітаз,унитаз"},
            {"ToiletPaperPB", "a toilet paper,vessapaperi,туалетний папір,туалетная бумага"},
            {"MirrorPB", "a mirror cabinet,peilikaappi,шкаф із дзеркалом,зеркальный шкаф"},
            {"SinkPB", "a sink,lavuaari,раковина,раковина"},
            {"TapPB", "a  tap,hana,кран,кран"},
            {"LampPB","a ceiling lamp, kattolamppu,word,word" },
            {"SoapPB", "a handsoap,käsisaippua,мило для рук,мыло для рук"},
            {"ToiletBrushPB", "a toilet brush,vessaharja,йоржик для унітазу,йоржик для унітазу"},
            {"BidetPB", "a bidet shower,käsisuihku,біде,гигиенический душ"},
            {"HandTowelPB", "a hand towel,käsipyyhe,рушник для рук,полотенце для рук"}
        };

        public void Show(string pic, int lanId)
        {
            try
            {

                string selectedWord = wordLibrary[pic]; // selecting the words from the library
                string[] separators = { "," }; // defining separators for array assigning
                string[] wordArr = selectedWord.Split(separators, StringSplitOptions.RemoveEmptyEntries); // words to array
                string word = wordArr[lanId]; // selecting the right word for the label
                string fiWord = wordArr[1];

                CustomMessageBoxForm customMessageBoxForm = new CustomMessageBoxForm(); // custom messagebox
                DialogResult result = customMessageBoxForm.ShowDialog(word, fiWord); // selecting the words for the custom messagebox
                if (result == DialogResult.OK) // when OK is clicked, the messagebox closes
                {
                    customMessageBoxForm.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}