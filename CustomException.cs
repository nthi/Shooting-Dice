// using System;

// //I think I have to create a custom exception for the Sore Loser when they lose. I am not sure what constructors/etc. need to be here. this is from the microsoft page https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-localized-exception-messages
// //https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions?source=recommendations

// namespace ShootingDice
// {

//     public class LoserException : Exception
//     {
//         //no idea how to make this ... constructor? work?
//         public LoserException() {}

//         //I think these are if we need a message to pop up? I do not know if I should have these.
//         public LoserException(string message)
//             : base(message) {}
//         public LoserException(string message, Exception inner)
//             : base(message, inner) {}
//     }

// }