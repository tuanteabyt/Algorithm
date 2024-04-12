public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        int[] result= new int[deck.Length];
        int indexDeck=0,indexInResult=0;
        bool skip=false;
        Array.Sort(deck);
        while(indexDeck<deck.Length){
             if(result[indexInResult]==0){
                if(!skip){
                result[indexInResult]=deck[indexDeck];
                skip=true;
                indexDeck++;
                }
                else{
                    skip=false;
                }
            }
        indexInResult=(indexInResult+1)%deck.Length;
        }
        return result;
    }
}