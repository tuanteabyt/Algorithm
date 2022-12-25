class Solution {
    public int totalFruit(int[] tree) {
       Map<Integer,Integer> m = new HashMap<>();
        int max = 0;
        int i = 0, j = 0;
        while(j < tree.length){
            if(m.size()<=2){
                max = Math.max(max,i-j);//tính số hoa quả đạt được
            }
            if(i < tree.length && m.size()<=2){
                m.put(tree[i],m.getOrDefault(tree[i],0)+1);//thêm số hoa quả vào giỏ
                i++;
            }else{
                m.compute(tree[j],(k,v)->{
                    if(v == 1) return null;//băt đầu từ cây j+1
                    return v-1;
                });
                j++;
            }
        }
        return max;
    }
}