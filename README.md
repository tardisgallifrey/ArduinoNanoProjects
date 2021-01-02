<h1>Arduino Nano Library Projects<h1>

Just got this started, but stay tuned for more.  This will be the github for 
my Arudino Nano C# Libraries.  These will/should end up with Nuget Packages.

<hr>
This github will build in .NET 5.0 (I know it works in Linux)  Windows users,
adapt as needed.

Quickie Use:

requires: "using NanoSerialLib;"  

Class object is: Board()
Three class methods: 
Board.Read() -- Returns a string.
Board.Write() -- Sends a string.
Board.Close() -- Closes arduino serial port.

var myNano = new Board(9600, "/dev/ttyxxx); "an integer for baud rate. "a string for serial port
on your machine."

Hint: You should consider these two bits of info coming through command line args.


string message;
message = myNano.Read();

message = "This is a message.";
myNano.Write(message);

myNano.Close();  -- DO NOT CLOSE until very end of use.