namespace EmpyrionNetAPIAccess
{
    public enum Timeouts
    {
        /// <summary>
        /// No Timeout waiting for an Response
        /// </summary>
        NoResponse = 0,
        /// <summary>
        /// Timeout after 1s
        /// </summary>
        Wait1s = 1,
        /// <summary>
        /// Timeout after 10s
        /// </summary>
        Wait10s = 10,
        /// <summary>
        /// Timeout after 20s
        /// </summary>
        Wait20s = 20,
        /// <summary>
        /// Timeout after 20s
        /// </summary>
        Wait30s = 30,
        /// <summary>
        /// Timeout after 1m
        /// </summary>
        Wait1m = 60,
        /// <summary>
        /// Timeout after 10m
        /// </summary>
        Wait10m = 600
    }

}
