using FlutterBinding.Engine;
using System;
using FlutterBinding.UI;

namespace FlutterBinding.Shell
{
    public class PlatformMessage
    {
        public long Id { get; set; }
        public string Channel { get; }
        public object RequestData { get; }
        public object ResponseData { get; private set; }
        public PlatformMessageResponse ResponseMessage { get; set; }

        public bool HasData => RequestData != null;
        
        public PlatformMessage(string channel, object requestData, PlatformMessageResponse responseMessage = null)
        {
            Channel     = channel;
            RequestData = requestData;
            ResponseMessage = responseMessage;
        }

        public void OnResponseData(object responseData)
        {
            ResponseData = responseData;
            ResponseMessage?.Complete(responseData);
        }
    }

    public class PlatformMessageResponse
    {
        private readonly int _responseId;
        private readonly PlatformMessageResponseCallback _callback;
        private readonly TaskRunner _uiTaskRunner;

        public object Message { get; private set; }
        public bool IsComplete { get; set; }

        public PlatformMessageResponse(
            PlatformMessageResponseCallback callback,
            TaskRunner uiTaskRunner)
        {
            _callback     = callback;
            _uiTaskRunner = uiTaskRunner;
        }

        public PlatformMessageResponse(
            int responseId,
            TaskRunner uiTaskRunner)
        {
            _responseId   = responseId;
            _uiTaskRunner = uiTaskRunner;
        }

        // Callable on any thread.
        public void Complete(object data)
        {
            IsComplete = true;
            Message = data;
            _uiTaskRunner.RunNowOrPostTask(() => _callback(this));
        }

        public void CompleteEmpty() => Complete(null);
    }
}
