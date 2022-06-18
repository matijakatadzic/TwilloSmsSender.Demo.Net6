# Send SMS messages with C# & .net 6

In modern web applications, the business may require to send SMS to end-users in various scopes like Alerting the users, acknowledging the users, or even sending OTP. Sending as SMS is the easiest way and also can be implemented easily in .NET applications using Twilio.

## Setting Up Twilio Account

Twilio two-way SMS and MMS messages allow you to carry on a conversation by both sending and receiving text and multimedia messages. This can enable a contact center agent to engage in an SMS-based chat with a customer, or let customers re-schedule appointments via text and receive automated responses.

1. Try / Create a free account – https://www.twilio.com/try-twilio
2. Choose the Service which we want like SMS, WhatsApp, Voice and etc from the option.
3. Get a Virtual Twilio Phone Number to Send & Recieve SMS

## Sending SMS in.NET Application

For this article example, let’s create a simple Api application that has one post object with two fields, one is to enter the Receiver Phone Number and another is for Message Content.

Install the required Twilio NuGet package, for that navigate to Tools and search Twilio.

## C# Code Implementation

Create a service and needed method for sending SMS.
Now run the application and enter the receiver’s phone number and message content.

## Conclusion
In this simple article, we discussed how to send SMS using Twilio in C# and the .NET applications. We will discuss more on this in upcoming articles. I hope you all liked this article and please feel free to share your feedback in the comment section.
