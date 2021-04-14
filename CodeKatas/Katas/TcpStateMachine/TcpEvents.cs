namespace CodeKatas.Katas.TcpStateMachine
{
    public static class TcpEvents
    {
        public const string AppPassiveOpen = "APP_PASSIVE_OPEN";
        public const string AppActiveOpen = "APP_ACTIVE_OPEN";
        public const string AppSend = "APP_SEND";
        public const string AppClose = "APP_CLOSE" ;
        public const string AppTimeout  = "APP_TIMEOUT";
        public const string RcvSyn = "RCV_SYN";
        public const string RcvAck = "RCV_ACK";
        public const string RcvSynAck = "RCV_SYN_ACK";
        public const string RcvFin = "RCV_FIN";
        public const string RcvFinAck = "RCV_FIN_ACK";
    }
}