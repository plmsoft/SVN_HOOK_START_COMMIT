namespace PLM.Start_commit
{
    internal class MessageLogItem
    {
        public string Message { get; private set; }
        public TypeLogItem TypeMessage { get; private set; }

        public MessageLogItem(string message, TypeLogItem type)
        {
            Message = message;
            TypeMessage = type;
        }
    }
}
