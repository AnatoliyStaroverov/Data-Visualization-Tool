using System;
using System.Collections.Generic;

namespace Data_Visualization_Tool{
  // abstract string class for string manupliation.
 public class Stringz
  {
       private string _currentStr = " ";
       private string _newStr =  " ";

       public Stringz(string userInput){_currentStr = userInput; }

    // Getter and Setter for current string 
    public string CurrentStr  
    {
        get => _currentStr;
        set{ _currentStr = value; }
    }

     // Getter and Setter for updated string  string 
    public string NewStr
    {
        get => _newStr;
        set{ _newStr = value; }
    }
    
    public String reverseString(){

        // String objects are immuntable but you can catac to end of string
        // by s1 += s2. 

        var revStr = new List<char>();
        
        // empty case
        if(this._currentStr.Length<1){
            return " ";
        }
        // string not empty 
        else{
            for (int i = this._currentStr.Length-1; i >= 0; i--){
            revStr.Add(this.CurrentStr[i]);
            }

             var result = new string (revStr.ToArray());
            return result;
        }
        

    }

   // function to see if string is palindrome
   // see if string is the same reversed.
    public bool IsParindrome(){

        Stack<char> str_stack = new Stack<char>();

        for(int i = 0 ; i< _currentStr.Length ; i++){
            str_stack.Push(_currentStr[i]);
        }

        
        for(int i = 0 ; i< _currentStr.Length ; i++){
            if(str_stack.Peek() == this.CurrentStr[i]){
                str_stack.Pop();
            }
            
        }
        
        if(str_stack.Count == 0){
            return true;
        }
        else{
            return false;
        }
    }
 }

}