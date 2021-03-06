﻿using P2PSocket.Core;
using P2PSocket.Core.Models;
using P2PSocket.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace P2PSocket.Server.Models.Send
{
    public class Msg_0x0301 : SendPacket
    {
        public Msg_0x0301(LogLevel logLevel, string msg,string sourceClientName = "Server") : base(P2PCommandType.Msg0x0301)
        {
            BinaryUtils.Write(Data, logLevel);
            BinaryUtils.Write(Data, msg);
            BinaryUtils.Write(Data, sourceClientName);
        }
    }
}
