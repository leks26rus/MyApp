using System;

public class someText {

    string text;

    public someText(string Text)
    {
        text = Text;
    }

    public string getText()
    {
        return text;
    }

    public string getUpperText()
    {
        return text.ToUpper();
    }

    public string getReverseText()
    {
        return reverseText();
    }

    private string reverseText() {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
