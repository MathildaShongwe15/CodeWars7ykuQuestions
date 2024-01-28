//Isogram : this is a word that has not repeating letters


//find the word that does not have repeating letters and return true otherwise false

class Program
{
  static bool Isogram( string word) {

   //make the string into lowercase

   string strlower = word.ToLower();
   
    //convert into char array

    char [] strarr = word.ToCharArray();

    //for loop to check for similarity
   
    for(int i = 0; i < strarr.Length-1; i++){

        if(strarr[i] == strarr[i+1]){

            return false;
        }
    }
  
  return true;
   
  }

}



