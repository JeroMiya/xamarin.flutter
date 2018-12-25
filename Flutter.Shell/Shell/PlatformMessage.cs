using System;

namespace Flutter.Framework.Shell
{
    public class PlatformMessage<TRequestData, TResponseData> where TRequestData : class
    {
        public long Id { get; set; }
        public string Channel { get; }
        public TRequestData RequestData { get; }
        public TResponseData ResponseData { get; set; }
        public Action<TResponseData> OnResponse { get; set; }

        public PlatformMessage(string channel, TRequestData requestData)
        {
            Channel = channel;
            RequestData = requestData;
        }

        public void OnResponseData(TResponseData responseData)
        {
            ResponseData = responseData;
            OnResponse?.Invoke(responseData);
        }
    }

    /// <inheritdoc />
    public class PlatformMessage<TRequestData> : PlatformMessage<TRequestData, object> where TRequestData : class
    {
        /// <inheritdoc />
        public PlatformMessage(string channel, TRequestData requestData) : base(channel, requestData) { }
    }

    public class PlatformMessage : PlatformMessage<object, object>
    {
        /// <inheritdoc />
        public PlatformMessage(string channel, object requestData) : base(channel, requestData) { }
    }

}
