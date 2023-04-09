using System;
using System.ComponentModel.DataAnnotations;

namespace eGym.BLL.Models.Requests;

public class PaymentRequest
{
    [Required(ErrorMessage = "You have to provide Card Number")]
    public string CardNumber { get; set; }

    [Required(ErrorMessage = "You have to provide Expire Date")]
    public DateTime ExpireDate { get; set; }

    [Required(ErrorMessage = "You have to provide CCV")]
    public int CCV { get; set; }

    [Required(ErrorMessage = "You have to provide Card holder name")]
    public string CardHolderName { get; set; }

    [Required(ErrorMessage = "You have to provide Amount")]
    public double Amount { get; set; }

    [Required(ErrorMessage = "You have to provide Accoount id")]
    public int AccountId { get; set; }
}

