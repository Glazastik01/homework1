string Char(string text, char[] Text){
    for (int i = 0; i < Text.Length; i++){
        text += Text[i].ToString();
    }
    return text;
}