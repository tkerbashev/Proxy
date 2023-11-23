namespace Proxy
{
    public class TVRemote : ITVController
    {
        ITVController _controller;
        public TVRemote(ITVController controller)
        {
            _controller = controller;
        }
        public void ChannelDown( )
        {
            _controller.ChannelDown( );
        }

        public void ChannelUp( )
        {
            _controller?.ChannelUp( );
        }

        public void Start( )
        {
            _controller.Start( );
        }

        public void Stop( )
        {
            _controller.Stop( );
        }

        public void VolumeDown( )
        {
            _controller.VolumeDown( );
        }

        public void VolumeUp( )
        {
            _controller.VolumeUp( );
        }
    }
}
