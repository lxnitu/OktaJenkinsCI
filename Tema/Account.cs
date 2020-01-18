using System;

namespace Tema
{
    public class Account
    {
        private decimal m_Sold;

        public decimal Sold
        {
            get
            {
                return m_Sold;
            }
            private set
            {
                m_Sold = value;

                if (SoldChanged != null)
                    SoldChanged(null, new EventArgs());
            }
        }


        public event EventHandler<EventArgs> SoldChanged;

        public void LoadSold(decimal sold)
        {
            Sold += sold;
        }

        public void Withdraw(decimal value)
        {
            if (Sold >= value)
                Sold -= value;
            else
                throw new ArgumentException(nameof(value), "Retragerea depaseste soldul!");
        }

        public void Transfer(decimal value, Account destination)
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination), "Nu a fost furnizat contul destinatie!");
            else
            {
                Withdraw(value);
                destination.LoadSold(value);
            }
        }
    }
}
