using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.view
{
    public class Auto
    {

        public int ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public decimal Hinta 
        {
            get
            {
                return Hinta;
            }
            set
            {
                Hinta = value;
            }
        }
        public DateTime Rekisteri_paivamaara
        {
            get
            {
                return Rekisteri_paivamaara;
            }
            set
            {
                Rekisteri_paivamaara = value;
            }
        }
        public decimal Moottorin_tilavuus
        {
            get
            {
                return Moottorin_tilavuus;
            }
            set
            {
                Moottorin_tilavuus = value;
            }
        }
        public int Mittarilukema 
        { 
            get 
            { 
                return Mittarilukema; 
            }
            set
            {
                Mittarilukema = value;
            }
        }
        public int AutonMerkkiID 
        {
            get
            { 
                return AutonMerkkiID; 
            }
            set
            {
                AutonMerkkiID = value;
            }
        }
        public int AutonMalliID
        {
            get
            {
                return AutonMalliID;
            }
            set
            {
                AutonMalliID = value;
            }
        }
        public int VaritID 
        {
            get
            {
                return VaritID;
            }
            set
            {
                VaritID = value;
            }
        }
        public int PolttoaineID
        {
            get
            {
                return PolttoaineID;
            }
            set
            {
                PolttoaineID = value;
            }
        }
    }
}
