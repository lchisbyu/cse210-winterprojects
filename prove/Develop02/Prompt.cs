using System;

class Prompt // methods and properties specific to the Prompt class go here
{

    public string GetRandomPrompt()
    {
        var randomPrompt = new Random();
        var list = new List<string>
        {
            "What was the highlight of your day?"
            ,"Did you make good use of your time today?"
            ,"What was the best part of your day today?"
            ,"Did you think to pray today for something?"
            ,"What got you in a writing mood?"
            ,"Tell me something important"
            ,"What would you change for tomorrow to make your day better?"
            ,"What did you do to bring others to the Savior and his gospel?"
            ,"What made you think about the Savior today?"
            ,"If you met the Savior today, what would you say? what would you ask?"
            ,"Reflect on a time when you overcame a fear or obstacle."
            ,"What goal can you set to be a better person?"
            ,"How can you serve someone else today?"
            ,"What did you do to be kind to your spouse today?"
            ,"Do you like who you are? If yes why? If no why? and what would you do to change it for the better?"
            ,"If it were the last day of the world would you be satisfied with your life?"
            ,"Write about a person who has had a significant impact on your life"
            ,"What area of your improvement wheel for yourself improved for you?"
            ,"How did you include the Holy Ghost in your decisions?"
            ,"Think about how you helped yourself to be healthy and describe it and what you think you could do better?"
            ,"Describe a moment of pure joy or happiness"
            ,"Think about a decision you made that you now regret and explore your emotions surrounding it"
            ,"Write about a place that holds a special meaning to you"
            ,"Think about a time when you felt truly content and explain why"
            ,"Describe an act of kindness you witnessed or experienced"
            ,"Write about a challenge you faced and how you overcame it"
            ,"Did you teach someone something you know to empower them for a better life or to be closer to the Savior?"
            ,"Reflect on a mistake you made and what you learned from it"
            ,"Describe a person, place, or thing that makes you feel nostalgic."
            ,"Did you reach out to a family member this week?"
            ,"List three things you're grateful for today"
            ,"Describe a difficult conversation you had and how you handled it"
            ,"Write about a time when you felt proud of yourself"
            ,"Reflect on a time when you learned something new about yourself"
            ,"Describe a person who inspires you and why"
            ,"Write about a time when you felt truly connected to others"
            ,"Reflect on a time when you felt disconnected or alone"
            ,"Describe a moment of beauty you witnessed today"
            ,"Write about a goal you're working towards and how you plan to achieve it"
            ,"Reflect on a time when you showed compassion or empathy towards someone."
        };
        int index = randomPrompt.Next(list.Count);
        return list[index];
    }
}