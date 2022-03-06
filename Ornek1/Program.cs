using Ornek1;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Character Karakter = new Character();
            Karakter.Name = "Alev Ejderi";
            Karakter.Burc = "Kova";
            Karakter.Attack = 83;
            Karakter.Defence = 80;
            Karakter.Etki = 20;
            Karakter.Anti = 44;
            Karakter.EtkiBurc = "Başak";
            Karakter.AntiBurc = "Boğa";

            Character Karakter1 = new Character();
            Karakter1.Name = "Kara Ejder";
            Karakter1.Burc = "Kova";
            Karakter1.Attack = 97;
            Karakter1.Defence = 53;
            Karakter1.Etki =6;
            Karakter1.Anti = 57;
            Karakter1.EtkiBurc = "Akrep";
            Karakter1.AntiBurc = "Balık";

            Character Karakter2 = new Character();
            Karakter2.Name = "Deniz Savaşçısı";
            Karakter2.Burc = "Balık";
            Karakter2.Attack = 68;
            Karakter2.Defence = 67;
            Karakter2.Etki = 30;
            Karakter2.Anti = 13;
            Karakter2.EtkiBurc = "Başak";
            Karakter2.AntiBurc = "Kova";

            Character Karakter3 = new Character();
            Karakter3.Name = "Simurg";
            Karakter3.Burc = "Yay";
            Karakter3.Attack = 100;
            Karakter3.Defence = 80;
            Karakter3.Etki = 50;
            Karakter3.Anti = 100;
            Karakter3.EtkiBurc = "Kova";
            Karakter3.AntiBurc = "Aslan";

            Character Karakter4 = new Character();
            Karakter4.Name = "Tapirus";
            Karakter4.Burc = "Yengeç";
            Karakter4.Attack = 32;
            Karakter4.Defence = 51;
            Karakter4.Etki = 36;
            Karakter4.Anti = 10;
            Karakter4.EtkiBurc = "Kova";
            Karakter4.AntiBurc = "Aslan";

            Character Karakter5 = new Character();
            Karakter5.Name = "Romdillo";
            Karakter5.Burc = "Terazi";
            Karakter5.Attack = 47;
            Karakter5.Defence = 45;
            Karakter5.Etki = 48;
            Karakter5.Anti = 17;
            Karakter5.EtkiBurc = "Oğlak";
            Karakter5.AntiBurc = "Yay";

            Character Karakter6 = new Character();
            Karakter6.Name = "Omega Kurtadam";
            Karakter6.Burc = "Koç";
            Karakter6.Attack = 50;
            Karakter6.Defence = 50;
            Karakter6.Etki = 32;
            Karakter6.Anti = 20;
            Karakter6.EtkiBurc = "Balık";
            Karakter6.AntiBurc = "Yengeç";

            Character Karakter7 = new Character();
            Karakter7.Name = "Akreon";
            Karakter7.Burc = "Koç";
            Karakter7.Attack = 38;
            Karakter7.Defence = 38;
            Karakter7.Etki = 55;
            Karakter7.Anti = 14;
            Karakter7.EtkiBurc = "Yay";
            Karakter7.AntiBurc = "Boğa";

            Character Karakter8 = new Character();
            Karakter8.Name = "Dev Yengeç";
            Karakter8.Burc = "Yengeç";
            Karakter8.Attack = 49;
            Karakter8.Defence = 74;
            Karakter8.Etki = 26;
            Karakter8.Anti = 26;
            Karakter8.EtkiBurc = "Kova";
            Karakter8.AntiBurc = "Aslan";

            Character Karakter9 = new Character();
            Karakter9.Name = "Siren";
            Karakter9.Burc = "Balık";
            Karakter9.Attack = 62;
            Karakter9.Defence = 64;
            Karakter9.Etki = 30;
            Karakter9.Anti = 4;
            Karakter9.EtkiBurc = "İkizler";
            Karakter9.AntiBurc = "Oğlak";

            Character Karakter10 = new Character();
            Karakter10.Name = "Dişsiz";
            Karakter10.Burc = "Aslan";
            Karakter10.Attack = 73;
            Karakter10.Defence = 54;
            Karakter10.Etki = 47;
            Karakter10.Anti = 40;
            Karakter10.EtkiBurc = "Terazi";
            Karakter10.AntiBurc = "Yengeç";

            Character Karakter11 = new Character();
            Karakter11.Name = "Minotor";
            Karakter11.Burc = "Boğa";
            Karakter11.Attack = 68;
            Karakter11.Defence = 56;
            Karakter11.Etki = 24;
            Karakter11.Anti = 13;
            Karakter11.EtkiBurc = "Aslan";
            Karakter11.AntiBurc = "Oğlak";

            Character Karakter12 = new Character();
            Karakter12.Name = "Kapkaba";
            Karakter12.Burc = "Aslan";
            Karakter12.Attack = 73;
            Karakter12.Defence = 70;
            Karakter12.Etki = 21;
            Karakter12.Anti = 40;
            Karakter12.EtkiBurc = "Terazi";
            Karakter12.AntiBurc = "Yengeç";


            Character Karakter13 = new Character();
            Karakter13.Name = "Kraken";
            Karakter13.Burc = "Balık";
            Karakter13.Attack = 53;
            Karakter13.Defence = 64;
            Karakter13.Etki = 45;
            Karakter13.Anti = 10;
            Karakter13.EtkiBurc = "İkizler";
            Karakter13.AntiBurc = "Boğa";


            Character Karakter14 = new Character();
            Karakter14.Name = "Kramus";
            Karakter14.Burc = "Boğa";
            Karakter14.Attack = 75;
            Karakter14.Defence = 62;
            Karakter14.Etki = 20;
            Karakter14.Anti = 21;
            Karakter14.EtkiBurc = "Koç";
            Karakter14.AntiBurc = "Oğlak";

            Character Karakter15 = new Character();
            Karakter15.Name = "Semender";
            Karakter15.Burc = "Boğa";
            Karakter15.Attack = 40;
            Karakter15.Defence = 87;
            Karakter15.Etki = 23;
            Karakter15.Anti = 31;
            Karakter15.EtkiBurc = "Koç";
            Karakter15.AntiBurc = "Oğlak";

            Character Karakter16 = new Character();
            Karakter16.Name = "Behmud";
            Karakter16.Burc = "Balık";
            Karakter16.Attack = 61;
            Karakter16.Defence = 65;
            Karakter16.Etki = 33;
            Karakter16.Anti = 22;
            Karakter16.EtkiBurc = "İkzler";
            Karakter16.AntiBurc = "Boğa";

            Character Karakter17 = new Character();
            Karakter17.Name = "Antik Fil";
            Karakter17.Burc = "Boğa";
            Karakter17.Attack = 62;
            Karakter17.Defence = 70;
            Karakter17.Etki = 43;
            Karakter17.Anti = 10;
            Karakter17.EtkiBurc = "Aslan";
            Karakter17.AntiBurc = "İkizler";

            Character Karakter18 = new Character();
            Karakter18.Name = "Ankebus";
            Karakter18.Burc = "Başak";
            Karakter18.Attack = 64;
            Karakter18.Defence = 60;
            Karakter18.Etki = 21;
            Karakter18.Anti = 17;
            Karakter18.EtkiBurc = "Boğa";
            Karakter18.AntiBurc = "Yay";

            Character Karakter19 = new Character();
            Karakter19.Name = "Aster";
            Karakter19.Burc = "Oğlak";
            Karakter19.Attack = 41;
            Karakter19.Defence = 60;
            Karakter19.Etki = 40;
            Karakter19.Anti = 17;
            Karakter19.EtkiBurc = "Yay";
            Karakter19.AntiBurc = "Yengeç";

            Character Karakter20 = new Character();
            Karakter20.Name = "Vampir";
            Karakter20.Burc = "Yay";
            Karakter20.Attack = 43;
            Karakter20.Defence = 40;
            Karakter20.Etki = 30;
            Karakter20.Anti = 13;
            Karakter20.EtkiBurc = "Akrep";
            Karakter20.AntiBurc = "Başak";

            Character Karakter21 = new Character();
            Karakter21.Name = "Parlus";
            Karakter21.Burc = "Yay";
            Karakter21.Attack = 85;
            Karakter21.Defence = 99;
            Karakter21.Etki = 14;
            Karakter21.Anti = 60;
            Karakter21.EtkiBurc = "İkizler";
            Karakter21.AntiBurc = "Oğlak";

            Character Karakter22 = new Character();
            Karakter22.Name = "Antik Sırtlan";
            Karakter22.Burc = "Balık";
            Karakter22.Attack = 60;
            Karakter22.Defence = 41;
            Karakter22.Etki = 41;
            Karakter22.Anti = 11;
            Karakter22.EtkiBurc = "Terazi";
            Karakter22.AntiBurc = "Başak";

            Character Karakter23 = new Character();
            Karakter23.Name = "Zavahuki";
            Karakter23.Burc = "Boğa";
            Karakter23.Attack = 72;
            Karakter23.Defence = 80;
            Karakter23.Etki = 23;
            Karakter23.Anti = 40;
            Karakter23.EtkiBurc = "Terazi";
            Karakter23.AntiBurc = "İkizler";

            Character Karakter24 = new Character();
            Karakter24.Name = "Çekiçkafa";
            Karakter24.Burc = "Terazi";
            Karakter24.Attack = 74;
            Karakter24.Defence = 75;
            Karakter24.Etki = 20;
            Karakter24.Anti = 31;
            Karakter24.EtkiBurc = "Koç";
            Karakter24.AntiBurc = "Akrep";

            Character Karakter25 = new Character();
            Karakter25.Name = "Griffin";
            Karakter25.Burc = "Koç";
            Karakter25.Attack = 74;
            Karakter25.Defence = 76;
            Karakter25.Etki = 17;
            Karakter25.Anti = 35;
            Karakter25.EtkiBurc = "Oğlak";
            Karakter25.AntiBurc = "Yay";

            Character Karakter26 = new Character();
            Karakter26.Name = "Işık Ejderi";
            Karakter26.Burc = "Kova";
            Karakter26.Attack = 52;
            Karakter26.Defence = 98;
            Karakter26.Etki = 5;
            Karakter26.Anti = 58;
            Karakter26.EtkiBurc = "Akrep";
            Karakter26.AntiBurc = "Balık";

            Character Karakter27 = new Character();
            Karakter27.Name = "Buz Ejderi";
            Karakter27.Burc = "Kova";
            Karakter27.Attack = 84;
            Karakter27.Defence = 81;
            Karakter27.Etki = 16;
            Karakter27.Anti = 30;
            Karakter27.EtkiBurc = "Yay";
            Karakter27.AntiBurc = "Boğa";

            Character Karakter28 = new Character();
            Karakter28.Name = "Bükrek";
            Karakter28.Burc = "Kova";
            Karakter28.Attack = 92;
            Karakter28.Defence = 94;
            Karakter28.Etki = 24;
            Karakter28.Anti = 40;
            Karakter28.EtkiBurc = "Aslan";
            Karakter28.AntiBurc = "Terazi";

            Character Karakter29 = new Character();
            Karakter29.Name = "Komodan";
            Karakter29.Burc = "Akrep";
            Karakter29.Attack = 67;
            Karakter29.Defence = 65;
            Karakter29.Etki = 23;
            Karakter29.Anti = 12;
            Karakter29.EtkiBurc = "Başak";
            Karakter29.AntiBurc = "Balık";

            Character Karakter30 = new Character();
            Karakter30.Name = "Fırtınıç";
            Karakter30.Burc = "Akrep";
            Karakter30.Attack = 63;
            Karakter30.Defence = 65;
            Karakter30.Etki = 17;
            Karakter30.Anti = 36;
            Karakter30.EtkiBurc = "Balık";
            Karakter30.AntiBurc = "Yengeç";

            Character Karakter31 = new Character();
            Karakter31.Name = "Akrozor";
            Karakter31.Burc = "Akrep";
            Karakter31.Attack = 73;
            Karakter31.Defence = 71;
            Karakter31.Etki = 23;
            Karakter31.Anti = 26;
            Karakter31.EtkiBurc = "Aslan";
            Karakter31.AntiBurc = "Kova";

            Character Karakter32 = new Character();
            Karakter32.Name = "Demogorgon";
            Karakter32.Burc = "Akrep";
            Karakter32.Attack = 43;
            Karakter32.Defence = 47;
            Karakter32.Etki = 52;
            Karakter32.Anti = 13;
            Karakter32.EtkiBurc = "Akrep";
            Karakter32.AntiBurc = "Balık";

            Character Karakter33 = new Character();
            Karakter33.Name = "Neron";
            Karakter33.Burc = "Yengeç";
            Karakter33.Attack = 69;
            Karakter33.Defence = 65;
            Karakter33.Etki = 10;
            Karakter33.Anti = 45;
            Karakter33.EtkiBurc = "Akrep";
            Karakter33.AntiBurc = "Başak";

            Character Karakter34 = new Character();
            Karakter34.Name = "Azmıc";
            Karakter34.Burc = "Akrep";
            Karakter34.Attack = 53;
            Karakter34.Defence = 50;
            Karakter34.Etki = 50;
            Karakter34.Anti = 11;
            Karakter34.EtkiBurc = "Oğlak";
            Karakter34.AntiBurc = "Terazi";

            Character Karakter35 = new Character();
            Karakter35.Name = "Basiliks";
            Karakter35.Burc = "Oğlak";
            Karakter35.Attack = 48;
            Karakter35.Defence = 47;
            Karakter35.Etki = 45;
            Karakter35.Anti = 17;
            Karakter35.EtkiBurc = "Yay";
            Karakter35.AntiBurc = "Kova";

            Character Karakter36 = new Character();
            Karakter36.Name = "Kerberus";
            Karakter36.Burc = "Oğlak";
            Karakter36.Attack = 54;
            Karakter36.Defence = 52;
            Karakter36.Etki = 44;
            Karakter36.Anti = 13;
            Karakter36.EtkiBurc = "Yay";
            Karakter36.AntiBurc = "Kova";

            Character Karakter37 = new Character();
            Karakter37.Name = "Dikenli Tosbağ";
            Karakter37.Burc = "Yay";
            Karakter37.Attack = 55;
            Karakter37.Defence = 75;
            Karakter37.Etki = 25;
            Karakter37.Anti = 18;
            Karakter37.EtkiBurc = "Kova";
            Karakter37.AntiBurc = "Terazi";

            Character Karakter38 = new Character();
            Karakter38.Name = "Yeti";
            Karakter38.Burc = "Yay";
            Karakter38.Attack = 45;
            Karakter38.Defence = 40;
            Karakter38.Etki = 65;
            Karakter38.Anti = 11;
            Karakter38.EtkiBurc = "Aslan";
            Karakter38.AntiBurc = "Akrep";

            Character Karakter39 = new Character();
            Karakter39.Name = "Sentor";
            Karakter39.Burc = "Yay";
            Karakter39.Attack = 63;
            Karakter39.Defence = 72;
            Karakter39.Etki = 27;
            Karakter39.Anti = 15;
            Karakter39.EtkiBurc = "Yengeç";
            Karakter39.AntiBurc = "Akrep";

            Character Karakter40 = new Character();
            Karakter40.Name = "Kumay";
            Karakter40.Burc = "Yay";
            Karakter40.Attack = 84;
            Karakter40.Defence = 72;
            Karakter40.Etki = 16;
            Karakter40.Anti = 37;
            Karakter40.EtkiBurc = "Kova";
            Karakter40.AntiBurc = "Aslan";

            Character Karakter41 = new Character();
            Karakter41.Name = "Abra";
            Karakter41.Burc = "Kova";
            Karakter41.Attack = 77;
            Karakter41.Defence = 75;
            Karakter41.Etki = 24;
            Karakter41.Anti = 43;
            Karakter41.EtkiBurc = "Aslan";
            Karakter41.AntiBurc = "Terazi";

            Character Karakter42 = new Character();
            Karakter42.Name = "Ejderha Avcısı";
            Karakter42.Burc = "Terazi";
            Karakter42.Attack = 86;
            Karakter42.Defence = 81;
            Karakter42.Etki = 34;
            Karakter42.Anti = 37;
            Karakter42.EtkiBurc = "Terazi";
            Karakter42.AntiBurc = "İkizler";

            Character Karakter43 = new Character();
            Karakter43.Name = "Kapra";
            Karakter43.Burc = "Koç";
            Karakter43.Attack = 80;
            Karakter43.Defence = 75;
            Karakter43.Etki = 13;
            Karakter43.Anti = 50;
            Karakter43.EtkiBurc = "Oğlak";
            Karakter43.AntiBurc = "Yay";

            Character Karakter44 = new Character();
            Karakter44.Name = "Tek Boynuz";
            Karakter44.Burc = "Başak";
            Karakter44.Attack = 78;
            Karakter44.Defence = 83;
            Karakter44.Etki = 12;
            Karakter44.Anti = 43;
            Karakter44.EtkiBurc = "Balık";
            Karakter44.AntiBurc = "İkizler";

            Character Karakter45 = new Character();
            Karakter45.Name = "Kristal Golem";
            Karakter45.Burc = "İkizler";
            Karakter45.Attack = 40;
            Karakter45.Defence = 100;
            Karakter45.Etki = 20;
            Karakter45.Anti = 50;
            Karakter45.EtkiBurc = "Boğa";
            Karakter45.AntiBurc = "Koç";

            Character Karakter46 = new Character();
            Karakter46.Name = "Gece Taşı";
            Karakter46.Burc = "Terazi";
            Karakter46.Attack = 58;
            Karakter46.Defence = 55;
            Karakter46.Etki = 44;
            Karakter46.Anti = 9;
            Karakter46.EtkiBurc = "Başak";
            Karakter46.AntiBurc = "Balık";

            Character Karakter47 = new Character();
            Karakter47.Name = "Sibirdiş";
            Karakter47.Burc = "Başak";
            Karakter47.Attack = 78;
            Karakter47.Defence = 70;
            Karakter47.Etki = 64;
            Karakter47.Anti = 64;
            Karakter47.EtkiBurc = "Koç";
            Karakter47.AntiBurc = "Kova";

            Character Karakter48 = new Character();
            Karakter48.Name = "Tulpar";
            Karakter48.Burc = "Başak";
            Karakter48.Attack = 71;
            Karakter48.Defence = 68;
            Karakter48.Etki = 16;
            Karakter48.Anti = 36;
            Karakter48.EtkiBurc = "Balık";
            Karakter48.AntiBurc = "İkziler";

            Character Karakter49 = new Character();
            Karakter49.Name = "Şeşe";
            Karakter49.Burc = "Terazi";
            Karakter49.Attack = 71;
            Karakter49.Defence = 68;
            Karakter49.Etki = 23;
            Karakter49.Anti = 23;
            Karakter49.EtkiBurc = "Yengeç";
            Karakter49.AntiBurc = "Akrep";

            Character Karakter50 = new Character();
            Karakter50.Name = "Merküt";
            Karakter50.Burc = "İkizler";
            Karakter50.Attack = 54;
            Karakter50.Defence = 60;
            Karakter50.Etki = 35;
            Karakter50.Anti = 25;
            Karakter50.EtkiBurc = "Boğa";
            Karakter50.AntiBurc = "Koç";

            Character Karakter51 = new Character();
            Karakter51.Name = "Golem";
            Karakter51.Burc = "İkizler";
            Karakter51.Attack = 30;
            Karakter51.Defence = 90;
            Karakter51.Etki = 20;
            Karakter51.Anti = 50;
            Karakter51.EtkiBurc = "Boğa";
            Karakter51.AntiBurc = "Koç";

            Character Karakter52 = new Character();
            Karakter52.Name = "Alfa Kurtadam";
            Karakter52.Burc = "Koç";
            Karakter52.Attack = 55;
            Karakter52.Defence = 55;
            Karakter52.Etki = 27;
            Karakter52.Anti = 20;
            Karakter52.EtkiBurc = "Yengeç";
            Karakter52.AntiBurc = "Balık";

            Character Karakter53 = new Character();
            Karakter53.Name = "Godzilla";
            Karakter53.Burc = "Oğlak";
            Karakter53.Attack = 92;
            Karakter53.Defence = 90;
            Karakter53.Etki = 7;
            Karakter53.Anti = 43;
            Karakter53.EtkiBurc = "Yengeç";
            Karakter53.AntiBurc = "Terazi";

            Character Karakter54 = new Character();
            Karakter54.Name = "Mosazor";
            Karakter54.Burc = "Yengeç";
            Karakter54.Attack = 67;
            Karakter54.Defence = 63;
            Karakter54.Etki = 33;
            Karakter54.Anti = 22;
            Karakter54.EtkiBurc = "Koç";
            Karakter54.AntiBurc = "Aslan";

            Character Karakter55 = new Character();
            Karakter55.Name = "Gümüş Ejderi";
            Karakter55.Burc = "Kova";
            Karakter55.Attack = 61;
            Karakter55.Defence = 89;
            Karakter55.Etki = 12;
            Karakter55.Anti = 31;
            Karakter55.EtkiBurc = "Balık";
            Karakter55.AntiBurc = "Oğlak";

            Character Karakter56 = new Character();
            Karakter56.Name = "Deniz Savaşçısı";
            Karakter56.Burc = "Balık";
            Karakter56.Attack = 68;
            Karakter56.Defence = 67;
            Karakter56.Etki = 30;
            Karakter56.Anti = 13;
            Karakter56.EtkiBurc = "Başak";
            Karakter56.AntiBurc = "Kova";

            Character Karakter57 = new Character();
            Karakter57.Name = "Deniz Savaşçısı";
            Karakter57.Burc = "Balık";
            Karakter57.Attack = 68;
            Karakter57.Defence = 67;
            Karakter57.Etki = 30;
            Karakter57.Anti = 13;
            Karakter57.EtkiBurc = "Başak";
            Karakter57.AntiBurc = "Kova";

            Character Karakter58 = new Character();
            Karakter58.Name = "Deniz Savaşçısı";
            Karakter58.Burc = "Balık";
            Karakter58.Attack = 68;
            Karakter58.Defence = 67;
            Karakter58.Etki = 30;
            Karakter58.Anti = 13;
            Karakter58.EtkiBurc = "Başak";
            Karakter58.AntiBurc = "Kova";

            Character Karakter59 = new Character();
            Karakter59.Name = "Deniz Savaşçısı";
            Karakter59.Burc = "Balık";
            Karakter59.Attack = 68;
            Karakter59.Defence = 67;
            Karakter59.Etki = 30;
            Karakter59.Anti = 13;
            Karakter59.EtkiBurc = "Başak";
            Karakter59.AntiBurc = "Kova";

            Character Karakter60 = new Character();
            Karakter60.Name = "Deniz Savaşçısı";
            Karakter60.Burc = "Balık";
            Karakter60.Attack = 68;
            Karakter60.Defence = 67;
            Karakter60.Etki = 30;
            Karakter60.Anti = 13;
            Karakter60.EtkiBurc = "Başak";
            Karakter60.AntiBurc = "Kova";

            Character Karakter61 = new Character();
            Karakter61.Name = "Deniz Savaşçısı";
            Karakter61.Burc = "Balık";
            Karakter61.Attack = 68;
            Karakter61.Defence = 67;
            Karakter61.Etki = 30;
            Karakter61.Anti = 13;
            Karakter61.EtkiBurc = "Başak";
            Karakter61.AntiBurc = "Kova";


            List<Character> Karakterler = new List<Character>();
            Karakterler.Add(Karakter);
            Karakterler.Add(Karakter1);
            Karakterler.Add(Karakter2);
            Karakterler.Add(Karakter3);
            Karakterler.Add(Karakter4);
            Karakterler.Add(Karakter5);
            Karakterler.Add(Karakter6);
            Karakterler.Add(Karakter7);
            Karakterler.Add(Karakter8);
            Karakterler.Add(Karakter9);
            Karakterler.Add(Karakter10);
            Karakterler.Add(Karakter11);
            Karakterler.Add(Karakter12);
            Karakterler.Add(Karakter13);
            Karakterler.Add(Karakter14);
            Karakterler.Add(Karakter15);
            Karakterler.Add(Karakter16);
            Karakterler.Add(Karakter17);
            Karakterler.Add(Karakter18);
            Karakterler.Add(Karakter19);
            Karakterler.Add(Karakter20);
            Karakterler.Add(Karakter21);
            Karakterler.Add(Karakter22);
            Karakterler.Add(Karakter23);
            Karakterler.Add(Karakter24);
            Karakterler.Add(Karakter25);
            Karakterler.Add(Karakter26);
            Karakterler.Add(Karakter27);
            Karakterler.Add(Karakter28);
            Karakterler.Add(Karakter29);
            Karakterler.Add(Karakter30);
            Karakterler.Add(Karakter31);
            Karakterler.Add(Karakter32);
            Karakterler.Add(Karakter33);
            Karakterler.Add(Karakter34);
            Karakterler.Add(Karakter35);
            Karakterler.Add(Karakter36);
            Karakterler.Add(Karakter37);
            Karakterler.Add(Karakter38);
            Karakterler.Add(Karakter39);
            Karakterler.Add(Karakter40);
            Karakterler.Add(Karakter41);
            Karakterler.Add(Karakter42);
            Karakterler.Add(Karakter43);
            Karakterler.Add(Karakter44);
            Karakterler.Add(Karakter45);
            Karakterler.Add(Karakter46);
            Karakterler.Add(Karakter46);
            Karakterler.Add(Karakter47);
            Karakterler.Add(Karakter48);
            Karakterler.Add(Karakter49);
            Karakterler.Add(Karakter50);
            Karakterler.Add(Karakter51);
            Karakterler.Add(Karakter52);
            Karakterler.Add(Karakter53);
            Karakterler.Add(Karakter54);
            Karakterler.Add(Karakter55);

            List<Character> Karakterler1 = new List<Character>();
            Karakterler1.Add(Karakter);
            Karakterler1.Add(Karakter1);
            Karakterler1.Add(Karakter2);
            Karakterler1.Add(Karakter3);
            Karakterler1.Add(Karakter4);
            Karakterler1.Add(Karakter5);
            Karakterler1.Add(Karakter6);
            Karakterler1.Add(Karakter7);
            Karakterler1.Add(Karakter8);
            Karakterler1.Add(Karakter9);
            Karakterler1.Add(Karakter10);
            Karakterler1.Add(Karakter11);
            Karakterler1.Add(Karakter12);
            Karakterler1.Add(Karakter13);
            Karakterler1.Add(Karakter14);
            Karakterler1.Add(Karakter15);
            Karakterler1.Add(Karakter16);
            Karakterler1.Add(Karakter17);
            Karakterler1.Add(Karakter18);
            Karakterler1.Add(Karakter19);
            Karakterler1.Add(Karakter20);
            Karakterler1.Add(Karakter21);
            Karakterler1.Add(Karakter22);
            Karakterler1.Add(Karakter23);
            Karakterler1.Add(Karakter24);
            Karakterler1.Add(Karakter25);
            Karakterler1.Add(Karakter26);
            Karakterler1.Add(Karakter27);
            Karakterler1.Add(Karakter28);
            Karakterler1.Add(Karakter29);
            Karakterler1.Add(Karakter30);
            Karakterler1.Add(Karakter31);
            Karakterler1.Add(Karakter32);
            Karakterler1.Add(Karakter33);
            Karakterler1.Add(Karakter34);
            Karakterler1.Add(Karakter35);
            Karakterler1.Add(Karakter36);
            Karakterler1.Add(Karakter37);
            Karakterler1.Add(Karakter38);
            Karakterler1.Add(Karakter39);
            Karakterler1.Add(Karakter40);
            Karakterler1.Add(Karakter41);
            Karakterler1.Add(Karakter42);
            Karakterler1.Add(Karakter43);
            Karakterler1.Add(Karakter44);
            Karakterler1.Add(Karakter45);
            Karakterler1.Add(Karakter46);
            Karakterler1.Add(Karakter46);
            Karakterler1.Add(Karakter47);
            Karakterler1.Add(Karakter48);
            Karakterler1.Add(Karakter49);
            Karakterler1.Add(Karakter50);
            Karakterler1.Add(Karakter51);
            Karakterler1.Add(Karakter52);
            Karakterler1.Add(Karakter53);
            Karakterler1.Add(Karakter54);
            Karakterler1.Add(Karakter55);


            SonucMetod sonuc = new SonucMetod();
            sonuc.Sonuc(Karakterler1, Karakterler);
            
            KarşılaştırmaMetotAtak_Atak metot1 = new KarşılaştırmaMetotAtak_Atak();
            KarşılaştırmaMetodAtak_Defans metot2 = new KarşılaştırmaMetodAtak_Defans();
            KarşılaştırmaMetodDefans_Atak metot3 = new KarşılaştırmaMetodDefans_Atak();
            /*foreach (var item in Karakterler1)
            {
                metot1.Add(item, Karakterler);

                Console.WriteLine(item.Name + " puanı = " + metot1.Add(item, Karakterler));
            }*/
            /*foreach (var item in Karakterler1)
            {
                Console.WriteLine(item.Name + " puanı = " + metot2.Add(item, Karakterler));
            }*/
            /*foreach (var item in Karakterler1)
            {

                Console.WriteLine(item.Name + " puanı = " + metot3.Add(item, Karakterler));
            }*/


        }
    }
}
