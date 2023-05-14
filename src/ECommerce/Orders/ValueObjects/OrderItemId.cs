﻿namespace ECommerce.Orders.ValueObjects;

using Exceptions;

public record OrderItemId
{
    public Guid Value { get; }

    private OrderItemId(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidOrderItemIdExceptions(value);

        Value = value;
    }

    public static OrderItemId Of(Guid value)
    {
        return new OrderItemId(value);
    }

    public static implicit operator Guid(OrderItemId orderItemId) => orderItemId.Value;
}
