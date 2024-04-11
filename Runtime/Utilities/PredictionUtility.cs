
namespace VideoKit.Utilities
{
    using Function.Types;

    internal static class PredictionUtility
    {
        public static string GetError(Prediction prediction)
        {
#if !FXN3D_006_OR_LATER
            if (prediction is CloudPrediction cloudPrediction)
            {
                return cloudPrediction.error;
            }
            return null;
#else
            return prediction.error;
#endif
        }
        
        /// <summary>
        /// Gets the results of a prediction.
        /// </summary>
        /// <param name="prediction">The prediction.</param>
        /// <returns>The object array.</returns>
        public static object?[]? GetResults(Prediction prediction)
        {
#if !FXN3D_006_OR_LATER
            if (prediction is CloudPrediction cloudPrediction)
            {
                return cloudPrediction.results;
            }
            return null;
#else
            return prediction.results;
#endif
        }
    }
}