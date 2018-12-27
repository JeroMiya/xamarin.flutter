using System;

namespace FlutterBinding.Shell
{
    public class PlatformMessage
    {
        public long Id { get; set; }
        public string Channel { get; }
        public object RequestData { get; }
        public object ResponseData { get; private set; }
        public Action<object> OnResponse { get; set; }

        public PlatformMessage(string channel, object requestData, Action<object> onResponse = null)
        {
            Channel     = channel;
            RequestData = requestData;
            OnResponse  = onResponse;
        }

        public void OnResponseData(object responseData)
        {
            ResponseData = responseData;
            OnResponse?.Invoke(responseData);
        }
    }

    /*
    public class PlatformMessage<TRequestData, TResponseData> : PlatformMessage
        where TRequestData : class
        where TResponseData : class
    {
        /// <inheritdoc />
        public PlatformMessage(string channel, TRequestData requestData, Action<TResponseData> onResponse) : base(channel, requestData)
        {
            OnResponse = (data) => onResponse?.Invoke(data as TResponseData);
        }

        public TRequestData GetRequestData()
        {
            return RequestData as TRequestData;
        }

        public TResponseData GetResponseData()
        {
            return ResponseData as TResponseData;
        }

        public void OnResponseData(TResponseData responseData)
        {
            ResponseData = responseData;
            OnResponse?.Invoke(responseData);
        }
    }

    /// <inheritdoc />
    public class PlatformMessage<TRequestData> : PlatformMessage where TRequestData : class
    {
        /// <inheritdoc />
        public PlatformMessage(string channel, TRequestData requestData) : base(channel, requestData) { }

        public TRequestData GetRequestData()
        {
            return RequestData as TRequestData;
        }
    }
    */
}
