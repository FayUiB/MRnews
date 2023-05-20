using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Knapper : MonoBehaviour
{
    public int _startNumber = 1;
    public int _number;
    public int _EndNumber = 21;

    public GameObject FØRSTEBOKS;
    public GameObject ANDREBOKS;
    public GameObject TREDJEBOKS;
    public GameObject FJERDEBOKS;
    public GameObject FEMTEBOKS;
    public GameObject SJETTEBOKS;
    public GameObject SJUENDEBOKS;
    public GameObject AATTENDEBOKS;
    public GameObject NIENDEBOKS;
    public GameObject TIENDEBOKS;
    public GameObject ELLEVTEBOKS;
    public GameObject TOLVTEBOKS;
    public GameObject TRETTENDEBOKS;
    public GameObject FJORTENDEBOKS;
    public GameObject FEMTENDEBOKS;
    public GameObject SEKSTENDEBOKS;
    public GameObject SYTTENDEBOKS;
    public GameObject ATTENDEBOKS;
    public GameObject NITTENDEBOKS;
    public GameObject TYVENDEBOKS;
    public GameObject ENOGTYVENDEBOKS;

    public GameObject FØRSTEBOKSback1;
    public GameObject ANDREBOKSback1;
    public GameObject TREDJEBOKSback1;
    public GameObject FJERDEBOKSback1;
    public GameObject FEMTEBOKSback1;
    public GameObject SJETTEBOKSback1;
    public GameObject SJUENDEBOKSback1;
    public GameObject AATTENDEBOKSback1;
    public GameObject NIENDEBOKSback1;
    public GameObject TIENDEBOKSback1;
    public GameObject ELLEVTEBOKSback1;
    public GameObject TOLVTEBOKSback1;
    public GameObject TRETTENDEBOKSback1;
    public GameObject FJORTENDEBOKSback1;
    public GameObject FEMTENDEBOKSback1;
    public GameObject SEKSTENDEBOKSback1;
    public GameObject SYTTENDEBOKSback1;
    public GameObject ATTENDEBOKSback1;
    public GameObject NITTENDEBOKSback1;
    public GameObject TYVENDEBOKSback1;
    public GameObject ENOGTYVENDEBOKSback1;

    public GameObject FØRSTEBOKSback2;
    public GameObject ANDREBOKSback2;
    public GameObject TREDJEBOKSback2;
    public GameObject FJERDEBOKSback2;
    public GameObject FEMTEBOKSback2;
    public GameObject SJETTEBOKSback2;
    public GameObject SJUENDEBOKSback2;
    public GameObject AATTENDEBOKSback2;
    public GameObject NIENDEBOKSback2;
    public GameObject TIENDEBOKSback2;
    public GameObject ELLEVTEBOKSback2;
    public GameObject TOLVTEBOKSback2;
    public GameObject TRETTENDEBOKSback2;
    public GameObject FJORTENDEBOKSback2;
    public GameObject FEMTENDEBOKSback2;
    public GameObject SEKSTENDEBOKSback2;
    public GameObject SYTTENDEBOKSback2;
    public GameObject ATTENDEBOKSback2;
    public GameObject NITTENDEBOKSback2;
    public GameObject TYVENDEBOKSback2;
    public GameObject ENOGTYVENDEBOKSback2;

    public GameObject B1bilde1;
    public GameObject B1bilde2;
    public GameObject B1bilde3;
    public GameObject B1bilde4;
    public GameObject B1bilde5;
    public GameObject B1bilde6;
    public GameObject B1bilde7;
    public GameObject B1bilde8;
    public GameObject B1bilde9;
    public GameObject B1bilde10;
    public GameObject B1bilde11;
    public GameObject B1bilde12;
    public GameObject B1bilde13;
    public GameObject B1bilde14;
    public GameObject B1bilde15;
    public GameObject B1bilde16;
    public GameObject B1bilde17;
    public GameObject B1bilde18;
    public GameObject B1bilde19;
    public GameObject B1bilde20;
    public GameObject B1bilde21;

    public GameObject Kart1;
    public GameObject Kart2;
    public GameObject Kart3;
    public GameObject Kart4;
    public GameObject Kart5;

    public GameObject KartMeta1;
    public GameObject KartMeta2;
    public GameObject KartMeta3;
    public GameObject KartMeta4;
    public GameObject KartMeta5;
    public GameObject KartMeta6;
    public GameObject KartMeta7;
    public GameObject KartMeta8;
    public GameObject KartMeta9;
    public GameObject KartMeta10;

    public GameObject Meta1;
    public GameObject Meta2;
    public GameObject Meta3;
    public GameObject Meta4;



    public TextMeshProUGUI _textNumber;



    // Update is called once per frame
    void Update()
    {
        //VIDERE, NESTE (hva som er synlig)

        //Intro

        bool a = _number == 1;
        if (a)
        {
            FØRSTEBOKS.SetActive(true);
            FØRSTEBOKSback1.SetActive(true);
            FØRSTEBOKSback2.SetActive(true);
            B1bilde1.SetActive(true);
            //Kart1.SetActive(true);

        }
        else
        {
            FØRSTEBOKS.SetActive(false);
            FØRSTEBOKSback1.SetActive(false);
            B1bilde1.SetActive(false);
            //Kart1.SetActive(false);
           

        }


        bool b = _number == 2;
        if (b)
        {
            ANDREBOKS.SetActive(true);
            ANDREBOKSback1.SetActive(true);
            ANDREBOKSback2.SetActive(true);
            B1bilde2.SetActive(true);
            //Kart1.SetActive(true);
         


        }
        else
        {
            ANDREBOKS.SetActive(false);
            ANDREBOKSback1.SetActive(false);
            B1bilde2.SetActive(false);
            //Kart1.SetActive(false);

        }

        bool c = _number == 3;
        if (c)
        {
            TREDJEBOKS.SetActive(true);
            TREDJEBOKSback1.SetActive(true);
            TREDJEBOKSback2.SetActive(true);
            B1bilde3.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            TREDJEBOKS.SetActive(false);
            TREDJEBOKSback1.SetActive(false);
            B1bilde3.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool d = _number == 4;
        if (d)
        {
            FJERDEBOKS.SetActive(true);
            FJERDEBOKSback1.SetActive(true);
            FJERDEBOKSback2.SetActive(true);
            B1bilde4.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            FJERDEBOKS.SetActive(false);
            FJERDEBOKSback1.SetActive(false);
            B1bilde4.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool e = _number == 5;
        if (e)
        {
            FEMTEBOKS.SetActive(true);
            FEMTEBOKSback1.SetActive(true);
            FEMTEBOKSback2.SetActive(true);
            B1bilde5.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            FEMTEBOKS.SetActive(false);
            FEMTEBOKSback1.SetActive(false);
            B1bilde5.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool f = _number == 6;
        if (f)
        {
            SJETTEBOKS.SetActive(true);
            SJETTEBOKSback1.SetActive(true);
            SJETTEBOKSback2.SetActive(true);
            B1bilde6.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            SJETTEBOKS.SetActive(false);
            SJETTEBOKSback1.SetActive(false);
            B1bilde6.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool g = _number == 7;
        if (g)
        {
            SJUENDEBOKS.SetActive(true);
            SJUENDEBOKSback1.SetActive(true);
            SJUENDEBOKSback2.SetActive(true);
            B1bilde7.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            SJUENDEBOKS.SetActive(false);
            SJUENDEBOKSback1.SetActive(false);
            B1bilde7.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool h = _number == 8;
        if (h)
        {
            AATTENDEBOKS.SetActive(true);
            AATTENDEBOKSback1.SetActive(true);
            AATTENDEBOKSback2.SetActive(true);
            B1bilde8.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            AATTENDEBOKS.SetActive(false);
            AATTENDEBOKSback1.SetActive(false);
            B1bilde8.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool i = _number == 9;
        if (i)
        {
            NIENDEBOKS.SetActive(true);
            NIENDEBOKSback1.SetActive(true);
            NIENDEBOKSback2.SetActive(true);
            B1bilde9.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            NIENDEBOKS.SetActive(false);
            NIENDEBOKSback1.SetActive(false);
            B1bilde9.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool j = _number == 10;
        if (j)
        {
            TIENDEBOKS.SetActive(true);
            TIENDEBOKSback1.SetActive(true);
            TIENDEBOKSback2.SetActive(true);
            B1bilde10.SetActive(true);
            //Kart2.SetActive(true);


        }
        else
        {
            TIENDEBOKS.SetActive(false);
            TIENDEBOKSback1.SetActive(false);
            B1bilde10.SetActive(false);
            //Kart2.SetActive(false);

        }

        bool k = _number == 11;
        if (k)
        {
            ELLEVTEBOKS.SetActive(true);
            ELLEVTEBOKSback1.SetActive(true);
            ELLEVTEBOKSback2.SetActive(true);
            B1bilde11.SetActive(true);
            //Kart3.SetActive(true);


        }
        else
        {
            ELLEVTEBOKS.SetActive(false);
            ELLEVTEBOKSback1.SetActive(false);
            B1bilde11.SetActive(false);
            //Kart3.SetActive(false);

        }

        bool l = _number == 12;
        if (l)
        {
            TOLVTEBOKS.SetActive(true);
            TOLVTEBOKSback1.SetActive(true);
            TOLVTEBOKSback2.SetActive(true);
            B1bilde12.SetActive(true);
            //Kart3.SetActive(true);


        }
        else
        {
            TOLVTEBOKS.SetActive(false);
            TOLVTEBOKSback1.SetActive(false);
            B1bilde12.SetActive(false);
            //Kart3.SetActive(false);

        }

        bool m = _number == 13;
        if (m)
        {
            TRETTENDEBOKS.SetActive(true);
            TRETTENDEBOKSback1.SetActive(true);
            TRETTENDEBOKSback2.SetActive(true);
            B1bilde13.SetActive(true);
            //Kart3.SetActive(true);


        }
        else
        {
            TRETTENDEBOKS.SetActive(false);
            TRETTENDEBOKSback1.SetActive(false);
            B1bilde13.SetActive(false);
            //Kart3.SetActive(false);

        }

        bool n = _number == 14;
        if (n)
        {
            FJORTENDEBOKS.SetActive(true);
            FJORTENDEBOKSback1.SetActive(true);
            FJORTENDEBOKSback2.SetActive(true);
            B1bilde14.SetActive(true);
            //Kart3.SetActive(true);


        }
        else
        {
            FJORTENDEBOKS.SetActive(false);
            FJORTENDEBOKSback1.SetActive(false);
            B1bilde14.SetActive(false);
            //Kart3.SetActive(false);

        }

        bool o = _number == 15;
        if (o)
        {
            FEMTENDEBOKS.SetActive(true);
            FEMTENDEBOKSback1.SetActive(true);
            FEMTENDEBOKSback2.SetActive(true);
            B1bilde15.SetActive(true);
            //Kart3.SetActive(true);


        }
        else
        {
            FEMTENDEBOKS.SetActive(false);
            FEMTENDEBOKSback1.SetActive(false);
            B1bilde15.SetActive(false);
            //Kart3.SetActive(false);

        }

        bool p = _number == 16;
        if (p)
        {
            SEKSTENDEBOKS.SetActive(true);
            SEKSTENDEBOKSback1.SetActive(true);
            SEKSTENDEBOKSback2.SetActive(true);
            B1bilde16.SetActive(true);
            //Kart4.SetActive(true);


        }
        else
        {
            SEKSTENDEBOKS.SetActive(false);
            SEKSTENDEBOKSback1.SetActive(false);
            B1bilde16.SetActive(false);
            //Kart4.SetActive(false);

        }

        bool q = _number == 17;
        if (q)
        {
            SYTTENDEBOKS.SetActive(true);
            SYTTENDEBOKSback1.SetActive(true);
            SYTTENDEBOKSback2.SetActive(true);
            B1bilde17.SetActive(true);
            //Kart4.SetActive(true);


        }
        else
        {
            SYTTENDEBOKS.SetActive(false);
            SYTTENDEBOKSback1.SetActive(false);
            B1bilde17.SetActive(false);
            //Kart4.SetActive(false);


        }

        bool r = _number == 18;
        if (r)
        {
            ATTENDEBOKS.SetActive(true);
            ATTENDEBOKSback1.SetActive(true);
            ATTENDEBOKSback2.SetActive(true);
            B1bilde18.SetActive(true);
            //Kart5.SetActive(true);


        }
        else
        {
            ATTENDEBOKS.SetActive(false);
            ATTENDEBOKSback1.SetActive(false);
            B1bilde18.SetActive(false);
            //Kart5.SetActive(false);


        }

        bool s = _number == 19;
        if (s)
        {
            NITTENDEBOKS.SetActive(true);
            NITTENDEBOKSback1.SetActive(true);
            NITTENDEBOKSback2.SetActive(true);
            B1bilde19.SetActive(true);
            //Kart5.SetActive(true);


        }
        else
        {
            NITTENDEBOKS.SetActive(false);
            NITTENDEBOKSback1.SetActive(false);
            B1bilde19.SetActive(false);
            //Kart5.SetActive(false);


        }

        bool t = _number == 20;
        if (t)
        {
            TYVENDEBOKS.SetActive(true);
            TYVENDEBOKSback1.SetActive(true);
            TYVENDEBOKSback2.SetActive(true);
            B1bilde20.SetActive(true);
            //Kart5.SetActive(true);


        }
        else
        {
            TYVENDEBOKS.SetActive(false);
            TYVENDEBOKSback1.SetActive(false);
            B1bilde20.SetActive(false);
            //Kart5.SetActive(false);


        }

        bool u = _number == 21;
        if (u)
        {
            ENOGTYVENDEBOKS.SetActive(true);
            ENOGTYVENDEBOKSback1.SetActive(true);
            ENOGTYVENDEBOKSback2.SetActive(true);
            B1bilde21.SetActive(true);
            //Kart5.SetActive(true);


        }
        else
        {
            ENOGTYVENDEBOKS.SetActive(false);
            ENOGTYVENDEBOKSback1.SetActive(false);
            B1bilde21.SetActive(false);
            //Kart5.SetActive(false);

        }


        //KART

        bool v = (_number == 1 || _number == 2);
        if (v) 
        {
            Kart1.SetActive(true);

        }
        else
        {
            Kart1.SetActive(false);
        }

        bool w = (_number == 3 || _number == 4 || _number == 5 || _number == 6 || _number == 7 || _number == 8 || _number == 9 || _number == 10);
        if (w)
        {
            Kart2.SetActive(true);

        }
        else
        {
            Kart2.SetActive(false);
        }

        bool x = (_number == 11 || _number == 12 || _number == 13 || _number == 14 || _number == 15);
        if (x)
        {
            Kart3.SetActive(true);

        }
        else
        {
            Kart3.SetActive(false);
        }

        bool y = (_number == 16 || _number == 17);
        if (y)
        {
            Kart4.SetActive(true);

        }
        else
        {
            Kart4.SetActive(false);
        }

        bool z = (_number == 18 || _number == 19 || _number == 20 || _number == 21);
        if (z)
        {
            Kart5.SetActive(true);

        }
        else
        {
            Kart5.SetActive(false);
        }

        
        bool aa = (_number == 1 || _number == 2 || _number == 3 || _number == 4 || _number == 18 || _number == 19);
        if (aa)
        {
            Meta1.SetActive(true);

        }
        else
        {
            Meta1.SetActive(false);
        }


        bool ab = (_number == 5 || _number == 6 || _number == 7 || _number == 8);
        if (ab)
        {
            Meta2.SetActive(true);

        }
        else
        {
            Meta2.SetActive(false);
        }

        bool ac = (_number == 9 || _number == 10 || _number == 11 || _number == 12 || _number == 13 || _number == 16 || _number == 17);
        if (ac)
        {
            Meta3.SetActive(true);

        }
        else
        {
            Meta3.SetActive(false);
        }

        bool ad = (_number == 14 || _number == 15 || _number == 20 || _number == 21);
        if (ad)
        {
            Meta4.SetActive(true);

        }
        else
        {
            Meta4.SetActive(false);
        }

        //Knappene


        //NESTE

    }
    public void ButtonNext()
    {
        if (_number < _EndNumber)
        {
            _number++;
            _textNumber.text = _number.ToString();

        }

        //Tilbake


    }
    public void ButtonPrev()
    {
        if (_number > _startNumber)
        {
            _number--;
            _textNumber.text = _number.ToString();
        }

    }

    //NAV KNAPPER

    public void BtnEn()
    {
        _number = 1;
        _textNumber.text = _number.ToString();
    }

    public void BtnTo()
    {
        _number = 2;
        _textNumber.text = _number.ToString();
    }

    public void BtnTre()
    {
        _number = 3;
        _textNumber.text = _number.ToString();
    }

    public void BtnFire()
    {
        _number = 4;
        _textNumber.text = _number.ToString();
    }

    public void BtnFem()
    {
        _number = 5;
        _textNumber.text = _number.ToString();
    }

    public void BtnSeks()
    {
        _number = 6;
        _textNumber.text = _number.ToString();
    }

    public void BtnSju()
    {
        _number = 7;
        _textNumber.text = _number.ToString();
    }

    public void BtnAatte()
    {
        _number = 8;
        _textNumber.text = _number.ToString();
    }

    public void BtnNi()
    {
        _number = 9;
        _textNumber.text = _number.ToString();
    }

    public void BtnTi()
    {
        _number = 10;
        _textNumber.text = _number.ToString();
    }

    public void BtnElleve()
    {
        _number = 11;
        _textNumber.text = _number.ToString();
    }

    public void BtnTolv()
    {
        _number = 12;
        _textNumber.text = _number.ToString();
    }

    public void BtnTretten()
    {
        _number = 13;
        _textNumber.text = _number.ToString();
    }

    public void BtnFjorten()
    {
        _number = 14;
        _textNumber.text = _number.ToString();
    }

    public void BtnFemten()
    {
        _number = 15;
        _textNumber.text = _number.ToString();
    }

    public void BtnSeksten()
    {
        _number = 16;
        _textNumber.text = _number.ToString();
    }

    public void BtnSytten()
    {
        _number = 17;
        _textNumber.text = _number.ToString();
    }

    public void BtnAtten()
    {
        _number = 18;
        _textNumber.text = _number.ToString();
    }

    public void BtnNitten()
    {
        _number = 19;
        _textNumber.text = _number.ToString();
    }

    public void BtnTjue()
    {
        _number = 20;
        _textNumber.text = _number.ToString();
    }

    public void BtnTjueEn()
    {
        _number = 21;
        _textNumber.text = _number.ToString();
    }

    public void KartH()
    {
        KartMeta1.SetActive(true);

        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }

    public void KartH2()
    {
        KartMeta2.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);


    }

    public void KartH3()
    {
        KartMeta3.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);


    }

    public void KartH4()
    {
        KartMeta4.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }

    public void KartH5()
    {
        KartMeta5.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }


    public void KartF1()
    {
        KartMeta6.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }

    public void KartB1()
    {
        KartMeta7.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }

    public void KartB2()
    {
        KartMeta8.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta9.SetActive(false);
        KartMeta10.SetActive(false);

    }

    public void KartB3()
    {
        KartMeta10.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta9.SetActive(false);

    }

    public void KartS1()
    {
        KartMeta9.SetActive(true);

        KartMeta1.SetActive(false);
        KartMeta2.SetActive(false);
        KartMeta3.SetActive(false);
        KartMeta4.SetActive(false);
        KartMeta5.SetActive(false);
        KartMeta6.SetActive(false);
        KartMeta7.SetActive(false);
        KartMeta8.SetActive(false);
        KartMeta10.SetActive(false);

    }


}