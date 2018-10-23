using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideo(string user)
        {
            try
            {
                // Access YouTube web service
                // Read data -xml, parse...
                // create list of video objects
                throw new Exception("Oops, again...");
            }
            catch (Exception ex)
            {
                // Log

                throw new YouTubeException("Could not fetch the video from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}