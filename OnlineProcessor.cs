﻿namespace SOLID.OCP
{
    public class OnlineProcessor : PaymentProcessor
    {
        protected override void WithdrawMoney() { }

        protected override void CalculateBonus() { }

        protected override void SendGreetings() { }
    }
}