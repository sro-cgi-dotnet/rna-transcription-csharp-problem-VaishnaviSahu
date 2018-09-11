using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {  
            String rna="";
            for(int i=0; i<nucleotide.Length; i++)
            {
                if(nucleotide[i]=='G')
                {
                    rna=rna+"C";
                }
              else if(nucleotide[i]=='C')
                {
                     rna=rna+"G";
                }
               else if(nucleotide[i]=='T')
                {
                     rna=rna+"A";
                }
               else if(nucleotide[i]=='A')
                {
                    rna=rna+"U";
                }
            }
            return (rna);
        }
    }
}
