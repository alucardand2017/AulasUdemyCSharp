using System;
using System.Globalization;
using ExInterface.Entities;
using ExInterface.Services;

namespace ExInterface.Services
{
    class Rentalservice
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;
       
        public Rentalservice(double pricePerHour, double pricePerDay, ITaxService taxService) // inversão de controle por injeção de dependencia através o parametro Itaxservice
        { 
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }
       
        public void ProcessInvoice(CarRental carRental)
        {
            double total;
            TimeSpan time = carRental.Finish.Subtract(carRental.Start);
            if (time.TotalHours > 12)
                 total = PricePerDay * Math.Ceiling(time.TotalDays);
            else
                 total = PricePerHour * Math.Ceiling(time.TotalHours);
            double tax = _TaxService.Tax(total);
            carRental.Invoice = new Invoice(total, tax); //repare que esse objeto Invoice não foi criado no momento da criação do carRental, só agora.
        }

    }
}
