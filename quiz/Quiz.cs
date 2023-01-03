using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace quiz
{
    public class Quiz
    {
        private HttpClient Client;
        private static string URI = "https://quizapi.io/api/v1/questions";
        public Question CurrentQuestion;
        public Queue<Question> QuestionQueue;
        public int QuestionCount;

        private int _correctAnswerCount;
        public int CorrectAnswerCount
        {
            get => _correctAnswerCount;
            private set 
            {
                _correctAnswerCount = value; 
            }
        }

        public int QuestionsLeft
        {
            get => QuestionQueue.Count;
        }

        public int CurrentQuestionNumber
        {
            get => QuestionCount - QuestionsLeft;
        }

        /// <summary>
        /// Load api-key from txt file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string LoadApiKey(string path)
        {
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding uTF8 = new(true);
                string key = "";
                if (fs.Read(b, 0, b.Length) > 0)
                {
                    key = uTF8.GetString(b);
                }

                return key.Replace("\0", string.Empty);
            }
        }

        public Quiz(int questionCount, Difficulty chosenDifficulty)
        {
            QuestionCount = questionCount;
            Client = new();

            // An API-key is required. 
            // https://quizapi.io/
            Client.DefaultRequestHeaders.Add("x-api-key", LoadApiKey("api-key.txt"));
            QuestionQueue = new();

            LoadNewQuestions(questionCount, chosenDifficulty);
            NextQuestion();
        }

        public void LoadNewQuestions(int questionCount, Difficulty chosenDifficulty)
        {
            Task<Question[]?> task = RequestQuestion(questionCount > 0 ? questionCount : 1, chosenDifficulty);
            task.Wait();

            foreach (Question question in task.Result)
            {
                QuestionQueue.Enqueue(question);
            }
        }

        public void LoadNewQuestions(int questionCount)
        {
            LoadNewQuestions(questionCount, Difficulty.Easy);
        }


        public bool NextQuestion()
        {
            if (QuestionQueue.Count == 0)
                return false;

            CurrentQuestion = QuestionQueue.Dequeue();
            return true;
        }

        private Question[]? ParseQuestion(string serializedJson)
        {
            return JsonConvert.DeserializeObject<Question[]>(serializedJson);
        }

        public async Task<Question[]?> RequestQuestion(int quantity, Difficulty chosenDifficulty)
        {
            var builder = new UriBuilder(URI);
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["limit"] = quantity.ToString();
            query["difficulty"] = chosenDifficulty.ToString();
            builder.Query = query.ToString();

            string url = builder.ToString();

            string responseBody = "";
            try
            {
                using HttpResponseMessage response = await Client.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException caught");
                Console.WriteLine("Message: {0}", e.Message);
                Environment.Exit(0);
            }

            return ParseQuestion(responseBody);
        }

        public bool CheckAnswer(string answerKey)
        {
            answerKey += "_correct";

            if (CurrentQuestion.CorrectAnswers[answerKey] == "true")
            {
                CorrectAnswerCount++;

                return true;
            }
            else return false;
        }

        public bool CheckAnswer(int answerInd)
        {
            return CheckAnswer("answer_" + (char)(answerInd + 'a'));
        }
    }
}
