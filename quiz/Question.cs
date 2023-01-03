using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace quiz
{
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public class Question
    {
        public int Id;
        [JsonProperty("question")]
        public string Description;
        public Dictionary<string, string> Answers;
        [JsonProperty("correct_answers")]
        public Dictionary<string, string> CorrectAnswers;
        public Boolean MultipleCorrectAnswers;
        public Difficulty Difficulty;

    }
}
