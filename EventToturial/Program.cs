﻿using EventToturial;

var stockMarket = new Stock();
var smsService = new SmsService();
var emailService = new EmailService();

stockMarket.OnPriceChanged += smsService.Send;
stockMarket.OnPriceChanged += emailService.Send;

while (true)
{
    var price = Random.Shared.Next(1, 50001);
    stockMarket.Update(price);
    Thread.Sleep(400);
}
 