namespace RingCentral
{
    public partial class InstantMessageNotification
    {
        // Universally unique identifier of a notification
        public string @uuid { get; set; }
        // Event filter URI
        public string @event { get; set; }
        // Internal identifier of a subscription
        public string @subscriptionId { get; set; }
        // Datetime of sending a notification in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @timestamp { get; set; }
        // Notification payload body
        public InstantMessageEvent @body { get; set; }
    }
}
