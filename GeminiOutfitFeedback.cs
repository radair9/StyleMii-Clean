using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class GeminiOutfitFeedback
{
    public string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");

    public async Task<string> GetClothingFeedback(string img1, string img2, string img3)
    {
        string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={apiKey}";

        using (var client = new HttpClient())
        {
            string b64_1 = Convert.ToBase64String(File.ReadAllBytes(img1));
            string b64_2 = Convert.ToBase64String(File.ReadAllBytes(img2));
            string b64_3 = Convert.ToBase64String(File.ReadAllBytes(img3));

            var payload = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new object[]
                        {
                            new { inline_data = new { mime_type = "image/png", data = b64_1 } },
                            new { inline_data = new { mime_type = "image/png", data = b64_2 } },
                            new { inline_data = new { mime_type = "image/png", data = b64_3 } },
                            new { text = "Analyse these clothing items and give honest, detailed fashion feedback. Comment on colour harmony, fit, style coherence, and how well they match the model. Be direct but constructive. Do not comment on what the model is wearing in the photo, disregard it and just place the selected clothes on the model. Short and snappy feedback, give a solid yes or no at the very start don't beat around the bush. Do not just be agreeable. Be completely honest, it is highly important you provide the correct feedback." }
                        }
                    }
                }
            };

            string json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);
            string responseJson = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();

            using (JsonDocument doc = JsonDocument.Parse(responseJson))
            {
                var root = doc.RootElement;

                var candidates = root.GetProperty("candidates");
                var firstCandidate = candidates[0];

                JsonElement contentElement = firstCandidate.GetProperty("content");

                JsonElement partsElement;

                // Handle both array and object formats
                if (contentElement.ValueKind == JsonValueKind.Array)
                {
                    partsElement = contentElement[0].GetProperty("parts");
                }
                else
                {
                    partsElement = contentElement.GetProperty("parts");
                }

                // Extract TEXT instead of inline_data
                foreach (var part in partsElement.EnumerateArray())
                {
                    if (part.TryGetProperty("text", out JsonElement textElement))
                    {
                        return textElement.GetString();
                    }
                }

                throw new Exception("No text feedback found in Gemini response.");
            }
        }
    }
}
