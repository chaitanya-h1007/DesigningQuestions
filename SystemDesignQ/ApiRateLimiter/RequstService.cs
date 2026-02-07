namespace ApiRateLimiter
{
    
    public class RequestService
    {
        public readonly static Dictionary<string, List<DateTime>> RequestStorage = new Dictionary<string, List<DateTime>>();


         private readonly object _lock = new object();

        private const int MAX_REQUESTS = 5;
        private static readonly TimeSpan WINDOW = TimeSpan.FromSeconds(10);

        public bool AllowRequest(string clientId, DateTime now)
        {
            lock (_lock)
            {
                // Create entry for new client
                if (!RequestStorage.ContainsKey(clientId))
                {
                    RequestStorage[clientId] = new List<DateTime>();
                }

                List<DateTime> recentRequests = RequestStorage[clientId];

                // Remove timestamps outside the sliding window
                DateTime windowStart = now - WINDOW;
                recentRequests.RemoveAll(time => time < windowStart);

                // Check rate limit
                if (recentRequests.Count >= MAX_REQUESTS)
                {
                    return false; // Rate limit exceeded
                }

                // Allow request and record timestamp
                recentRequests.Add(now);
                return true;
            }
        }
    }
}