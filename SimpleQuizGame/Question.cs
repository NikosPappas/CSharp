public class Question{
    public string Text{ get; set;}
    public string CorrectAnswer {get; set;}
    public Question(string text,string answer){
        Text=text;
        CorrectAnswer=answer;
    }
}