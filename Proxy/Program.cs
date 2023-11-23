using Proxy;

Console.WriteLine( "Proxy Design Pattern example" );
Console.WriteLine();

TVColtroller tvController = new();
var tvRemote = new TVRemote( tvController );

Console.WriteLine("Testing the remote:");
tvRemote.Start();
tvRemote.ChannelUp();
tvRemote.VolumeUp();
tvRemote.Stop();
