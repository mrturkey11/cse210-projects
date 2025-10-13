public static class Prompts
{
    public static string[] prompts = new string[] {
    "If you had a magic wand to solve any one problem what would it be and how would your life change?",
    "If you were unapologetically loved and accepted yourself what would change moving forward?",
    "What are you the best at? What do you love doing the most? How could you spend more time engaging in both activities?",
    "What makes your heart happy? What gives you the greatest thrills?",
    "What do you believe is holding you back in your life? What could you do to change it to serve you?",
    "Where do you see yourself in three months, six months, nine months, and twelve months? Be specific.",
    "What are your top five memories? Why do they hold a special place in your mind?",
    "How would your life change if you woke up and stopped worrying about your past and your future?",
    "What scares you the most and why? How can you tackle this fear so it controls less of your life?",
    "If you could go back in time and tell yourself one piece of advice, what would it be?",
    "What are three things you are looking forward to doing this week? Why?",
    "Who do you need to forgive? What’s stopping you from doing so today?",
    "What opportunities do you have in front of you right now? What’s making you hesitate to decide?",
    "How would you like to be remembered when you are gone?",
    "What energizes you? What drains you? How can you maximize your energizers and limit your drainers?",
    "What is an assumption about yourself or the world that has been holding you back?",
    "What is something that is worrying you at the moment? How have you tried to address it?",
    "What was the last book you read? What about it was interesting or useful?",
    "If you were happier, how would people know?",
    "List five people you spend the most time with in your day-to-day life. How are these people helping you grow or live a fulfilling life?",
    "What do you like about yourself? Why do you like these aspects?",
    "What advice would you give to a random stranger?",
    "When did you last spend time with your family or a close friend?",
    "If there were no limits or obstacles in your way, journal about where would you be in 10 years.",
    "When was the last time you were seriously sick? How did you heal yourself?" };
    public static string GetPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(1, prompts.Length)];
    }
}