using System;
using System.IO;

public class Scripture{
    private string _passage;

        public Scripture(){
            Console.WriteLine("Write out the entire passage:");
            _passage = Console.ReadLine();

        }
}


    
//     private Reference _reference;
//     public List<Words> _passage;
//     private string[] tempString;
//     private static Random randomNum = new Random();
//     private int numb; 

//     public Scripture(Reference reference, string verse)  
//     {
//         this._reference = reference;
//         this._passage = new List<Words>();
//         tempString = verse.Split("");
//         foreach(string word in tempString){
//             this._passage.Add(new Words(words));
//         }
//     }   

//     public void Display() 
//     {
//         Console.Clear();
//         _reference.Display();
//         foreach(Words value in _passage){
//             value.Display
//         }
//     }

//     public void Hidewords(){
//         foreach(Words value in _passage){
//             if(value.GetVisibility()){
//                 continue;
//             }
//         }
//     }

//     public bool AreWordsHidden(){
//         var list = _passage.ConvertAll(item => item.GetVisibility());
//         if (list.TrueForAll(isHidden)){
//             return true;

//         }
//         return false;
//     }
    
//     private static bool isHidden(bool value){
//         if (value == false){
//             return true;

//         }
//         return false;
//     }
// }