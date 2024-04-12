public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> s =new Stack<int>();
        int sum=0;
        for(int i=0;i<operations.Length;i++){
         if(operations[i]=="+"){
            int top=s.Pop();
            int num=s.Peek()+top;
            s.Push(top);
            s.Push(num);
            sum+=s.Peek();
         }
         else if(operations[i]=="C"){
            int a=s.Pop();
            sum-=a;
         }
         else if(operations[i]=="D"){
            int a=s.Peek();
            s.Push(2*a);
            sum+=2*a;
         }
         else{
            s.Push(Int32.Parse(operations[i]));
            sum+=s.Peek();
         }
        }
        return sum;
    }
}