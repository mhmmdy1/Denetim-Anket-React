using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.api.Token
{
    public static class Validator
    {
        private const int _expirationMinutes = 10;

        public static bool IsTokenValid(string token)
        {
            bool result = false;

            try
            {
                // Base64 decode the string, obtaining the token:username:timeStamp.
                string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));

                // Split the parts.
                string[] parts = key.Split(new char[] { ':' });
                if (parts.Length == 4)
                {
                    // Get the hash message, username, and timestamp.
                    string hash = parts[0];
                    string apikey = parts[1];
                    string username = parts[2];
                    long ticks = long.Parse(parts[3]);

                    DateTime timeStamp = new DateTime(ticks);

                    // Ensure the timestamp is valid.
                    bool expired = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
                    if (!expired)
                    {
                        //
                        // Lookup the user's account from the db.
                        //
                        if (username == "john")
                        {
                            string password = "password";

                            // Hash the message with the key to generate a token.
                            string computedToken = Generator.GenerateToken(apikey, username, password, ticks);

                            // Compare the computed token with the one supplied and ensure they match.
                            result = (token == computedToken);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
