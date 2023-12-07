using Proxy;

Console.WriteLine( "Proxy Structural Design Pattern example\n" );

TVColtroller tvController = new();
var tvRemote = new TVRemote( tvController );

Console.WriteLine("Testing the remote:");
tvRemote.Start();
tvRemote.ChannelUp();
tvRemote.VolumeUp();
tvRemote.Stop();
