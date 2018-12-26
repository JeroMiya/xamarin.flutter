using Android.Util;
using System;

namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A named channel for communicating with the Flutter application using basic, asynchronous message passing.
     *
     * <p>Messages are encoded into binary before being sent, and binary messages received are decoded
     * into Java objects. The {@link MessageCodec} used must be compatible with the
     * one used by the Flutter application. This can be achieved by creating a
     * <a href="https://docs.flutter.io/flutter/services/BasicMessageChannel-class.html">BasicMessageChannel</a>
     * counterpart of this channel on the Dart side. The static Java type of messages sent and received
     * is {@code Object}, but only values supported by the specified {@link MessageCodec} can be used.</p>
     *
     * <p>The logical identity of the channel is given by its name. Identically named channels will interfere
     * with each others communication.</p>
     */
    public class BasicMessageChannel<T> where T : class
    {
        private static readonly string TAG = "BasicMessageChannel#";

        private readonly IBinaryMessenger _messenger;
        private readonly string _name;
        private readonly IMessageCodec<T> _codec;

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and {@link MessageCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         * @param codec a {@link MessageCodec}.
         */
        public BasicMessageChannel(IBinaryMessenger messenger, string name, IMessageCodec<T> codec)
        {
            //assert messenger != null;
            //assert name != null;
            //assert codec != null;
            _messenger = messenger;
            _name      = name;
            _codec     = codec;
        }

        /**
         * Sends the specified message to the Flutter application on this channel.
         *
         * @param message the message, possibly null.
         */
        public void Send(T message)
        {
            Send(message, null);
        }

        /**
         * Sends the specified message to the Flutter application, optionally expecting a reply.
         *
         * <p>Any uncaught exception thrown by the reply callback will be caught and logged.</p>
         *
         * @param message the message, possibly null.
         * @param callback a {@link Reply} callback, possibly null.
         */
        public void Send(T message, IReply callback)
        {
            _messenger.Send(
                _name,
                _codec.EncodeMessage(message),
                callback == null ? null : new IncomingReplyHandler(callback, _name, _codec));
        }

        /**
         * Registers a message handler on this channel for receiving messages sent from the Flutter
         * application.
         *
         * <p>Overrides any existing handler registration for (the name of) this channel.</p>
         *
         * <p>If no handler has been registered, any incoming message on this channel will be handled silently
         * by sending a null reply.</p>
         *
         * @param handler a {@link MessageHandler}, or null to deregister.
         */
        public void SetMessageHandler(IMessageHandler handler)
        {
            _messenger.SetMessageHandler(
                _name,
                handler == null ? null : new IncomingMessageHandler(handler, _name, _codec));
        }

        /**
         * A handler of incoming messages.
         */
        public interface IMessageHandler
        {
            /**
             * Handles the specified message received from Flutter.
             *
             * <p>Handler implementations must reply to all incoming messages, by submitting a single reply
             * message to the given {@link Reply}. Failure to do so will result in lingering Flutter reply
             * handlers. The reply may be submitted asynchronously.</p>
             *
             * <p>Any uncaught exception thrown by this method, or the preceding message decoding, will be
             * caught by the channel implementation and logged, and a null reply message will be sent back
             * to Flutter.</p>
             *
             * <p>Any uncaught exception thrown during encoding a reply message submitted to the {@link Reply}
             * is treated similarly: the exception is logged, and a null reply is sent to Flutter.</p>
             *
             * @param message the message, possibly null.
             * @param reply a {@link Reply} for sending a single message reply back to Flutter.
             */
            void OnMessage(T message, IReply reply);
        }

        /**
         * Message reply callback. Used to submit a reply to an incoming
         * message from Flutter. Also used in the dual capacity to handle a reply
         * received from Flutter after sending a message.
         */
        public interface IReply
        {
            /**
             * Handles the specified message reply.
             *
             * @param reply the reply, possibly null.
             */
            void Reply(T reply);
        }

        private class ReplyImpl : IReply
        {
            public Action<T> OnReply;

            /// <inheritdoc />
            public void Reply(T reply)
            {
                OnReply?.Invoke(reply);
            }
        }

        private class IncomingReplyHandler : IBinaryReply
        {
            private readonly IReply _callback;
            private readonly string _name;
            private readonly IMessageCodec<T> _codec;

            public IncomingReplyHandler(IReply callback, string name, IMessageCodec<T> codec)
            {
                _callback = callback;
                _name     = name;
                _codec    = codec;
            }

            //@Override
            // TODO: ByteBuffer->object
            public void Reply(object reply)
            {
                try
                {
                    _callback.Reply(_codec.DecodeMessage(reply));
                }
                catch (Exception e)
                {
                    Log.Error(TAG + _name, "Failed to handle message reply", e);
                }
            }
        }

        private class IncomingMessageHandler : IBinaryMessageHandler
        {
            private readonly IMessageHandler _handler;
            private readonly string _name;
            private readonly IMessageCodec<T> _codec;

            public IncomingMessageHandler(IMessageHandler handler, string name, IMessageCodec<T> codec)
            {
                _handler = handler;
                _name    = name;
                _codec   = codec;
            }

            //@Override
            //TODO: ByteBuffer->object
            public void OnMessage(object message, IBinaryReply callback)
            {
                try
                {
                    _handler.OnMessage(
                        _codec.DecodeMessage(message),
                        new ReplyImpl
                        {
                            OnReply = (reply) => { callback.Reply(_codec.EncodeMessage(reply)); }
                        });
                }
                catch (Exception e)
                {
                    Log.Error(TAG + _name, "Failed to handle message", e);
                    callback.Reply(null);
                }
            }
        }
    }
}
