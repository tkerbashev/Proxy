namespace Proxy
{
    public interface ITVController
    {
        void Start();
        void Stop();
        void ChannelUp();
        void ChannelDown();
        void VolumeUp();
        void VolumeDown();
    }
}
