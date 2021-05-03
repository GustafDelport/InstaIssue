namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ClientContext
    {
        private ClientControlType controlType;

        public ClientContext(ClientControlType controlType)
        {
            this.controlType = controlType;
        }

        public void doWork()
        {
            controlType.doWork();
        }
    }
}
