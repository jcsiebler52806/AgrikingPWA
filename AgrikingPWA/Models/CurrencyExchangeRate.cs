using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CurrencyExchangeRate
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? BaseCurrencyId { get; set; }

    public string? TransactionCurrencyId { get; set; }

    public DateTime EffectiveDate { get; set; }

    public decimal ExchangeRate { get; set; }

    public virtual Currency? BaseCurrency { get; set; }

    public virtual Currency? TransactionCurrency { get; set; }
}
