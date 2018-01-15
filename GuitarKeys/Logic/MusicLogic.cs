using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarKeys.Models;
using System.Diagnostics;

namespace GuitarKeys.Logic
{
    
    class MusicLogic
    {
        public static List<string> MajorNotes = new List<string> { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        public static List<string> MinorNotes = new List<string> { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };

        //public static Key GetKey = new Key();

        public List<string> thing;

        public List<int> MajorScale = new List<int> { 2, 2, 1, 2, 2, 2, 1 };
        public List<int> MinorScale = new List<int> { 2, 1, 2, 2, 1, 2, 2 };

        public List<string> KeyNotes;
        public string Start_Position;
        public int Current_Position = 0;

        public void GetKey(string Tonic_Note, bool minor)
        {
            Current_Position = GetStartPosition(Tonic_Note);

            if(Current_Position != -1)
            {
                for (int i = 0; i == 6; i++)
                {
                    KeyNotes.Add(MajorNotes[Current_Position]);
                    
                    Current_Position = Current_Position + MajorScale[i];

                    Current_Position = (Current_Position > 12) ? Current_Position - 12 : Current_Position;
                }
                     
            }
        }

        public static int GetStartPosition(string Tonic_Note) 
        {
            if(MajorNotes.Contains(Tonic_Note) == true)
            {
                return MajorNotes.IndexOf(Tonic_Note);
            }
            else if(MinorNotes.Contains(Tonic_Note) == true)
            {
                return MinorNotes.IndexOf(Tonic_Note);
            }
            else
            {
                return -1;
            }
        }


    }




    //    Public Function GenerateKey(Tonic_Note As String) As String
    //    MajorScale = Array("A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#")
    //    MinorScale = Array("A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab")


    //    Current_Position = GetNotePosition(Tonic_Note)


    //    For i = 0 To 6
    //        Current_Position = Current_Position + MajorScale(i)
    //        If Current_Position > 12 Then
    //            Current_Position = Current_Position - 12
    //        End If


    //        KeyNotes(i) = MajorNotes(Current_Position)
    //    Next i
    //End Function

    //Public Function GetNotePosition(Tonic_Note) As Integer
    //    For i = LBound(MajorNotes) To UBound(MajorNotes)
    //        If Tonic_Note = MajorNotes(i) Or Tonic_Note = MinorNotes(i) Then
    //            GetNotePosition = i
    //            Exit For
    //        End If
    //    Next i
    //End Function
}
