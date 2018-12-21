using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

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
        private static string TAG = "BasicMessageChannel#";

        private BinaryMessenger messenger;
        private string name;
        private MessageCodec<T> codec;

        /**
         * Creates a new channel associated with the specified {@link BinaryMessenger}
         * and with the specified name and {@link MessageCodec}.
         *
         * @param messenger a {@link BinaryMessenger}.
         * @param name a channel name String.
         * @param codec a {@link MessageCodec}.
         */
        public BasicMessageChannel(BinaryMessenger messenger, string name, MessageCodec<T> codec)
        {
            //assert messenger != null;
            //assert name != null;
            //assert codec != null;
            this.messenger = messenger;
            this.name = name;
            this.codec = codec;
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
        public void Send(T message, Reply<T> callback)
        {
            messenger.Send(name, codec.EncodeMessage(message),
                callback == null ? null : new IncomingReplyHandler(callback, name, codec));
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
        public void SetMessageHandler(MessageHandler<T> handler)
        {
            messenger.SetMessageHandler(name,
                handler == null ? null : new IncomingMessageHandler(handler, name, codec));
        }

        /**
         * A handler of incoming messages.
         */
        public interface MessageHandler<T>
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
            void OnMessage(T message, Reply<T> reply);
        }

        /**
         * Message reply callback. Used to submit a reply to an incoming
         * message from Flutter. Also used in the dual capacity to handle a reply
         * received from Flutter after sending a message.
         */
        public interface Reply<T>
        {
            /**
             * Handles the specified message reply.
             *
             * @param reply the reply, possibly null.
             */
            void Reply(T reply);
        }

        public class ReplyImpl<T> : Reply<T>
        {
            public Action<T> OnReply;

            /// <inheritdoc />
            public void Reply(T reply)
            {
                OnReply?.Invoke(reply);
            }
        }

        private class IncomingReplyHandler : BinaryReply
        {
            private Reply<T> callback;
            private string name;
            private MessageCodec<T> codec;

            public IncomingReplyHandler(Reply<T> callback, string name, MessageCodec<T> codec)
            {
                this.callback = callback;
                this.name = name;
                this.codec = codec;
            }

            //@Override
            // TODO: ByteBuffer->object
            public void Reply(object reply)
            {
                try
                {
                    callback.Reply(codec.DecodeMessage(reply));
                }
                catch (Exception e)
                {
                    Log.Error(TAG + name, "Failed to handle message reply", e);
                }
            }
        }

        private class IncomingMessageHandler : BinaryMessageHandler
        {
            private MessageHandler<T> handler;
            private string name;
            private MessageCodec<T> codec;

            public IncomingMessageHandler(MessageHandler<T> handler, string name, MessageCodec<T> codec)
            {
                this.handler = handler;
                this.name = name;
                this.codec = codec;
            }

            //@Override
            //TODO: ByteBuffer->object
            public void OnMessage(object message, BinaryReply callback)
            {
                try
                {
                    handler.OnMessage(
                        codec.DecodeMessage(message),
                        new ReplyImpl<T>
                        {
                            OnReply = (reply) => { callback.Reply(codec.EncodeMessage(reply)); }
                        });
                }
                catch (Exception e)
                {
                    Log.Error(TAG + name, "Failed to handle message", e);
                    callback.Reply(null);
                }
            }
        }
    }
}