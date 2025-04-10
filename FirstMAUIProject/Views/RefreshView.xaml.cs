using System.Text;
using System;

namespace FirstMAUIProject.Views;

public partial class RefreshView : ContentView
{
    private Random random;
    public RefreshView()
	{
		InitializeComponent(); 
		this.pullToRefresh.Refreshing += PullToRefresh_Refreshing;
        this.random = new Random();
    }

    private async void PullToRefresh_Refreshing(object sender, EventArgs e)
    {
        this.pullToRefresh.IsRefreshing = true;
        await Task.Delay(2000);
        this.pullToRefresh.IsRefreshing = false;
        refreshLabel.Text = GetRandomSentence(15);
    }

    public string GetRandomSentence(int wordCount)
    {
        string[] words = { 
            // Nouns (25)
            "apple", "car", "river", "book", "mountain", "teacher", "city", "house", "idea", "phone",
            "ocean", "dog", "bird", "music", "road", "light", "forest", "computer", "cloud", "story",
            "flower", "train", "window", "cake", "game",

            // Verbs (20)
            "run", "jump", "walk", "think", "write", "read", "listen", "talk", "build", "play",
            "eat", "drink", "swim", "drive", "fly", "draw", "sleep", "help", "sing", "smile",

            // Adjectives (15)
            "happy", "blue", "strong", "cold", "bright", "dark", "quiet", "tall", "small", "soft",
            "quick", "clean", "kind", "sharp", "green",

            // Adverbs (15)
            "quickly", "slowly", "happily", "sadly", "loudly", "softly", "brightly", "calmly", "clearly", "easily",
            "silently", "badly", "gently", "bravely", "honestly",

            // Prepositions (10)
            "above", "below", "under", "over", "between", "near", "behind", "inside", "outside", "across",

            // Conjunctions (5)
            "and", "but", "or", "so", "yet",

            // Interjections (5)
            "wow", "hey", "oops", "oh", "yay",

            // Pronouns (15)
            "he", "she", "they", "we", "it", "I", "you", "me", "him", "her",
            "us", "them", "my", "your", "our" 
        };

        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < wordCount; i++)
        {
            // Select a random word from the array
            builder.Append(words[random.Next(words.Length)]).Append(" ");
        }

        string sentence = builder.ToString().Trim() + ". ";

        // Set the first letter of the first word in the sentenece to uppercase
        sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

        builder = new StringBuilder();
        builder.Append(sentence);

        return builder.ToString();
    }
}