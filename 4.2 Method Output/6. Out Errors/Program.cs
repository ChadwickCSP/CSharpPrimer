using System;

namespace OutErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GARRRR";
      bool marker;
			string murmur = Whisper(statement, marker);
      Console.WriteLine(murmur);
    }  
    
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      return phrase.ToLower();
    }
	} 
}
