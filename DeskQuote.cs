using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_Moses
{
    public class DeskQuote
    {
        private Desk desk;
        private string customerName;
        private int rushDays;
        private double? quotePrice;
        private DateTime quoteDate;

        public DeskQuote(Desk desk, string customerName, int rushDays, DateTime quoteDate)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.rushDays = rushDays;
            this.quoteDate = quoteDate; 
        }
        public DateTime GetQuoteDate()
        {
            return quoteDate;
        }
        public DateTime GetEstimatedCompletionDate()
        {
            return quoteDate.AddDays(rushDays); // Adding rushDays to the quoteDate
        }

        public string GetName()
        {
            return this.customerName;
        }

        public int GetRushDays()
        {
            return this.rushDays;
        }

        public double? GetQuotePrice()
        {
            return this.quotePrice;
        }

        public Desk GetDesk()
        {
            return this.desk;
        }

        public double CalculateQuote()
        {
            double basePrice = 200;
            double drawerPrice = 50 * desk.NumberOfDrawers;
            double surfacePrice = 0;

            if (desk.GetSurfaceArea() > 1000)
                surfacePrice = desk.GetSurfaceArea() - 1000;

            double materialPrice = 0;
            switch (desk.Material)
            {
                case DesktopMaterial.Laminate:
                    materialPrice = 100;
                    break;
                case DesktopMaterial.Oak:
                    materialPrice = 200;
                    break;
                case DesktopMaterial.Rosewood:
                    materialPrice = 300;
                    break;
                case DesktopMaterial.Veneer:
                    materialPrice = 125;
                    break;
                case DesktopMaterial.Pine:
                    materialPrice = 50;
                    break;
            }

            double rushOrderPrice = 0;
            if (rushDays == 3)
            {
                if (desk.GetSurfaceArea() < 1000)
                    rushOrderPrice = 60;
                else if (desk.GetSurfaceArea() <= 2000)
                    rushOrderPrice = 70;
                else
                    rushOrderPrice = 80;
            }
            else if (rushDays == 5)
            {
                if (desk.GetSurfaceArea() < 1000)
                    rushOrderPrice = 40;
                else if (desk.GetSurfaceArea() <= 2000)
                    rushOrderPrice = 50;
                else
                    rushOrderPrice = 60;
            }
            else if (rushDays == 7)
            {
                if (desk.GetSurfaceArea() < 1000)
                    rushOrderPrice = 30;
                else if (desk.GetSurfaceArea() <= 2000)
                    rushOrderPrice = 35;
                else
                    rushOrderPrice = 40;
            }

            quotePrice = basePrice + drawerPrice + surfacePrice + materialPrice + rushOrderPrice;
            return quotePrice.Value;
        }

        public double GetQuote()
        {
            if (!quotePrice.HasValue)
                return CalculateQuote();
            else
                return quotePrice.Value;
        }
    }
}
