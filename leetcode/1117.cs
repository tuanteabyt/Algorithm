using System.Threading;
public class H20{
    private int count = 0;
    private object _lock =new object();
    private SemaphoreSlim hSem=new SemaphoreSlim(2);
    private SemaphoreSlim oSem=new SemaphoreSlim(1);
    public H20(){

    }
    public void Hydrogen(Action releaseHydrogen){
        hSem.Wait();
        lock(_lock){
            releaseHydrogen();
            count++;
            if(count%2==0){
                oSem.Release();
            }
        }
    }
    public void Oxygen(Action releaseOxygen){
        oSem.Wait();
        releaseOxygen();
        hSem.Release(2);
    }

}