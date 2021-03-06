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
        
        if(str_stack.Count == 0 && this._currentStr.Length == 0){
            return true;
        }
        else{
            return false;
        }
    }

 
    /* return minimal number of deletions need from both string to create an anagram.

    *  example : 
        str1 = "hheelloobabe"    // Anagram made is "hhebee"
        str2 = "hhebzakereed"    // total deletions: (12 - 6) + (12 - 6) = 12 deletions
    * 
    */
    public int MakeAnagrams(string str1, string str2){

     int del_count = 0;
     int[] positionCounter = 0;

    // empty string condition for either string.
     if(str1.Length <1 || str2.Length<1){
         return del_count;
     }

     // string 2 is larger condition 
     else if(str1.Length <=str2.Length ){
        for( int i = 0 ; i <str1.Length; i++ ){
            
        }
     }


    }


 } // end of class
} 