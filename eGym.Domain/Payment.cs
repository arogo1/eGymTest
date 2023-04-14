using System;
using System.ComponentModel.DataAnnotations;

namespace eGym.Domain;

public class Payment
{
    public int PaymentId { get; set; }

    public string CardNumber { get; set; }

    public DateTime ExpireDate { get; set; }

    public int CCV { get; set; }

    public string CardHolderName { get; set; }

    public double Amount { get; set; }

    public int AccountId { get; set; }
}

