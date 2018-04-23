using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tort
{
    public class Tort
    {
        public List<ElementTortu> element = new List<ElementTortu>();
        public List<string> tu_byles = new List<string>();
        string ilosc_swieczek;
        int ilosc_swieczek_ = 0;
        int licznik_zapalone = 0;
        int licznik_zgaszone;
        int licznik_staly;
        bool check = false;


        public void generuj_tort(List<ElementTortu> a)
        {
            Console.WriteLine("Podaj ile lat ma Jas");
            ilosc_swieczek = Console.ReadLine();
            Int32.TryParse(ilosc_swieczek, out ilosc_swieczek_);

            for (int i = 1; i <= ilosc_swieczek_; i++)
            {
                element.Add(new ElementTortu(i,true));
            }
            //foreach (ElementTortu item in element)
            //{
            //    item.wypisz();
            //}
            Console.WriteLine();
        }

        public void zdmuchuj_swieczki(List<ElementTortu> a)
        {
            ElementTortu e1 = new ElementTortu(2, false);
            element[1] = e1;

            if (element.Count % 2 != 0)
            {
                for (int i = 1; i < element.Count; i++)
                {
                    if (element.Count - 1 == licznik_zgaszone)
                    {
                        for (int j = 0; j < element.Count; j++)
                        {
                            if (element[j].czy_zapalony == true)
                            {
                                Console.WriteLine("Swieczka ktora zostala to swieczka z numerem: " + element[j].swieczka);
                                check = true;
                                break;
                            }
                        }
                    }
                    if (check == true) break;
                    if (element[i].czy_zapalony == false)
                    {

                        if (licznik_staly >= element.Count)
                        {

                            licznik_staly++;
                        }
                        else
                        {
                            licznik_zgaszone++;
                            licznik_staly++;
                        }
                    }

                    if (element[i].czy_zapalony == true)
                    {
                        licznik_zapalone++;
                        licznik_staly++;

                        if (licznik_zapalone >= 2)
                        {
                            element[i].swieczka = i + 1;
                            element[i].czy_zapalony = false;
                            licznik_zapalone = 0;
                            licznik_zgaszone++;
                        }

                    }
                    if (i == element.Count - 1)
                    {

                        i = -1;
                    }
                }
            }
            else if(element.Count % 2 == 0)
            {
                for (int i = 1; i < element.Count; i++)
                {
                    if (element.Count -1 == licznik_zgaszone)
                    {
                        for (int j = 0; j < element.Count; j++)
                        {
                            if (element[j].czy_zapalony == true)
                            {
                                Console.WriteLine("Swieczka ktora zostala to swieczka z numerem: " + element[j].swieczka);
                                check = true;
                                break;
                            }
                        }
                    }
                    if (check == true) break;
                    if (element[i].czy_zapalony == false)
                    {
                        
                        if (licznik_staly >= element.Count)
                        {
                            
                            licznik_staly++;
                        }
                        else
                        {
                            licznik_zgaszone++;
                            licznik_staly++;
                        }
                    }

                    if (element[i].czy_zapalony == true)
                    {
                        
                        licznik_zapalone++;
                        
                        licznik_staly++;
                        
                    if (licznik_zapalone >= 2)
                    {
                        element[i].swieczka = i + 1;
                        element[i].czy_zapalony = false;
                        licznik_zapalone = 0;
                        licznik_zgaszone++;
                    }
                        
                    
                    }
                    if (i == element.Count - 1)
                    {
                        
                        i = -1;
                    }
                }
            }
        }
            ////foreach (ElementTortu item in element)
            ////{
            ////    item.wypisz();
            ////}
        }
    }

