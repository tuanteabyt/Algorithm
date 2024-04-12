public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int count1=0,count2=0,n=students.Length,tmp;
        for(int i=0;i<students.Length;i++){
            if(students[i]==0){
                count1++;
            }
            else{
                count2++;            
            }
        }
        for(int i=0;i<sandwiches.Length;i++){
            if(sandwiches[i]==0&&count1==0){
                return count2;
            }
            if(sandwiches[i]==1&&count2==0){
                return count1;
            }
            if(sandwiches[i]==0){
                count1--;
            }
            else{
                count2--;            
            }
        }
        return 0;

    }
}