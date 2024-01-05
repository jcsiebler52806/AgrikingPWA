using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Currency
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Symbol { get; set; }

    public string? NetSuiteId { get; set; }

    public virtual ICollection<CommissionDetail> CommissionDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<CreditMemo> CreditMemos { get; set; } = new List<CreditMemo>();

    public virtual ICollection<CurrencyExchangeRate> CurrencyExchangeRateBaseCurrencies { get; set; } = new List<CurrencyExchangeRate>();

    public virtual ICollection<CurrencyExchangeRate> CurrencyExchangeRateTransactionCurrencies { get; set; } = new List<CurrencyExchangeRate>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<ItemPrice> ItemPrices { get; set; } = new List<ItemPrice>();

    public virtual ICollection<MillAllocation> MillAllocations { get; set; } = new List<MillAllocation>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();
}
