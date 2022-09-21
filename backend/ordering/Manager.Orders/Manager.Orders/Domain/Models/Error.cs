namespace Manager.Orders.Domain.Models;

public readonly record struct Error(DateTime Date, string Message);